namespace pManagement
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Messdatenanzeigen_button = new System.Windows.Forms.Button();
            this.Messdateneingeben_button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Messdatenanzeigen_button
            // 
            this.Messdatenanzeigen_button.Location = new System.Drawing.Point(842, 33);
            this.Messdatenanzeigen_button.Name = "Messdatenanzeigen_button";
            this.Messdatenanzeigen_button.Size = new System.Drawing.Size(87, 46);
            this.Messdatenanzeigen_button.TabIndex = 0;
            this.Messdatenanzeigen_button.Text = "Messdaten anzeigen";
            this.Messdatenanzeigen_button.UseVisualStyleBackColor = true;
            this.Messdatenanzeigen_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Messdateneingeben_button
            // 
            this.Messdateneingeben_button.Location = new System.Drawing.Point(842, 106);
            this.Messdateneingeben_button.Name = "Messdateneingeben_button";
            this.Messdateneingeben_button.Size = new System.Drawing.Size(87, 49);
            this.Messdateneingeben_button.TabIndex = 1;
            this.Messdateneingeben_button.Text = "Messdaten eingeben";
            this.Messdateneingeben_button.UseVisualStyleBackColor = true;
            this.Messdateneingeben_button.Click += new System.EventHandler(this.Messdateneingeben_button_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(854, 191);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 28);
            this.button3.TabIndex = 2;
            this.button3.Text = "Beenden";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(782, 502);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 502);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Messdateneingeben_button);
            this.Controls.Add(this.Messdatenanzeigen_button);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Messdatenanzeigen_button;
        private System.Windows.Forms.Button Messdateneingeben_button;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

