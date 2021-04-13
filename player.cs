using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace BlackJack
{
    public class Player
    {

        public void Play (List<Deck.Card> deck)
        {
            Dealer dealer = new Dealer();
            var yourHand = dealer.InitialDeal(deck);
            int handTotal = 0;           

            while (handTotal < 21)
            {
                Console.WriteLine("Your Hand: ");
                foreach (var card in yourHand)
                {
                    Console.WriteLine(card.face + " of " + card.suit);                  
                }
                handTotal = dealer.ScoreHand(yourHand);
                Console.WriteLine("Your Hand Total: " + handTotal);
                Console.WriteLine();
                Console.WriteLine("Would you like to Hit or Stand?");
                Console.WriteLine();
                string choice = Console.ReadLine();
                
                if (choice == "Stand" || choice == "stand" || choice == "s" || choice == "S" )
                {
                    Console.WriteLine("You stand with a hand total of" + handTotal);
                    Thread.Sleep(500);
                    Console.WriteLine("Dealer will play now");
                    dealer.Play(handTotal);

                }
                else if (choice == "Hit" || choice == "hit" || choice == "h" || choice == "H")
                {
                    dealer.Hit(deck, yourHand);
                    Console.Write("");
                    Console.WriteLine("Your Hand: ");
                    foreach (var card in yourHand)
                    {
                        Console.WriteLine(card.face + " of " + card.suit);                  
                    }
                    handTotal = dealer.ScoreHand(yourHand);
                    Console.WriteLine("Your Hand Total: " + handTotal);
                }
                else
                {
                    Console.WriteLine("Please type either Hit or Stand");
                }

            }

            if (handTotal == 21)
            {
                Console.WriteLine("21!");
                Thread.Sleep(500);
                Console.WriteLine("Dealer will play now");
                dealer.Play(handTotal);

            }

            if (handTotal > 21)
            {
                Console.WriteLine("Bust! You lose!");
            }

        }
    }

}