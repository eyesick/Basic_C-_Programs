using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.Twentyone;
using System.Data.SqlClient;
using System.Data;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel and Casino";
            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name.", casinoName);
            string playername = Console.ReadLine();
            if (playername.ToLower() == "admin")
            {
                List<ExceptionEntity> exceptions = ReadExceptions();
                foreach (var exception in exceptions)
                {
                    Console.Write(exception.id+ " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.ReadLine();
                return;
            }
            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("please enter digits only no decimals");
            }

        


            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now", playername);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer =="ya")
            {
                Player player = new Player(playername, bank);
                player.id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\isaac\Documents\logs.txt", true))
                {
                    file.WriteLine(player.id);
                }
                Game game = new TwentyOne_Game();
                game += player;
                player.isActivelyplayting = true;
                while (player.isActivelyplayting && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (Fraudexception ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("An error occured. Please contact your system admin");
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now");
            Console.ReadLine();
        }

        private static void UpdateDbWithException(Exception ex)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TwentyOneGame;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES (@ExceptionType, @ExceptionMessage, @TimeStamp)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TwentyOneGame;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }
    }
}
