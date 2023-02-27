using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppbtqlsv
{
    public partial class detailForm : Form
    {
        QLSV a = new QLSV();
        public detailForm()
        {
            InitializeComponent();
        }
        SV svf = null;
        public detailForm(string MSSV)
        {
            InitializeComponent();
            {
                foreach(SV v in CSDL.Instance.GetAllSV())
                {
                    if (v.MSSV == MSSV)
                    {
                        svf = v;
                    }
                }
            }
            if (svf != null)
            {
                TBMSSV.Text = ((SV)svf).MSSV.ToString();
                TBMSSV.ReadOnly = true;
                TBName.Text = ((SV)svf).Name.ToString();
                TBDTB.Text = svf.DTB.ToString();
                dateTimePicker1.Value = (DateTime)svf.DateofBirth;
                CBBLopSH.DataSource = a.getLopSH2();
                CBBLopSH.Text = ((SV)svf).LopSH.ToString();
                if (svf.Gender)
                {
                    Male.Checked = true;
                    Female.Checked = false;
                }
                else
                {
                    Male.Checked = false;
                    Female.Checked = true;
                    
                }
                if (svf.HocBa) HocBa.Checked = true;
                if (svf.HoSo) HoSo.Checked = true;
                if (svf.Anh) Anh.Checked = true;
            }
            else
            {
                CBBLopSH.DataSource = a.getLopSH2();
            }
        }
        private void detailForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TBMSSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Gender_Enter(object sender, EventArgs e)
        {

        }

        private void Male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            svf.MSSV = TBMSSV.Text.ToString();
            svf.Name = TBName.Text.ToString();
            svf.DTB = Convert.ToDouble(TBDTB.Text);
            svf.Anh = Anh.Checked;
            svf.HoSo = HoSo.Checked;
            svf.HocBa = HocBa.Checked;
            if (Male.Checked) svf.Gender = true;
            else svf.Gender = false;
            svf.LopSH = CBBLopSH.SelectedItem.ToString();
            svf.DateofBirth = dateTimePicker1.Value;
            
            a.qLSV(svf);
            this.Close();
        }

        private void TBDTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
