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
    class attendanceDAL
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
            adap = new SqlDataAdapter("select * from chaitanya_studentAttendanceProcedure_SMS ORDER BY Student_id", cnn);
            ds = new System.Data.DataSet();
            adap.Fill(ds, "Details");

            return ds;
        }

        public int insertAttendance(int id, string name, int math,int physics,int chem,float tot)
        {
            try
            {
                string connetionString;
                SqlCommand comm;
                connetionString = @"Data Source=SQLLISTENER; Initial Catalog=DIT-Training; Integrated Security=True; User ID=sa; Password=Chaitu@123";
                cnn = new SqlConnection(connetionString);
                cnn.Open();

                comm = new SqlCommand("EXEC [chaitanya_AttendanceProcedure_SMS] " + "'" + name + "'" + "," +
                                       math+ "," +physics + "," + chem + "," + tot + " " , cnn);
                comm.ExecuteNonQuery();
                return 1;
            }
            catch (Exception e1)
            {
                MessageBox.Show("There is no Student with this ID to insert these details in the Record !!! ");
                return 0;
            }
           
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

                comm = new SqlCommand("DELETE FROM chaitanya_studentAttendanceProcedure_SMS WHERE Student_Id = " + id2, cnn);
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
