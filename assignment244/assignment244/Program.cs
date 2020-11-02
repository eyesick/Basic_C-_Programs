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
            //IQuittable quit = new Employee();
            //Employee test = new Employee();
            //test.firstName = "Slim";
            //test.lastName = "Shadey";
            //test.ID = 1;
            //Employee test1 = new Employee() { ID = 2 };
            //test.SayName();
            //Console.WriteLine(test.firstName + " " + test.lastName);
            //bool one = test1 != test;
            //Console.ReadLine();
            //quit.Quit();

            List<string> strings = new List<string>() { "one", "two", "three", };
            List<int> numbers = new List<int>() { 1, 2, 3 };
            Employee<string> employee = new Employee<string>() { things = strings };
            Employee<int> employee1 = new Employee<int>() { things = numbers};
            foreach (string thing in employee.things)
            {
                Console.WriteLine(thing);
            }

            foreach (int thing in employee1.things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
    }
}
