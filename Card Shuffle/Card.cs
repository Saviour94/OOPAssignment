using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardShuffle;


namespace CardShuffle
{
    public class Card
    {
        public CardPack.CardSuit suit;
        public CardPack.CardVal value;

        public const int CardNum = 52;
        public Card(int Suit, int Value)
        {
            suit = (CardPack.CardSuit)Suit;
            value = (CardPack.CardVal)Value;
        }
        public override string ToString()
        {
            return string.Format("{0} of {1}", suit, value);
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