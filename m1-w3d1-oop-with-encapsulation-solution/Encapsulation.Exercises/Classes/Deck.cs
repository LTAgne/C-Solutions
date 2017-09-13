using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Exercises.Classes
{
    // This class is for a deck of cards
    // It holds (hopefully) up to 52 cards, no more.
    public class Deck
    {
        // We are keeping this private because we don't want anyone cheating
        // by changing our cards
        private List<Card> cards = new List<Card>();

        // Derived property to get remaining card count
        public int NumberOfCardsRemaining
        {
            get
            {
                return cards.Count;
            }
        }

        // Deck Constructor that initializes the 52 card deck
        public Deck()
        {            
            for (int i = 0; i < 4; i++)
            {
                for(int j = 1; j <= 13; j++)
                {
                    // We are using the enum CardSuits and CardValues
                    // and can cast an integer to its enum value
                    Card c = new Card((CardSuits)i, (CardValues)j);
                    cards.Add(c);
                }    
            }           
        }

        // Shuffles the Cards
        public void Shuffle()
        {
            Random r = new Random();

            for (int i = 0; i < 100000; i++)
            {                
                int swap1 = r.Next(cards.Count);
                int swap2 = r.Next(cards.Count);

                Card temp = cards[swap1];
                cards[swap1] = cards[swap2];
                cards[swap2] = temp;            
            }
        }

        // Removes numberOfCards from the list
        public Card[] DrawCard(int numberOfCards)
        {
            //Make sure that we don't overdraw from the deck
            int maxCardsToDraw = (numberOfCards > cards.Count) ? numberOfCards : cards.Count;

            //Identify which cards we will draw
            Card[] cardsToDraw = cards.GetRange(0, maxCardsToDraw).ToArray();

            //Remove the cards from the list
            cards.RemoveRange(0, maxCardsToDraw);

            return cardsToDraw;
        }

        public void CutDeck()
        {
            Random r = new Random();

            // Pick a random spot in the deck
            int randomIndex = r.Next(cards.Count);

            List<Card> cutDeck = new List<Card>();
            
            // Copy the contents of the index to the end of the deck to a new list
            cutDeck.AddRange(cards.GetRange(randomIndex, cards.Count - randomIndex));
            cards.RemoveRange(randomIndex, cards.Count - randomIndex);

            // Copy the contents of the beginning to index to the new list
            cutDeck.AddRange(cards);

            // Replace cards with the cutDeck
            cards = cutDeck;
        }
    }
}
