using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class TurnDoer
    {
        public int ErrorCatcher(int[] gameBoard)
        {
            int turn = Turn(gameBoard);
            return turn;
        }
        public int Turn(int[] gameBoard)
        {
            int convertedTurn = 10;
            Console.Write("Enter your next move: ");
            string playerTurn = Console.ReadLine();
            try
            {
                convertedTurn = Convert.ToInt32(playerTurn);
                if (convertedTurn > 9 || convertedTurn < 1)
                {
                    Console.WriteLine("Oops! That's not a square you can choose. Enter a number between 1 and 9");
                    convertedTurn = ErrorCatcher(gameBoard);
                }
                else if (gameBoard[convertedTurn - 1] != 0)
                {
                    Console.WriteLine("Oops! Someone already went there. Enter another number");
                    convertedTurn = ErrorCatcher(gameBoard);
                    return convertedTurn;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{playerTurn}', please enter a number between 1 and 9");
                convertedTurn = ErrorCatcher(gameBoard);
                return convertedTurn;
            }
            return convertedTurn;
        }
    }
}
