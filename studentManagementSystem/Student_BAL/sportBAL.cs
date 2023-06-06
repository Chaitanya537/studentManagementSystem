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
    class sportBAL
    {

        public int insertRecord(string id,string nm,string sport)
        {
            int res = 0;
            int id1 = Convert.ToInt32(id);
            try
            {
                sportDAL ob = new sportDAL();
                if ((nm != null && sport != null) && id1 > 1000)
                {
                    res = ob.insertSport(id1, nm, sport);
                }
                else
                    MessageBox.Show("Enter a valid data !!!");
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message + "Error");
            }
            return res;
        }
    }
}
