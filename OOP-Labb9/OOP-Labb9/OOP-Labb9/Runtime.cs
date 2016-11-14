using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb9
{
    class Runtime
    {
        public char Player { get; set; } = 'O';
        //public bool IsWin { get; set; } = false;

        public void Start()
        {

            var board = new Board();
            var gameResults = new GameResults();
            var playerNodes = board.NodeGenerator();
            var counter = new Counter { Threshold = 9 };
            var counterWin = new Counter { Threshold = 1 };
            counter.ThresholdReached += (sender, e) =>
            {
                Console.WriteLine("Draw");
                counterWin.Total = 1;
                gameResults.PlayAgain(counterWin, counter, playerNodes, board);
            };
            counterWin.ThresholdReached += (sender, e) =>
            {
                char player = 'X';
                if (Player == 'X') player = 'O';
                else player = 'X';
                Console.WriteLine("Congratulations {0}. You won!", player);
                //IsWin = true;
                gameResults.PlayAgain(counterWin, counter, playerNodes, board);
            };


            while (true)
            {

                Console.Clear();
                board.GameBoard(playerNodes);
                Console.WriteLine("Player: {0}", Player);
                var input = int.Parse(Console.ReadLine());

                gameResults.CheckInput(playerNodes, board, this, input, counter);

                gameResults.CheckWin(playerNodes, this, counterWin);

                if (counterWin.Total == 1)
                {
                    counterWin.OnThresholdReached(EventArgs.Empty);
                }

                if (counter.Total == 9 && counterWin.Total == 0)
                {

                    counter.OnThresholdReached(EventArgs.Empty);
                }


            }
        }


    }
}

