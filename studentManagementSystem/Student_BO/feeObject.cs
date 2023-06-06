using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentManagementSystem.Student_BO
{
    class feeObject
    {
        public int id { get; set; }

        public string name { get; set; }

        public int fee { get; set; }

        public int amount_paid { get; set; }

        public string Last_date { get; set; }

    }
    public class teacherUpdateobj
    {
        public string fname { get; set; }
        public string lastname { get; set; }
        public int age { get; set; }
        public int cls { get; set; }
        public string sub { get; set; }
        public int sal { get; set; }
        public string gen { get; set; }
        public string mail { get; set; }
        public string num { get; set; }
        public int search { get; set; }
    }

}
