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
                        private int numberOfCards;

                        public Hand()
                        {
                                    cards = new List<Card>();
                                    numberOfCards = 0;
                        }

                        public Hand(Deck d, int numCards)
                        {
                                    cards = new List<Card>();
                                    numberOfCards = numCards;
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
                                                return numberOfCards;
                                    }
                        }

                        // Add a card to the cards.
                        public void AddCard(Card c)
                        {
                                    cards.Add(c);
                                    numberOfCards++;
                        }

                        // Discard a card by index, this will check if it's out of bounds.
                        public Card Discard(int index)
                        {
                                    if (index == -1 || index >= NumCards)
                                                return null;
                                    Card temp = cards[index];
                                    cards.Remove(cards[index]);
                                    numberOfCards--;
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

                        // This will take a value or both a value and a suit in one method.
                        public bool HasCard(int v, int s = -1)
                        {
                                    return IndexOf(v, s) != -1;
                        }

                        // Just a puppet for the List.IndexOf() method.
                        public int IndexOf(Card c)
                        {
                                    return cards.IndexOf(c);
                        }

                        // Same thing but except a value or a value+suit are entered as parameters.
                        public int IndexOf(int v, int s = -1)
                        {
                                    for (int i = 0; i < cards.Count; i++)
                                    {
                                                if (cards[i].Value == v && (s == -1 || cards[i].Suit == s))
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
