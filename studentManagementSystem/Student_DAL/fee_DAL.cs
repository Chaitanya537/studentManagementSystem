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
using studentManagementSystem.Student_BO;

namespace studentManagementSystem.Student_DAL
{
    class fee_DAL
    {
        SqlConnection cnn;
        SqlDataAdapter adap;
        DataSet ds;
        public DataSet displayFee()
        {
            string connetionString;
            connetionString = @"Data Source=SQLLISTENER; Initial Catalog=DIT-Training; Integrated Security=True; User ID=sa; Password=Chaitu@123";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            adap = new SqlDataAdapter("select * from chaitanya_studentFeeDetails_SMS ORDER BY Student_Id", cnn);
            ds = new System.Data.DataSet();
            adap.Fill(ds, "Details");

            return ds;
        }
        public int insertData(feeObject obj)
        {
            int r = 0;
            string connetionString;
            SqlCommand comm;
            connetionString = @"Data Source=SQLLISTENER; Initial Catalog=DIT-Training; Integrated Security=True; User ID=sa; Password=Chaitu@123";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            comm = new SqlCommand("chaitanya_studentFeeProcedure_SMS", cnn);
            comm.CommandType = CommandType.StoredProcedure;
            
            comm.Parameters.AddWithValue("@name", obj.name);
            comm.Parameters.AddWithValue("@fee", obj.fee);
            comm.Parameters.AddWithValue("@amount_paid", obj.amount_paid);
            comm.Parameters.AddWithValue("@Balance_amount", (obj.fee - obj.amount_paid));
            comm.Parameters.AddWithValue("@LastDateToPay", obj.Last_date);


            r = comm.ExecuteNonQuery();
            return r;
            

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

                comm = new SqlCommand("DELETE FROM chaitanya_studentFeeDetails_SMS WHERE Student_Id = " + id2, cnn);
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
