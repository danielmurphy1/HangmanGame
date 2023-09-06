using HangmanGame;

GameScreen gameScreen = new GameScreen();
MysteryWord mysteryWord = new MysteryWord();
Player player = new Player();
string joined;

gameScreen.DisplayWelcomeMessage();

if (Console.ReadKey().Key == ConsoleKey.Spacebar)
{
    mysteryWord.GenerateMysterWord();
    gameScreen.Initialize(mysteryWord.word.Length, player.lettersGuessed, player.guessesRemaining);
}
else
{
    return;
}

//main game loop
while (!player.hasWordSolved)
{
    //Display the mystery word above hidden word spaces - For Dev and Testing
    //gameScreen.DisplayCharactersForMysteryWord(mysteryWord.mysteryWordCharacters);
    Console.WriteLine("");
    //show hidden word characters as _
    gameScreen.DisplayHiddenWordCharacters();
    player.input = gameScreen.GuessLetter();
    //check for valid letter guess
    if (player.IsGuessValid())
    {
        Console.Clear();
        player.UpdateGuessedLetters();
        gameScreen.DisplayGuessedLetters(player.lettersGuessed);
        if (mysteryWord.word.Contains(player.input))
        {
            //replace spaces with letters if part of mystery word
            gameScreen.UpdateHiddenWordCharacters(player.input, mysteryWord.word);
        } 
        else
        {
            player.guessesRemaining--;
            //progressively draw hangman as player guesses wrong
            gameScreen.UpdateGallowsAndHangman(player.guessesRemaining);
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
    //check if guessed hidden word is equal to the stored mystery word
    if (mysteryWord.word == joined)
    {
        gameScreen.DisplayWinMessage();
        gameScreen.DisplayHiddenWordCharacters();
        player.ToggleHasWordSolved();
    }

    if (player.guessesRemaining == 0)
    {
        gameScreen.DisplayLossMessage();
        gameScreen.DisplayHiddenWordCharacters();
        Console.WriteLine("\n");
        //this allows the player to see the mystery word after an unsuccessful game over
        gameScreen.DisplayCharactersForMysteryWord(mysteryWord.mysteryWordCharacters);
        player.ToggleHasWordSolved();
    }

    if (player.hasWordSolved)
    {
        gameScreen.DisplayPlayAgainMessage();
        char input = char.ToUpper(Console.ReadKey(true).KeyChar);
        if (input == 'Y')
        {
            mysteryWord.GenerateMysterWord();
            player.ResetPlayer();
            gameScreen.ResetGameScreen(mysteryWord.word.Length, player.lettersGuessed, player.guessesRemaining);
        }
        else
        {
            break;
        }
    }
}
gameScreen.DisplayGoodbyeMessage();