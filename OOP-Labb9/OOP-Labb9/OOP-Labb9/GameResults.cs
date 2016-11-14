using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb9
{
    class GameResults
    {
        internal void PlayAgain(Counter counterWin, Counter counter, Node[,] playernodes, Board board)
        {
            if (counterWin.Total == 1)
            {

                Console.WriteLine("Do you want to play again? (Y/N)");
                var input = Console.ReadLine();
                if (input == "y")
                {
                    counter.Total = 0;
                    board.ResetPlayerNodes(playernodes);

                    counterWin.Total = 0;
                    

                }
                else if (input == "n") Environment.Exit(0);
                else Console.WriteLine("Please enter a valid option");



            }


        }

        internal void CheckWin(Node[,] playerNodes, Runtime runtime, Counter counterWin)
        {
            char player = 'X';
            if (runtime.Player == 'O')
            {
               player = 'X';
            }
            else player = 'X';

            //for (int i = 0; i < 3; i++)
            //{
            //    int col = 0;
            //    int row = 0;
            //    if (playerNodes[col, row].Player == playerNodes[col, row + 1].Player && playerNodes[col, row + 2].Player == playerNodes[0, 2].Player)
            //}

            if (playerNodes[0, 0].Player == playerNodes[0, 1].Player && playerNodes[0, 1].Player == playerNodes[0, 2].Player)
            {
                
               counterWin.Add(1); 

            }
            else if (playerNodes[1, 0].Player == playerNodes[1, 1].Player && playerNodes[1, 1].Player == playerNodes[1, 2].Player)
            {
               
                counterWin.Add(1); 
            }
            else if (playerNodes[2, 0].Player == playerNodes[2, 1].Player && playerNodes[2, 1].Player == playerNodes[2, 2].Player)
            {
                
                counterWin.Add(1);
            }
            else if (playerNodes[0, 0].Player == playerNodes[1, 0].Player && playerNodes[1, 0].Player == playerNodes[2, 0].Player)
            {
                
                counterWin.Add(1);
            }
            else if (playerNodes[0, 1].Player == playerNodes[1, 1].Player && playerNodes[1, 1].Player == playerNodes[2, 1].Player)
            {
                
                counterWin.Add(1);
            }
            else if (playerNodes[0, 2].Player == playerNodes[1, 2].Player && playerNodes[1, 2].Player == playerNodes[2, 2].Player)
            {
               
                counterWin.Add(1);
            }
            else if (playerNodes[0, 0].Player == playerNodes[1, 1].Player && playerNodes[1, 1].Player == playerNodes[2, 2].Player)
            {
               
                counterWin.Add(1);
            }
            else if (playerNodes[0, 2].Player == playerNodes[1, 1].Player && playerNodes[1, 1].Player == playerNodes[2, 0].Player)
            {

                counterWin.Add(1);
            }
            else if (playerNodes[0, 2].Player == playerNodes[1, 1].Player && playerNodes[1, 1].Player == playerNodes[2, 0].Player)
            {

                counterWin.Add(1);
            }
        }

        internal void CheckInput(Node[,] playerNodes, Board board, Runtime runtime, int input, Counter counter)
        {
            if (input == 1 && playerNodes[0, 0].Player == '1')
            {
                counter.Add(1);
                board.PlaceMarker(0, 0, runtime.Player, playerNodes, runtime);
                if (runtime.Player == 'O') runtime.Player = 'X';
                else runtime.Player = 'O';
            }

            else if (input == 2 && playerNodes[0, 1].Player == '2')
            {
                counter.Add(1);
                board.PlaceMarker(0, 1, runtime.Player, playerNodes, runtime);
                if (runtime.Player == 'O') runtime.Player = 'X';
                else runtime.Player = 'O';
            }

            else if (input == 3 && playerNodes[0, 2].Player == '3')
            {
                counter.Add(1);
                board.PlaceMarker(0, 2, runtime.Player, playerNodes, runtime);
                if (runtime.Player == 'O') runtime.Player = 'X';
                else runtime.Player = 'O';
            }

            else if (input == 4 && playerNodes[1, 0].Player == '4')
            {
                counter.Add(1);
                board.PlaceMarker(1, 0, runtime.Player, playerNodes, runtime);
                if (runtime.Player == 'O') runtime.Player = 'X';
                else runtime.Player = 'O';
            }

            else if (input == 5 && playerNodes[1, 1].Player == '5')
            {
                counter.Add(1);
                board.PlaceMarker(1, 1, runtime.Player, playerNodes, runtime);
                if (runtime.Player == 'O') runtime.Player = 'X';
                else runtime.Player = 'O';
            }

            else if (input == 6 && playerNodes[1, 2].Player == '6')
            {
                counter.Add(1);
                board.PlaceMarker(1, 2, runtime.Player, playerNodes, runtime);
                if (runtime.Player == 'O') runtime.Player = 'X';
                else runtime.Player = 'O';
            }
            else if (input == 7 && playerNodes[2, 0].Player == '7')
            {
                counter.Add(1);
                board.PlaceMarker(2, 0, runtime.Player, playerNodes, runtime);
                if (runtime.Player == 'O') runtime.Player = 'X';
                else runtime.Player = 'O';
            }
            else if (input == 8 && playerNodes[2, 1].Player == '8')
            {
                counter.Add(1);
                board.PlaceMarker(2, 1, runtime.Player, playerNodes, runtime);
                if (runtime.Player == 'O') runtime.Player = 'X';
                else runtime.Player = 'O';
            }
            else if (input == 9 && playerNodes[2, 2].Player == '9')
            {
                counter.Add(1);
                board.PlaceMarker(2, 2, runtime.Player, playerNodes, runtime);
                if (runtime.Player == 'O') runtime.Player = 'X';
                else runtime.Player = 'O';
            }

            else
            {
                Console.WriteLine("Invalid input, please try again");
                Console.ReadKey(true);
            }
        }
    }
}
