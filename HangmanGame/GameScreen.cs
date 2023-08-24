using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    public class GameScreen
    {
        public void GenerateWelcomeMessage()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n");
            Console.WriteLine("\t\t\t\t\t\tWelcome to Console Hangman!");
            Console.WriteLine("\n\n\t\t\t\t\tGuess the correct word before you are hung.");
            Console.WriteLine("\t\t\tAfter a correct letter guessed, that letter will take its place in the mystery word.");
            Console.WriteLine("\t\tAfter each incorrect guess, an additional piece of the gallows or of the hangman will be drawn.");
            Console.WriteLine("\t\t\tIf all pieces are drawn before you guess the mystery word correctly, you lose.");
            Console.WriteLine("\t\t\t\t\tYou have a total of seven guesses. Good Luck!");
            Console.WriteLine("\t\t\t\t\t\tPress SPACEBAR to play.");
            Console.WriteLine("\t\t\t\t\t\tPress Q to quit.");
        }
    }
}
