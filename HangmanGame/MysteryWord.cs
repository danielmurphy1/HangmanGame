using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    internal class MysteryWord
    {
        public string word = string.Empty;
        public bool isWordSolved = false;
        public char[] mysteryWordCharacters = Array.Empty<char>();
        private string wordList = File.ReadAllText("../../../../word_list.txt");
        private string[] words;

        public MysteryWord()
        {
            words = wordList.Split(",");
        }

        /*generates the mystery word from included list file (word_list.txt). 
         * list is coneverted to an array in constructor. here the word is made uppercase
         and then turned into a character array */
        public void GenerateMysterWord()
        {
            Random random = new Random();
            int wordIndex = random.Next(0, words.Length);
            word = words[wordIndex].ToUpper();
            mysteryWordCharacters = word.ToCharArray();
        }

        public bool ToogleIsWordSolved()
        {
            return isWordSolved = !isWordSolved;
        }
    }
}
