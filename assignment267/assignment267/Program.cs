using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment267
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.Amount = 10m;
            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }

        public struct Number
        {
            public decimal Amount;
        }
    }
}
