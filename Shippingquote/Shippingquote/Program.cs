using System;
using System.Net;

class Program
    {
        static void Main()
        {
        Console.WriteLine("Welcome to package Express\nPlease enter package Wieght");
        double weight = Convert.ToDouble(Console.ReadLine());
        if (weight > 50)
        {
            Console.WriteLine("Package to heavy to be shipped via Package Express\nPress enter to exit program");
            Console.ReadLine();
            Environment.Exit(1);
        }
        Console.WriteLine("Please enter package width");
        double width = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter package height");
        double height = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter package length");
        double length = Convert.ToDouble(Console.ReadLine());
        if (width + height + length > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express");
            Console.ReadLine();
            Environment.Exit(1);
        }
        double cost = width * height * length * weight / 100;
        Console.WriteLine("Your estimated total is " + cost);
        Console.ReadLine();
         
        


    }
    }

