using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Emplist = new List<Employee>();
            Emplist.Add(new Employee("Ram","Mumbai"));
            Emplist.Add(new Employee("Shyam","Chennai"));
            Emplist.Add(new Employee("Raju","Delhi"));
            Emplist.Add(new Employee("Vivek","Bombay"));
            Emplist.Add(new Employee("Sabu","Dubai"));
            var fquery = from Employee employee in Emplist
                         orderby employee.City
                         group employee by employee.City;
             
            foreach(var f in fquery)
            {
                Console.WriteLine("Employees with " + f.Key + "city");
                foreach (var e in f)
                {
                    Console.WriteLine("" + e.Name);
                }
            }
        }
    }
}
