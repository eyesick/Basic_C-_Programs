using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool ginput = false;
            while (!ginput)
            {
                try
                {
                    Console.WriteLine("Please enter the day of the week");
                    string day = Console.ReadLine();
                    Daysoftheweek daysoftheweek = (Daysoftheweek)Enum.Parse(typeof(Daysoftheweek), day);
                    Console.WriteLine(daysoftheweek);
                    Console.ReadLine();
                    ginput = true;
                }
                catch (System.ArgumentException ex)
                {
                    Console.WriteLine("Please enter an actual day of the week");
                    
                }
            }
            Console.WriteLine("you have exited the loop");
            Console.ReadLine();
        }
        public enum Daysoftheweek
        {
            Monday,
            Tuesday,
            Wednessday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
        }
    }
}
