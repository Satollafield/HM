using System;
using System.Linq;

namespace Hangman
{
    public class HangmanGame
    {

        static void Main(string[] args)
        {

            string guess;
            int turnsLeft = 0;
            

            Console.WriteLine("Guess a letter!");
            Attempts();
            while (turnsLeft < 6)
            {
                guess = Console.ReadLine();

                if (answer.Contains(guess))
                {
                    Correct();

                }
                else if (usedChars.SequenceEqual(answer))
                {
                    Win();
                }
                else
                {
                    Wrong();
                    Attempts();
                }
            }

            Lose();
            void Correct()
            {
                Console.WriteLine("Correct!");
                foreach (string test in usedChars)
                {
                    if (guess == answer[0])
                    {
                        usedChars[0] = "s";
                    }
                    if (guess == answer[1])
                    {
                        usedChars[1] = "h";
                    }
                    if (guess == answer[2])
                    {
                        usedChars[2] = "r";
                    }
                    if (guess == answer[3])
                    {
                        usedChars[3] = "e";
                    }
                    if (guess == answer[4])
                    {
                        usedChars[4] = "k";
                    }
                }
                Console.WriteLine(string.Join(" ", usedChars));

            }
            void Wrong()
            {
                turnsLeft = turnsLeft + 1;
               
            }
            void Win()
            {
                Console.WriteLine("Success! Press \"ENTER\" to close the game");
                Console.ReadLine();
                Environment.Exit(0);
            }
            void Lose()
            {
                Console.WriteLine("You have failed The Swamp! Press \"ENTER\" to close the game");
                Console.ReadLine();
                Environment.Exit(0);
            }
            void Attempts()
            {
                Console.WriteLine("You have made: " + turnsLeft + " attempts!");
            }

            string[] answer = new string[] { "s", "h", "r", "e", "k" };
            string[] usedChars = new string[] { "_", "_", "_", "_", "_" };

        }

        public double TotalGuesses(double num1, double num2)
            {
                return num1 + num2;
            }
    }
}

//TODO: 
// Seperate Functions into own class/files.
// Remove Shrek
// Randomise the word
// Have final success message occure without additional key press. 
// Display already set words.
// Add a hanging man of some sort.

