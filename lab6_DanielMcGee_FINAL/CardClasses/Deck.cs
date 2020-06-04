using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClasses
{
            public class Deck
            {
                        private List<Card> deckOfCards;
                        private int cardsRemaining;
                        public Deck()
                        {
                                    string[] va = { "", "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "Ten", "Jack", "Queen", "King" };
                                    string[] su = { "", "Clubs", "Diamonds", "Hearts", "Spades" };
                                    deckOfCards = new List<Card>();
                                    cardsRemaining = 0;
                                    for (int v = 1; v < va.Length; v++)
                                    {
                                                for (int s = 1; s < su.Length; s++)
                                                {
                                                            deckOfCards.Add(new Card(s, v));
                                                            cardsRemaining++;
                                                }
                                    }
                        }

                        public int CardsRemaining
                        {
                                    get
                                    {
                                                return cardsRemaining;
                                    }
                        }

                        public Card this[int i]
                        {
                                    get
                                    {
                                                if (i > -1 && i < cardsRemaining)
                                                {
                                                            return deckOfCards[i];
                                                }
                                                else return null;
                                    }
                                    set
                                    {
                                                if (i > -1 && i < cardsRemaining)
                                                {
                                                            deckOfCards[i] = value;
                                                }
                                    }
                        }

                        public Card Draw()
                        {
                                    if (CardsRemaining > 0)
                                    {
                                                Card d = deckOfCards[CardsRemaining - 1];
                                                cardsRemaining--;
                                                deckOfCards.Remove(d);
                                                return d;
                                    }
                                    return null;
                        }

                        public bool IsEmpty()
                        {
                                    return (CardsRemaining == 0) ? true : false;
                        }

                        public void Shuffle()
                        {
                                    if (CardsRemaining == 2)
                                    {
                                                Card temp = deckOfCards[0];
                                                deckOfCards[0] = deckOfCards[1];
                                                deckOfCards[1] = temp;
                                    }
                                    else if (CardsRemaining > 2)
                                    {
                                                Random r = new Random();
                                                for (int i = 0; i < CardsRemaining / 2; i++)
                                                {
                                                            int ranNumber = r.Next(CardsRemaining / 2, CardsRemaining);
                                                            Card temp = deckOfCards[i];
                                                            deckOfCards[i] = deckOfCards[ranNumber];
                                                            deckOfCards[ranNumber] = temp;
                                                }
                                    }
                        }

                        public override string ToString()
                        {
                                    string result = "";
                                    foreach (Card c in deckOfCards)
                                    {
                                                result += (c.ToString() + "\n");
                                    }
                                    return result;
                        }

            }
}
