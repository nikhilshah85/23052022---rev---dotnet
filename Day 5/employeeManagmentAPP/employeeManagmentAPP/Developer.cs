using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeManagmentAPP
{
    internal class Developer : Employee
    {
        public override string ApplyLeaves(int days)
        {
            if (days > 5)
            {
                Console.WriteLine("Leave Cannot be approved - Developer are allowd to have max 5 days leave at a streach");
                return "";
            }
            return base.ApplyLeaves(days);
        }
    }
}
