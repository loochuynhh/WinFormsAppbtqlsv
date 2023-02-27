namespace WinFormsAppbtqlsv
{
    partial class mainForm
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
            this.CBBLopSH = new System.Windows.Forms.ComboBox();
            this.Search = new System.Windows.Forms.Button();
            this.TBSearch = new System.Windows.Forms.TextBox();
            this.LopSH = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Sort = new System.Windows.Forms.Button();
            this.CBBSort = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CBBLopSH
            // 
            this.CBBLopSH.FormattingEnabled = true;
            this.CBBLopSH.Location = new System.Drawing.Point(148, 20);
            this.CBBLopSH.Name = "CBBLopSH";
            this.CBBLopSH.Size = new System.Drawing.Size(182, 33);
            this.CBBLopSH.TabIndex = 1;
            this.CBBLopSH.SelectedIndexChanged += new System.EventHandler(this.CBBLopSH_SelectedIndexChanged);
            this.CBBLopSH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CBBLopSH_KeyPress);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(521, 18);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(112, 34);
            this.Search.TabIndex = 3;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // TBSearch
            // 
            this.TBSearch.Location = new System.Drawing.Point(671, 20);
            this.TBSearch.Name = "TBSearch";
            this.TBSearch.Size = new System.Drawing.Size(150, 31);
            this.TBSearch.TabIndex = 4;
            this.TBSearch.TextChanged += new System.EventHandler(this.TBSearch_TextChanged);
            // 
            // LopSH
            // 
            this.LopSH.AutoSize = true;
            this.LopSH.Location = new System.Drawing.Point(65, 23);
            this.LopSH.Name = "LopSH";
            this.LopSH.Size = new System.Drawing.Size(65, 25);
            this.LopSH.TabIndex = 5;
            this.LopSH.Text = "LopSH";
            this.LopSH.Click += new System.EventHandler(this.LopSH_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(65, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(756, 225);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(65, 359);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(112, 34);
            this.Add.TabIndex = 7;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(218, 359);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(112, 34);
            this.Edit.TabIndex = 8;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(367, 359);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(112, 34);
            this.Delete.TabIndex = 9;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Sort
            // 
            this.Sort.Location = new System.Drawing.Point(521, 359);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(112, 34);
            this.Sort.TabIndex = 10;
            this.Sort.Text = "Sort";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // CBBSort
            // 
            this.CBBSort.FormattingEnabled = true;
            this.CBBSort.Location = new System.Drawing.Point(652, 359);
            this.CBBSort.Name = "CBBSort";
            this.CBBSort.Size = new System.Drawing.Size(169, 33);
            this.CBBSort.TabIndex = 11;
            this.CBBSort.SelectedIndexChanged += new System.EventHandler(this.CBBSort_SelectedIndexChanged);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 433);
            this.Controls.Add(this.CBBSort);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LopSH);
            this.Controls.Add(this.TBSearch);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.CBBLopSH);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox CBBLopSH;
        private Button Search;
        private TextBox TBSearch;
        private Label LopSH;
        private DataGridView dataGridView1;
        private Button Add;
        private Button Edit;
        private Button Delete;
        private Button Sort;
        private ComboBox CBBSort;
    }
}