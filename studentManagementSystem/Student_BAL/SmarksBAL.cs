using System;
using System.IO;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using studentManagementSystem.Student_DAL;

namespace studentManagementSystem.Student_BAL
{
    class SmarksBAL
    {

        public int insertTable(string id, string name, string cls, string m, string p, string c, string sc)
        {
            int res = 0;
            int id1 = Convert.ToInt32(id);
            int cls1 = Convert.ToInt32(cls);
            int m1 = Convert.ToInt32(m);
            int p1 = Convert.ToInt32(p);
            int c1 = Convert.ToInt32(c);
            int sc1 = Convert.ToInt32(sc);
            int tot = m1 + p1 + c1 + sc1;
            float avg = tot / 3;
            try
            {
                SmarksDAL obj = new SmarksDAL();

                if (name != null && (cls1 > 5 && cls1 <= 10) && (m1 >= 0 && m1 <= 100) && (p1 >= 0 && p1 <= 50) && (c1 >= 0 && c1 <= 50) && (tot >= 0 && tot <= 300) && (avg >= 0 && avg <= 100))
                {

                    res = obj.insertmarks(id1, name, cls1, m1, p1, c1, sc1, tot, avg);
                }
                else
                    MessageBox.Show("Enter valid details !!!");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message + "Error");
            }
            return res;

        }
    }
}
