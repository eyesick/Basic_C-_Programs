using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            TwentyOne_Game game = new TwentyOne_Game();
            game.Players = new List<string>() { };
            Deck deck = new Deck();
            deck.Shuffle(3);
            
            
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);

            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }



    }
}
