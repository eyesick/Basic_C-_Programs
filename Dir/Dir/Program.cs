using System;


    class Program
    {
        static void Main()
        {
        Console.WriteLine("The Tech Academy\nStudent Daily Report");
        Console.WriteLine("What is your name?");
        string yourname = Console.ReadLine();
        Console.WriteLine("What course are you on?");
        string coursename = Console.ReadLine();
        Console.WriteLine("What page number?");
        string coursenumber = Console.ReadLine();
        int coursenumbervalue = Convert.ToInt32(coursenumber);
        Console.WriteLine("Do you need help with anything? Please answer \"True\" or \"False\" ");
        string Helpneeded = Console.ReadLine();
        bool Helpneededvalue = Convert.ToBoolean(Helpneeded);
        Console.WriteLine("Where there any positive experiences you'd like to share? Please give specifics.");
        string PositiveExperience = Console.ReadLine();
        Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
        string Feedback = Console.ReadLine();
        Console.WriteLine("How many hours did you study today?");
        string hoursstudied = Console.ReadLine();
        int studytime = Convert.ToInt32(hoursstudied);
        Console.WriteLine("Thank you for your answers. An instructior will respond to this shortly. Have a great day");
        Console.ReadLine();
        }
    }

