using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    internal class Player
    {
        public int guessesRemaining = 7;
        public List<char> lettersGuessed = new List<char>();
        public char input;

        public void GuessLetter()
        {
            Console.WriteLine("\nWhat letter would you like to guess?");
            input = Console.ReadKey().KeyChar;
            input = char.ToUpper(input);
        }


        public void AddToGuessedLetters(char character)
        {
            if (!lettersGuessed.Contains(character))
            {
                lettersGuessed.Add(character);
            }
        }

        public bool IsGuessValid()
        {
            if(!char.IsLetter(input))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("That was not a valid letter. Please guess a valid letter.");
                Console.ResetColor();
                return false;
            }
            else if(lettersGuessed.Contains(input))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You have already guessed that letter. Please guess a different letter");
                Console.ResetColor();
                return false;
            }
            else
            {
                return char.IsLetter(input);

            }
        }
    }
}
