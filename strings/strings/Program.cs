using System;
using System.Text;

class Program
    {
        static void Main()
        {
        Console.WriteLine("Hello what is your name?");
        string name = Console.ReadLine();
        string uppername = name.ToUpper();
        Console.WriteLine("How old are you?");
        string age = Console.ReadLine();
        Console.WriteLine("what is your favorite food?");
        string food = Console.ReadLine();
        string userinputs = name + "\n" + age + "\n" + food; 
        StringBuilder sb = new StringBuilder();
        Console.WriteLine("you gave the answers\n" + userinputs);
        sb.Append("Hello " + uppername);
        sb.Append(" You are " + age + " years old");
        sb.Append(" your favorite food is " + food);
        Console.WriteLine(sb);
        Console.ReadLine();
        }
    }

