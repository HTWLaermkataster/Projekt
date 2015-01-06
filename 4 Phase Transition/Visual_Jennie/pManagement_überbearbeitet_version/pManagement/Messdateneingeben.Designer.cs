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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.speichern_button = new System.Windows.Forms.Button();
            this.schliessen_button = new System.Windows.Forms.Button();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Messwert:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(123, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 6;
            // 
            // speichern_button
            // 
            this.speichern_button.Location = new System.Drawing.Point(16, 187);
            this.speichern_button.Name = "speichern_button";
            this.speichern_button.Size = new System.Drawing.Size(78, 36);
            this.speichern_button.TabIndex = 9;
            this.speichern_button.Text = "speichern";
            this.speichern_button.UseVisualStyleBackColor = true;
            this.speichern_button.Click += new System.EventHandler(this.speichern_button_Click);
            
            // 
            // schliessen_button
            // 
            this.schliessen_button.Location = new System.Drawing.Point(167, 187);
            this.schliessen_button.Name = "schliessen_button";
            this.schliessen_button.Size = new System.Drawing.Size(81, 36);
            this.schliessen_button.TabIndex = 10;
            this.schliessen_button.Text = "schließen";
            this.schliessen_button.UseVisualStyleBackColor = true;
            this.schliessen_button.Click += new System.EventHandler(this.schliessen_button_Click);
            // 
            // Messdateneingeben
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 237);
            this.Controls.Add(this.schliessen_button);
            this.Controls.Add(this.speichern_button);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button speichern_button;
        private System.Windows.Forms.Button schliessen_button;
    }
}