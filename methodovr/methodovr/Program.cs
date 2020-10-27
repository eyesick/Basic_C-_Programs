using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodovr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please provide a number");
            int input = Convert.ToInt32(Console.ReadLine());
            math Math = new math();
            int x2 = Math.by2(input);
            Console.WriteLine(x2);
            int secondx2 = Math.by2(input, 3.3m);
            int thirdx2 = Math.by2(x2, secondx2, "product");
            Console.ReadLine();        }
    }
}
