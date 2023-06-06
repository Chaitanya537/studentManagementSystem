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

namespace studentManagementSystem.teacher_DAL
{
    class DataAccess
    {
        SqlConnection cnn;
        SqlDataAdapter adap;
        DataSet ds;

        //public System.Data.SqlClient.SqlCommand UpdateCommand { get; set; }
        public void connSQL()
        {
            string connetionString;
           
            SqlConnection cnn;
            connetionString = @"Data Source=SQLLISTENER; Initial Catalog=DIT-Training; Integrated Security=True; User ID=sa; Password=Chaitu@123";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
 
            
        }
        public DataSet showTable()
        {
            string connetionString;
       
        
            connetionString = @"Data Source=SQLLISTENER; Initial Catalog=DIT-Training; Integrated Security=True; User ID=sa; Password=Chaitu@123";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            adap = new SqlDataAdapter("select * from chaitanya_teacherDetails_SMS", cnn);
            ds = new System.Data.DataSet();
            adap.Fill(ds, "Details");
           

           /* using (SqlConnection sqlcon = new SqlConnection(connetionString))
            {
                sqlcon.Open();
                comm = new SqlCommand("exec chaitanya_teacherDetailsDU_SMS;", sqlcon);
                comm.CommandType = CommandType.Text;
                SqlDataAdapter sqlDa = new SqlDataAdapter(comm);
                DataTable dtb1 = new DataTable();
                sqlDa.Fill(dtb1);
            }*/
                return ds;
            
        }

        public void teacherUpdate()
        {
            try
            {
                string connetionString;
               
                connetionString = @"Data Source=SQLLISTENER; Initial Catalog=DIT-Training; Integrated Security=True; User ID=sa; Password=Chaitu@123";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                adap = new SqlDataAdapter("select * from chaitanya_teacherDetails_SMS", cnn);
                SqlCommandBuilder cmbdl = new SqlCommandBuilder(adap);
                DataSet ds = new System.Data.DataSet();
                
                adap.Fill(ds, "Details");
          
                adap.Update(ds,"chaitanya_teacherDetails_SMS");
                
                MessageBox.Show("Data Updated !!!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
        }
        public int teacherInsert(string name1,string name2,int age,int Tclss,string sub,int sal,string gen,string mail,string num)
        {
            try
            {
                string connetionString;
                SqlCommand comm;
                connetionString = @"Data Source=SQLLISTENER; Initial Catalog=DIT-Training; Integrated Security=True; User ID=sa; Password=Chaitu@123";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
    
                comm = new SqlCommand("EXEC chaitanya_teacherDetailsProcedure_SMS " + "'" + name1 + "'" + "," + "'" + name2 + "'" + "," + age + "," + Tclss +
                                        "," + "'" + sub + "'" + "," + sal + "," + "'" + gen + "'" + "," + "'" + mail + "'" +
                                        "," + "'" + num + "'", cnn);
                comm.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return 1;

        }

        public void deleteReocrd(string s)
        {
           
            try
            {
                int id1 = 0;
                id1 = Convert.ToInt32(s);
              
                string connetionString;
                SqlCommand comm;
   
                connetionString = @"Data Source=SQLLISTENER; Initial Catalog=DIT-Training; Integrated Security=True; User ID=sa; Password=Chaitu@123";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                MessageBox.Show("Record Successfully Deleted !!!");
                comm = new SqlCommand("EXEC chaitanya_teacherDetailsDelete_SMS " + id1 + " ",cnn);
                comm.ExecuteNonQuery();
            //    return 1;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message + "Error");
            }
           

        }
        public void updateRecord(string id)
        {
            
            

        }

    }
}
