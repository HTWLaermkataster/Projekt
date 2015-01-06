namespace pManagement
{
    partial class anmelden
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
            this.label2 = new System.Windows.Forms.Label();
            this.anmelden_button = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.mitarbeiter_textBox = new System.Windows.Forms.TextBox();
            this.passwort_textBox = new System.Windows.Forms.TextBox();
            this.CreateUserButton = new System.Windows.Forms.Button();
            this.AnmeldungFailed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mitarbeiter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Passwort";
            // 
            // anmelden_button
            // 
            this.anmelden_button.Location = new System.Drawing.Point(21, 189);
            this.anmelden_button.Name = "anmelden_button";
            this.anmelden_button.Size = new System.Drawing.Size(79, 23);
            this.anmelden_button.TabIndex = 3;
            this.anmelden_button.Text = "anmelden";
            this.anmelden_button.UseVisualStyleBackColor = true;
            this.anmelden_button.Click += new System.EventHandler(this.anmelden_button_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(164, 189);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(78, 23);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "beenden";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.schließen_button_Click);
            // 
            // mitarbeiter_textBox
            // 
            this.mitarbeiter_textBox.Location = new System.Drawing.Point(142, 87);
            this.mitarbeiter_textBox.Name = "mitarbeiter_textBox";
            this.mitarbeiter_textBox.Size = new System.Drawing.Size(100, 22);
            this.mitarbeiter_textBox.TabIndex = 5;
            this.mitarbeiter_textBox.TextChanged += new System.EventHandler(this.mitarbeiter_textBox_TextChanged);
            // 
            // passwort_textBox
            // 
            this.passwort_textBox.Location = new System.Drawing.Point(142, 127);
            this.passwort_textBox.Name = "passwort_textBox";
            this.passwort_textBox.PasswordChar = '*';
            this.passwort_textBox.Size = new System.Drawing.Size(100, 22);
            this.passwort_textBox.TabIndex = 6;
            // 
            // CreateUserButton
            // 
            this.CreateUserButton.Location = new System.Drawing.Point(21, 23);
            this.CreateUserButton.Name = "CreateUserButton";
            this.CreateUserButton.Size = new System.Drawing.Size(221, 23);
            this.CreateUserButton.TabIndex = 8;
            this.CreateUserButton.Text = "Neuen Benutzer erstellen";
            this.CreateUserButton.UseVisualStyleBackColor = true;
            this.CreateUserButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnmeldungFailed
            // 
            this.AnmeldungFailed.AutoSize = true;
            this.AnmeldungFailed.ForeColor = System.Drawing.Color.OrangeRed;
            this.AnmeldungFailed.Location = new System.Drawing.Point(21, 158);
            this.AnmeldungFailed.Name = "AnmeldungFailed";
            this.AnmeldungFailed.Size = new System.Drawing.Size(179, 17);
            this.AnmeldungFailed.TabIndex = 9;
            this.AnmeldungFailed.Text = "Anmeldung fehlgeschlagen";
            this.AnmeldungFailed.Visible = false;
            this.AnmeldungFailed.Click += new System.EventHandler(this.AnmeldungFailed_Click);
            // 
            // anmelden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 275);
            this.Controls.Add(this.AnmeldungFailed);
            this.Controls.Add(this.CreateUserButton);
            this.Controls.Add(this.passwort_textBox);
            this.Controls.Add(this.mitarbeiter_textBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.anmelden_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "anmelden";
            this.Text = "Lärmkataster";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button anmelden_button;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox mitarbeiter_textBox;
        private System.Windows.Forms.TextBox passwort_textBox;
        private System.Windows.Forms.Button CreateUserButton;
        private System.Windows.Forms.Label AnmeldungFailed;
    }
}