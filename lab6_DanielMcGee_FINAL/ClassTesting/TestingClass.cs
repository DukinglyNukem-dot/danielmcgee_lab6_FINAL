using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardClasses;

namespace ClassTesting
{
            class TestingClass
            {
                        static void Main(string[] args)
                        {
                                    Console.WriteLine("TESTING THE HAND CLASS.");
                                    Deck d = new Deck();
                                    Hand h = new Hand(d, 2);
                                    Console.WriteLine("Created a hand of 2 cards, lets see them. \n");
                                    Console.WriteLine(h.ToString());
                                    Console.WriteLine("Let's get rid of one card from the last one drawn. \n");
                                    h.Discard(1);
                                    Console.WriteLine("Let's see the final one. \n");
                                    Console.WriteLine(h.GetCard(0).ToString());
                                    Console.WriteLine("Let's add two. \n");
                                    h.AddCard(new Card(2, 2));
                                    h.AddCard(new Card(4, 2));
                                    Console.WriteLine("Let's see them again. \n");
                                    Console.WriteLine(h.ToString());
                                    Console.WriteLine("Let's get the second card by index and then get the index of the card. \n");
                                    Card c1 = h.GetCard(1);
                                    Console.WriteLine("Index of second card, should be 1 and is: " + h.IndexOf(c1));
                                    Console.WriteLine("Now let's get the index of it by it's value and suit. \n");
                                    Console.WriteLine("Index should be 1 and is: " + h.IndexOf(c1.Value, c1.Suit));
                                    Console.WriteLine("Does the hand contain the card we've been checking? " + (h.HasCard(c1) ? "Yes" : "No"));
                                    Console.WriteLine("Can we find it by it's value and suit? " + (h.HasCard(c1.Value, c1.Suit) ? "Yes" : "No"));
                                    Console.WriteLine("TESTING COMPLETE.");
                                    /* 
                                    *  ^^^^^
                                    * HAND CLASS TESTING
                                    *
                                    * BLACKJACK HAND CLASS TESTING
                                    * v v v v v
                                     */
                                    Console.WriteLine("TESTING BLACKJACK HAND.");
                                    Deck d2 = new Deck();
                                    d2.Shuffle();
                                    BJHand bjHand = new BJHand(d2, 3);
                                    for (int i = 0; i < 8; i++)
                                    {
                                                Console.WriteLine("///////");
                                                Console.WriteLine("Showing results of the hand: " + bjHand.ToString());
                                                Console.WriteLine("Showing score of the hand: " + bjHand.Score + ", is it a bust? " + bjHand.IsBusted);
                                                Console.WriteLine("Emptying hand and filling it.");
                                                Console.WriteLine("///////");
                                                // Emptying hand.
                                                bjHand.Discard(0);
                                                bjHand.Discard(0);
                                                bjHand.Discard(0);
                                                bjHand.AddCard(d2.Draw());
                                                bjHand.AddCard(d2.Draw());
                                                bjHand.AddCard(d2.Draw());
                                    }
                                    Console.WriteLine("TESTING COMPLETE.");
                        }
            }
}
