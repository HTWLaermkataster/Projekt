namespace pManagement
{
    partial class Ort
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
            this.TBOrtName = new System.Windows.Forms.TextBox();
            this.TBOrtNotes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BOrtOk = new System.Windows.Forms.Button();
            this.BOrtCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBOrtName
            // 
            this.TBOrtName.Location = new System.Drawing.Point(52, 61);
            this.TBOrtName.Name = "TBOrtName";
            this.TBOrtName.Size = new System.Drawing.Size(161, 22);
            this.TBOrtName.TabIndex = 0;
            // 
            // TBOrtNotes
            // 
            this.TBOrtNotes.Location = new System.Drawing.Point(52, 141);
            this.TBOrtNotes.Multiline = true;
            this.TBOrtNotes.Name = "TBOrtNotes";
            this.TBOrtNotes.Size = new System.Drawing.Size(161, 67);
            this.TBOrtNotes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Anmerkungen";
            // 
            // BOrtOk
            // 
            this.BOrtOk.Location = new System.Drawing.Point(12, 237);
            this.BOrtOk.Name = "BOrtOk";
            this.BOrtOk.Size = new System.Drawing.Size(105, 52);
            this.BOrtOk.TabIndex = 4;
            this.BOrtOk.Text = "Bestätigen";
            this.BOrtOk.UseVisualStyleBackColor = true;
            this.BOrtOk.Click += new System.EventHandler(this.BOrtOk_Click);
            // 
            // BOrtCancel
            // 
            this.BOrtCancel.Location = new System.Drawing.Point(132, 237);
            this.BOrtCancel.Name = "BOrtCancel";
            this.BOrtCancel.Size = new System.Drawing.Size(105, 52);
            this.BOrtCancel.TabIndex = 5;
            this.BOrtCancel.Text = "abbrechen";
            this.BOrtCancel.UseVisualStyleBackColor = true;
            // 
            // Ort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 325);
            this.Controls.Add(this.BOrtCancel);
            this.Controls.Add(this.BOrtOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBOrtNotes);
            this.Controls.Add(this.TBOrtName);
            this.Name = "Ort";
            this.Text = "Ort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBOrtName;
        private System.Windows.Forms.TextBox TBOrtNotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BOrtOk;
        private System.Windows.Forms.Button BOrtCancel;
    }
}