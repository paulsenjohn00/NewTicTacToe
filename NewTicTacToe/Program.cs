using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to group 2-6's Tic-Tac-Toe Game!");

            TurnDoer td = new TurnDoer();
            CheckWin cw = new CheckWin();
            byte[] gameBoard = new byte[9];
            byte playerTurn;


            for (int i = 0; i < 9; i++)
            {
                // Print Board goes here later
                // Checks for each player win
                if (cw.WinCheck(gameBoard, 1) == true)
                {
                    Console.WriteLine("Congradulations player 1! You won!");
                    break;
                }
                else if (cw.WinCheck(gameBoard, 2) == true)
                {
                    Console.WriteLine("Congradulations player 2! You won!");
                    break;
                }
                else
                {
                    //checks which turn it is, asks player to take their turn
                    if (i % 2 == 0)
                    {
                        Console.WriteLine("Player 1's Turn");
                        playerTurn = td.Turn(gameBoard);
                        gameBoard[playerTurn - 1] = 1;
                    }
                    else
                    {
                        Console.WriteLine("Player 2's Turn");
                        playerTurn = td.Turn(gameBoard);
                        gameBoard[playerTurn - 1] = 2;
                    }
                }
            }
        }
    }
}

