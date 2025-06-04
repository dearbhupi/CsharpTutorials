using DI_rockPaperScissor;

RockPaperScissor _game = new RockPaperScissor();

do
{
    RoundResults _result = RockPaperScissor.PlayRound();

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

} while (Console.ReadLine().ToUpper() == "Y");
