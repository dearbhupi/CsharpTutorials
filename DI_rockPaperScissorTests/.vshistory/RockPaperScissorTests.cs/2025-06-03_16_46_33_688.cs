using Microsoft.VisualStudio.TestTools.UnitTesting;
using DI_rockPaperScissor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI_rockPaperScissorTests;
using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace DI_rockPaperScissor.Tests
{
    //[TestClass()]
    //public class RockPaperScissorTests
    //{
    //    [TestMethod()]
    //    public void PlayRoundTest()
    //    {
    //        Assert.Fail();
    //    }
    //}

    [TestClass()]
    public class RockPaperScissorTests
    {
        [TestMethod()]
        public void RockBeastsScissors()
        {
            RockPaperScissor _game = new RockPaperScissor(new ForcedPlayer(Choice.Rock), new ForcedPlayer(Choice.Scissors));

            var output = _game.PlayRound();

            var Expected_output = RoundResults.Player1Win;
            Assert.AreEqual(output, Expected_output);
        }
    }
} 