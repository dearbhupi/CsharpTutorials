namespace DI_rockPaperScissor
{
    public class RockPaperScissor
    {

        private IPlayer _player1;
        private IPlayer _player2;

        public RockPaperScissor(IPlayer player1, IPlayer player2)
        {
            _player1 = player1;
            _player2 = player2;
        }

        public RoundResults PlayRound()
        {
            

            Choice p1 = _player1.GetChoice();
            Choice p2 = _player2.GetChoice();

            Console.WriteLine($"player1 picks : {p1} \nComputer picks : {p2}");

            // GameLogic
            if (p1 == p2)
            {
                return RoundResults.Draw;
            }

            if (p1 == Choice.Rock && p2 == Choice.Scissors ||
                p1 == Choice.Paper && p2 == Choice.Rock ||
                    p1 == Choice.Scissors && p2 == Choice.Paper)
            {
                return RoundResults.Player1Win;
            }
            return RoundResults.Player2Win;
        }
    }


    public enum Choice
    {
        Rock,
        Paper,
        Scissors

    }

    public enum RoundResults
    {
        Player1Win,
        Player2Win,
        Draw
    }
}

