using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace BlackJack
{  
  
    public class Deck
    {
        public enum suit { Diamonds, Hearts, Clubs, Spades }
        public enum face { Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace }
        public struct Card {public suit suit; public face face;}

        public List<Card> ResetAndShuffle ()
        {
            var allFaces = (face[])Enum.GetValues(typeof(face));
            var allSuits = (suit[])Enum.GetValues(typeof(suit));
            var fullDeck = allSuits.SelectMany(x => allFaces.Select(y => new Card { suit = x, face = y }));

            var shuffledDeck = fullDeck.OrderBy(x => Guid.NewGuid());
            
            Console.Write("Shuffling");
            Thread.Sleep(500);
            Console.Write(" . ");
            Thread.Sleep(500);
            Console.Write(" . ");
            Thread.Sleep(500);
            Console.WriteLine(" . ");
            


            return shuffledDeck.ToList();

        }
        

    }

}