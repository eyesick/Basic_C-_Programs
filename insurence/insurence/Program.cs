using System;



    class Program
    {
        static void Main()
        {
        Console.WriteLine("What is your age");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Have you ever had a Dui");
        bool conviction = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("How many tickets do you have");
        int tickets = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Qualified?");
        Console.WriteLine(age > 15 && !conviction && tickets < 4);
        Console.ReadLine();
        }
    }

