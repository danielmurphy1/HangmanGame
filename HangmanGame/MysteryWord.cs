using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    internal class MysteryWord
    {
        public string word = "establishment";
        public string hiddenWord = string.Empty;
        public bool isWordSolved = false;
        public char[] mysteryWordCharacters = Array.Empty<char>();
        public char[] hiddenWordCharacters = Array.Empty<char>();

        public string GenerateMysterWord()
        {
            Console.WriteLine($"length of mystery word, { word.Length } { word[0] } { word[1] }");
            word = word.ToUpper();
            return word;
        }
        
        public void CreateMysteryWordArray(string word)
        {
            mysteryWordCharacters = word.ToCharArray();
        }

        public void PopulateHiddenMysteryWordArray(int mysteryWordLength)
        {
            for (int i = 0; i < mysteryWordLength -1; i++)
            {
                hiddenWordCharacters[i] = '_';
            }
        }

        public bool ToogleIsWordSolved()
        {
            return isWordSolved = !isWordSolved;
        }

        //public char[] HashedMysteryWord(char[] mysteryWordArray)
        //{
        //    foreach (char letter in mysteryWordArray)
        //    {
        //        letter = "_"
        //    }
        //}
    }
}
