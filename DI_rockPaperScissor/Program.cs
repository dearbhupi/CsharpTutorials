using DI_rockPaperScissor;

//RockPaperScissor _game = new RockPaperScissor();
// now the RockPaperScissor have two argument in its construction using Iplayer
RockPaperScissor _game = new RockPaperScissor(new HumanPlayer(), new ComputerPlayer());

do
{
    RoundResults _result = _game.PlayRound();

    if (_result == RoundResults.Player1Win)
    {
        Console.WriteLine("Player 1 wins");
    }
    else if (_result == RoundResults.Player2Win)
    {
        Console.WriteLine("Player 1 wins");
    }
    else
    {
        Console.WriteLine("It's Draw");
    }
    Console.WriteLine("Play Again (Y/N) ? : ");
    ;
} while (Console.ReadLine().ToUpper() == "Y");
