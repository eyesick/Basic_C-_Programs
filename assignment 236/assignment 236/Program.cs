using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_236
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee sample = new Employee() { FirstName = "Sample",LastName = "Student",ID = 1};
            sample.SayName();
            Console.ReadLine();
            

        }
    }
}
