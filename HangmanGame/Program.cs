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
    gameScreen.PopulateHiddenWordCharacters(mysteryWord.word.Length);
    gameScreen.DisplayGuessedLetters(player.lettersGuessed);
    gameScreen.DrawGallowsAndHangMan();
    gameScreen.DisplayGuessesRemaining(player.guessesRemaining);
}
else
{
    return;
}

//main game loop
while (!mysteryWord.isWordSolved)
{
    //Display the mystery word above hidden word spaces - For Dev and Testing
    //gameScreen.DisplayCharactersForMysteryWord(mysteryWord.mysteryWordCharacters);
    Console.WriteLine("");
    //show hidden word characters as _
    gameScreen.DisplayHiddenWordCharacters();
    player.GuessLetter();
    //check for valid letter guess
    if (player.IsGuessValid())
    {
        Console.Clear();
        player.AddToGuessedLetters(player.input);
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
            switch (player.guessesRemaining)
            {
                case 6:
                    gameScreen.UpdateGallowsAndHangman(1, 2, "O");
                    break;
                case 5:
                    gameScreen.UpdateGallowsAndHangman(2, 2, "|");
                    break;
                case 4:
                    gameScreen.UpdateGallowsAndHangman(3, 2, "|");
                    break;
                case 3:
                    gameScreen.UpdateGallowsAndHangman(2, 1, "-");
                    break;
                case 2:
                    gameScreen.UpdateGallowsAndHangman(2, 3, "-");
                    break;
                case 1:
                    gameScreen.UpdateGallowsAndHangman(4, 1, "/");
                    break;
                case 0:
                    gameScreen.UpdateGallowsAndHangman(4, 3, "\\");
                    break;

            }
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
        mysteryWord.ToogleIsWordSolved();
    }

    if (player.guessesRemaining == 0)
    {
        gameScreen.DisplayLossMessage();
        gameScreen.DisplayHiddenWordCharacters();
        Console.WriteLine("\n");
        //this allows the player to see the mystery word after an unsuccessful game over
        gameScreen.DisplayCharactersForMysteryWord(mysteryWord.mysteryWordCharacters);
        mysteryWord.ToogleIsWordSolved();
    }

    if (mysteryWord.isWordSolved)
    {
        gameScreen.DisplayPlayAgainMessage();
        char input = char.ToUpper(Console.ReadKey(true).KeyChar);
        if (input == 'Y')
        {
            Console.Clear();
            mysteryWord.GenerateMysterWord();
            player.ResetPlayer();
            gameScreen.hiddenWordCharacters.Clear();
            gameScreen.ResetGallowsAndHangman();
            gameScreen.PopulateHiddenWordCharacters(mysteryWord.word.Length);
            gameScreen.DisplayGuessedLetters(player.lettersGuessed);
            gameScreen.DrawGallowsAndHangMan();
            gameScreen.DisplayGuessesRemaining(player.guessesRemaining);
            mysteryWord.ToogleIsWordSolved();
        }
        else
        {
            break;
        }
    }
}
gameScreen.DisplayGoodbyeMessage();