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
using studentManagementSystem.teacher_DAL;
using CsvHelper;
using CsvHelper.Configuration;
using studentManagementSystem.Student_BO;
using System.Net.Mail;

namespace studentManagementSystem.teacher_BAL
{
    public class BussinessClass
    {

        private static bool IsValid(string email)
        {
            var valid = true;

            try
            {
                var emailAddress = new MailAddress(email);
            }
            catch
            {
                valid = false;
            }
            return valid;
        }
        public int teacherInsert(string name1,string name2,string cls,string sub,string age,string sal,string gen,string mail,string number)
        {
            int a=0;
            string gender = gen;
            string mails = mail;
            bool ck = IsValid(mails);
            string num = number;
            
            try
            {
                double dnum = Convert.ToDouble(num);
                int Tclass = Convert.ToInt32(cls);
                int agee = Convert.ToInt32(age);
                int salary = Convert.ToInt32(sal);
                DataAccess obj1 = new DataAccess();
                if(Tclass<=10 && Tclass>=6)
                {
                    if(agee<120 && agee>=22)
                    {
                        if(salary > 1000 && salary<100000)
                        {
                            if ((gen == "MALE" || gen == "FEMALE" || gen == "Male" || gen == "Female" || gen == "male" || gen == "female"))
                            {
                                if(ck==true)
                                {
                                    a = obj1.teacherInsert(name1, name2, agee, Tclass, sub, salary, gender, mails, num);
                                }
                            }
                        }
                    }   
                }
                else
                {
                    MessageBox.Show("Enter the Valid Details !!!");
                }
               

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
            return a;
        
        }

        public int teacherLogin(string login,string passd)
        {
            int t = 0;
            string connetionString;
            SqlCommand comm;
            SqlDataReader dreader;
            SqlConnection cnn;
            connetionString = @"Data Source=SQLLISTENER; Initial Catalog=DIT-Training; Integrated Security=True; User ID=sa; Password=Chaitu@123";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            comm = new SqlCommand("exec chaitanya_loginProcedure_SMS " + "'" + login + "'" + "," + "'" + passd + "'", cnn);
            dreader = comm.ExecuteReader();

            while (dreader.Read())
            {
                if (login == null || passd == null)
                {
                   // MessageBox.Show("Login ID or Password Can't be Empty !!!");
                    t = t + 1;
                    break;
                }
                else
                {
                    if (dreader.GetValue(0).ToString().Trim() == login)
                    {
                        if (dreader.GetValue(1).ToString().Trim() == passd)
                        {
                           // MessageBox.Show("Successfully logged Inn !!!");
                        }
                        else
                        {
                           // MessageBox.Show("Enter Correct Passowrd !!!");
                        }
                        t = t + 1;
                        break;
                    }
                    else
                    {
                       // MessageBox.Show("Enter Valid Login Id/Email Id, Not the User name !!!");
                        t = t + 1;
                        break;
                    }
                }
            }
            cnn.Close();
            return t;
        }

        public void teacherUpdate(teacherUpdateobj ob)
        {
            try
            {
                int r = 0;
                string connetionString;
                SqlCommand comm;
                SqlConnection cnn;
                connetionString = @"Data Source=SQLLISTENER; Initial Catalog=DIT-Training; Integrated Security=True; User ID=sa; Password=Chaitu@123";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                bool ck = IsValid(ob.mail);
                if (ob.cls <= 10 && ob.cls >= 6)
                {
                    if (ob.age < 120 && ob.age >= 22)
                    {
                        if (ob.sal > 1000 && ob.sal < 100000)
                        {
                            if ((ob.gen == "MALE" || ob.gen == "FEMALE" || ob.gen == "Male" || ob.gen == "Female" || ob.gen == "male" || ob.gen == "female"))
                            {
                                if (ck == true)
                                {
                                    comm = new SqlCommand("chaitanya_teacherupdateProcedure_SMS", cnn);
                                    comm.CommandType = CommandType.StoredProcedure;

                                    comm.Parameters.AddWithValue("@fname", ob.fname);
                                    comm.Parameters.AddWithValue("@lname", ob.lastname);
                                    comm.Parameters.AddWithValue("@age", ob.age);
                                    comm.Parameters.AddWithValue("@class", ob.cls);
                                    comm.Parameters.AddWithValue("@subject", ob.sub);
                                    comm.Parameters.AddWithValue("@salary", ob.sal);
                                    comm.Parameters.AddWithValue("@gender", ob.gen);
                                    comm.Parameters.AddWithValue("@mail", ob.mail);
                                    comm.Parameters.AddWithValue("@num", ob.num);
                                    comm.Parameters.AddWithValue("@id", ob.search);
                                    comm.ExecuteNonQuery();
                                    MessageBox.Show("Updated Successfully !!!");
                                    r = 1;
                                }
                            }
                        }
                    }
                }
                if(r==0)
                    MessageBox.Show("Not Updated !!!");
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message + "ERROR ");
            }
        }

    }
}
 
