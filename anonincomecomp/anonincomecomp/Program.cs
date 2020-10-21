using System;


    class Program
    {
        static void Main()
        {
        Console.WriteLine("Anonymous Income Comparison Program\n Person 1\nHourly rate");
        double p1hourly = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Hours worked per week");
        double p1hours = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Person 2\nHourly rate");
        double p2hourly = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Hours worked per week");
        double p2hours = Convert.ToDouble(Console.ReadLine());
        double p1annual = p1hours * 52 * p1hourly;
        Console.WriteLine("Annual salary of Person 1: " + p1annual);
        double p2annual = p2hours * 52 * p2hourly;
        Console.WriteLine("Annual salary of Person 2: " + p2annual);
        bool Greaterthan = p1annual > p2annual;
        Console.WriteLine("Does person 1 make more money than person 2?\n" + Greaterthan);
        Console.ReadLine();

    }
    }

