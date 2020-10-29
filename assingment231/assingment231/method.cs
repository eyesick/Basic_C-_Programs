using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assingment231
{
    static class method
    {
        public static void Voidmethod(int a, out int result)
        {
            result = a / 2;


        }

        public static void Voidmethod(int speed, int weight, out int force, out int stoptime)
        {
            force = speed * weight;
            stoptime = speed / force;
        }

        public static void Consoleout()
        {
            Console.WriteLine("This is a static method");
        }
    }
}
