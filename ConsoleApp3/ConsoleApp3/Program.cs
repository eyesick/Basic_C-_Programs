using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number");
            long input = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(input * 50);
            Console.WriteLine("Please input a number");
            long input2 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(input2 + 25);
            Console.WriteLine("Please input a number");
            long input3 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(input3 / 12.5);
            Console.WriteLine("Please input a number");
            long input4 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(input4 > 50);
            Console.WriteLine("Please input a number");
            long input5 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(input5 % 7);
        }
    }
}
