using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardShuffle;

namespace CardShuffle
{

    public class CardPack

    public class Pack //Want to randomly generate a pack of cards with suit 1-4 and card 0-12 in a (suit, card) format
                      // Switched from List to Array initially then back to a List because it seemed easier to manipulate for the shuffle methods
    {
        private static List<Card> cards = new List<Card>();

        public const int CardNum = 52;

       

        public Pack() //Should randomly generate a pack of cards with suit 1-4 and card 0-12 in a (suit, card) format
        {
            {
                int index = 0;
                for (int s = 1; s < 5; s++)
                {
                    for (int v = 0; v < 13; v++)
                    {
                        Card newCard = new Card(s, v);
                        cards.Add(newCard);
                        index++;
                    }
                }
            }
        }
        public static bool shuffleCardPack(int typeOfShuffle)


        //for Fisher Yates we need to:
        //1. Take the list
        //2. Get the number of items in the list (n)
        //3. Count backwards from the number of items in the list
        //4. Generate a random number (k) between 1 and n
        //5. Then swap that number with the counting backwards point and repeat

        public static Random rng = new Random();
        
        private static Card value;

        public static void FisherYates()
        {

            int n = CardNum;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n+ 1);
                value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }
        }
        //For Riffle we need to slice the pack into 2 and then randomly intersect the 2 halves
        public static void Riffle()
        {
            List<Card> RiffleSlice = new List<Card>();

            int i = 26;
            int j = CardNum - 1;
            while (i > 0)
            {
                int temp = cards


            }
        }

        public static Card deal()
        {
           for (int i = 0; i < CardNum;  i++)
            {
                Card dealt = cards[i]
            }

        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
        }


        //Card suits in their typical alphabetical ordering
        public enum CardSuit
        {
            Clubs = 1,
            Diamonds = 2,
            Hearts = 3,
            Spades = 4,
        }

        //Card values (Ace is high), unsure if I want the range to be 2-14 or 0-12
        public enum CardVal
        {
            two = 0,
            three = 1,
            four = 2,
            five = 3,
            six = 4,
            seven = 5,
            eight = 6,
            nine = 7,
            ten = 8,
            jack = 9,
            queen = 10,
            king = 11,
            ace = 12,
        }

        public CardSuit MySuit { get; set; }
        public CardVal MyValue { get; set; }

    }
}
   





    
