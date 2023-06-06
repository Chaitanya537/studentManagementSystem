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
    class SmarksDAL
    {
        SqlConnection cnn;
        SqlDataAdapter adap;
        DataSet ds;
        public DataSet showmarks()
        {
            string connetionString;
            connetionString = @"Data Source=SQLLISTENER; Initial Catalog=DIT-Training; Integrated Security=True; User ID=sa; Password=Chaitu@123";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            adap = new SqlDataAdapter("select * from chaitanya_studentinfo_SMS order by Student_id", cnn);
            ds = new System.Data.DataSet();
            adap.Fill(ds, "Details");

            return ds;

        }

        public int insertmarks(int id,string name,int cls,int m1,int p1,int c1,int sc1,int tot,float avg)
        {
            try
            {
                string connetionString;
                SqlCommand comm;
                connetionString = @"Data Source=SQLLISTENER; Initial Catalog=DIT-Training; Integrated Security=True; User ID=sa; Password=Chaitu@123";
                cnn = new SqlConnection(connetionString);
                cnn.Open();

                comm = new SqlCommand("EXEC chaitanya_studentMarks_SMS " + id + "," + "'" + name + "'" + "," +
                                    cls + "," + m1 + "," + p1 + "," + c1 + "," + sc1 + "," + tot + "," + avg + " ", cnn);
                comm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return 1;
        }
        public int deleteRecord(string s)
        {
            int r = 0;
          
            try
            {
                int num = Convert.ToInt32(s);
                string connetionString;
                SqlCommand comm;
                connetionString = @"Data Source=SQLLISTENER; Initial Catalog=DIT-Training; Integrated Security=True; User ID=sa; Password=Chaitu@123";
                cnn = new SqlConnection(connetionString);
                cnn.Open();

                comm = new SqlCommand("DELETE FROM chaitanya_studentinfo_SMS WHERE Student_Id = " + num, cnn);
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
        public DataSet showPercent()
        {

            string connetionString;

            connetionString = @"Data Source=SQLLISTENER; Initial Catalog=DIT-Training; Integrated Security=True; User ID=sa; Password=Chaitu@123";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            adap = new SqlDataAdapter("EXEC [chaitanya_studentinfoDESC_SMS]", cnn);
            ds = new System.Data.DataSet();
            adap.Fill(ds, "Details");

            return ds;

        }

        public DataSet viewList(int t)
        {
            string connetionString;
            connetionString = @"Data Source=SQLLISTENER; Initial Catalog=DIT-Training; Integrated Security=True; User ID=sa; Password=Chaitu@123";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            if(t==1)
            {
                adap = new SqlDataAdapter("EXEC chaitanya_studentPercentageMath_SMS", cnn);
                ds = new System.Data.DataSet();
                adap.Fill(ds, "Details");
                return ds;
            }
            else if(t==2)
            {
                adap = new SqlDataAdapter("EXEC chaitanya_studentPercentagePS_SMS", cnn);
                ds = new System.Data.DataSet();
                adap.Fill(ds, "Details");
                return ds;
            }
            else if (t == 3)
            {
                adap = new SqlDataAdapter("EXEC chaitanya_studentPercentageNS_SMS", cnn);
                ds = new System.Data.DataSet();
                adap.Fill(ds, "Details");
                return ds;
            }
            else if (t == 4)
            {
                adap = new SqlDataAdapter("EXEC chaitanya_studentPercentageSocial_SMS", cnn);
                ds = new System.Data.DataSet();
                adap.Fill(ds, "Details");
                return ds;
            }
            else
            {
                adap = new SqlDataAdapter("EXEC chaitanya_studentPercentageTot_SMS", cnn);
                ds = new System.Data.DataSet();
                adap.Fill(ds, "Details");
                return ds;
            }


        }

    }
}
