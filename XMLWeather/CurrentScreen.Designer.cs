namespace XMLWeather
{
    partial class CurrentScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cityOutput = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.conditionOutput = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.highLabel = new System.Windows.Forms.Label();
            this.lowLabel = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.riseOutput = new System.Windows.Forms.Label();
            this.setOutput = new System.Windows.Forms.Label();
            this.humidityOutput = new System.Windows.Forms.Label();
            this.riseLabel = new System.Windows.Forms.Label();
            this.humidityLabel = new System.Windows.Forms.Label();
            this.setLabel = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(-4, 74);
            this.cityOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(375, 48);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "Stratford";
            this.cityOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tempLabel
            // 
            this.tempLabel.BackColor = System.Drawing.Color.Transparent;
            this.tempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.ForeColor = System.Drawing.Color.White;
            this.tempLabel.Location = new System.Drawing.Point(0, 165);
            this.tempLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(375, 81);
            this.tempLabel.TabIndex = 26;
            this.tempLabel.Text = "4*C";
            this.tempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 562);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 43);
            this.label3.TabIndex = 40;
            this.label3.Text = "Current";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(226, 562);
            this.forecastLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(144, 43);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "forecast";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // conditionOutput
            // 
            this.conditionOutput.BackColor = System.Drawing.Color.Transparent;
            this.conditionOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionOutput.ForeColor = System.Drawing.Color.White;
            this.conditionOutput.Location = new System.Drawing.Point(-5, 122);
            this.conditionOutput.Name = "conditionOutput";
            this.conditionOutput.Size = new System.Drawing.Size(375, 43);
            this.conditionOutput.TabIndex = 43;
            this.conditionOutput.Text = "Cloudy";
            this.conditionOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateLabel
            // 
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(-1, 237);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(383, 30);
            this.dateLabel.TabIndex = 44;
            this.dateLabel.Text = "Date";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(8, 22);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(374, 42);
            this.titleLabel.TabIndex = 76;
            this.titleLabel.Text = " Weather Network";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highLabel
            // 
            this.highLabel.AutoSize = true;
            this.highLabel.BackColor = System.Drawing.Color.Transparent;
            this.highLabel.ForeColor = System.Drawing.Color.White;
            this.highLabel.Location = new System.Drawing.Point(9, 297);
            this.highLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.highLabel.Name = "highLabel";
            this.highLabel.Size = new System.Drawing.Size(42, 20);
            this.highLabel.TabIndex = 77;
            this.highLabel.Text = "High";
            // 
            // lowLabel
            // 
            this.lowLabel.AutoSize = true;
            this.lowLabel.BackColor = System.Drawing.Color.Transparent;
            this.lowLabel.ForeColor = System.Drawing.Color.White;
            this.lowLabel.Location = new System.Drawing.Point(168, 297);
            this.lowLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lowLabel.Name = "lowLabel";
            this.lowLabel.Size = new System.Drawing.Size(38, 20);
            this.lowLabel.TabIndex = 78;
            this.lowLabel.Text = "Low";
            // 
            // minOutput
            // 
            this.minOutput.BackColor = System.Drawing.Color.Transparent;
            this.minOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.minOutput.ForeColor = System.Drawing.Color.Cyan;
            this.minOutput.Location = new System.Drawing.Point(168, 317);
            this.minOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(184, 43);
            this.minOutput.TabIndex = 79;
            this.minOutput.Text = "min";
            this.minOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // riseOutput
            // 
            this.riseOutput.BackColor = System.Drawing.Color.Transparent;
            this.riseOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.riseOutput.ForeColor = System.Drawing.Color.Gold;
            this.riseOutput.Location = new System.Drawing.Point(4, 393);
            this.riseOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.riseOutput.Name = "riseOutput";
            this.riseOutput.Size = new System.Drawing.Size(170, 43);
            this.riseOutput.TabIndex = 85;
            this.riseOutput.Text = "max";
            this.riseOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // setOutput
            // 
            this.setOutput.BackColor = System.Drawing.Color.Transparent;
            this.setOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.setOutput.ForeColor = System.Drawing.Color.LightCoral;
            this.setOutput.Location = new System.Drawing.Point(165, 393);
            this.setOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.setOutput.Name = "setOutput";
            this.setOutput.Size = new System.Drawing.Size(194, 43);
            this.setOutput.TabIndex = 86;
            this.setOutput.Text = "max";
            this.setOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // humidityOutput
            // 
            this.humidityOutput.BackColor = System.Drawing.Color.Transparent;
            this.humidityOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.humidityOutput.ForeColor = System.Drawing.Color.White;
            this.humidityOutput.Location = new System.Drawing.Point(4, 472);
            this.humidityOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.humidityOutput.Name = "humidityOutput";
            this.humidityOutput.Size = new System.Drawing.Size(170, 43);
            this.humidityOutput.TabIndex = 87;
            this.humidityOutput.Text = "max";
            this.humidityOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // riseLabel
            // 
            this.riseLabel.AutoSize = true;
            this.riseLabel.BackColor = System.Drawing.Color.Transparent;
            this.riseLabel.ForeColor = System.Drawing.Color.White;
            this.riseLabel.Location = new System.Drawing.Point(9, 373);
            this.riseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.riseLabel.Name = "riseLabel";
            this.riseLabel.Size = new System.Drawing.Size(63, 20);
            this.riseLabel.TabIndex = 88;
            this.riseLabel.Text = "Sunrise";
            // 
            // humidityLabel
            // 
            this.humidityLabel.AutoSize = true;
            this.humidityLabel.BackColor = System.Drawing.Color.Transparent;
            this.humidityLabel.ForeColor = System.Drawing.Color.White;
            this.humidityLabel.Location = new System.Drawing.Point(9, 452);
            this.humidityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.Size = new System.Drawing.Size(70, 20);
            this.humidityLabel.TabIndex = 89;
            this.humidityLabel.Text = "Humidity";
            // 
            // setLabel
            // 
            this.setLabel.AutoSize = true;
            this.setLabel.BackColor = System.Drawing.Color.Transparent;
            this.setLabel.ForeColor = System.Drawing.Color.White;
            this.setLabel.Location = new System.Drawing.Point(168, 373);
            this.setLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.setLabel.Name = "setLabel";
            this.setLabel.Size = new System.Drawing.Size(60, 20);
            this.setLabel.TabIndex = 90;
            this.setLabel.Text = "Sunset";
            // 
            // maxOutput
            // 
            this.maxOutput.BackColor = System.Drawing.Color.Transparent;
            this.maxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.maxOutput.ForeColor = System.Drawing.Color.Red;
            this.maxOutput.Location = new System.Drawing.Point(6, 317);
            this.maxOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(154, 43);
            this.maxOutput.TabIndex = 91;
            this.maxOutput.Text = "max";
            this.maxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(-7, 521);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(382, 41);
            this.label5.TabIndex = 94;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateLabel2
            // 
            this.dateLabel2.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel2.ForeColor = System.Drawing.Color.White;
            this.dateLabel2.Location = new System.Drawing.Point(4, 267);
            this.dateLabel2.Name = "dateLabel2";
            this.dateLabel2.Size = new System.Drawing.Size(368, 30);
            this.dateLabel2.TabIndex = 95;
            this.dateLabel2.Text = "date";
            this.dateLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.dateLabel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.setLabel);
            this.Controls.Add(this.humidityLabel);
            this.Controls.Add(this.riseLabel);
            this.Controls.Add(this.humidityOutput);
            this.Controls.Add(this.setOutput);
            this.Controls.Add(this.riseOutput);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.lowLabel);
            this.Controls.Add(this.highLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.conditionOutput);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.tempLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(375, 615);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label conditionOutput;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label highLabel;
        private System.Windows.Forms.Label lowLabel;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label riseOutput;
        private System.Windows.Forms.Label setOutput;
        private System.Windows.Forms.Label humidityOutput;
        private System.Windows.Forms.Label riseLabel;
        private System.Windows.Forms.Label humidityLabel;
        private System.Windows.Forms.Label setLabel;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label dateLabel2;
    }
}
