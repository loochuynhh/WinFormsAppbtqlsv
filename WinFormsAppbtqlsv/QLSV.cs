using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppbtqlsv
{
    public class QLSV
    {
        
        
        public delegate bool comparestr(object s1, object s2);
        public static void swap(ref List<SV> list, int i, int j)
        {
            SV temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
        public List<SV> sort(List<SV> s1, comparestr cmp)
        {
            for(int i = 0; i < s1.Count - 1; i++)
            {
                for(int j = 0; j < s1.Count - i - 1; j++)
                {
                    if (cmp(s1[j], s1[j + 1]))
                    {
                        swap(ref s1,j, j + 1);
                    }
                }
            }
            return s1; 

        }
        public static bool cmpName(object s1, object s2)
        {

            if(string.Compare(((SV)s1).Name, ((SV)s2).Name) > 0){
                
                return true; 
            }
            
                return false;
            
        }
        public static bool cmpMSSV(object s1, object s2)
        {
            if (string.Compare(((SV)s1).MSSV, ((SV)s2).MSSV) > 0) { return true; }
            return false;
        }
        public static bool cmpDTB(object s1, object s2)
        {
            if (((SV)s1).DTB > ((SV)s2).DTB) { return true; }
            return false;
        }
        public static bool cmpLopSH(object s1, object s2)
        {
            if (string.Compare(((SV)s1).LopSH, ((SV)s2).LopSH) > 0) { return true; }
            return false;
        }
        public List<String> getLopSH()
        {
            List<String> loptest = new List<String>();
            foreach(SV i in CSDL.Instance.GetAllSV())
            {
                loptest.Add(i.LopSH.ToString());
            }
            loptest.Add("ALL");
            List<String> lopSH = new List<String>();
            lopSH.AddRange(loptest.Distinct());
            return lopSH;
        }
        public List<String> getLopSH2()
        {
            List<String> loptest = new List<String>();
            foreach (SV i in CSDL.Instance.GetAllSV())
            {
                loptest.Add(i.LopSH.ToString());
            }
            List<String> lopSH = new List<String>();
            lopSH.AddRange(loptest.Distinct());
            return lopSH;
        }
        public List<SV> getdata(string lopSH, string text)
        {
            List<SV> lop = new List<SV>();
            if (lopSH == "ALL")
            {
                foreach (SV i in CSDL.Instance.GetAllSV())
                {
                    if (i.Name.Contains(text))
                    {
                        lop.Add(i);
                    }
                }
                return lop;
            }
            else
            {
                foreach (SV i in CSDL.Instance.GetAllSV())
                {
                    if (i.LopSH == lopSH && i.Name.Contains(text))
                    {
                        lop.Add(i);
                    }
                }
                return lop;
            }
        }
        public void delSV(string lopSH, string text, int index) { 
            List<SV> lop = getdata(lopSH, text);
            CSDL.Instance.Del(lop[index].MSSV);
        }
        public string getaddedit(string lopSH, string text, int index)
        {
            List<SV> lop = getdata(lopSH, text);
            return lop[index].MSSV;
        }
        public List<string> getcbbsort() { 
            List<string> list = new List<string>();
            list.Add("Name");
            list.Add("DTB");
            list.Add("LopSH");
            list.Add("MSSV");
            return list;
        }
        public List<SV> getdataaftersort(string lopSH, string text, string sort)
        {
            List<SV> lop = getdata(lopSH, text);
            if(sort == "Name")
            {
                this.sort(lop, cmpName);
                return lop;
            }
            else if(sort == "DTB")
            {
                this.sort(lop, cmpDTB);
                return lop;
            }
            else if(sort == "LopSH")
            {
                this.sort(lop, cmpLopSH);
                return lop;
            }
            else
            {
                this.sort(lop, cmpMSSV);
                return lop;
            }
        }
        public void qLSV(SV v)
        {
            bool ok = false;
            foreach(SV s in CSDL.Instance.GetAllSV())
            {
                if (s.MSSV == v.MSSV)
                {
                    ok = true;
                    CSDL.Instance.Update(v);
                    return;
                }
            }
            if(!ok) CSDL.Instance.Add(v);
        }
    }
    
}
