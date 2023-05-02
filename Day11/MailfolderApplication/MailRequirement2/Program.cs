using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailRequirement1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("enter _id,_to,_from,_subject,_content,_receivedDate,_size");
                string input = Console.ReadLine();
                string[] arrinput = input.Split(',');
                long id = long.Parse(arrinput[0]);
                string to = arrinput[1];
                string from = arrinput[2];
                string subject = arrinput[3];
                string content = arrinput[4];
                //DateTime receivedDate = DateTime.Parse(arrinput[5]);
                double size = long.Parse(arrinput[5]);

            }






            }
        }
    }

