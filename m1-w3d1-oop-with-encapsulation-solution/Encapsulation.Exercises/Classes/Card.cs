using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Exercises.Classes
{
    public class Card
    {
        private CardSuits suit;
        public CardSuits Suit
        {
            get { return suit; }
        }

        private CardValues faceValue;
        public CardValues FaceValue
        {
            get { return faceValue; }
        }
       

        // Constructor
        // Require that all cards have a suit value and card value
        public Card(CardSuits suit, CardValues faceValue)
        {
            this.suit = suit;
            this.faceValue = faceValue;
        }
    }

    public enum CardSuits
    {
        Diamonds,
        Hearts,
        Clubs,
        Spades
    }
    public enum CardValues
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13
    }
}
