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
            this.simulatedRifleShootingControl1 = new SimulatedRifleShooting.SimulatedRifleShootingControl();
            this.SuspendLayout();
            // 
            // simulatedRifleShootingControl1
            // 
            this.simulatedRifleShootingControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simulatedRifleShootingControl1.Location = new System.Drawing.Point(0, 0);
            this.simulatedRifleShootingControl1.Name = "simulatedRifleShootingControl1";
            this.simulatedRifleShootingControl1.Size = new System.Drawing.Size(538, 327);
            this.simulatedRifleShootingControl1.TabIndex = 0;
            // 
            // SimulatedRifleShootingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 327);
            this.Controls.Add(this.simulatedRifleShootingControl1);
            this.Name = "SimulatedRifleShootingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Имитация стрельбы из винтовки";
            this.ResumeLayout(false);

        }

        #endregion

        private SimulatedRifleShootingControl simulatedRifleShootingControl1;
    }
}

