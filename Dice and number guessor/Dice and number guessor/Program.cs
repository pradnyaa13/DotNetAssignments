using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_and_number_guessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordToGuess = "CSharp";
            string guessedWord = new string('_', wordToGuess.Length);
            int attempts = 4;
            bool gameWon = false;

            char[] wordArray = wordToGuess.ToLower().ToCharArray();
            char[] guessedArray = guessedWord.ToLower().ToCharArray();

            Console.WriteLine("Welcome to the Word Guessing Game");
            Console.WriteLine("You have to guess the word one letter at a time.");
            Console.WriteLine("You have " + attempts + " attempts to guess the word.");
            Console.WriteLine("Word to guess: " + new string(guessedArray));

            while (attempts > 0 && !gameWon)
            {
                Console.WriteLine("\nAttempts left: " + attempts);
                Console.Write("Enter a letter: ");
                char guess = Char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine();

                bool letterFound = false;

                for (int i = 0; i < wordArray.Length; i++)
                {
                    if (wordArray[i] == guess && guessedArray[i] == '_')
                    {
                        guessedArray[i] = guess;
                        letterFound = true;
                    }
                }
                if (!letterFound)
                {
                    attempts--;
                    Console.WriteLine("Incorrect guess!");
                }
                else
                {
                    Console.WriteLine("Good guess!");
                }
                if (new string(guessedArray) == wordToGuess.ToLower())
                {
                    gameWon = true;
                    Console.WriteLine("Congratulations, you've guessed the word: " + wordToGuess);
                }
                else
                {
                    Console.WriteLine("Current word: " + new string(guessedArray));
                }
            }
            if (!gameWon)
            {
                Console.WriteLine("Sorry, you've run out of attempts. The word was: " + wordToGuess);
            }
        }
    }
}
