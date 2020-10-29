using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assingment231
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("inpput a number to be divided by 2");
            int input = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            method.Voidmethod(input, out result);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
