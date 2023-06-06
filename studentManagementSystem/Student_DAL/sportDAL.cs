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
using studentManagementSystem.Student_BAL;

namespace studentManagementSystem.Student_DAL
{
    class sportDAL
    {
        SqlConnection cnn;
        SqlDataAdapter adap;
        DataSet ds;
        public DataSet showData()
        {
            string connetionString;
            connetionString = @"Data Source=SQLLISTENER; Initial Catalog=DIT-Training; Integrated Security=True; User ID=sa; Password=Chaitu@123";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            adap = new SqlDataAdapter("select * from chaitanya_studentSport_SMS ORDER BY S_id", cnn);
            ds = new System.Data.DataSet();
            adap.Fill(ds, "Details");

            return ds;
        }

        public int insertSport(int id, string name,string sport)
        {
            try
            {
                string connetionString;
                SqlCommand comm;
                connetionString = @"Data Source=SQLLISTENER; Initial Catalog=DIT-Training; Integrated Security=True; User ID=sa; Password=Chaitu@123";
                cnn = new SqlConnection(connetionString);
                cnn.Open();

                comm = new SqlCommand("EXEC chaitanya_studentSportProcedure_SMS " + id + "," + "'" + name + "'" + "," +
                                    "'" + sport + "'", cnn);
                comm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return 1;
        }
        public int deletedata(string s1)
        {
            int r = 0;
           
            try
            {
                int id2 = Convert.ToInt32(s1);
                string connetionString;
                SqlCommand comm;
                connetionString = @"Data Source=SQLLISTENER; Initial Catalog=DIT-Training; Integrated Security=True; User ID=sa; Password=Chaitu@123";
                cnn = new SqlConnection(connetionString);
                cnn.Open();

                comm = new SqlCommand("DELETE FROM chaitanya_studentSport_SMS WHERE S_Id = " + id2, cnn);
                comm.ExecuteNonQuery();
                MessageBox.Show("Successfully Record Deleted !!!");
                r = 1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "Error");
            }
            return r;

        }

    }

    
}
