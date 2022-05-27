using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeManagmentAPP
{
    internal class HR : Employee
    {
        public override string ApplyLeaves(int days)
        {
            if (days > 12)
            {
                Console.WriteLine("Leave Cannot be approved -HR are allowd to have max 12 days leave at a streach");
                return "";
            }
            return base.ApplyLeaves(days);
        }
    }
}
