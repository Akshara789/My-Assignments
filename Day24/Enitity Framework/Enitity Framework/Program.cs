using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enitity_Framework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EFDBEntities e1 = new EFDBEntities();

            foreach (var item in e1.Depts)

            {

                Console.WriteLine(item.DeptName);

            }

            using (var context = new EFDBEntities())

            {

                var dept = new Dept()

                {

                    DeptId = 3,

                    DeptName= "IT"

                };

                context.Depts.Add(dept);

                context.SaveChanges();

            }

        }

    }
}
    

