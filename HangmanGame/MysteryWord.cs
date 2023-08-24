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
        public bool isWordSolved = false;
        public char[] mysteryWordCharacters;

        public string GenerateMysterWord()
        {
            return word;
        }
        
        public void CreateMysteryWordArray(string word)
        {
            word = word.ToUpper();
            mysteryWordCharacters = word.ToCharArray();
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
