using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Exercises.Classes
{
    public class Card
    {
        private string suit;
        public string Suit
        {
            get { return suit; }
        }

        private int value;
        public int Value
        {
            get { return value; }
        }

        private bool isFaceUp;
        public bool IsFaceUp
        {
            get { return this.isFaceUp; }
        }

        public string Color
        {
            get
            {
                if(this.suit == "Diamonds" || this.suit == "Hearts")
                {
                    return "Red";
                }
                else
                {
                    return "Black";
                }
            }
        }

        public string FaceValue
        {
            get
            {
                
                if (this.value == 1)
                {
                    return "Ace of " + this.suit;
                }
                else if (this.value == 11)
                {
                    return "Jack of " + this.suit;
                }
                else if (this.value == 12)
                {
                    return "Queen of " + this.suit;
                }
                else if (this.value == 13)
                {
                    return "King of " + this.suit;
                }
                else
                {
                    return this.value + " of " + this.suit;
                }

            }
        }



        // Constructor
        // Require that all cards have a suit value and card value
        public Card(string suit, int faceValue)
        {
            this.suit = suit;
            this.value = faceValue;
        }

        public bool FlipOver()
        {
            this.isFaceUp = !this.isFaceUp; //flip the value
            return this.isFaceUp;
        }
    }

    
}
