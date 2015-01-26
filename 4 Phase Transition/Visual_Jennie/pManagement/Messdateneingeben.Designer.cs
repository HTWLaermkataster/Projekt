namespace pManagement
{
    partial class Messdateneingeben
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.speichern_button = new System.Windows.Forms.Button();
            this.schliessen_button = new System.Windows.Forms.Button();
            this.TBMaxWert = new System.Windows.Forms.TextBox();
            this.TBMinWert = new System.Windows.Forms.TextBox();
            this.TBAverage = new System.Windows.Forms.TextBox();
            this.LabelMax = new System.Windows.Forms.Label();
            this.LabelMin = new System.Windows.Forms.Label();
            this.LabelAverage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Messpunkte";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 1;
            // 
            // speichern_button
            // 
            this.speichern_button.Location = new System.Drawing.Point(23, 214);
            this.speichern_button.Name = "speichern_button";
            this.speichern_button.Size = new System.Drawing.Size(78, 36);
            this.speichern_button.TabIndex = 9;
            this.speichern_button.Text = "speichern";
            this.speichern_button.UseVisualStyleBackColor = true;
            this.speichern_button.Click += new System.EventHandler(this.speichern_button_Click);
            // 
            // schliessen_button
            // 
            this.schliessen_button.Location = new System.Drawing.Point(174, 214);
            this.schliessen_button.Name = "schliessen_button";
            this.schliessen_button.Size = new System.Drawing.Size(81, 36);
            this.schliessen_button.TabIndex = 10;
            this.schliessen_button.Text = "schließen";
            this.schliessen_button.UseVisualStyleBackColor = true;
            this.schliessen_button.Click += new System.EventHandler(this.schliessen_button_Click);
            // 
            // TBMaxWert
            // 
            this.TBMaxWert.Location = new System.Drawing.Point(123, 73);
            this.TBMaxWert.Name = "TBMaxWert";
            this.TBMaxWert.Size = new System.Drawing.Size(132, 22);
            this.TBMaxWert.TabIndex = 11;
            // 
            // TBMinWert
            // 
            this.TBMinWert.Location = new System.Drawing.Point(123, 121);
            this.TBMinWert.Name = "TBMinWert";
            this.TBMinWert.Size = new System.Drawing.Size(132, 22);
            this.TBMinWert.TabIndex = 12;
            // 
            // TBAverage
            // 
            this.TBAverage.Location = new System.Drawing.Point(123, 166);
            this.TBAverage.Name = "TBAverage";
            this.TBAverage.Size = new System.Drawing.Size(132, 22);
            this.TBAverage.TabIndex = 13;
            // 
            // LabelMax
            // 
            this.LabelMax.AutoSize = true;
            this.LabelMax.Location = new System.Drawing.Point(16, 76);
            this.LabelMax.Name = "LabelMax";
            this.LabelMax.Size = new System.Drawing.Size(71, 17);
            this.LabelMax.TabIndex = 14;
            this.LabelMax.Text = "Max. Wert";
            // 
            // LabelMin
            // 
            this.LabelMin.AutoSize = true;
            this.LabelMin.Location = new System.Drawing.Point(16, 125);
            this.LabelMin.Name = "LabelMin";
            this.LabelMin.Size = new System.Drawing.Size(68, 17);
            this.LabelMin.TabIndex = 15;
            this.LabelMin.Text = "Min. Wert";
            this.LabelMin.Click += new System.EventHandler(this.LabelMin_Click);
            // 
            // LabelAverage
            // 
            this.LabelAverage.AutoSize = true;
            this.LabelAverage.Location = new System.Drawing.Point(16, 166);
            this.LabelAverage.Name = "LabelAverage";
            this.LabelAverage.Size = new System.Drawing.Size(87, 17);
            this.LabelAverage.TabIndex = 16;
            this.LabelAverage.Text = "Durchschnitt";
            // 
            // Messdateneingeben
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 288);
            this.Controls.Add(this.LabelAverage);
            this.Controls.Add(this.LabelMin);
            this.Controls.Add(this.LabelMax);
            this.Controls.Add(this.TBAverage);
            this.Controls.Add(this.TBMinWert);
            this.Controls.Add(this.TBMaxWert);
            this.Controls.Add(this.schliessen_button);
            this.Controls.Add(this.speichern_button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Messdateneingeben";
            this.Text = "Messdaten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button speichern_button;
        private System.Windows.Forms.Button schliessen_button;
        private System.Windows.Forms.TextBox TBMaxWert;
        private System.Windows.Forms.TextBox TBMinWert;
        private System.Windows.Forms.TextBox TBAverage;
        private System.Windows.Forms.Label LabelMax;
        private System.Windows.Forms.Label LabelMin;
        private System.Windows.Forms.Label LabelAverage;
    }
}