// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using HangmanGame;

string wordList = File.ReadAllText("../../../../word_list.txt");
string[] words = wordList.Split(",");

GameScreen gameScreen = new GameScreen();

gameScreen.GenerateWelcomeMessage();

if (Console.ReadKey().Key == ConsoleKey.Spacebar)
{
    Console.WriteLine("Temp Holder - Space Pressed");
}
else if (Console.ReadKey().Key == ConsoleKey.Q ) //takes two presses - why?
{
    Console.WriteLine("Temp Holder - Q Pressed");
}
else
{
    //add another key pressed scenario

}