using System;
using System.Collections.Generic;
using System.Threading;

namespace rps {
    class Program {
        static void Main (string[] args) {

            Console.Clear ();
            Console.Write ("What is your name: ");
            string name = Console.ReadLine ();
            bool valid = false;
            string ans = "";

            Console.WriteLine ($"Hello {name}, Are you Ready To Rock The Paper, Paper The Scissor and Scissor the Paper??");
            Console.WriteLine ("Are You Sure You Wish To Enter This Tournament?  (Y/N)");
            while (!valid) {
                char choice = Console.ReadKey ().KeyChar;
                Console.Clear ();
                Dictionary<string, int> Weapons = new Dictionary<string, int> () { { "Rock", 1 }, { "Paper", 2 }, { "Scissors", 3 },
                };

                if (choice == 'y') {
                    Console.Clear ();
                    Console.WriteLine (@"
                    Welcome To The ThunderDome!


    _______
-- - '   ____)
      (_____)
      (_____)                       ROCK
      (____)
-- -.__(___)

    _______
-- - '   ____)
          ______)
          _______)                  PAPER
         _______)
---.__________)

    _________
-- - '   ____)___
        _________)                  SCISSORS
       __________)
      (____)
-- -.__(___)

                    ");
                    Console.WriteLine ("Choose Your Weapon! ROCK Paper Scissors");
                    string userChoice = Console.ReadLine ().ToUpper ();
                    Random r = new Random ();
                    int computerChoice = r.Next (0, 4);
                    string[] choices = new string[3] { "ROCK", "PAPER", "SCISSORS" };
                    Console.WriteLine ("Computer:" + choices[computerChoice]);

                    if (userChoice == "ROCK" && choices[computerChoice] == "SCISSORS") {
                        Console.WriteLine ("You Win");
                    } else if (userChoice == "ROCK" && choices[computerChoice] == "PAPER") {
                        Console.WriteLine ("YOU SUCK LOSER!");
                    } else if (userChoice == "PAPER" && choices[computerChoice] == "ROCK") {
                        Console.WriteLine ("You Win!");
                    } else if (userChoice == "PAPER" && choices[computerChoice] == "SCISSORS") {
                        Console.WriteLine ("YOU SUCK LOSER!");
                    } else if (userChoice == "SCISSORS" && choices[computerChoice] == "ROCK") {
                        Console.WriteLine ("YOU SUCK LOSER!");
                    } else if (userChoice == "SCISSORS" && choices[computerChoice] == "PAPER") {
                        Console.WriteLine ("YOU Win!");
                    } else {
                        Console.WriteLine ("It's a Tie! Try Again you sister kisser!");
                    }
                    Console.WriteLine ("Play Again If You Dare? (Y/N)");
                } else {
                    Console.WriteLine ("SO LONG LOSER!");
                }
            }
        }
    }
}