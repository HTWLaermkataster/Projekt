using System.Windows.Forms;

namespace pManagement
{
    partial class UserCreate
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
            this.TBBenutzername = new System.Windows.Forms.TextBox();
            this.TBPasswort = new System.Windows.Forms.TextBox();
            this.TBPasswortBestätigen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bestätigen_button = new System.Windows.Forms.Button();
            this.abbrechen_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswortNichtIdentischLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBBenutzername
            // 
            this.TBBenutzername.Location = new System.Drawing.Point(146, 54);
            this.TBBenutzername.Name = "TBBenutzername";
            this.TBBenutzername.Size = new System.Drawing.Size(100, 22);
            this.TBBenutzername.TabIndex = 0;
            // 
            // TBPasswort
            // 
            this.TBPasswort.Location = new System.Drawing.Point(146, 95);
            this.TBPasswort.Name = "TBPasswort";
            this.TBPasswort.PasswordChar = '*';
            this.TBPasswort.Size = new System.Drawing.Size(100, 22);
            this.TBPasswort.TabIndex = 1;
            // 
            // TBPasswortBestätigen
            // 
            this.TBPasswortBestätigen.Location = new System.Drawing.Point(146, 142);
            this.TBPasswortBestätigen.Name = "TBPasswortBestätigen";
            this.TBPasswortBestätigen.PasswordChar = '*';
            this.TBPasswortBestätigen.Size = new System.Drawing.Size(100, 22);
            this.TBPasswortBestätigen.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Benutzername";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Passwort";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Passwort bestätigen";
            // 
            // bestätigen_button
            // 
            this.bestätigen_button.Location = new System.Drawing.Point(15, 207);
            this.bestätigen_button.Name = "bestätigen_button";
            this.bestätigen_button.Size = new System.Drawing.Size(91, 23);
            this.bestätigen_button.TabIndex = 6;
            this.bestätigen_button.Text = "bestätigen";
            this.bestätigen_button.UseVisualStyleBackColor = true;
            this.bestätigen_button.Click += new System.EventHandler(this.bestätigen_button_Click);
            // 
            // abbrechen_button
            // 
            this.abbrechen_button.Location = new System.Drawing.Point(154, 207);
            this.abbrechen_button.Name = "abbrechen_button";
            this.abbrechen_button.Size = new System.Drawing.Size(92, 23);
            this.abbrechen_button.TabIndex = 7;
            this.abbrechen_button.Text = "abbrechen";
            this.abbrechen_button.UseVisualStyleBackColor = true;
            this.abbrechen_button.Click += new System.EventHandler(this.abbrechen_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Neuen Benutzer erstellen";
            // 
            // PasswortNichtIdentischLabel
            // 
            this.PasswortNichtIdentischLabel.AutoSize = true;
            this.PasswortNichtIdentischLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.PasswortNichtIdentischLabel.Location = new System.Drawing.Point(31, 176);
            this.PasswortNichtIdentischLabel.Name = "PasswortNichtIdentischLabel";
            this.PasswortNichtIdentischLabel.Size = new System.Drawing.Size(164, 17);
            this.PasswortNichtIdentischLabel.TabIndex = 9;
            this.PasswortNichtIdentischLabel.Text = "Passwort falsch bestätigt";
            this.PasswortNichtIdentischLabel.Visible = false;
            // 
            // UserCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 257);
            this.Controls.Add(this.PasswortNichtIdentischLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.abbrechen_button);
            this.Controls.Add(this.bestätigen_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBPasswortBestätigen);
            this.Controls.Add(this.TBPasswort);
            this.Controls.Add(this.TBBenutzername);
            this.Name = "UserCreate";
            this.Text = "Lärmkataster";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBBenutzername;      
        private System.Windows.Forms.TextBox TBPasswort;
        private System.Windows.Forms.TextBox TBPasswortBestätigen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bestätigen_button;
        private System.Windows.Forms.Button abbrechen_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PasswortNichtIdentischLabel;
    }
}