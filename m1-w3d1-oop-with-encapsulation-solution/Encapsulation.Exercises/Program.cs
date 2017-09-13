using Encapsulation.Exercises.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create the new deck
            Deck deck1 = new Deck();

            //Shuffle the deck
            deck1.Shuffle();

            //Draw the cards off of the deck
            Card[] drawCards = deck1.DrawCard(52);

            //Print out each of the cards
            for (int i = 0; i < drawCards.Length; i++)
            {
                Console.WriteLine(drawCards[i].FaceValue.ToString() + " of " + drawCards[i].Suit.ToString());
            }
        }
    }
}
