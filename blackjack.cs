using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace BlackJack
{
    class Game
    {
        static void Main ()
        {
            Console.WriteLine("Welcome to Black Jack!");
            Console.WriteLine("(Press enter key to continue...)");
            Console.ReadKey();
            Console.WriteLine("You and the dealer will each begin with $100");
            Thread.Sleep(500);
            Console.WriteLine("Bets will be $10 each round");
            Thread.Sleep(500);
            Console.WriteLine("You lose when you run out of money");
            Thread.Sleep(500);
            Console.WriteLine("Ready? (Press any key to play...)");
            Console.ReadKey();

            double dealerMoney = 100;
            double playerMoney = 100;

            while (dealerMoney > 0 && playerMoney > 0)
            {
                Deck deck = new Deck();
                var shuffledDeck = deck.ResetAndShuffle();

                Player player = new Player();
                player.Play(shuffledDeck);

            }

            
        }
    }
}

