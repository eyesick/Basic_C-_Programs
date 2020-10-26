using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number");
            int a = Convert.ToInt32(Console.ReadLine());
            Class1 b = new Class1();
            double divided = b.Dividehalf(a);
            int doubled = b.Times2(a);
            int Power = b.Times10(a);
            Console.WriteLine(a + " divided by 2 is " + divided);
            Console.WriteLine(a + " times by 2 is " + doubled);
            Console.WriteLine(a + " times by 10 is " + Power);

            Console.ReadLine();
        }
    }
}
