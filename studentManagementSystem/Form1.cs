using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Globalization;
using System.Collections;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using studentManagementSystem.teacher_DAL;
using studentManagementSystem.teacher_BAL;
using studentManagementSystem.Student_DAL;
using studentManagementSystem.Student_BAL;
using studentManagementSystem.Student_BO;
using System.Net.Mail;

namespace studentManagementSystem
{
    public partial class Form1 : Form
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

        public Form1()
        {
            InitializeComponent();
        }
        int temp = 0;
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = homePage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = teacherPage;
            DataAccess obj = new DataAccess();

            DataSet tb1 = obj.showTable();
            teacherTable.DataSource = tb1.Tables[0];
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = homePage;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = homePage;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = homePage;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = homePage;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = homePage;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = homePage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = infoPage;
            DataLevel obj = new DataLevel();
            DataSet tb2 = obj.showData();
            infoTable.DataSource = tb2.Tables[0];

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = marksPage;
            SmarksDAL obj = new SmarksDAL();
            DataSet tb2 = obj.showmarks();
            marksTable.DataSource = tb2.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = sportsPage;
            sportDAL obj = new sportDAL();
            DataSet tb2 = obj.showData();
            sportsTable.DataSource = tb2.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = attendancePage;
            attendanceDAL dl = new attendanceDAL();
            DataSet tb2 = dl.showData();
            attendanceTable.DataSource = tb2.Tables[0];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = feePage;
            fee_DAL obj = new fee_DAL();
            DataSet tb2 = obj.displayFee();
            feeTable.DataSource = tb2.Tables[0];
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = percentagePage;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = percentagePage;

