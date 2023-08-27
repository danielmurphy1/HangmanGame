﻿using System;
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

        public string GenerateMysterWord()
        {
            Random random = new Random();
            int wordIndex = random.Next(0, words.Length);
            word = words[wordIndex];
            Console.WriteLine($"length of mystery word, { word.Length } { word[0] } { word[1] }");
            word = word.ToUpper();
            return word;
        }
        
        public void CreateMysteryWordArray(string word)
        {
            mysteryWordCharacters = word.ToCharArray();
        }

        public bool ToogleIsWordSolved()
        {
            return isWordSolved = !isWordSolved;
        }
    }
}
