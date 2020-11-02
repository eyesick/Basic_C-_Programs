using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment244
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable quit = new Employee();
            Employee test = new Employee();
            test.firstName = "Slim";
            test.lastName = "Shadey";
            test.ID = 1;
            Employee test1 = new Employee() { ID = 2 };
            test.SayName();
            Console.WriteLine(test.firstName + " " + test.lastName);
            test1 == test;
            Console.ReadLine();
            quit.Quit();

        }
    }
}
