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
    class attendanceBAL
    {

        public int insertRecord(string id, string nm, string m1,string p1,string c1)
        {
            int res = 0;
            float avg,tot;
            int id1 = Convert.ToInt32(id);
            int math = Convert.ToInt32(m1);
            int phy = Convert.ToInt32(p1);
            int che = Convert.ToInt32(c1);
            try
            {
                attendanceDAL ob = new attendanceDAL();
                tot = (math + phy + che)/3;
                avg = tot * 100 / 60;
                if ((nm != null && id1 > 1000) && math>=0 && phy>=0 && che>=0 && (math<=60) && phy<=60 && che<=60)
                {
                    res = ob.insertAttendance(id1, nm, math, phy, che,avg);
                }
                else
                    MessageBox.Show("Enter a valid data !!!");
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message + "Error");
            }
            return res;
        }
    }
}
