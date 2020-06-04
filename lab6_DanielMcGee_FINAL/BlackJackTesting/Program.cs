using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardClasses;

namespace BlackJackTesting
{
            class Program
            {
                        static void Main(string[] args)
                        {
                                    BlackJackGameTest();
                        }
                        static void ShowResults(BJHand player,BJHand dealer)
                        {
                                    Console.WriteLine("Player's hand: \n" + player.ToString());
                                    Console.WriteLine("Dealer's hand: \n" + dealer.ToString());
                                    Console.WriteLine("Player's score: " + player.Score.ToString());
                                    Console.WriteLine("Dealer's score: " + dealer.Score.ToString());
                        }

                        static void BlackJackGameTest()
                        {
                                    // Make the deck and shuffle.
                                    Deck d = new Deck();
                                    d.Shuffle();
                                    // Initiate the dealer and player.
                                    BJHand dealer = new BJHand(d, 2);
                                    BJHand player = new BJHand(d, 2);
                                    // While playing start hitting or just stand.
                                    bool playing = true;
                                    while (playing)
                                    {
                                                if (player.Score == 21)
                                                {
                                                            Console.WriteLine("The player just scored a blackjack."); return;
                                                }
                                                else if (dealer.Score == 21)
                                                {
                                                            Console.WriteLine("The dealer just scored a blackjack."); return;
                                                }
                                                Console.WriteLine("Enter HIT to draw a card or STAND to finish up.");
                                                ShowResults(player, dealer);
                                                string sss = Console.ReadLine();
                                                if (sss == "HIT")
                                                {
                                                            player.AddCard(d.Draw());
                                                            dealer.AddCard(d.Draw());
                                                            if (player.Score > 20 || dealer.Score > 20)
                                                            {
                                                                        playing = false;
                                                                        ShowResults(player, dealer);
                                                            }
                                                }
                                                else if (sss == "STAND")
                                                {
                                                            playing = false;
                                                            ShowResults(player, dealer);
                                                }
                                                else
                                                {
                                                            Console.WriteLine("That wasn't a readable answer, try again.");
                                                }
                                    }
                                    // Game over.
                                    Console.WriteLine("Calculating results.");
                                    // If the dealer has a score less than the player and neither are busted.
                                    while (dealer.Score <= player.Score && !(dealer.IsBusted || player.IsBusted))
                                    {
                                                dealer.AddCard(d.Draw());
                                                ShowResults(player, dealer);
                                    }
                                    // Show the final results.
                                    if ((player.IsBusted && dealer.IsBusted) || (player.Score == dealer.Score))
                                    {
                                                Console.WriteLine("It's a tie.");
                                    }
                                    else
                                    {
                                                if (player.IsBusted)
                                                {
                                                            Console.WriteLine("The player has busted and the dealer won.");
                                                }
                                                else if (dealer.IsBusted)
                                                {
                                                            Console.WriteLine("The dealer has busted and the player won.");
                                                }
                                                else if (player.Score > dealer.Score)
                                                {
                                                            Console.WriteLine("The player has won.");
                                                }
                                                else
                                                {
                                                            Console.WriteLine("The dealer has won.");
                                                }
                                    }
                        }
            }
}
