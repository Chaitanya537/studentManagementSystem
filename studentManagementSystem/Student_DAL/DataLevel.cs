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


namespace studentManagementSystem.Student_DAL
{
    class DataLevel
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

            adap = new SqlDataAdapter("select * from chaitanya_studentData_SMS", cnn);
            ds = new System.Data.DataSet();
            adap.Fill(ds, "Details");

            return ds;
        }
        public int  insertData(string n1,string n2,int agee,string mail,string gen,int clas,string num)
        {

            try
            {
                string connetionString;
                SqlCommand comm;
                connetionString = @"Data Source=SQLLISTENER; Initial Catalog=DIT-Training; Integrated Security=True; User ID=sa; Password=Chaitu@123";
                cnn = new SqlConnection(connetionString);
                cnn.Open();

                comm = new SqlCommand("EXEC chaitanya_studentDetailsProcedure_SMS " + "'" + n1 + "'" + "," + "'" + n2 + "'" + "," +
                                        agee + "," + "'" + mail + "'" + "," + "'" + gen + "'" + "," + clas + "," +
                                        "'" + num + "'", cnn);
                comm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return 1;
        }

        public void deleterecord(string s)
        {
           

            try
            {
                int id1 = Convert.ToInt32(s);
                string connetionString;
                SqlCommand comm;
                connetionString = @"Data Source=SQLLISTENER; Initial Catalog=DIT-Training; Integrated Security=True; User ID=sa; Password=Chaitu@123";
                cnn = new SqlConnection(connetionString);
                cnn.Open();

                comm = new SqlCommand("DELETE FROM chaitanya_studentData_SMS WHERE Student_Id = " + id1, cnn);
                comm.ExecuteNonQuery();
                MessageBox.Show("Successfully Record Deleted !!!");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message + "Error");
            }



        }
    }
}
