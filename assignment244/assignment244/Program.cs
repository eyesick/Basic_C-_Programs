using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            //List<string> strings = new List<string>() { "one", "two", "three", };
            //List<int> numbers = new List<int>() { 1, 2, 3 };
            //Employee<string> employee = new Employee<string>() { things = strings };
            //Employee<int> employee1 = new Employee<int>() { things = numbers};
            //foreach (string thing in employee.things)
            //{
            //    Console.WriteLine(thing);
            //}

            //foreach (int thing in employee1.things)
            //{
            //    Console.WriteLine(thing);
            //}
            
            List<Employee> employees = new List<Employee>();
           
            employees.Add(new Employee() { firstName = "Mike", lastName = "Lowrey", ID = 1 });
            employees.Add(new Employee() { firstName = "Joe", lastName = "Momma", ID = 2 });
            employees.Add(new Employee() { firstName = "Evan", lastName = "Griffen", ID = 3 });
            employees.Add(new Employee() { firstName = "John", lastName = "Smith", ID = 4 });
            employees.Add(new Employee() { firstName = "Carlos", lastName = "Santana", ID = 5 });
            employees.Add(new Employee() { firstName = "Joe", lastName = "Rogan", ID = 6 });
            employees.Add(new Employee() { firstName = "Bob", lastName = "Robertson", ID = 7 });
            employees.Add(new Employee() { firstName = "Milo", lastName = "Thatch", ID = 8 });
            employees.Add(new Employee() { firstName = "Bell", lastName = "Cranel", ID = 9 });
            employees.Add(new Employee() { firstName = "Billy", lastName = "Butcher", ID = 10 });
            
            List<Employee> employeesJoe = new List<Employee>();
            foreach (Employee employee in employees)
            {
                
                if (employee.firstName == "Joe")
                {
                    employeesJoe.Add(employee);
                }
                
            }
            List<Employee> newlist1 = employees.Where(x => x.firstName == "Joe").ToList();
            List<Employee> newlist = employees.Where(x => x.ID > 5).ToList();
            Console.ReadLine();

        }
    }
}
