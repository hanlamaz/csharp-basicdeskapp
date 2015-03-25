using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Card
    {
        string suit; // Hearts,Tiles(Diamonds)Clovers(Clubs),Pikes(Spades)
        string face; // 1,2,3,4...
        public Card(string face ,string suit)
        {
            this.face = face;
            this.suit = suit;
        }
        public string ToString()
        {
            return suit + " " + face;
        }

    }
}
