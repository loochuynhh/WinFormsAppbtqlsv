using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppbtqlsv
{
    public class CSDL
    {
        private DataTable dt;
        private static CSDL _Instance;
        public static CSDL Instance
        {
            get
            {
                if (_Instance != null) return _Instance;
                return _Instance = new CSDL();
            }
            set { _Instance = value; }
        }
        public CSDL()
        {
            DateTime d1 = new DateTime(2003, 10, 1);
            DateTime d2 = new DateTime(2002,11, 1);
            DateTime d3 = new DateTime(2002,12, 30);
            DateTime d4 = new DateTime(2002,2, 3);
            DateTime d5 = new DateTime(2002,11, 6);
            DateTime d6 = new DateTime(2002,1, 8);
            DateTime d7 = new DateTime(2002,6, 9);
            DateTime d8 = new DateTime(2002,10, 17);
            dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("MSSV", typeof(string)),
                new DataColumn("Name",typeof(string)),
                new DataColumn("LopSH",typeof(string)),
                new DataColumn("Gender",typeof(bool)),
                new DataColumn("DTB",typeof(double)),
                new DataColumn("HoSo",typeof(bool)),
                new DataColumn("Anh",typeof(bool)),
                new DataColumn("HocBa",typeof(bool)),
                new DataColumn("DateofBirth",typeof(DateTime)),
            }) ;
            List<SV> s = new List<SV>
            {
                new SV("1001", "Huynh Van Loc ","21T_DT1", true, 7.8, false, false, true, d8),
                new SV("1002", "Huynh Van An ","21T_DT2", false, 8.8, false, false, false, d1),
                new SV("1003", "Huynh Van Lan ","21T_DT2", true, 6.8, false, true, true, d2),
                new SV("1004", "Huynh Van Tam ","21T_DT3", false, 9.0, true, false, true, d3),
                new SV("1005", "Huynh Van Phat ","21T_DT3", true, 7.5, false, true, false, d4),
                new SV("1006", "Huynh Van Ngo","21T_DT2", true, 8.4, false, true, true, d5),
                new SV("1007", "Huynh Van Huy ","21T_DT1", false, 9.2, false, false, false, d6),
                new SV("1008", "Huynh Van Thai ","21T_DT3", true, 8.1, true, true, true, d7),
            };
            for (int i = 0; i < s.Count;i++)
            {
                DataRow row;
                row = dt.NewRow();
                row[0] = s[i].MSSV.ToString();
                row[1] = s[i].Name.ToString();
                row[2] = s[i].LopSH.ToString();
                row[3] = (bool)s[i].Gender;
                row[4] = (double)s[i].DTB;
                row[5] = (bool)s[i].HoSo;
                row[6] = (bool)s[i].Anh;
                row[7] = (bool)s[i].HocBa;
                row[8] = (DateTime)s[i].DateofBirth;
                dt.Rows.Add(row);
            }
        }
        public List<SV> GetAllSV()
        {
            List<SV> s = new List<SV>();
            foreach(DataRow dr in dt.Rows)
            {
                SV i = new SV();
                i.MSSV = (string)dr["MSSV"];
                i.Name = (string)dr["Name"];
                i.LopSH = (string)dr["LopSH"];
                i.Gender = (bool)dr["Gender"];
                i.Anh = (bool)dr["Anh"];
                i.HoSo = (bool)dr["HoSo"];
                i.HocBa = (bool)dr["HocBa"];
                i.DTB = (double)dr["DTB"];
                i.DateofBirth = (DateTime)dr["DateofBirth"];
                s.Add(i);
            }
            return s;
        }
        public void Del(string mssv)
        {
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                if(dt.Rows[i]["MSSV"].ToString() == mssv) dt.Rows.RemoveAt(i);
            }
        }
        public void Add(SV s)
        {
            DataRow row;
            row = dt.NewRow();
            row[0] = s.MSSV.ToString();
            row[1] = s.Name.ToString();
            row[2] = s.LopSH.ToString();
            row[3] = (bool)s.Gender;
            row[4] = (double)s.DTB;
            row[5] = (bool)s.HoSo;
            row[6] = (bool)s.Anh;
            row[7] = (bool)s.HocBa;
            row[8] = (DateTime)s.DateofBirth;
            dt.Rows.Add(row);
        }

        public void Update(SV s)
        {
            int index = -1;
            int cnt = dt.Rows.Count;
            for (int i = 0;i< cnt; i++)
            {
                if ((string)dt.Rows[i]["MSSV"] == s.MSSV)
                {
                    index = i;
                    
                }
            }
            dt.Rows.RemoveAt(index);
            this.Add(s);
        }
    }
}
