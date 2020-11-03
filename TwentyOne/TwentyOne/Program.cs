using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.Twentyone;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playername = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today");
            int bank = Convert.ToInt32(Console.ReadLine());
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
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now");
            Console.ReadLine();
        }
    }
}
