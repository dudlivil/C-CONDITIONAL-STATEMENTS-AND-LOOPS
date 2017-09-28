using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace ConsoleApplication49
{
    class Program
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            if (profession == "Athlete")
            {
                Console.WriteLine("The Athlete has to pay {0:f2}.", quantity * 0.70);
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                Console.WriteLine("The " + profession + " has to pay {0:f2}.", quantity);
            }
            else if (profession == "SoftUni Student")
            {
                Console.WriteLine("The SoftUni Student has to pay {0:f2}.", quantity * 1.70);
            }
            else
            {
                Console.WriteLine("The " + profession + " has to pay {0:f2}.", quantity * 1.20);
            }
        }
    }
}
