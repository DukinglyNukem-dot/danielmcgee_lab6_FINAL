using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClasses
{
            public class Hand
            {
                        protected List<Card> cards;

                        public Hand()
                        {
                                    cards = new List<Card>();
                        }

                        public Hand(Deck d, int numCards)
                        {
                                    cards = new List<Card>();
                                    // Draw cards.
                                    for (int i = 0; i < numCards; i++)
                                    {
                                                cards.Add(d.Draw());
                                    }
                        }

                        // readable-only
                        public int NumCards
                        {
                                    get
                                    {
                                                return cards.Count;
                                    }
                        }

                        // Add a card to the cards.
                        public void AddCard(Card c)
                        {
                                    cards.Add(c);
                        }

                        // Discard a card by index, this will check if it's out of bounds.
                        public Card Discard(int index)
                        {
                                    if (index == -1 || index >= NumCards)
                                                return null;
                                    Card temp = cards[index];
                                    cards.Remove(cards[index]);
                                    return temp;
                        }

                        // Get a card by index, this will check if it's out of bounds.
                        public Card GetCard(int index)
                        {
                                    if (index == -1 || index >= NumCards)
                                                return null;
                                    return cards[index];
                        }

                        // Uses the indexof method in this class.
                        public bool HasCard(Card c)
                        {
                                    return cards.IndexOf(c) != -1;
                        }

                        // This will take value.
                        public bool HasCard(int v)
                        {
                                    return IndexOf(v) != -1;
                        }

                        // This will take a value and a suit.
                        public bool HasCard(int v,int s)
                        {
                                    return IndexOf(v,s) != -1;
                        }

                        // Just a puppet for the List.IndexOf() method.
                        public int IndexOf(Card c)
                        {
                                    return cards.IndexOf(c);
                        }

                        // Index of card but takes a value.
                        public int IndexOf(int v)
                        {
                                    for (int i = 0; i < cards.Count; i++)
                                    {
                                                if (cards[i].Value == v)
                                                            return i;
                                    }
                                    return -1;
                        }

                        // Same as the last but will also take a suit.
                        public int IndexOf(int v,int s)
                        {
                                    for (int i = 0; i < cards.Count; i++)
                                    {
                                                if (cards[i].Value == v && cards[i].Suit == s)
                                                            return i;
                                    }
                                    return -1;
                        }

                        // Retrieves all of the cards in the hand and returns a string containing the statistics.
                        public override string ToString()
                        {
                                    string result = "\n";
                                    for (int i = 0; i < cards.Count; i++)
                                    {
                                                result += cards[i].ToString() + "\n";
                                    }
                                    return result;
                        }
            }
}
