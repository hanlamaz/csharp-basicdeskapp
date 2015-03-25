using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Decks
    {
        private const int NUMBER_OF_CARDS = 52;
        Card[] deck;
        string[] faces = { "bir", "iki", "üç ", "dört", "beş", "altı", "yedi", "sekiz", "dokuz", "on ", "vale", "kız", "papaz" };
        string[] suits = { "kupa", "maça", "karo", "sinek" };
        int topDeck;
        public Decks()
        {
            deck = new Card[NUMBER_OF_CARDS];
            int counter = 0;
            for (int i = 0; i < suits.Length; i++)
            {
                for (int j = 0; j < faces.Length; j++)
                {
                    deck[counter++] = new Card(faces[j], suits[i]);

                }
            }

        }
        public void View()
        {
            for (int l = 0; l < 13; l++)
            {
                Console.WriteLine(deck[l].ToString() + "\t" + deck[l + 13].ToString() + "\t" + deck[l + 26].ToString() + "\t" + deck[l + 39].ToString());
            }

        }
        public void Shuffle()
        {
            Random rnd = new Random();
            int randomIndex;
            int[] swap = new int[NUMBER_OF_CARDS];
            for (int i = 0; i < NUMBER_OF_CARDS; i++)
            {
                randomIndex = rnd.Next(NUMBER_OF_CARDS);
                Card temp = deck[i];
                deck[i] = deck[randomIndex];
                deck[randomIndex] = temp;

                
            }

        }
        public Card SelectUpperCard()
        {
            return deck[topDeck++];
        }
    }
}


