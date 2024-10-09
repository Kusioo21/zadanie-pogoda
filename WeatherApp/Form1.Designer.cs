namespace Pogoda
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Temperature = new Label();
            Humidity = new Label();
            Precipitation = new Label();
            SuspendLayout();
            // 
            // Temperature
            // 
            Temperature.AutoSize = true;
            Temperature.Location = new Point(94, 44);
            Temperature.Name = "Temperature";
            Temperature.Size = new Size(79, 15);
            Temperature.TabIndex = 0;
            Temperature.Text = "Temperatura: ";
            // 
            // Humidity
            // 
            Humidity.AutoSize = true;
            Humidity.Location = new Point(320, 44);
            Humidity.Name = "Humidity";
            Humidity.Size = new Size(73, 15);
            Humidity.TabIndex = 1;
            Humidity.Text = "Wilgotność: ";
            // 
            // Precipitation
            // 
            Precipitation.AutoSize = true;
            Precipitation.Location = new Point(586, 44);
            Precipitation.Name = "Precipitation";
            Precipitation.Size = new Size(45, 15);
            Precipitation.TabIndex = 2;
            Precipitation.Text = "Opady:";
            Precipitation.Click += Precipitation_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Precipitation);
            Controls.Add(Humidity);
            Controls.Add(Temperature);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Temperature;
        private Label Humidity;
        private Label Precipitation;
    }
}
