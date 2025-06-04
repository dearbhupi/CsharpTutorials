using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_rockPaperScissor
{
    internal class ComputerPlayer : IPlayer

    {
        public Choice GetChoice()
        {

            //Player2 choices
            // create object for genearting random choices for player2 or computer
            Random _random = new Random();

            Choice p2 = (Choice)_random.Next(0, 3);

           // Console.WriteLine($"Player 2 picked {p2.ToString()} ");

            return p2;
        }
    }
}
