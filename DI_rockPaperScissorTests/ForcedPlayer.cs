using DI_rockPaperScissor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_rockPaperScissorTests
{
    /// <summary>
    /// this class where we can force the player to pick whatever we suggest for testing purposes
    /// </summary>
    internal class ForcedPlayer : DI_rockPaperScissor.IPlayer
    {
        private Choice _choice;

        public ForcedPlayer(Choice choice)
        { 
            _choice = choice;
        }
        public Choice GetChoice()
        {
            return _choice;
        }
    }
}
