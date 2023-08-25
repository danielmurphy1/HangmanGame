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
        //public char[] lettersGuessed = Array.Empty<char>();
        public List<char> lettersGuessed = new List<char>();
        public char input;

        public void GuessLetter()
        {
            //while (true)
            //{
                Console.WriteLine("\nWhat letter would you like to guess?");
                input = Console.ReadKey().KeyChar;
                //if (char.IsLetter(input))
                //{
                //    return input;
                //} else
                //{
                //    Console.WriteLine("\nThat is not a valid letter. Please choose a valid letter.");
                //}
            //}
            
            
        }

        public void AddToGuessedLetters(char character)
        {
            char upperCaseGuess = char.ToUpper(character);
            lettersGuessed.Add(upperCaseGuess);
        }

        public bool IsGuessValid()
        {
            return char.IsLetter(input);
        }
    }
}
