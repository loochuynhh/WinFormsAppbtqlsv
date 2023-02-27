namespace WinFormsAppbtqlsv
{
    partial class detailForm
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
            this.MSSV = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DayofBirth = new System.Windows.Forms.Label();
            this.TBMSSV = new System.Windows.Forms.TextBox();
            this.TBName = new System.Windows.Forms.TextBox();
            this.CBBLopSH = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Female = new System.Windows.Forms.RadioButton();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Gender = new System.Windows.Forms.GroupBox();
            this.DTB = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.HoSo = new System.Windows.Forms.CheckBox();
            this.Anh = new System.Windows.Forms.CheckBox();
            this.HocBa = new System.Windows.Forms.CheckBox();
            this.TBDTB = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Ten = new System.Windows.Forms.Label();
            this.Gender.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MSSV
            // 
            this.MSSV.AutoSize = true;
            this.MSSV.Location = new System.Drawing.Point(72, 34);
            this.MSSV.Name = "MSSV";
            this.MSSV.Size = new System.Drawing.Size(59, 25);
            this.MSSV.TabIndex = 0;
            this.MSSV.Text = "MSSV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "LopSH";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // DayofBirth
            // 
            this.DayofBirth.AutoSize = true;
            this.DayofBirth.Location = new System.Drawing.Point(72, 237);
            this.DayofBirth.Name = "DayofBirth";
            this.DayofBirth.Size = new System.Drawing.Size(96, 25);
            this.DayofBirth.TabIndex = 3;
            this.DayofBirth.Text = "DayofBirth";
            // 
            // TBMSSV
            // 
            this.TBMSSV.Location = new System.Drawing.Point(189, 31);
            this.TBMSSV.Name = "TBMSSV";
            this.TBMSSV.Size = new System.Drawing.Size(150, 31);
            this.TBMSSV.TabIndex = 4;
            this.TBMSSV.TextChanged += new System.EventHandler(this.TBMSSV_TextChanged);
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(189, 93);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(150, 31);
            this.TBName.TabIndex = 5;
            this.TBName.TextChanged += new System.EventHandler(this.TBName_TextChanged);
            // 
            // CBBLopSH
            // 
            this.CBBLopSH.FormattingEnabled = true;
            this.CBBLopSH.Location = new System.Drawing.Point(186, 162);
            this.CBBLopSH.Name = "CBBLopSH";
            this.CBBLopSH.Size = new System.Drawing.Size(153, 33);
            this.CBBLopSH.TabIndex = 6;
            this.CBBLopSH.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(186, 237);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(153, 31);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Location = new System.Drawing.Point(70, 75);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(93, 29);
            this.Female.TabIndex = 8;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Location = new System.Drawing.Point(70, 30);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(75, 29);
            this.Male.TabIndex = 9;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            this.Male.CheckedChanged += new System.EventHandler(this.Male_CheckedChanged);
            // 
            // Gender
            // 
            this.Gender.Controls.Add(this.Male);
            this.Gender.Controls.Add(this.Female);
            this.Gender.Location = new System.Drawing.Point(483, 31);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(300, 115);
            this.Gender.TabIndex = 10;
            this.Gender.TabStop = false;
            this.Gender.Text = "Gender";
            this.Gender.Enter += new System.EventHandler(this.Gender_Enter);
            // 
            // DTB
            // 
            this.DTB.AutoSize = true;
            this.DTB.Location = new System.Drawing.Point(72, 308);
            this.DTB.Name = "DTB";
            this.DTB.Size = new System.Drawing.Size(43, 25);
            this.DTB.TabIndex = 11;
            this.DTB.Text = "DTB";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.HoSo);
            this.groupBox2.Controls.Add(this.Anh);
            this.groupBox2.Controls.Add(this.HocBa);
            this.groupBox2.Location = new System.Drawing.Point(483, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 161);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // HoSo
            // 
            this.HoSo.AutoSize = true;
            this.HoSo.Location = new System.Drawing.Point(70, 126);
            this.HoSo.Name = "HoSo";
            this.HoSo.Size = new System.Drawing.Size(83, 29);
            this.HoSo.TabIndex = 2;
            this.HoSo.Text = "HoSo";
            this.HoSo.UseVisualStyleBackColor = true;
            // 
            // Anh
            // 
            this.Anh.AutoSize = true;
            this.Anh.Location = new System.Drawing.Point(70, 80);
            this.Anh.Name = "Anh";
            this.Anh.Size = new System.Drawing.Size(70, 29);
            this.Anh.TabIndex = 1;
            this.Anh.Text = "Anh";
            this.Anh.UseVisualStyleBackColor = true;
            // 
            // HocBa
            // 
            this.HocBa.AutoSize = true;
            this.HocBa.Location = new System.Drawing.Point(70, 30);
            this.HocBa.Name = "HocBa";
            this.HocBa.Size = new System.Drawing.Size(89, 29);
            this.HocBa.TabIndex = 0;
            this.HocBa.Text = "HocBa";
            this.HocBa.UseVisualStyleBackColor = true;
            // 
            // TBDTB
            // 
            this.TBDTB.Location = new System.Drawing.Point(186, 304);
            this.TBDTB.Name = "TBDTB";
            this.TBDTB.Size = new System.Drawing.Size(150, 31);
            this.TBDTB.TabIndex = 13;
            this.TBDTB.TextChanged += new System.EventHandler(this.TBDTB_TextChanged);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(212, 404);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(112, 34);
            this.OK.TabIndex = 14;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(582, 404);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(112, 34);
            this.Cancel.TabIndex = 15;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Ten
            // 
            this.Ten.AutoSize = true;
            this.Ten.Location = new System.Drawing.Point(72, 96);
            this.Ten.Name = "Ten";
            this.Ten.Size = new System.Drawing.Size(59, 25);
            this.Ten.TabIndex = 16;
            this.Ten.Text = "Name";
            this.Ten.Click += new System.EventHandler(this.label1_Click);
            // 
            // detailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 478);
            this.Controls.Add(this.Ten);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.TBDTB);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DTB);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.CBBLopSH);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.TBMSSV);
            this.Controls.Add(this.DayofBirth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MSSV);
            this.Name = "detailForm";
            this.Text = "Detail";
            this.Load += new System.EventHandler(this.detailForm_Load);
            this.Gender.ResumeLayout(false);
            this.Gender.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label MSSV;
        private Label label3;
        private Label DayofBirth;
        private TextBox TBMSSV;
        private TextBox TBName;
        private ComboBox CBBLopSH;
        private DateTimePicker dateTimePicker1;
        private RadioButton Female;
        private RadioButton Male;
        private GroupBox Gender;
        private Label DTB;
        private GroupBox groupBox2;
        private CheckBox HoSo;
        private CheckBox Anh;
        private CheckBox HocBa;
        private TextBox TBDTB;
        private Button OK;
        private Button Cancel;
        private Label Ten;
    }
}