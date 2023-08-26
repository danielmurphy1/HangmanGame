// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using HangmanGame;

string wordList = File.ReadAllText("../../../../word_list.txt");
string[] words = wordList.Split(",");

GameScreen gameScreen = new GameScreen();
MysteryWord mysteryWord = new MysteryWord();
Player player = new Player();

gameScreen.DisplayWelcomeMessage();

if (Console.ReadKey().Key == ConsoleKey.Spacebar)
{
    Console.Clear();
    mysteryWord.GenerateMysterWord();
    mysteryWord.CreateMysteryWordArray(mysteryWord.word);
    gameScreen.DisplayGuessedLetters(player.lettersGuessed);
    gameScreen.DrawGallowsAndHangMan();
}
else
{
    return;
}

while (!mysteryWord.isWordSolved)
{
    //show mysteryword characters as _
    gameScreen.DisplayCharactersForMysteryWord(mysteryWord.mysteryWordCharacters);
    Console.WriteLine("");
    gameScreen.PopulateHiddenWordCharacters(mysteryWord.word.Length);
    player.GuessLetter();
    if (player.IsGuessValid())
    {
        Console.Clear();
        player.AddToGuessedLetters(player.input);
        gameScreen.DisplayGuessedLetters(player.lettersGuessed);
        gameScreen.DrawGallowsAndHangMan();
    }
    else
    {
        gameScreen.DisplayGuessedLetters(player.lettersGuessed);
        gameScreen.DrawGallowsAndHangMan();
    }
   
    //if(Console.ReadKey(true).Key == ConsoleKey.Spacebar)
    //{
    //    mysteryWord.ToogleIsWordSolved();
    //}
}
gameScreen.DisplayGoodbyeMessage();