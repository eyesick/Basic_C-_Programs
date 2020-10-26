using System;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {


        string[] stringarray = { "bob", "bill", "mike" };
        Console.WriteLine("Please select a number between 0 and 2");
        int index = Convert.ToInt32(Console.ReadLine());
        bool correctinput = false;
            do
            {
                switch (index)
                {
                    default:
                        Console.WriteLine("The number you have selected is not between 0 and 2 please try again");
                        index = Convert.ToInt32(Console.ReadLine());                        
                        break;
                    case 0:
                        Console.WriteLine(stringarray[index]);
                        correctinput = true;
                        break;
                    case 1:
                        Console.WriteLine(stringarray[index]);
                        correctinput = true;
                        break;
                    case 2:
                        Console.WriteLine(stringarray[index]);
                        correctinput = true;
                        break;


                
                }
            } while (!correctinput); 
        Console.ReadLine();
        int[] numberarray = { 5, 3, 9, 7 };
        Console.WriteLine("Please select a number between 0 and 3");
        int numindex = Convert.ToInt32(Console.ReadLine());
        bool correctinput1 = false;
            do
            {
                switch (numindex)
                {
                    default:
                        Console.WriteLine("The number you have selected is not between 0 and 3 please try again");
                        numindex = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 0:
                        Console.WriteLine(numberarray[numindex]);
                        correctinput1 = true;
                        break;
                    case 1:
                        Console.WriteLine(numberarray[numindex]);
                        correctinput1 = true;
                        break;
                    case 2:
                        Console.WriteLine(numberarray[numindex]);
                        correctinput1 = true;
                        break;
                    case 3:
                        Console.WriteLine(numberarray[numindex]);
                        correctinput1 = true;
                        break;



                }
            } while (!correctinput1);
        List<String> mylist = new List<string>();
        mylist.Add(stringarray[index]);
        mylist.Add(Convert.ToString(numberarray[numindex]));
        Console.WriteLine("Please select 0 or 1 ");
        int listindex = Convert.ToInt32(Console.ReadLine());
        correctinput1 = false;
        do
        {
            switch (listindex)
            {
                default:
                    Console.WriteLine("The number you have selected is not between 0 and 3 please try again");
                    listindex = Convert.ToInt32(Console.ReadLine());
                    break;
                case 0:
                    Console.WriteLine(numberarray[numindex]);
                    correctinput1 = true;
                    break;
                case 1:
                    Console.WriteLine(numberarray[numindex]);
                    correctinput1 = true;
                    break;




            }
        } while (!correctinput1);
        Console.ReadLine();
    }
    }


