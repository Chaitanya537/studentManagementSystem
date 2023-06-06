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
    class studentDetails
    {
        SqlConnection cnn;
        SqlDataAdapter adap;
        DataSet ds;
        public DataSet viewStudent(int t)
        {
            string connetionString;
            connetionString = @"Data Source=SQLLISTENER; Initial Catalog=DIT-Training; Integrated Security=True; User ID=sa; Password=Chaitu@123";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            if(t==1)
            {
                adap = new SqlDataAdapter("exec chaitanya_studentProcedureClass_SMS", cnn);
                ds = new System.Data.DataSet();
                adap.Fill(ds, "Details");
                return ds;
            }
            else if(t==2)
            {
                adap = new SqlDataAdapter("exec [chaitanya_studentProcedureMarks_SMS]", cnn);
                ds = new System.Data.DataSet();
                adap.Fill(ds, "Details");
                return ds;
            }
            else if (t == 3)
            {
                adap = new SqlDataAdapter("exec [chaitanya_studentProcedureAttendance_SMS]", cnn);
                ds = new System.Data.DataSet();
                adap.Fill(ds, "Details");
                return ds;
            }
            else if (t == 4)
            {
                adap = new SqlDataAdapter("exec [chaitanya_studentProcedureFeedue_SMS]", cnn);
                ds = new System.Data.DataSet();
                adap.Fill(ds, "Details");
                return ds;
            }
            else if (t == 5)
            {
                adap = new SqlDataAdapter("exec [chaitanya_studentProcedurecAt_SMS]", cnn);
                ds = new System.Data.DataSet();
                adap.Fill(ds, "Details");
                return ds;
            }
            else if (t == 6)
            {
                adap = new SqlDataAdapter("exec [chaitanya_studentProcedurecAf_SMS]", cnn);
                ds = new System.Data.DataSet();
                adap.Fill(ds, "Details");
                return ds;
            }
            else if (t == 7)
            {
                adap = new SqlDataAdapter("exec [chaitanya_studentProcedurecAa_SMS]", cnn);
                ds = new System.Data.DataSet();
                adap.Fill(ds, "Details");
                return ds;
            }
            else if (t==8)
            {
                adap = new SqlDataAdapter("exec [chaitanya_studentProcedurecAs_SMS]", cnn);
                ds = new System.Data.DataSet();
                adap.Fill(ds, "Details");
                return ds;
            }
            else
            {
                adap = new SqlDataAdapter("exec chaitanya_studentProcedureFull_SMS", cnn);
                ds = new System.Data.DataSet();
                adap.Fill(ds, "Details");
                return ds;
            }
        }
    }
}
