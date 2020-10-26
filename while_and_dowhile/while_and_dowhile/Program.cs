using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Guess a number between 1 and 10");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = false;
            while (!isGuessed)
            {
                switch (number)
                {
                    default:
                        Console.WriteLine("You guessed out side 1 and 10 try again");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 1:
                        Console.WriteLine("You guessed 1 try again");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("You guessed 2 try again");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("You guessed 3 try again");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("You guessed 4 try again");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("You guessed 5 try again");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 6:
                        Console.WriteLine("You guessed 6 try again");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("You guessed 7 That is correct\npress enter to play a new game");
                        Console.ReadLine();
                        isGuessed = true;
                        break;
                    case 8:
                        Console.WriteLine("You guessed 8 try again");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 9:
                        Console.WriteLine("You guessed 9 try again");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 10:
                        Console.WriteLine("You guessed 10 try again");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            Console.WriteLine("Guess a number between 1 and 9");
            int number1 = Convert.ToInt32(Console.ReadLine());
            bool isGuessed1 = number1 == 9;
            do
            {
                switch (number1)
                {
                    default:
                        Console.WriteLine("You guessed out side 1 and 10 try again");
                        Console.WriteLine("Guess a number");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 1:
                        Console.WriteLine("You guessed 1 try again");
                        Console.WriteLine("Guess a number");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("You guessed 2 try again");
                        Console.WriteLine("Guess a number");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("You guessed 3 try again");
                        Console.WriteLine("Guess a number");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("You guessed 4 try again");
                        Console.WriteLine("Guess a number");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("You guessed 5 try again");
                        Console.WriteLine("Guess a number");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 6:
                        Console.WriteLine("You guessed 6 try again");
                        Console.WriteLine("Guess a number");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("You guessed 7 try again");
                        Console.WriteLine("Guess a number");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 8:
                        Console.WriteLine("You guessed 8 try again");
                        Console.WriteLine("Guess a number");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 9:
                        Console.WriteLine("You guessed 9 That is correct\nThank you for playing");
                        Console.ReadLine();
                        isGuessed1 = true;
                        break;
                }
            }
            while (!isGuessed1);
            Console.ReadLine();
        }
        
    }

