using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClasses
{
            public class Card
            {
                        private static string[] values = { "", "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "Ten", "Jack", "Queen", "King" };
                        private static string[] suits = { "", "Clubs", "Diamonds", "Hearts", "Spades" };
                        private static Random generator = new Random();

                        private int value;
                        private int suit;

                        public Card()
                        {

                                    Value = generator.Next(1, values.Length);
                                    Suit = generator.Next(1, suits.Length);
                        }

                        public Card(int s, int v)
                        {
                                    Value = (v < values.Length) ? v : 0;
                                    Suit = (s < values.Length) ? s : 0;
                        }

                        public int Value
                        {
                                    get { return this.value; }
                                    set { this.value = value; }
                        }

                        public int Suit
                        {
                                    get { return this.suit; }
                                    set { this.suit = value; }
                        }

                        public bool HasMatchingSuit(Card other)
                        {
                                    return (Suit == other.Suit) ? true : false;
                        }

                        public bool HasMatchingValue(Card other)
                        {
                                    return (Value == other.Value) ? true : false;
                        }

                        public bool IsAce()
                        {
                                    return (Value == 1) ? true : false;
                        }

                        public bool IsBlack()
                        {
                                    return (Suit == Array.IndexOf(suits, suits[1]) || Suit == Array.IndexOf(suits, suits[4])) ? true : false;
                        }

                        public bool IsRed()
                        {
                                    return (Suit == Array.IndexOf(suits, suits[2]) || Suit == Array.IndexOf(suits, suits[3])) ? true : false;
                        }

                        public bool IsClub()
                        {
                                    return (Suit == Array.IndexOf(suits, suits[1])) ? true : false;
                        }

                        public bool IsDiamond()
                        {
                                    return (Suit == Array.IndexOf(suits, suits[2])) ? true : false;
                        }

                        public bool IsHeart()
                        {
                                    return (Suit == Array.IndexOf(suits, suits[3])) ? true : false;
                        }

                        public bool IsSpade()
                        {
                                    return (Suit == Array.IndexOf(suits, suits[4])) ? true : false;
                        }

                        public bool IsFaceCard()
                        {
                                    return (Value > 10) ? true : false;
                        }

                        public override string ToString()
                        {
                                    return values[Value] + " of " + suits[Suit];
                        }

                        public override int GetHashCode()
                        {
                                    return new { Value, Suit }.GetHashCode();
                        }

                        public override bool Equals(object obj)
                        {
                                    var c = obj as Card;
                                    return HasMatchingSuit(c) && HasMatchingValue(c);
                        }

            }
}
