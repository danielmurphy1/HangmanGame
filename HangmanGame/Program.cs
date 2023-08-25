// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using HangmanGame;

string wordList = File.ReadAllText("../../../../word_list.txt");
string[] words = wordList.Split(",");

GameScreen gameScreen = new GameScreen();
MysteryWord mysteryWord = new MysteryWord();

gameScreen.DisplayWelcomeMessage();

if (Console.ReadKey().Key == ConsoleKey.Spacebar)
{
    Console.WriteLine("Temp Holder - Space Pressed");
    mysteryWord.GenerateMysterWord();
    mysteryWord.CreateMysteryWordArray(mysteryWord.word);
    //Console.WriteLine(mysteryWordArray[0]);
    //Console.WriteLine(mysteryWordArray[1]);
    //Console.WriteLine(mysteryWordArray[2]);

}
else
{
    return;
}

while (mysteryWord.isWordSolved != true)
{
    Console.WriteLine("While Loop Running");
    gameScreen.DrawGallowsAndHangMan();
    //show mysteryword characters as _
    gameScreen.DisplayCharactersForMysteryWord(mysteryWord.mysteryWordCharacters);
   
    if(Console.ReadKey(true).Key == ConsoleKey.Spacebar)
    {
        mysteryWord.ToogleIsWordSolved();
    }
}
gameScreen.DisplayGoodbyeMessage();