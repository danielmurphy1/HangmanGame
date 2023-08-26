using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    public class GameScreen
    {
        public string[,] gallowsAndHangman = new string[6, 6]
        {
            {"\t\t\t\t\t\t\t\t ", " ", "-", "-", "-", "|"},
            {"\t\t\t\t\t\t\t\t ", " ", "O", " ", " ", "|"},
            {"\t\t\t\t\t\t\t\t ", "-", "|", "-", " ", "|"},
            {"\t\t\t\t\t\t\t\t ", " ", "|", " ", " ", "|"},
            {"\t\t\t\t\t\t\t\t ", "/", " ", "\\", " ", "|"},
            {"\t\t\t\t\t\t\t\t ", " ", " ", " ", " ", "|"},
        };
       
        public void DrawGallowsAndHangMan()
        {
            Console.WriteLine("\n\n\n");
            for (int i = 0; i < gallowsAndHangman.GetLength(0); i++)
            {
                for (int j = 0; j < gallowsAndHangman.GetLength(1); j++)
                {
                    Console.Write(gallowsAndHangman[i, j]);
                }
                Console.WriteLine("");
            }
        }

        public void PopulateHiddenWordCharacters(int mysterWordLength)
        {
            for(int i = 0; i < mysterWordLength; i++)
            {
                Console.Write("_  ");
            }
        }

        public void DisplayCharactersForMysteryWord(char[] mysteryWordArray)
        {
            foreach (char letter in mysteryWordArray)
            {
                Console.Write($"{letter}  ");
            }
        }

        public void DisplayGuessedLetters(List<char> lettersGuessed)
        {
            Console.WriteLine("You have guessed the following letters:\n");
            foreach (char letter in lettersGuessed)
            {
                Console.Write(letter + " ");
            }
        }
        public void DisplayWelcomeMessage()
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
            Console.WriteLine("\t\t\t\t\t     Press any other key to quit.");
        }

        public void DisplayGoodbyeMessage()
        {
            Console.WriteLine("\n\n\n\t\t\t\t\tThank you for playing Console Hangman! Goodbye.");
        }
    }
}
