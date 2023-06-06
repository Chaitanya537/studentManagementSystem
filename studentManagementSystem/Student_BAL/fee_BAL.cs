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
using studentManagementSystem.Student_DAL;
using studentManagementSystem.Student_BO;


namespace studentManagementSystem.Student_BAL
{
    class fee_BAL
    {
        public int insrtData(feeObject ob)
        {
            try
            {
                fee_DAL obj = new fee_DAL();
                if (ob.name != null && ob.fee >= ob.amount_paid && ob.fee>1000 && ob.amount_paid>100)
                {
                    int r = obj.insertData(ob);
                    return r;
                }
                else
                    MessageBox.Show("Enter valid Details !!!");
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message + "Error!");
            }
            return 0;

        }
    }
}
