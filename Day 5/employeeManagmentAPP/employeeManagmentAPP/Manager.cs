using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeManagmentAPP
{
    internal class Manager : Employee
    {
        public string FloorNo { get; set; }

        public override string ApplyLeaves(int days)
        {
            if (days > 8)
            {
                Console.WriteLine("Leave Cannot be approved - Manager are allowd to have max 8 days leave at a streach");
                return "";
            }
            return base.ApplyLeaves(days);
        }
    }
}
