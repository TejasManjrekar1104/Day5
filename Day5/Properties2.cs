using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    public class employee
    {
        public int EmpId { get; private set; }
        public string EmpName { get; private set; }

        public employee(int empid, string empname)
        {
            EmpId = empid;
            EmpName = empname;
        }
    }

    class Properties2
    {
        
        public static void Main2()
        {
            employee e = new employee(101, "Tejas");
            Console.WriteLine(e.EmpId);
            Console.WriteLine(e.EmpName);

        }
    }
}
