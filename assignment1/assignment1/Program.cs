using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

class Program
    {
        static void Main()
        {
        string[] Names = { "Mike", "Sally", "Kevin"};
        Console.WriteLine("What is your last name");
        string Lname = Console.ReadLine();
        for (int i = 0; i < Names.Length; i++)
        {
            Console.WriteLine("Are you related to " + Names[i] + " " + Lname );
        }
        for (int j = 0; j < Names.Length; j++)
        {
            Console.WriteLine(Names[j]);
            
        }
        Console.ReadLine();
        bool loop = true;
            while (loop)
        {
            Console.WriteLine("i am in a loop write false to exit loop");
            string exit = Console.ReadLine();
            if (exit == "false")
            {
                loop = false;
            }

        }
        int remaining = 5;
        int guesses = 0;
        bool notguessed = true;
        while (guesses < 5 && notguessed )
        {
            
            
            Console.WriteLine("You have " + remaining +" Guesses Remaining\nGuess now enter a number");
            guesses++;
            remaining--;
            int guess = Convert.ToInt32(Console.ReadLine());
            if (guess == 7)
            {
                Console.WriteLine("You guessed correct with " + guesses + " guesses");
                notguessed = false;
                Console.ReadLine();
            }

            else if (remaining <= 1)
            {
                Console.WriteLine("Last guess make it count");
            }
            else if (remaining == 0)
            {
                Console.WriteLine("You ran out of guesses");
                Console.ReadLine();
            }


        }
        List<String> Places = new List<string>() {"chevrolet", "ford", "dodge", "jeep", "buik"};
        Console.WriteLine("Please enter an American car maker");
        string input = Console.ReadLine();
        input.ToLower();
        bool located = false;
        int counter = 0;
        foreach (string place in Places)
        {
            if (!located)
            {
                
                counter++;
                if (place == input)
                {
                    Console.WriteLine("That item is located at index " + counter);
                    //Console.WriteLine(Places[counter]);
                    located = true;

                }
            }
        }
        if (!located)
        {
            Console.WriteLine("That item was not in the list");
        }
        List<String> pies = new List<string>() {"apple", "cherry", "pecan", "apple", "pumpkin", };
        Console.WriteLine("We have 4 pies available please enter your favorite flavor to see if we have yours");
        string favourite = Console.ReadLine();
        favourite.ToLower();
        bool flavorfound = false;
        int counter1 = 0;
        foreach (string pie in pies)
        { 
                counter1++;
            if (favourite == pie) 
            {
                Console.WriteLine("Your flavor is located at index " + counter1);
                flavorfound = true;
            }
        }
        if(!flavorfound)
        {
            Console.WriteLine("We dont have your flavor");
        }
        List<string> colors = new List<string> {"black", "blue", "black", "red", "yellow", "green"};
        List<string> logs = new List<string>();
        foreach(string color in colors)
        {
            foreach (string log in logs)
            {
                if (log == color)
                {
                    Console.WriteLine("The color is " + color + " and has been repeated");
                }
            }
            logs.Add(color);
            
            Console.WriteLine("The color is " + color + " and has not been repeated");
        }
        Console.ReadLine();
    }
    }

