using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace Io
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string text = Console.ReadLine();
            
            using (StreamWriter file = new StreamWriter(@"C:\Users\isaac\Documents\logs.txt", true))
            {
                file.WriteLine(text);
                
            }
            string[] lines = File.ReadAllLines(@"C:\Users\isaac\Documents\logs.txt");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            Console.ReadLine();
        }
    }
}