            SmarksDAL ob = new SmarksDAL();
            DataSet dl = ob.showPercent();
            percentageTable.DataSource = dl.Tables[0];
        }

        private void teacherTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = teacherRegistration;
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                int res=0;
                BussinessClass obj = new BussinessClass();
                if (fnameBox.Text.Length > 2 && lnameBox.Text.Length > 2 && nbBox.Text.Length==10)
                {
                    res = obj.teacherInsert(fnameBox.Text, lnameBox.Text, classBox.Text, subjectBox.Text, ageBox.Text, salaryBox.Text, genderBox.Text, mailBox.Text, nbBox.Text);
                }
                else
                    MessageBox.Show("Enter Valid Details ");

                if (res == 1)
                {
                    MessageBox.Show("Data Inserted Successfully !!!");
                }
                else
                    MessageBox.Show("Insertion Failed !!!");
            }
              catch(Exception e1)
              {
                MessageBox.Show(e1.Message + "Error");
              }
            

        }

        private void homePage_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = teacherPage;
        }

        private void refreashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fnameBox.Clear();
            lnameBox.Clear();
            classBox.Clear();
            subjectBox.Clear();
            ageBox.Clear();
            salaryBox.Clear();
            genderBox.Clear();
            mailBox.Clear();
            nbBox.Clear();



        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = teacherPage;
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void homeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = homePage;
        }

        private void exitToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void backToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = homePage;
        }

        private void homeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = homePage;
        }

        private void refreashToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = teacherPage;
            DataAccess obj = new DataAccess();

            DataSet tb1 = obj.showTable();
            teacherTable.DataSource = tb1.Tables[0];
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            DataAccess obj = new DataAccess();
            obj.deleteReocrd(deleteBox1.Text);
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = infoRegister;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int res = 0;
            BussinessLevel obj1 = new BussinessLevel();
            if (SFirstnameBox.Text.Length > 2 && SlastnameBox.Text.Length > 2)
            {
                res = obj1.insertData(SFirstnameBox.Text, SlastnameBox.Text, SageBox.Text, SmailBox.Text, SgenderBox.Text, SclassBox.Text, SnumberBox.Text);
            }
            else
                MessageBox.Show("Enter Valid Name ");
            if (res == 1)
            {
                MessageBox.Show("Data Inserted Successfully !!!");
            }
            else
                MessageBox.Show("Insertion Failed !!!");

        }

        private void button20_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = infoPage;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            DataLevel dl = new DataLevel();
            dl.deleterecord(textBox1.Text);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = homePage;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = homePage;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = infoPage;
            DataLevel obj = new DataLevel();

            DataSet tb1 = obj.showData();
            infoTable.DataSource = tb1.Tables[0];
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = homePage;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            SFirstnameBox.Clear();
            SlastnameBox.Clear();
            SmailBox.Clear();
            SnumberBox.Clear();
            SgenderBox.Clear();
            SageBox.Clear();
            SclassBox.Clear();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = infoPage;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = marksRegister;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                int res = 0;
                SmarksBAL obj = new SmarksBAL();
                if (snameBox2.Text.Length > 2)
                {
                    res = obj.insertTable(sidBox2.Text, snameBox2.Text, sclassBox2.Text, mathBox.Text, physicsBox.Text, chemistryBox.Text, socialBox.Text);
                }
                else
                    MessageBox.Show("Enter Valid name ");
                if (res == 1)
                {
                    MessageBox.Show("Successfully Inserted !!!");
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message + "Error");
            }

        }

        private void button24_Click(object sender, EventArgs e)
        {
            int res;
            SmarksDAL obj = new SmarksDAL();
            res = obj.deleteRecord(deleteMarkBox.Text);
            if (res == 1)
            {
                MessageBox.Show("successfully deleted !!!");
            }
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = homePage;
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = homePage;
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = marksPage;
            SmarksDAL obj = new SmarksDAL();
            DataSet tb2 = obj.showmarks();
            marksTable.DataSource = tb2.Tables[0];
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = homePage;
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = marksPage;
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            sidBox2.Clear();
            snameBox2.Clear();
            sclassBox2.Clear();
            mathBox.Clear();
            physicsBox.Clear();
            chemistryBox.Clear();
            socialBox.Clear();
        }

        private void sportButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = sportRegister;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
            int r = 0;
            sportBAL obj2 = new sportBAL();
            if (nameBox3.Text.Length > 2 && sportBox.Text.Length>2)
            {
                r = obj2.insertRecord(idBox3.Text, nameBox3.Text, sportBox.Text);
            }
            else
                MessageBox.Show("Enter Valid Details ");
            if (r == 1)
            {
                MessageBox.Show("Successfully Inserted!!!");
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            int r;
            sportDAL ob = new sportDAL();
            r = ob.deletedata(deleteBox4.Text);
            if (r == 1)
            {
                MessageBox.Show("Record deletion completed !!!");
            }
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = homePage;
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = sportsPage;
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            idBox3.Clear();
            nameBox3.Clear();
            sportBox.Clear();
        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = homePage;
        }

        private void toolStripMenuItem22_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = homePage;
        }

        private void toolStripMenuItem24_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = sportsPage;
            sportDAL obj = new sportDAL();
            DataSet tb2 = obj.showData();
            sportsTable.DataSource = tb2.Tables[0];
        }

        private void button27_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = attendanceRegister;
        }

        private void attendanceRegister_Click(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {
            int r = 0;
            attendanceBAL ob = new attendanceBAL();
            if (nameBoxA.Text.Length > 2)
            {
                r = ob.insertRecord(idBoxA.Text, nameBoxA.Text, mathBoxA.Text, physicsBoxA.Text, chemistryBoxA.Text);
            }
            else
                MessageBox.Show("Enter Valid Name ");
            if (r == 1)
            {
                MessageBox.Show("Successfully Inserted!!!");
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            int r;
            attendanceDAL ob = new attendanceDAL();
            r = ob.deletedata(textBox2.Text);
            if (r == 1)
            {
                MessageBox.Show("Record deletion completed !!!");
            }
        }

        private void toolStripMenuItem25_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = homePage;
        }

        private void toolStripMenuItem26_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = homePage;
        }

        private void toolStripMenuItem27_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = attendancePage;
            attendanceDAL dl = new attendanceDAL();
            DataSet tb2 = dl.showData();
            attendanceTable.DataSource = tb2.Tables[0];
        }

        private void toolStripMenuItem28_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void toolStripMenuItem29_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = homePage;

        }

        private void toolStripMenuItem30_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void toolStripMenuItem32_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = attendancePage;

        }

        private void toolStripMenuItem31_Click(object sender, EventArgs e)
        {
            idBoxA.Clear();
            nameBoxA.Clear();
            mathBoxA.Clear();
            physicsBoxA.Clear();
            chemistryBoxA.Clear();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = feeRegister;
        }

        private void label63_Click(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {
            int r;
            fee_BAL obj = new fee_BAL();
            feeObject ob = new feeObject();
            ob.id = Convert.ToInt32(idBoxF.Text);
            ob.name = nameBoxF.Text;
            ob.fee = Convert.ToInt32(feeBoxF.Text);
            ob.amount_paid = Convert.ToInt32(paidBoxF.Text);
            ob.Last_date = dateTimePicker1.Text;
            r = obj.insrtData(ob);
            if (r == 1)
            {
                MessageBox.Show("Successfully Inserted !!!");
            }
        }

        private void toolStripMenuItem33_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = homePage;
        }

        private void toolStripMenuItem34_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = homePage;

        }

        private void toolStripMenuItem36_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void toolStripMenuItem35_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = feePage;
            fee_DAL obj = new fee_DAL();
            DataSet tb2 = obj.displayFee();
            feeTable.DataSource = tb2.Tables[0];
        }

        private void toolStripMenuItem40_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = feePage;
        }

        private void toolStripMenuItem37_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = homePage;
        }

        private void toolStripMenuItem38_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void toolStripMenuItem39_Click(object sender, EventArgs e)
        {
            idBoxF.Clear();
            nameBoxF.Clear();
            feeBoxF.Clear();
            paidBoxF.Clear();

        }

        private void button32_Click(object sender, EventArgs e)
        {
            int r;
            fee_DAL ob = new fee_DAL();
            r = ob.deletedata(textBox3.Text);
            if (r == 1)
            {
                MessageBox.Show("Deletion Completed !!!");
            }

        }

        private void label67_Click(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {

            int t;
            temp = temp + 1;
            BussinessClass ob = new BussinessClass();
            t = ob.teacherLogin(loginBoxL.Text, passwordBoxL.Text);
            if (t == 1)
            {
                tabControl1.SelectedTab = homePage;
            }
            else if (temp == 3 && t != 1)
            {
                MessageBox.Show("3 Login Attempts Failed !!!, Now you are Going to EXIT");

                Environment.Exit(0);
            }
            else
                MessageBox.Show("Wrong LOGIN ID/ PASSWORD !!!");

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button36_Click(object sender, EventArgs e)
        {
            try
            {
  
                string connetionString;
                SqlCommand comm;
                SqlConnection cnn;
                connetionString = @"Data Source=SQLLISTENER; Initial Catalog=DIT-Training; Integrated Security=True; User ID=sa; Password=Chaitu@123";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                comm = new SqlCommand("select * from chaitanya_teacherDetails_SMS where ID = " + searchBoxU.Text + "", cnn);
                comm.Parameters.AddWithValue("@Id", Convert.ToInt32(searchBoxU.Text));
                SqlDataReader da = comm.ExecuteReader();

                while (da.Read())
                {

                    FnameBoxU.Text = da.GetValue(1).ToString();
                    LnameBoxU.Text = da.GetValue(2).ToString();
                    ageBoxU.Text = da.GetValue(3).ToString();
                    classBoxU.Text = da.GetValue(4).ToString();
                    subjectBoxU.Text = da.GetValue(5).ToString();
                    salaryBoxU.Text = da.GetValue(6).ToString();
                    genderBoxU.Text = da.GetValue(7).ToString();
                    mailBoxU.Text = da.GetValue(8).ToString();
                    numBoxU.Text = da.GetValue(9).ToString();

                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message + "Error");
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem41_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = teacherUpdate;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            BussinessClass t = new BussinessClass();
            teacherUpdateobj ob = new teacherUpdateobj();

            ob.fname = FnameBoxU.Text;
            ob.lastname = LnameBoxU.Text;
            ob.age = Convert.ToInt32(ageBoxU.Text);
            ob.cls = Convert.ToInt32(classBoxU.Text);
            ob.sub = subjectBoxU.Text;
            ob.sal = Convert.ToInt32(salaryBoxU.Text);
            ob.gen = genderBoxU.Text;
            ob.mail = mailBoxU.Text;
            ob.num = numBoxU.Text;
            ob.search = Convert.ToInt32(searchBoxU.Text);
            t.teacherUpdate(ob);


        }

        private void toolStripMenuItem42_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = homePage;
        }

        private void toolStripMenuItem44_Click(object sender, EventArgs e)
        {
            FnameBoxU.Clear();
            LnameBoxU.Clear();
            classBoxU.Clear();
            subjectBoxU.Clear();
            ageBoxU.Clear();
            salaryBoxU.Clear();
            mailBoxU.Clear();
            numBoxU.Clear();
            searchBoxU.Clear();
            genderBoxU.Clear();
        }

        private void toolStripMenuItem45_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = teacherUpdate;
        }

        private void toolStripMenuItem46_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = teacherUpdate;
        }

        private void toolStripMenuItem43_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = teacherPage;
        }

        private void toolStripMenuItem43_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = teacherPage;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            try
            {
                string connetionString;
                SqlCommand comm;
                SqlConnection cnn;
                connetionString = @"Data Source=SQLLISTENER; Initial Catalog=DIT-Training; Integrated Security=True; User ID=sa; Password=Chaitu@123";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                comm = new SqlCommand("select * from chaitanya_studentData_SMS where Student_Id = " + SsearchBoxU.Text + "", cnn);
                comm.Parameters.AddWithValue("@Student_Id", Convert.ToInt32(SsearchBoxU.Text));

                SqlDataReader da = comm.ExecuteReader();
                while (da.Read())
                {
                    SFnameBoxU.Text = da.GetValue(1).ToString();
                    SLnameBoxU.Text = da.GetValue(2).ToString();

                    SageBoxU.Text = da.GetValue(3).ToString();
                    SmailBoxU.Text = da.GetValue(4).ToString();
                    SgenderBoxU.Text = da.GetValue(5).ToString();
                    SclassBoxU.Text = da.GetValue(6).ToString();
                    SnumberBoxU.Text = da.GetValue(7).ToString();
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message + "ERROR !!!");
            }
        }

        private void toolStripMenuItem47_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = infoupdate;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            int r = 0;
            try
            {
                bool ck = IsValid(SmailBoxU.Text);
                string connetionString;
                SqlCommand comm,comm1,comm2,comm3,comm4;
                SqlConnection cnn;
                connetionString = @"Data Source=SQLLISTENER; Initial Catalog=DIT-Training; Integrated Security=True; User ID=sa; Password=Chaitu@123";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                double db = Convert.ToDouble(SnumberBoxU.Text);
                if (Convert.ToInt32(SageBoxU.Text) > 5 && Convert.ToInt32(SageBoxU.Text) < 100)
                {
                    if ((Convert.ToInt32(SclassBoxU.Text) > 5 && Convert.ToInt32(SclassBoxU.Text) <= 10))
                    {
                        if (SgenderBoxU.Text.ToLower().Trim().ToString() == "male" || SgenderBoxU.Text.ToLower().Trim().ToString() == "female")
                        {
                            if (SFnameBoxU.Text.Length>2 && SLnameBoxU.Text.Length>2)
                            {
                                if(ck==true)
                                {
                                    comm = new SqlCommand("chaitanya_studentupdateProcedure_SMS", cnn);
                                    comm.CommandType = CommandType.StoredProcedure;

                                    comm.Parameters.AddWithValue("@fname", SFnameBoxU.Text);
                                    comm.Parameters.AddWithValue("@lname", SLnameBoxU.Text);
                                    comm.Parameters.AddWithValue("@age", SageBoxU.Text);
                                    comm.Parameters.AddWithValue("@mail", SmailBoxU.Text);
                                    comm.Parameters.AddWithValue("@gender", SgenderBoxU.Text);
                                    comm.Parameters.AddWithValue("@class", SclassBoxU.Text);
                                    comm.Parameters.AddWithValue("@number", SnumberBoxU.Text);
                                    comm.Parameters.AddWithValue("@id", SsearchBoxU.Text);
                                    comm.ExecuteNonQuery();


                                    comm1 = new SqlCommand("chaitanya_marksupdate_SMS", cnn);
                                    comm1.CommandType = CommandType.StoredProcedure;
                                    comm1.Parameters.AddWithValue("@name", SFnameBoxU.Text);
                                    comm1.Parameters.AddWithValue("@clss", SclassBoxU.Text);
                                    comm1.Parameters.AddWithValue("@id", SsearchBoxU.Text);
                                    comm1.ExecuteNonQuery();

                                    comm2 = new SqlCommand("chaitanya_sportupdate_SMS", cnn);
                                    comm2.CommandType = CommandType.StoredProcedure;
                                    comm2.Parameters.AddWithValue("@name", SFnameBoxU.Text);
                                    comm2.Parameters.AddWithValue("@id", SsearchBoxU.Text);
                                    comm2.ExecuteNonQuery();

                                    comm3 = new SqlCommand("chaitanya_attendanceupdate_SMS", cnn);
                                    comm3.CommandType = CommandType.StoredProcedure;
                                    comm3.Parameters.AddWithValue("@name", SFnameBoxU.Text);
                                    comm3.Parameters.AddWithValue("@id", SsearchBoxU.Text);
                                    comm3.ExecuteNonQuery();

                                    comm4 = new SqlCommand("exec [chaitanya_feeeupdate_SMS] " + "'" + SFnameBoxU.Text + "'" + "," + SsearchBoxU.Text + "", cnn);
                                    comm4.ExecuteNonQuery();
                                    MessageBox.Show("Updated Successfully !!!");
                                    r = 1;
                                }
                                
                            }
                        }
                    }
                }
                if (r == 0)
                {
                    MessageBox.Show("Updation Failed ");
                }
                
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message + "ERROR ");
            }
        }

        private void toolStripMenuItem48_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = homePage;
        }

        private void toolStripMenuItem49_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = infoPage;
        }

        private void toolStripMenuItem50_Click(object sender, EventArgs e)
        {
            SFnameBoxU.Clear();
            SLnameBoxU.Clear();
            SageBoxU.Clear();
            SmailBoxU.Clear();
            SgenderBoxU.Clear();
            SclassBoxU.Clear();
            SnumberBoxU.Clear();
            SsearchBoxU.Clear();

        }

        private void toolStripMenuItem51_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void toolStripMenuItem52_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = teacherRegistration;
        }

        private void toolStripMenuItem53_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = teacherPage;
        }

        private void toolStripMenuItem54_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = teacherRegistration;
        }

        private void toolStripMenuItem55_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = infoRegister;
        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem56_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = infoupdate;
        }

        private void toolStripMenuItem57_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = infoRegister;
        }

        private void toolStripMenuItem58_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = infoPage;
        }

        private void button34_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = infoPage;
        }

        private void dateBoxF_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            int t;
            if (classButton.Checked == true)
                t = 1;
            else if (topperButton.Checked == true)
                t = 2;
            else if (attendanceButton.Checked == true)
                t = 3;
            else if (feedueButton.Checked == true)
                t = 4;
            else if (cAtButton.Checked == true)
                t = 5;
            else if (cAfButton.Checked == true)
                t = 6;
            else if (cAaButton.Checked == true)
                t = 7;
            else if (cAsButton.Checked == true)
                t = 8;
            else
                t = 0;
           
            studentDetails ob = new studentDetails();
            DataSet dl = ob.viewStudent(t);
            studentTable.DataSource = dl.Tables[0];
            tabControl1.SelectedTab = studentPage;
        }

        private void button18_Click_2(object sender, EventArgs e)
        {

            tabControl1.SelectedTab = homePage;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            int t;
            if (mathButton.Checked == true)
                t = 1;
            else if (psButton.Checked == true)
                t = 2;
            else if (nsButton.Checked == true)
                t = 3;
            else if (socialButton.Checked == true)
                t = 4;
            else if (radioButton1.Checked == true)
                t = 0;
            else
                t = -1;
            SmarksDAL ob = new SmarksDAL();
            DataSet ds =  ob.viewList(t);
            percentageTable.DataSource = ds.Tables[0];
        }

        private void button40_Click(object sender, EventArgs e)
        {
            try
            {
                string connetionString;
                SqlCommand comm;
                SqlConnection cnn;
                connetionString = @"Data Source=SQLLISTENER; Initial Catalog=DIT-Training; Integrated Security=True; User ID=sa; Password=Chaitu@123";
                cnn = new SqlConnection(connetionString);
                cnn.Open();

                comm = new SqlCommand("chaitanya_marksProcedure_SMS", cnn);
                comm.CommandType = CommandType.StoredProcedure;

                int a, b, c, d, f;
                a = Convert.ToInt32(MclassBoxU.Text);
                b = Convert.ToInt32(MmathBoxU.Text);
                c = Convert.ToInt32(MpsBoxU.Text);
                d = Convert.ToInt32(MchemBoxU.Text);
                f = Convert.ToInt32(MsocialBoxU.Text);
               
                
                if (MnameBoxU.Text != null && (a > 5 && a <= 10) && (b >= 0 && b <= 100) && (c >= 0 && c <= 50) && (d >= 0 && d <= 50) && (f >= 0 && f <= 300))
                {
                    comm.Parameters.AddWithValue("@name", MnameBoxU.Text);
                    comm.Parameters.AddWithValue("@cls", a);
                    comm.Parameters.AddWithValue("@math", b);
                    comm.Parameters.AddWithValue("@ps", c);
                    comm.Parameters.AddWithValue("@chem", d);
                    comm.Parameters.AddWithValue("@social", f);
                    comm.Parameters.AddWithValue("@id", MsearchBoxU.Text);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully !!!");
                }
                else
                    MessageBox.Show("Updation Failed !!!");
                    
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message + "ERROR ");
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            try
            {
                string connetionString;
                SqlCommand comm;
                SqlConnection cnn;
                connetionString = @"Data Source=SQLLISTENER; Initial Catalog=DIT-Training; Integrated Security=True; User ID=sa; Password=Chaitu@123";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                comm = new SqlCommand("select * from [chaitanya_studentinfo_SMS] where Student_id = " + MsearchBoxU.Text + "", cnn);
                comm.Parameters.AddWithValue("@Student_id", Convert.ToInt32(MsearchBoxU.Text));

                SqlDataReader da = comm.ExecuteReader();
                while (da.Read())
                {
                    MnameBoxU.Text = da.GetValue(1).ToString();
                    MclassBoxU.Text = da.GetValue(2).ToString();

                    MmathBoxU.Text = da.GetValue(3).ToString();
                    MpsBoxU.Text = da.GetValue(4).ToString();
                    MchemBoxU.Text = da.GetValue(5).ToString();
                    MsocialBoxU.Text = da.GetValue(6).ToString();
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message + "ERROR !!!");
            }
        }

        private void toolStripMenuItem59_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = homePage;
        }

        private void toolStripMenuItem60_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = marksPage;
        }

        private void toolStripMenuItem61_Click(object sender, EventArgs e)
        {
            MnameBoxU.Clear();
            MmathBoxU.Clear();
            MpsBoxU.Clear();
            MchemBoxU.Clear();
            MsocialBoxU.Clear();
            MsearchBoxU.Clear();
            MclassBoxU.Clear();

        }

        private void label98_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem62_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void toolStripMenuItem63_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = marksRegister;
        }

        private void toolStripMenuItem64_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = marksPage;
        }

        private void toolStripMenuItem65_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = marksUpdate;
        }

        private void toolStripMenuItem66_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = marksRegister;
        }

        private void toolStripMenuItem67_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = marksUpdate;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            try
            {
                string connetionString;
                SqlCommand comm;
                SqlConnection cnn;
                connetionString = @"Data Source=SQLLISTENER; Initial Catalog=DIT-Training; Integrated Security=True; User ID=sa; Password=Chaitu@123";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                comm = new SqlCommand("select * from [chaitanya_studentSport_SMS]  where S_id = " + spsearchBoxU.Text + "", cnn);
                comm.Parameters.AddWithValue("@S_id", Convert.ToInt32(spsearchBoxU.Text));

                SqlDataReader da = comm.ExecuteReader();
                while (da.Read())
                {
                    spnameBoxU.Text = da.GetValue(1).ToString();
                    spsportBoxU.Text = da.GetValue(2).ToString();
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message + "ERROR !!!");
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            try
            {
                string connetionString;
                SqlCommand comm;
                SqlConnection cnn;
                connetionString = @"Data Source=SQLLISTENER; Initial Catalog=DIT-Training; Integrated Security=True; User ID=sa; Password=Chaitu@123";
                cnn = new SqlConnection(connetionString);
                cnn.Open();

                comm = new SqlCommand("chaitanya_sportProcedure_SMS", cnn);
                comm.CommandType = CommandType.StoredProcedure;

                comm.Parameters.AddWithValue("@name", spnameBoxU.Text);
                comm.Parameters.AddWithValue("@sport", spsportBoxU.Text);
                
                comm.Parameters.AddWithValue("@id", spsearchBoxU.Text);
                comm.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully !!!");
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message + "ERROR ");
            }
        }

        private void toolStripMenuItem68_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = homePage;
        }

        private void toolStripMenuItem69_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = sportsPage;
        }

        private void toolStripMenuItem70_Click(object sender, EventArgs e)
        {
            spsearchBoxU.Clear();
            spsportBoxU.Clear();
            spnameBoxU.Clear();
        }

        private void toolStripMenuItem71_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void toolStripMenuItem72_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = sportRegister;
        }

        private void toolStripMenuItem73_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = sportsPage;
        }

        private void toolStripMenuItem74_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = sportUpdate;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            try
            {
                string connetionString;
                SqlCommand comm;
                SqlConnection cnn;
                connetionString = @"Data Source=SQLLISTENER; Initial Catalog=DIT-Training; Integrated Security=True; User ID=sa; Password=Chaitu@123";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                comm = new SqlCommand("select * from [chaitanya_studentAttendanceProcedure_SMS] where Student_id = " + AsearchBoxU.Text + "", cnn);
                comm.Parameters.AddWithValue("@Student_Id", Convert.ToInt32(AsearchBoxU.Text));

                SqlDataReader da = comm.ExecuteReader();
                while (da.Read())
                {
                    AnameBoxU.Text = da.GetValue(1).ToString();
                    AmathBoxU.Text = da.GetValue(2).ToString();
                    ApsBoxU.Text = da.GetValue(3).ToString();
                    AchemBoxU.Text = da.GetValue(4).ToString();                    
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message + "ERROR !!!");
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            try
            {
                string connetionString;
                SqlCommand comm;
                SqlConnection cnn;
                connetionString = @"Data Source=SQLLISTENER; Initial Catalog=DIT-Training; Integrated Security=True; User ID=sa; Password=Chaitu@123";
                cnn = new SqlConnection(connetionString);
                cnn.Open();

                comm = new SqlCommand("chaitanya_attendanceProcedureStudent_SMS", cnn);
                comm.CommandType = CommandType.StoredProcedure;

                int a,math,phy,che;
                a = Convert.ToInt32(AsearchBoxU.Text);
                math = Convert.ToInt32(AmathBoxU.Text);
                phy = Convert.ToInt32(ApsBoxU.Text);
                che = Convert.ToInt32(AchemBoxU.Text);

                if ((AnameBoxU.Text != null && a > 1000) && math >= 0 && phy >= 0 && che >= 0 && (math <= 60) && phy <= 60 && che <= 60)
                {
                    comm.Parameters.AddWithValue("@name", AnameBoxU.Text);
                    comm.Parameters.AddWithValue("@math", AmathBoxU.Text);
                    comm.Parameters.AddWithValue("@ps", ApsBoxU.Text);
                    comm.Parameters.AddWithValue("@ns", AchemBoxU.Text);
                    comm.Parameters.AddWithValue("@id", AsearchBoxU.Text);

                    comm.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully !!!");
                }
                else
                    MessageBox.Show("Updation Failed, Please check once !!!");
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message + "ERROR ");
            }
        }

        private void toolStripMenuItem75_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = homePage;
        }

        private void toolStripMenuItem76_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = attendancePage;
        }

        private void label111_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem77_Click(object sender, EventArgs e)
        {
            AsearchBoxU.Clear();
            AnameBoxU.Clear();
            AmathBoxU.Clear();
            ApsBoxU.Clear();
            AchemBoxU.Clear();
        }

        private void toolStripMenuItem78_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void toolStripMenuItem79_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = attendanceRegister;
        }

        private void toolStripMenuItem80_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = attendancePage;
        }

        private void toolStripMenuItem81_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = attendanceUpdate;
        }

        private void button47_Click(object sender, EventArgs e)
        {
            try
            {
                string connetionString;
                SqlCommand comm;
                SqlConnection cnn;
                connetionString = @"Data Source=SQLLISTENER; Initial Catalog=DIT-Training; Integrated Security=True; User ID=sa; Password=Chaitu@123";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                comm = new SqlCommand("select * from [chaitanya_studentFeeDetails_SMS] where Student_Id = " + feesearchBoxU.Text + "", cnn);
                comm.Parameters.AddWithValue("@Student_Id", Convert.ToInt32(feesearchBoxU.Text));

                SqlDataReader da = comm.ExecuteReader();
                while (da.Read())
                {
                    feenameBox.Text = da.GetValue(1).ToString();
                    feefeeBox.Text = da.GetValue(2).ToString();
                    feepaidBox.Text = da.GetValue(3).ToString();                  
                    dateTimePicker2.Text = da.GetValue(5).ToString();                
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message + "ERROR !!!");
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            try
            {
                string connetionString;
                SqlCommand comm;
                SqlConnection cnn;
                connetionString = @"Data Source=SQLLISTENER; Initial Catalog=DIT-Training; Integrated Security=True; User ID=sa; Password=Chaitu@123";
                cnn = new SqlConnection(connetionString);
                cnn.Open();

                comm = new SqlCommand("chaitanya_feeProcedure_SMS", cnn);
                comm.CommandType = CommandType.StoredProcedure;

                int fe, pd;
                fe = Convert.ToInt32(feefeeBox.Text);
                pd = Convert.ToInt32(feepaidBox.Text);
                if (feenameBox.Text.Length > 2 && fe >= pd && fe > 1000 && pd > 100)
                {
                    comm.Parameters.AddWithValue("@name", feenameBox.Text);
                    comm.Parameters.AddWithValue("@fee", feefeeBox.Text);
                    comm.Parameters.AddWithValue("@paid", feepaidBox.Text);
                    comm.Parameters.AddWithValue("@LDay", dateTimePicker2.Text);
                    comm.Parameters.AddWithValue("@id", feesearchBoxU.Text);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully !!!");
                }
                else
                    MessageBox.Show("Updation Failed, Please Try again ");
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message + "ERROR ");
            }
        }

        private void toolStripMenuItem82_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = homePage;
        }

        private void toolStripMenuItem83_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = feePage;
        }

        private void toolStripMenuItem84_Click(object sender, EventArgs e)
        {
            feenameBox.Clear();
            feefeeBox.Clear();
            feepaidBox.Clear();
            feesearchBoxU.Clear();

        }

        private void toolStripMenuItem85_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void toolStripMenuItem86_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = feeRegister;
        }

        private void toolStripMenuItem87_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = feePage;
        }

        private void toolStripMenuItem88_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = feeUpdate;
        }

        private void MnameBoxU_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
