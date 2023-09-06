namespace HangmanGame
{
    internal class MysteryWord
    {
        public string word = string.Empty;
        public char[] mysteryWordCharacters = Array.Empty<char>();
        private string[] words = File.ReadAllText("../../../../word_list.txt").Split(",");

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
    }
}
