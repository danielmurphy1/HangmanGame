using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    public class GameScreen
    {
        /*this is what the array looks like if all characters
         * are manually added.
        public string[,] gallowsAndHangman = new string[6, 6]
        {
            {"\t\t\t\t\t\t\t\t ", " ", "-", "-", "-", "|"},
            {"\t\t\t\t\t\t\t\t ", " ", "O", " ", " ", "|"},
            {"\t\t\t\t\t\t\t\t ", "-", "|", "-", " ", "|"},
            {"\t\t\t\t\t\t\t\t ", " ", "|", " ", " ", "|"},
            {"\t\t\t\t\t\t\t\t ", "/", " ", "\\", " ", "|"},
            {"\t\t\t\t\t\t\t\t ", " ", " ", " ", " ", "|"},
        };
        */

        public string[,] gallowsAndHangman = new string[6, 6]
        {
            {"\t\t\t\t\t\t\t\t ", " ", "-", "-", "-", "|"},
            {"\t\t\t\t\t\t\t\t ", " ", " ", " ", " ", "|"},
            {"\t\t\t\t\t\t\t\t ", " ", " ", " ", " ", "|"},
            {"\t\t\t\t\t\t\t\t ", " ", " ", " ", " ", "|"},
            {"\t\t\t\t\t\t\t\t ", " ", " ", " ", " ", "|"},
            {"\t\t\t\t\t\t\t\t ", " ", " ", " ", " ", "|"},
        };
        public List<char> hiddenWordCharacters = new List<char>();


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

        public void ResetGallowsAndHangman()
        {
            gallowsAndHangman = new string[6, 6]
            {
                {"\t\t\t\t\t\t\t\t ", " ", "-", "-", "-", "|"},
                {"\t\t\t\t\t\t\t\t ", " ", " ", " ", " ", "|"},
                {"\t\t\t\t\t\t\t\t ", " ", " ", " ", " ", "|"},
                {"\t\t\t\t\t\t\t\t ", " ", " ", " ", " ", "|"},
                {"\t\t\t\t\t\t\t\t ", " ", " ", " ", " ", "|"},
                {"\t\t\t\t\t\t\t\t ", " ", " ", " ", " ", "|"},
            };
        }

        public void UpdateGallowsAndHangman(int updateRow, int updateCol, string updateIcon)
        {
            gallowsAndHangman[updateRow, updateCol] = updateIcon;
        }

        //populates the hidden word list on the game screen with spaces for each letter in the mystery word
        public void PopulateHiddenWordCharacters(int mysterWordLength)
        {
            for (int i = 0; i < mysterWordLength; i++)
            {
                hiddenWordCharacters.Add('_');
            }
        }

        public void UpdateHiddenWordCharacters(char character, string mysteryWord)
        {
            for (int i = 0; i < mysteryWord.Length - 1; i++)
            {
                int index = mysteryWord.IndexOf(character, i);
                if (index >= 0)
                {
                    hiddenWordCharacters[index] = character;
                }
            }
        }

        //display the hidden word list as set of characters: begin of game all spaces, updates with each correct letter guess
        public void DisplayHiddenWordCharacters()
        {
            foreach(char character in hiddenWordCharacters)
            {
                Console.Write($"{character}  ");
            }
        }

        //displays the mystery word for the player on a game loss
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

        public void DisplayGuessesRemaining(int guesses)
        {
            Console.WriteLine($"\n\nYou have {guesses} guesses remaining.");
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

        public void DisplayWinMessage()
        {
            Console.WriteLine("Congratulations! You have won Console Hangman!");
        }

        public void DisplayLossMessage()
        {
            Console.WriteLine("You have failed to guess the word, and you now hang from the gallows.");
        }

        public void DisplayPlayAgainMessage()
        {
            Console.WriteLine("\nWould you like to play again? \nPress Y to play again or any other key to exit.");
        }

        public void DisplayGoodbyeMessage()
        {
            Console.WriteLine("\n\n\n\t\t\t\t\tThank you for playing Console Hangman! Goodbye.");
        }
    }
}
