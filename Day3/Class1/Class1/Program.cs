using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 500;
            class1 e1 = new class1();
            class1 e2 = new class1(300, "Rahul", 30000);
            Console.WriteLine("Enter Employee Id:");
            e1.EmpId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name:");
            e1.Name = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary:");
            e1.Salary = Decimal.Parse(Console.ReadLine());
        }
    }
}
