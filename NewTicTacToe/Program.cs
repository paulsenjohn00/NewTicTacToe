using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to group 2-6's Tic-Tac-Toe Game!\n");

            TurnDoer td = new TurnDoer();
            Support s = new Support();
            int[] gameBoard = new int[9];
            int playerTurn;


            for (int i = 0; i < 10; i++)
            {
                // Print Board goes here later
                s.DisplayBoard(gameBoard);
                // Checks for each player win
                if (s.CheckBoard(gameBoard) == true)
                {
                    break;
                }
                else if (s.CheckBoard(gameBoard) == true)
                {
                    break;
                }
                else if (i == 9)
                {
                    Console.WriteLine("It's a draw!");
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

