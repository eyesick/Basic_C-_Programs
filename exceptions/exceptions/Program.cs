using System;
using System.Collections.Generic;

class Program
    {
        static void Main(string[] args)
        {
        List<int> numbers = new List<int> {2,5,9,14,32,77,84 };
        try
        {
            Console.WriteLine("enter a positive whole number");
            int input = Convert.ToInt32(Console.ReadLine());
            foreach (int number in numbers)
            {
                double newnumber = number / input;
                Console.WriteLine(newnumber);
            }
        }
        catch(System.DivideByZeroException ex)
        {
            Console.WriteLine("you cannot divide by zero");
        }
        catch(System.FormatException ex)
        {
            Console.WriteLine("You have entered a non number");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("The program will continue");
            Console.ReadLine();
        }
        }

 }
    

