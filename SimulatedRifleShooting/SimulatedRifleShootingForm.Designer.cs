namespace SimulatedRifleShooting
{
    partial class SimulatedRifleShootingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControlTransitionMatrix = new DevExpress.XtraGrid.GridControl();
            this.gridViewTransitionMatrix = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simulateButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gridControlInitialProbabilities = new DevExpress.XtraGrid.GridControl();
            this.gridViewInitialProbabilities = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.testDataSetButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTransitionMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTransitionMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInitialProbabilities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInitialProbabilities)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlTransitionMatrix
            // 
            this.gridControlTransitionMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlTransitionMatrix.Location = new System.Drawing.Point(12, 108);
            this.gridControlTransitionMatrix.MainView = this.gridViewTransitionMatrix;
            this.gridControlTransitionMatrix.Name = "gridControlTransitionMatrix";
            this.gridControlTransitionMatrix.Size = new System.Drawing.Size(354, 88);
            this.gridControlTransitionMatrix.TabIndex = 0;
            this.gridControlTransitionMatrix.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTransitionMatrix});
            // 
            // gridViewTransitionMatrix
            // 
            this.gridViewTransitionMatrix.Appearance.SelectedRow.BackColor = System.Drawing.Color.White;
            this.gridViewTransitionMatrix.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewTransitionMatrix.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridViewTransitionMatrix.GridControl = this.gridControlTransitionMatrix;
            this.gridViewTransitionMatrix.IndicatorWidth = 50;
            this.gridViewTransitionMatrix.Name = "gridViewTransitionMatrix";
            this.gridViewTransitionMatrix.OptionsBehavior.AllowSortAnimation = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewTransitionMatrix.OptionsCustomization.AllowSort = false;
            this.gridViewTransitionMatrix.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridViewTransitionMatrix.OptionsView.ShowGroupPanel = false;
            this.gridViewTransitionMatrix.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewTransitionMatrix_CustomDrawRowIndicator);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 89);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(205, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Матрица переходов между состояниями";
            // 
            // simulateButton
            // 
            this.simulateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simulateButton.Location = new System.Drawing.Point(381, 173);
            this.simulateButton.Name = "simulateButton";
            this.simulateButton.Size = new System.Drawing.Size(137, 23);
            this.simulateButton.TabIndex = 2;
            this.simulateButton.Text = "имитация";
            this.simulateButton.Click += new System.EventHandler(this.simulateButton_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(169, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Вектор начальных вероятностей";
            // 
            // gridControlInitialProbabilities
            // 
            this.gridControlInitialProbabilities.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlInitialProbabilities.Location = new System.Drawing.Point(12, 25);
            this.gridControlInitialProbabilities.MainView = this.gridViewInitialProbabilities;
            this.gridControlInitialProbabilities.Name = "gridControlInitialProbabilities";
            this.gridControlInitialProbabilities.Size = new System.Drawing.Size(354, 47);
            this.gridControlInitialProbabilities.TabIndex = 4;
            this.gridControlInitialProbabilities.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewInitialProbabilities});
            // 
            // gridViewInitialProbabilities
            // 
            this.gridViewInitialProbabilities.Appearance.SelectedRow.BackColor = System.Drawing.Color.White;
            this.gridViewInitialProbabilities.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewInitialProbabilities.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridViewInitialProbabilities.GridControl = this.gridControlInitialProbabilities;
            this.gridViewInitialProbabilities.IndicatorWidth = 50;
            this.gridViewInitialProbabilities.Name = "gridViewInitialProbabilities";
            this.gridViewInitialProbabilities.OptionsBehavior.AllowSortAnimation = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewInitialProbabilities.OptionsCustomization.AllowSort = false;
            this.gridViewInitialProbabilities.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridViewInitialProbabilities.OptionsView.ShowGroupPanel = false;
            this.gridViewInitialProbabilities.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewInitialProbabilities_CustomDrawRowIndicator);
            // 
            // testDataSetButton
            // 
            this.testDataSetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.testDataSetButton.Location = new System.Drawing.Point(381, 25);
            this.testDataSetButton.Name = "testDataSetButton";
            this.testDataSetButton.Size = new System.Drawing.Size(137, 28);
            this.testDataSetButton.TabIndex = 5;
            this.testDataSetButton.Text = "тестовый набор данных";
            this.testDataSetButton.Click += new System.EventHandler(this.testDataSetButton_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 202);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(169, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Временная диаграмма переходов";
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.Location = new System.Drawing.Point(12, 221);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(506, 38);
            this.richTextBox.TabIndex = 8;
            this.richTextBox.Text = "";
            // 
            // SimulatedRifleShootingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 294);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.testDataSetButton);
            this.Controls.Add(this.gridControlInitialProbabilities);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.simulateButton);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControlTransitionMatrix);
            this.Name = "SimulatedRifleShootingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Имитация стрельбы из винтовки";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTransitionMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTransitionMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInitialProbabilities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInitialProbabilities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlTransitionMatrix;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTransitionMatrix;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simulateButton;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gridControlInitialProbabilities;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewInitialProbabilities;
        private DevExpress.XtraEditors.SimpleButton testDataSetButton;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.RichTextBox richTextBox;
    }
}

