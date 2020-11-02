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
            test.SayName();
            Console.WriteLine(test.firstName + " " + test.lastName);
            Console.ReadLine();
            quit.Quit();

        }
    }
}
