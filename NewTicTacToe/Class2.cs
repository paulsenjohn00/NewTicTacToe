using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class CheckWin
    {
        public bool WinCheck(byte[] gameBoard, byte player)
        {
            if (gameBoard[0] == player && gameBoard[1] == player && gameBoard[2] == player ||
               gameBoard[0] == player && gameBoard[3] == player && gameBoard[6] == player ||
               gameBoard[0] == player && gameBoard[4] == player && gameBoard[8] == player ||
               gameBoard[1] == player && gameBoard[4] == player && gameBoard[7] == player ||
               gameBoard[2] == player && gameBoard[5] == player && gameBoard[8] == player ||
               gameBoard[2] == player && gameBoard[4] == player && gameBoard[6] == player ||
               gameBoard[3] == player && gameBoard[4] == player && gameBoard[5] == player ||
               gameBoard[6] == player && gameBoard[7] == player && gameBoard[8] == player)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
