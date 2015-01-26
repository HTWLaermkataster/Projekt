namespace pManagement
{
    partial class Lärmkataster_Form
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BDeleteMeasurements = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.LMethodInvalid = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TBMethodDescription = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TBMethodName = new System.Windows.Forms.TextBox();
            this.LBMethods = new System.Windows.Forms.ListBox();
            this.BMethodCancel = new System.Windows.Forms.Button();
            this.BMethodAdd = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.CBChoosePosition = new System.Windows.Forms.ComboBox();
            this.LDataInvalid = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BClearTBData = new System.Windows.Forms.Button();
            this.BSaveData = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TBAverage = new System.Windows.Forms.TextBox();
            this.TBMinWert = new System.Windows.Forms.TextBox();
            this.TBMaxWert = new System.Windows.Forms.TextBox();
            this.PBMap = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.LPointsDataInvalid = new System.Windows.Forms.Label();
            this.BMessPointDelete = new System.Windows.Forms.Button();
            this.BMessPointCancel = new System.Windows.Forms.Button();
            this.BMessPointAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CBMessPoints = new System.Windows.Forms.ComboBox();
            this.PBPoints = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBPointsDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBPointsName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBPointsX = new System.Windows.Forms.TextBox();
            this.TBPointsY = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.measuringMethodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.measuringMethodBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.BMethodsDelete = new System.Windows.Forms.Button();
            this.Bexport = new System.Windows.Forms.Button();
            this.TBEmployee = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBMap)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.measuringMethodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.measuringMethodBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(575, 273);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(-1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1217, 682);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Bexport);
            this.tabPage2.Controls.Add(this.BDeleteMeasurements);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1209, 653);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Messdaten anzeigen";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BDeleteMeasurements
            // 
            this.BDeleteMeasurements.Location = new System.Drawing.Point(9, 501);
            this.BDeleteMeasurements.Name = "BDeleteMeasurements";
            this.BDeleteMeasurements.Size = new System.Drawing.Size(118, 43);
            this.BDeleteMeasurements.TabIndex = 2;
            this.BDeleteMeasurements.Text = "Löschen";
            this.BDeleteMeasurements.UseVisualStyleBackColor = true;
            this.BDeleteMeasurements.Click += new System.EventHandler(this.BDeleteMeasurements_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1206, 449);
            this.dataGridView1.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.BMethodsDelete);
            this.tabPage3.Controls.Add(this.LMethodInvalid);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.TBMethodDescription);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.TBMethodName);
            this.tabPage3.Controls.Add(this.LBMethods);
            this.tabPage3.Controls.Add(this.BMethodCancel);
            this.tabPage3.Controls.Add(this.BMethodAdd);
            this.tabPage3.Controls.Add(this.shapeContainer1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1209, 653);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Messmethoden verwalten";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // LMethodInvalid
            // 
            this.LMethodInvalid.AutoSize = true;
            this.LMethodInvalid.ForeColor = System.Drawing.Color.Red;
            this.LMethodInvalid.Location = new System.Drawing.Point(20, 251);
            this.LMethodInvalid.Name = "LMethodInvalid";
            this.LMethodInvalid.Size = new System.Drawing.Size(220, 17);
            this.LMethodInvalid.TabIndex = 7;
            this.LMethodInvalid.Text = "Bitte Überprüfen Sie Ihre Eingabe";
            this.LMethodInvalid.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(77, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 17);
            this.label13.TabIndex = 6;
            this.label13.Text = "Beschreibung";
            // 
            // TBMethodDescription
            // 
            this.TBMethodDescription.Location = new System.Drawing.Point(54, 134);
            this.TBMethodDescription.Multiline = true;
            this.TBMethodDescription.Name = "TBMethodDescription";
            this.TBMethodDescription.Size = new System.Drawing.Size(153, 96);
            this.TBMethodDescription.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(77, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Messmethode";
            // 
            // TBMethodName
            // 
            this.TBMethodName.Location = new System.Drawing.Point(54, 56);
            this.TBMethodName.Name = "TBMethodName";
            this.TBMethodName.Size = new System.Drawing.Size(153, 22);
            this.TBMethodName.TabIndex = 3;
            // 
            // LBMethods
            // 
            this.LBMethods.FormattingEnabled = true;
            this.LBMethods.ItemHeight = 16;
            this.LBMethods.Location = new System.Drawing.Point(307, 56);
            this.LBMethods.Name = "LBMethods";
            this.LBMethods.Size = new System.Drawing.Size(319, 212);
            this.LBMethods.TabIndex = 2;
            this.LBMethods.SelectedIndexChanged += new System.EventHandler(this.LBMethods_SelectedIndexChanged);
            // 
            // BMethodCancel
            // 
            this.BMethodCancel.Location = new System.Drawing.Point(134, 281);
            this.BMethodCancel.Name = "BMethodCancel";
            this.BMethodCancel.Size = new System.Drawing.Size(103, 48);
            this.BMethodCancel.TabIndex = 1;
            this.BMethodCancel.Text = "abbrechen";
            this.BMethodCancel.UseVisualStyleBackColor = true;
            this.BMethodCancel.Click += new System.EventHandler(this.BMethodCancel_Click);
            // 
            // BMethodAdd
            // 
            this.BMethodAdd.Location = new System.Drawing.Point(8, 281);
            this.BMethodAdd.Name = "BMethodAdd";
            this.BMethodAdd.Size = new System.Drawing.Size(103, 48);
            this.BMethodAdd.TabIndex = 0;
            this.BMethodAdd.Text = "hinzufügen";
            this.BMethodAdd.UseVisualStyleBackColor = true;
            this.BMethodAdd.Click += new System.EventHandler(this.BMethodAdd_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.TBEmployee);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.CBChoosePosition);
            this.tabPage1.Controls.Add(this.LDataInvalid);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.BClearTBData);
            this.tabPage1.Controls.Add(this.BSaveData);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.TBAverage);
            this.tabPage1.Controls.Add(this.TBMinWert);
            this.tabPage1.Controls.Add(this.TBMaxWert);
            this.tabPage1.Controls.Add(this.PBMap);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1209, 653);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Messdaten erfassen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Messort";
            // 
            // CBChoosePosition
            // 
            this.CBChoosePosition.FormattingEnabled = true;
            this.CBChoosePosition.Location = new System.Drawing.Point(9, 65);
            this.CBChoosePosition.Name = "CBChoosePosition";
            this.CBChoosePosition.Size = new System.Drawing.Size(214, 24);
            this.CBChoosePosition.TabIndex = 33;
            // 
            // LDataInvalid
            // 
            this.LDataInvalid.AutoSize = true;
            this.LDataInvalid.ForeColor = System.Drawing.Color.Red;
            this.LDataInvalid.Location = new System.Drawing.Point(6, 462);
            this.LDataInvalid.Name = "LDataInvalid";
            this.LDataInvalid.Size = new System.Drawing.Size(227, 17);
            this.LDataInvalid.TabIndex = 32;
            this.LDataInvalid.Text = "Überprüfen Sie bitte Ihre Eingaben";
            this.LDataInvalid.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(45, 387);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 17);
            this.label12.TabIndex = 27;
            this.label12.Text = "Methode auswählen";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(60, 300);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "Uhrzeit wählen";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 407);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 24);
            this.comboBox1.TabIndex = 25;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 334);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(220, 22);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // BClearTBData
            // 
            this.BClearTBData.Location = new System.Drawing.Point(123, 499);
            this.BClearTBData.Name = "BClearTBData";
            this.BClearTBData.Size = new System.Drawing.Size(100, 23);
            this.BClearTBData.TabIndex = 23;
            this.BClearTBData.Text = "Abbrechen";
            this.BClearTBData.UseVisualStyleBackColor = true;
            this.BClearTBData.Click += new System.EventHandler(this.BClearTBData_Click);
            // 
            // BSaveData
            // 
            this.BSaveData.Location = new System.Drawing.Point(9, 500);
            this.BSaveData.Name = "BSaveData";
            this.BSaveData.Size = new System.Drawing.Size(84, 23);
            this.BSaveData.TabIndex = 22;
            this.BSaveData.Text = "Speichern";
            this.BSaveData.UseVisualStyleBackColor = true;
            this.BSaveData.Click += new System.EventHandler(this.BSaveData_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Durchschnitt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Min. Wert";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Max. Wert";
            // 
            // TBAverage
            // 
            this.TBAverage.Location = new System.Drawing.Point(123, 206);
            this.TBAverage.Name = "TBAverage";
            this.TBAverage.Size = new System.Drawing.Size(100, 22);
            this.TBAverage.TabIndex = 18;
            // 
            // TBMinWert
            // 
            this.TBMinWert.Location = new System.Drawing.Point(123, 160);
            this.TBMinWert.Name = "TBMinWert";
            this.TBMinWert.Size = new System.Drawing.Size(100, 22);
            this.TBMinWert.TabIndex = 17;
            // 
            // TBMaxWert
            // 
            this.TBMaxWert.Location = new System.Drawing.Point(123, 112);
            this.TBMaxWert.Name = "TBMaxWert";
            this.TBMaxWert.Size = new System.Drawing.Size(100, 22);
            this.TBMaxWert.TabIndex = 16;
            // 
            // PBMap
            // 
            this.PBMap.Location = new System.Drawing.Point(236, 28);
            this.PBMap.Name = "PBMap";
            this.PBMap.Size = new System.Drawing.Size(967, 483);
            this.PBMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBMap.TabIndex = 15;
            this.PBMap.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.LPointsDataInvalid);
            this.tabPage4.Controls.Add(this.BMessPointDelete);
            this.tabPage4.Controls.Add(this.BMessPointCancel);
            this.tabPage4.Controls.Add(this.BMessPointAdd);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.CBMessPoints);
            this.tabPage4.Controls.Add(this.PBPoints);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.TBPointsDescription);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.TBPointsName);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.TBPointsX);
            this.tabPage4.Controls.Add(this.TBPointsY);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1209, 653);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Messorte verwalten";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // LPointsDataInvalid
            // 
            this.LPointsDataInvalid.AutoSize = true;
            this.LPointsDataInvalid.ForeColor = System.Drawing.Color.Red;
            this.LPointsDataInvalid.Location = new System.Drawing.Point(3, 235);
            this.LPointsDataInvalid.Name = "LPointsDataInvalid";
            this.LPointsDataInvalid.Size = new System.Drawing.Size(227, 17);
            this.LPointsDataInvalid.TabIndex = 51;
            this.LPointsDataInvalid.Text = "Überprüfen Sie bitte Ihre Eingaben";
            this.LPointsDataInvalid.Visible = false;
            // 
            // BMessPointDelete
            // 
            this.BMessPointDelete.Location = new System.Drawing.Point(9, 379);
            this.BMessPointDelete.Name = "BMessPointDelete";
            this.BMessPointDelete.Size = new System.Drawing.Size(208, 33);
            this.BMessPointDelete.TabIndex = 50;
            this.BMessPointDelete.Text = "löschen";
            this.BMessPointDelete.UseVisualStyleBackColor = true;
            this.BMessPointDelete.Click += new System.EventHandler(this.BMessPointDelete_Click);
            // 
            // BMessPointCancel
            // 
            this.BMessPointCancel.Location = new System.Drawing.Point(117, 267);
            this.BMessPointCancel.Name = "BMessPointCancel";
            this.BMessPointCancel.Size = new System.Drawing.Size(100, 32);
            this.BMessPointCancel.TabIndex = 49;
            this.BMessPointCancel.Text = "abbrechen";
            this.BMessPointCancel.UseVisualStyleBackColor = true;
            this.BMessPointCancel.Click += new System.EventHandler(this.BMessPointCancel_Click);
            // 
            // BMessPointAdd
            // 
            this.BMessPointAdd.Location = new System.Drawing.Point(9, 267);
            this.BMessPointAdd.Name = "BMessPointAdd";
            this.BMessPointAdd.Size = new System.Drawing.Size(100, 32);
            this.BMessPointAdd.TabIndex = 48;
            this.BMessPointAdd.Text = "hinzufügen";
            this.BMessPointAdd.UseVisualStyleBackColor = true;
            this.BMessPointAdd.Click += new System.EventHandler(this.BMessPointAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 47;
            this.label5.Text = "Messorte";
            // 
            // CBMessPoints
            // 
            this.CBMessPoints.FormattingEnabled = true;
            this.CBMessPoints.Location = new System.Drawing.Point(105, 332);
            this.CBMessPoints.Name = "CBMessPoints";
            this.CBMessPoints.Size = new System.Drawing.Size(121, 24);
            this.CBMessPoints.TabIndex = 46;
            // 
            // PBPoints
            // 
            this.PBPoints.Location = new System.Drawing.Point(234, 16);
            this.PBPoints.Name = "PBPoints";
            this.PBPoints.Size = new System.Drawing.Size(967, 483);
            this.PBPoints.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBPoints.TabIndex = 45;
            this.PBPoints.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Anmerkungen";
            // 
            // TBPointsDescription
            // 
            this.TBPointsDescription.Location = new System.Drawing.Point(125, 151);
            this.TBPointsDescription.Multiline = true;
            this.TBPointsDescription.Name = "TBPointsDescription";
            this.TBPointsDescription.Size = new System.Drawing.Size(100, 65);
            this.TBPointsDescription.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Ort";
            // 
            // TBPointsName
            // 
            this.TBPointsName.Location = new System.Drawing.Point(125, 109);
            this.TBPointsName.Name = "TBPointsName";
            this.TBPointsName.Size = new System.Drawing.Size(100, 22);
            this.TBPointsName.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "Y Wert";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "X Wert";
            // 
            // TBPointsX
            // 
            this.TBPointsX.Enabled = false;
            this.TBPointsX.Location = new System.Drawing.Point(125, 28);
            this.TBPointsX.Name = "TBPointsX";
            this.TBPointsX.Size = new System.Drawing.Size(100, 22);
            this.TBPointsX.TabIndex = 38;
            // 
            // TBPointsY
            // 
            this.TBPointsY.Enabled = false;
            this.TBPointsY.Location = new System.Drawing.Point(125, 65);
            this.TBPointsY.Name = "TBPointsY";
            this.TBPointsY.Size = new System.Drawing.Size(100, 22);
            this.TBPointsY.TabIndex = 37;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1209, 653);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Auswertung d. Daten";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // measuringMethodBindingSource
            // 
            this.measuringMethodBindingSource.DataSource = typeof(pManagement.ServiceReference1.MeasuringMethod);
            // 
            // measuringMethodBindingSource1
            // 
            this.measuringMethodBindingSource1.DataSource = typeof(pManagement.ServiceReference1.MeasuringMethod);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1209, 653);
            this.shapeContainer1.TabIndex = 8;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 274;
            this.lineShape1.X2 = 271;
            this.lineShape1.Y1 = 4;
            this.lineShape1.Y2 = 644;
            // 
            // BMethodsDelete
            // 
            this.BMethodsDelete.Location = new System.Drawing.Point(330, 281);
            this.BMethodsDelete.Name = "BMethodsDelete";
            this.BMethodsDelete.Size = new System.Drawing.Size(95, 47);
            this.BMethodsDelete.TabIndex = 9;
            this.BMethodsDelete.Text = "löschen";
            this.BMethodsDelete.UseVisualStyleBackColor = true;
            this.BMethodsDelete.Click += new System.EventHandler(this.BMethodsDelete_Click);
            // 
            // Bexport
            // 
            this.Bexport.Location = new System.Drawing.Point(199, 501);
            this.Bexport.Name = "Bexport";
            this.Bexport.Size = new System.Drawing.Size(114, 43);
            this.Bexport.TabIndex = 3;
            this.Bexport.Text = "exportieren";
            this.Bexport.UseVisualStyleBackColor = true;
            // 
            // TBEmployee
            // 
            this.TBEmployee.Location = new System.Drawing.Point(123, 246);
            this.TBEmployee.Name = "TBEmployee";
            this.TBEmployee.Size = new System.Drawing.Size(100, 22);
            this.TBEmployee.TabIndex = 35;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 246);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 17);
            this.label14.TabIndex = 36;
            this.label14.Text = "Mitarbeiter";
            // 
            // Lärmkataster_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 684);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Lärmkataster_Form";
            this.Text = "Lärmkataster";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBMap)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.measuringMethodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.measuringMethodBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button BClearTBData;
        private System.Windows.Forms.Button BSaveData;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBAverage;
        private System.Windows.Forms.TextBox TBMinWert;
        private System.Windows.Forms.TextBox TBMaxWert;
        private System.Windows.Forms.PictureBox PBMap;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox LBMethods;
        private System.Windows.Forms.Button BMethodCancel;
        private System.Windows.Forms.Button BMethodAdd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TBMethodDescription;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TBMethodName;
        private System.Windows.Forms.Label LMethodInvalid;
        private System.Windows.Forms.BindingSource measuringMethodBindingSource;
        private System.Windows.Forms.BindingSource measuringMethodBindingSource1;
        private System.Windows.Forms.Label LDataInvalid;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.PictureBox PBPoints;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBPointsDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBPointsName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBPointsX;
        private System.Windows.Forms.TextBox TBPointsY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBMessPoints;
        private System.Windows.Forms.Button BMessPointDelete;
        private System.Windows.Forms.Button BMessPointCancel;
        private System.Windows.Forms.Button BMessPointAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBChoosePosition;
        private System.Windows.Forms.Label LPointsDataInvalid;
        private System.Windows.Forms.Button BDeleteMeasurements;
        private System.Windows.Forms.TabPage tabPage5;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button BMethodsDelete;
        private System.Windows.Forms.Button Bexport;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TBEmployee;
    }
}

