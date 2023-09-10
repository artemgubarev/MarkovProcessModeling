using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace SimulatedRifleShooting
{
    public partial class SimulatedRifleShootingForm : Form
    {
        private readonly DataTable _dataTableTransitionMatrix = new DataTable();
        private readonly DataTable _dataTableInitialProbabilities = new DataTable();
        private const int statesNumber = 3;

        public SimulatedRifleShootingForm()
        {
            InitializeComponent();

            #region Инициализация таблиц для входных данных
            for (int i = 0; i < statesNumber; i++)
            {
                _dataTableTransitionMatrix.Columns.Add("S"+i.ToString());
                _dataTableInitialProbabilities.Columns.Add("S"+i.ToString());
                _dataTableTransitionMatrix.Rows.Add(new object[] { });
            }
            _dataTableInitialProbabilities.Rows.Add(new object[] { });
            gridControlTransitionMatrix.DataSource = _dataTableTransitionMatrix;
            gridControlInitialProbabilities.DataSource = _dataTableInitialProbabilities;
            #endregion
        }

        private void simulateButton_Click(object sender, EventArgs e)
        {
            if (!InputDataValidate())
            {
                return;
            }
            var transitionMatrix = ParseDataTable(_dataTableTransitionMatrix);
            var initialProbabilities = ParseDataTable(_dataTableInitialProbabilities).ElementAt(0);
            var ticks = Simulate(transitionMatrix, initialProbabilities);
            DrawTransitionDiagram(ticks);
        }
        private void testDataSetButton_Click(object sender, EventArgs e)
        {
            string[] transitionMatrixRows
                = Properties.Resources.transitionMatrix.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            FillDataTable(_dataTableTransitionMatrix, transitionMatrixRows);

            string[] initialProbabilitiesRows =
                 Properties.Resources.initialProbabilities.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            FillDataTable(_dataTableInitialProbabilities, initialProbabilitiesRows);
        }

        private int[] Simulate(IEnumerable<double[]> transitionMatrix, double[] initialProbabilities)
        {
            var random = new Random();
            // определяется начальное состояние
            int state = 0;
            double rand = random.NextDouble();
            double current = 0.0;
            for (int i = 0; i < initialProbabilities.Length; i++)
            {
                if (rand > current && rand < initialProbabilities[i] + current)
                {
                    state = i;
                }
                current += initialProbabilities[i];
            }
            // количество тактов в которые мешень была в определенном состоянии
            int[] ticks = new int[statesNumber];
            ticks[state]++; 
            while (state != statesNumber - 1)
            {
                // выстрел
                double shot = random.NextDouble();
                double[] probabilities = transitionMatrix.ElementAt(state);
                current = 0.0;
                for (int i = 0; i < probabilities.Length; i++)
                {
                    if (shot > current && shot < probabilities[i] + current)
                    {
                        state = i;
                        ticks[state]++;
                    }
                    current += probabilities[i];
                }
            }
            return ticks;
        }

        #region Установить заголовки для строк
        private void gridViewTransitionMatrix_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            SetRowHeader(e);
        }

        private void gridViewInitialProbabilities_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            SetRowHeader(e);
        }

        private void SetRowHeader(RowIndicatorCustomDrawEventArgs e)
        {
            e.Info.Appearance.Font = new Font("Tahoma", 8);
            e.Info.Appearance.Options.UseFont = true;
            int rowIndex = e.RowHandle;
            if (rowIndex >= 0)
            {
                e.Info.DisplayText = "S" + rowIndex.ToString();
                e.Info.ImageIndex = -1;
            }
        }
        #endregion

        #region Валидация входных данных
        private bool InputDataValidate()
        {
            string errorMessage;
            if (!InitialProbabilitiesValidate())
            {
                errorMessage = "Невалидные данные в векторе начальных вероятностей";
                MessageBox.Show(errorMessage);
                return false;
            }
            var noValidRowsIndexes = TransitionMatrixValidate();
            if (noValidRowsIndexes.Count() > 0)
            {
                errorMessage = "Невелидные данные в строках с порядковым номером - " +
                    "(";
                foreach (var index in noValidRowsIndexes)
                {
                    errorMessage += index.ToString() + " ,";
                }
                errorMessage = errorMessage.Remove(errorMessage.Length - 1);
                errorMessage += ")";
                MessageBox.Show(errorMessage);
                return false; 
            }
            return true;
        }
        /// <summary>
        /// Валидация матрицы переходов
        /// </summary>
        /// <returns>Индексы невалидных строк</returns>
        private IEnumerable<int> TransitionMatrixValidate()
        {
            var noValidRowsIndexes = new List<int>();
            // rows
            for (int i = 0; i < statesNumber; i++)
            {
                // cols
                double sum = 0.0;
                bool isDigit = true;
                for (int j = 0; j < statesNumber; j++)
                {
                    string value = _dataTableTransitionMatrix.Rows[i][j].ToString();
                    if (!double.TryParse(value,NumberStyles.Any, CultureInfo.InvariantCulture, out double doubleValue))
                    {
                        noValidRowsIndexes.Add(i);
                        isDigit = false;
                        break;
                    }
                    else
                    {
                        if (doubleValue < 0)
                        {
                            noValidRowsIndexes.Add(i);
                        }
                        sum += doubleValue;
                    }
                }
                if (sum != 1.0 && isDigit)
                {
                    noValidRowsIndexes.Add(i);
                }
            }
            return noValidRowsIndexes;
        }

        /// <summary>
        /// Валидация вектора начальных вероятностей
        /// </summary>
        private bool InitialProbabilitiesValidate()
        {
            double sum = 0;
            bool isDigit = true;    
            for (int i = 0; i < statesNumber; i++)
            {
                string value = _dataTableInitialProbabilities.Rows[0][i].ToString();
                if (!double.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out double doubleValue))
                {
                    isDigit = false;
                    return false;
                }
                else
                {
                    if (doubleValue < 0)
                    {
                        return false;
                    }
                    sum += doubleValue;
                }
            }
            if (sum != 1.0 && isDigit)
            {
                return false;
            }
            return true;    
        }
        #endregion

        /// <summary>
        /// Парсинг данных из таблиц
        /// </summary>
        /// <param name="dataTable"></param>
        /// <returns></returns>
        private IEnumerable<double[]> ParseDataTable(DataTable dataTable)
        {
            int rows = dataTable.Rows.Count;
            int cols = dataTable.Columns.Count;
            var data = new List<double[]>();
            for (int i = 0; i < rows; i++)
            {
                double[] row = new double[cols];
                for (int j = 0; j < cols; j++)
                {
                    string value = dataTable.Rows[i][j].ToString();
                    row[j] = double.Parse(value, NumberStyles.Any, CultureInfo.InvariantCulture);
                }
                data.Add(row);
            }
            return data;
        }

        private void FillDataTable(DataTable dataTable, string[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                var row = data[i].Split(' ');
                for (int j = 0; j < row.Length; j++)
                {
                    dataTable.Rows[i][j] = row[j];
                }
            }
        }

        private void DrawTransitionDiagram(int[] ticks)
        {
            richTextBox.Clear();
            string diagram = string.Empty;
            for (int i = 0; i < ticks.Length; i++)
            {
                for (int j = 0; j < ticks[i]; j++)
                {
                    diagram += 'S' + i.ToString() + "->";
                }
            }
            diagram = diagram.Remove(diagram.Length - 2);
            richTextBox.AppendText(diagram);
        }
    }
}
