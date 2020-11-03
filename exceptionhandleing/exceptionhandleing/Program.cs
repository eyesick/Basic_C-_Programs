using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionhandleing
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validinput = false;
            int age;
            try
            {
                while (!validinput)
                {
                    Console.WriteLine("What is your age");
                    validinput = int.TryParse(Console.ReadLine(), out age);
                    if (validinput && age < 0 || age == 0)
                    {
                        if (age < 0)
                        {
                            Console.WriteLine("You havent been born yet");
                       
                            validinput = false;
                        }
                        if (age == 0)
                        {
                            Console.WriteLine("There must be a mistake a new born couldnt use a computer");
                            
                            validinput = false;   
                        }
                        Console.WriteLine("Please only use positive whole numbers to represent how old you are in years");
                    }

                    if (age > 0)
                    {
                        DateTime today = DateTime.Now;
                        DateTime yearborn = today.AddYears(-age);
                        Console.WriteLine("you were born in the year {0}", yearborn.Year.ToString());

                    }
                    Console.ReadLine();
                }
             


                
                
          

            }
            catch (Exception)
            {
                Console.WriteLine("An error had occured");
                Console.ReadLine();
            }

          

        }
    }
}
