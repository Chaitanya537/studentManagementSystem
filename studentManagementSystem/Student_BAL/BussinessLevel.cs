using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using studentManagementSystem.Student_DAL;
using System.Net.Mail;


namespace studentManagementSystem.Student_BAL
{
    class BussinessLevel
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
        public int insertData(string n1,string n2,string age,string mail,string gen,string cls,string num)
        {
            int res = 0;
            try
            {
                bool ck = IsValid(mail);
                int agee = Convert.ToInt32(age);
                int clas = Convert.ToInt32(cls);
                double db = Convert.ToDouble(num);
                DataLevel dl = new DataLevel();
                if(agee>5 && agee<100)
                {
                    if((clas > 5 && clas <= 10))
                    {
                            if((gen == "MALE" || gen == "FEMALE" || gen == "Male" || gen == "Female" || gen == "male" || gen == "female"))
                            {
                                if(ck==true)
                                {
                                    res = dl.insertData(n1, n2, agee, mail, gen, clas, num);
                                }
                            }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return res;
        }

    }
}
