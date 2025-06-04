using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace DI_rockPaperScissor
{
    public class RockPaperScissor
    {

        public RoundResults PlayRound()
        {
            // Player1 choices
            Choice p1;
            do
            {
                Console.WriteLine("Enter Choice : (R)ock, (P)aper, (S)cissors : ");

                string input = Console.ReadLine().ToUpper();
                if (input == "R")
                {
                    p1 = Choice.Rock;
                    break;

                }
                else if (input == "P")
                {
                    p1 = Choice.Paper;
                    break;

                }
                else if (input == "S")
                {
                    p1 = Choice.Scissors;
                    break;

                }
                else
                {
                    Console.WriteLine("Invalid Choice, try again !");
                }
            } while (true);


            //Player2 choices
            // create object for genearting random choices for player2 or computer
            Random _random = new Random();

            Choice p2 = (Choice)_random.Next(0, 3);





            Console.WriteLine($"Player 2 picked {p2.ToString()} ");


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