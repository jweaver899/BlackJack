using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


namespace BlackJack
{
    public class Dealer
    {
        public List<Deck.Card> InitialDeal (List<Deck.Card> deck)
        {
            var hand = deck.Take(2).ToList();
            deck.RemoveAt(0);
            deck.RemoveAt(0);

            Console.Write("Dealing");
            Thread.Sleep(500);
            Console.Write(" . ");
            Thread.Sleep(500);
            Console.Write(" . ");
            Thread.Sleep(500);
            Console.WriteLine(" . ");
            
            return hand;

        }
        public List<Deck.Card> Hit (List<Deck.Card> deck, List<Deck.Card> hand)
        {
            var hit = deck.Take(1).ToList();
            hand.AddRange(hit);
            deck.RemoveAt(0);

            Console.Write("Hitting");
            Thread.Sleep(500);
            Console.Write(" . ");
            Thread.Sleep(500);
            Console.Write(" . ");
            Thread.Sleep(500);
            Console.WriteLine(" . ");

            return hand;
            
        }

        public int ScoreHand (List<Deck.Card> hand)
        {
            int handTotal = 0;
            foreach (var card in hand)
            {
                switch (card.face.ToString())
                {
                    case "Two":
                        handTotal += 2;
                        break;
                    case "Three":
                        handTotal += 3;
                        break;
                    case "Four":
                        handTotal += 4;
                        break;
                    case "Five":
                        handTotal += 5;
                        break;
                    case "Six":
                        handTotal += 6;
                        break;
                    case "Seven":
                        handTotal += 7;
                        break;
                    case "Eight":
                        handTotal += 8;
                        break;
                    case "Nine":
                        handTotal += 9;
                        break;
                    case "Ace":
                        handTotal += 11;
                        break;
                    default:
                        handTotal += 10;
                        break;
                }               
            }
            return handTotal;

        }

        public void Play ()
        {

        }
    }

}