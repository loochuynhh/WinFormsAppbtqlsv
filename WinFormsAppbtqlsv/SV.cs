using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppbtqlsv
{
    public class SV
    {
        public string Name { get; set; }
        public string MSSV { get; set; }
        public string LopSH { get; set; }
        public bool Gender { get; set; }
        public double DTB { get; set; }
        public bool HoSo { get; set; }
        public bool Anh { get; set; }
        public bool HocBa { get; set; }
        public DateTime DateofBirth { get; set; }
        public SV()
        {

        }
        public SV(string MSSV, string Name, string LopSH, bool Gender, double DTB, bool HoSo, bool Anh, bool HocBa, DateTime DateOfBirth)
        {
            this.Name = Name;   
            this.MSSV = MSSV;
            this.Anh = Anh;
            this.HocBa = HocBa;
            this.DateofBirth = DateOfBirth;
            this.HoSo = HoSo;
            this.DTB = DTB;
            this.LopSH = LopSH;
            this.Gender = Gender;

        }
    }
}
