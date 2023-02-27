namespace WinFormsAppbtqlsv
{
    public partial class mainForm : Form
    {
        QLSV a = new QLSV();
        
        public mainForm()
        {
            InitializeComponent();
        }
        
        private void CBBLopSH_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            CBBLopSH.DataSource = a.getLopSH();
            CBBSort.DataSource = a.getcbbsort();
        }

        private void CBBLopSH_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void LopSH_Click(object sender, EventArgs e)
        {
           
        }
        public void dataview(string s, string t, string type)
        {
            if (type == "")
            {
                dataGridView1.DataSource = a.getdata(s, t);
                dataGridView1.Columns["DateofBirth"].Visible = false;
                dataGridView1.Columns["HoSo"].Visible = false;
                dataGridView1.Columns["HocBa"].Visible = false;
                dataGridView1.Columns["Anh"].Visible = false;
            }
            else
            {
                dataGridView1.DataSource = a.getdataaftersort(s, t, type);
                dataGridView1.Columns["DateofBirth"].Visible = false;
                dataGridView1.Columns["HoSo"].Visible = false;
                dataGridView1.Columns["HocBa"].Visible = false;
                dataGridView1.Columns["Anh"].Visible = false;
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
           dataview(CBBLopSH.SelectedItem.ToString(), TBSearch.Text, "");
            

        }

        private void TBSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                a.delSV(CBBLopSH.SelectedItem.ToString(), TBSearch.Text, dataGridView1.CurrentRow.Index);
                dataview(CBBLopSH.SelectedItem.ToString(), TBSearch.Text, "");
            }
        }

        private void CBBSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string txt = CBBLopSH.SelectedItem.ToString();

        }

        private void Sort_Click(object sender, EventArgs e)
        {
            dataview(CBBLopSH.SelectedItem.ToString(), TBSearch.Text, CBBSort.SelectedItem.ToString());
        }

        private void Add_Click(object sender, EventArgs e)
        {
            
            detailForm f = new detailForm("");
            f.ShowDialog();
            this.Refresh();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            
            detailForm f = new detailForm(a.getaddedit(CBBLopSH.SelectedItem.ToString(), TBSearch.Text, dataGridView1.CurrentRow.Index));
            f.ShowDialog();
            this.Refresh();
        }
    }
}