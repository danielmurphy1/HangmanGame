// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using HangmanGame;



GameScreen gameScreen = new GameScreen();
MysteryWord mysteryWord = new MysteryWord();
Player player = new Player();
string joined;

gameScreen.DisplayWelcomeMessage();

if (Console.ReadKey().Key == ConsoleKey.Spacebar)
{
    Console.Clear();
    mysteryWord.GenerateMysterWord();
    mysteryWord.CreateMysteryWordArray(mysteryWord.word);
    gameScreen.PopulateHiddenWordCharacters(mysteryWord.word.Length);
    gameScreen.DisplayGuessedLetters(player.lettersGuessed);
    gameScreen.DrawGallowsAndHangMan();
    gameScreen.DisplayGuessesRemaining(player.guessesRemaining);
}
else
{
    return;
}

while (!mysteryWord.isWordSolved)
{
    //for Dev only
    gameScreen.DisplayCharactersForMysteryWord(mysteryWord.mysteryWordCharacters);
    Console.WriteLine("");

    //show mysteryword characters as _
    gameScreen.DisplayHiddenWordCharacters();
    player.GuessLetter();
    if (player.IsGuessValid())
    {
        Console.Clear();
        player.AddToGuessedLetters(player.input);
        gameScreen.DisplayGuessedLetters(player.lettersGuessed);
        if (mysteryWord.word.Contains(player.input))
        {
            gameScreen.UpdateHiddenWordCharacters(player.input, mysteryWord.word);
        } else
        {
            player.guessesRemaining--;
        }
        gameScreen.DrawGallowsAndHangMan();
        gameScreen.DisplayGuessesRemaining(player.guessesRemaining);
    }
    else
    {
        gameScreen.DisplayGuessedLetters(player.lettersGuessed);
        gameScreen.DrawGallowsAndHangMan();
        gameScreen.DisplayGuessesRemaining(player.guessesRemaining);
    }

    joined = String.Join("", gameScreen.hiddenWordCharacters);
    if(player.guessesRemaining == 0 || mysteryWord.word == joined)
    {
        mysteryWord.ToogleIsWordSolved();
    }
}
gameScreen.DisplayGoodbyeMessage();