using DI_rockPaperScissor;

rockPaperScissor _game = new rockPaperScissor();

do
{
    RoundResults _result = new PlayerRound();

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

} while (Console.WriteLine().ToUpper() == "Y");
