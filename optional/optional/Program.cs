using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace optional
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Console.WriteLine("Please in put the speed of your vehicle");
            
            int speed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input the brake power of your vehicle\nnote its okay to leave this filed blank if you dont know the default value is one");
            try
            {   
                string brakeforce = Console.ReadLine();
                if (brakeforce != "")
                {
                    int intbrake = Convert.ToInt32(brakeforce);
                    int stoptime = car.stoptime(speed, intbrake);
                    Console.WriteLine("your stop time is " + stoptime + " seconds");
                    Console.ReadLine();
                }

                else
                {
                    int stoptime = car.stoptime(speed);
                    Console.WriteLine("your stop time is " + stoptime + " seconds");
                    Console.ReadLine();
                }
                
            }
             
           

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("oops your forgot the breaks theres no stopping now");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.ReadLine();
                
            }
            
           

        }
    }
}
