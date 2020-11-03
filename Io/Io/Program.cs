using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Policy;

namespace Io
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter a number");
            //string text = Console.ReadLine();

            //using (StreamWriter file = new StreamWriter(@"C:\Users\isaac\Documents\logs.txt", true))
            //{
            //    file.WriteLine(text);

            //}
            //string[] lines = File.ReadAllLines(@"C:\Users\isaac\Documents\logs.txt");
            //foreach (string line in lines)
            //{
            //    Console.WriteLine(line);
            //}
            //Console.ReadLine();

            //DateTime timenow = DateTime.Now;
            //Console.WriteLine(timenow);
            //Console.WriteLine("Please entere number");
            //int x = Convert.ToInt32(Console.ReadLine());     
            //Console.WriteLine(timenow.AddHours(x));
            //Console.ReadLine();

            const bool isTrue = true;
            var isFalse = false;

        }

        public class person
        {
            private string last;
            private string first;

            public person(string lastName, string firstName)
            {
                last = lastName;
                first = firstName;
            }

            public person() : this()
            {
                
            }
        }
    }
}
