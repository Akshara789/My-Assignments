using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    public class Class1
    {
        public int EmpId;
        public string Name;
        public decimal Salary;

        public Class1()
        {

        }

        public Class1(int empId, string name, decimal salary)
        {
            EmpId = empId;  
            Name = name;
            this.Salary = salary;
        }
    }
}
