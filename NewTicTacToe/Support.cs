using System;
using System.Linq;

namespace TicTacToe
{
    public class Support
    {
        public Support()
        {
        }
        public void DisplayBoard(int[] boardArray)
        {
            string output = "Board Display: (Results Left, Positions Right)\n";
            for (int i = 0; i < 3; ++i)
            {
                output += TranslateBoard(boardArray[i]);
            }
            output += "  1|2|3\n";
            for (int i = 3; i < 6; ++i)
            {
                output += TranslateBoard(boardArray[i]);
            }
            output += "  4|5|6\n";
            for (int i = 6; i < 9; ++i)
            {
                output += TranslateBoard(boardArray[i]);
            }
            output += "  7|8|9\n";

            Console.WriteLine(output);
        }
        public bool CheckBoard(int[] boardArray)
        {
            //No Turns yet:
            if (boardArray.All(val => val == boardArray[0]))
            {
                return false;
            }
            else
            {
                //Line A + 1's + Diagonal1
                if (boardArray[0] != 0)
                {
                    //Line A
                    if (boardArray[0] == boardArray[1])
                    {

                        if (boardArray[0] == boardArray[2])
                        {
                            PrintWinner(boardArray[0]);
                            //PRINT WINNER
                            return true;
                        }
                        //else
                        //{
                        //    //Print 
                        //    return false;
                        //}
                    }
                    //1's
                    if (boardArray[0] == boardArray[3])
                    {
                        if (boardArray[0] == boardArray[6])
                        {
                            PrintWinner(boardArray[0]);
                            return true;
                        }
                        //else
                        //{
                        //	return false;
                        //}
                    }
                    //Diagonal1:
                    if (boardArray[0] == boardArray[4])
                    {
                        if (boardArray[0] == boardArray[8])
                        {
                            PrintWinner(boardArray[0]);
                            return true;
                        }
                    }
                    //else
                    //{
                    //	return false;
                    //}
                }
                //B:
                if (boardArray[3] != 0)
                {
                    if (boardArray[3] == boardArray[4] && boardArray[3] == boardArray[5])

                    {
                        PrintWinner(boardArray[3]);
                        return true;
                    }
                }
                //C:
                if (boardArray[6] != 0)
                {
                    if (boardArray[6] == boardArray[7] && boardArray[6] == boardArray[8])

                    {
                        PrintWinner(boardArray[6]);
                        return true;
                    }
                }
                //2's:
                if (boardArray[1] != 0)
                {
                    if (boardArray[1] == boardArray[4] && boardArray[1] == boardArray[7])

                    {
                        PrintWinner(boardArray[1]);
                        return true;
                    }
                }
                //3's + D2:
                if (boardArray[2] != 0)
                {
                    if (boardArray[2] == boardArray[5] && boardArray[2] == boardArray[8])
                    {
                        PrintWinner(boardArray[2]);
                        return true;
                    }
                    if (boardArray[2] == boardArray[4] && boardArray[2] == boardArray[6])
                    {
                        PrintWinner(boardArray[2]);
                        return true;
                    }
                }


                return false;
            }
        }
        protected string TranslateBoard(int key)
        {
            if (key == 2)
            {
                return "o";
            }
            else if (key == 1)
            {
                return "x";
            }
            else
            {
                return "*";
            }
        }
        protected void PrintWinner(int key)
        {
            if (key == 2)
            {
                Console.WriteLine("o Wins!\nThanks for Playing!\n");
            }
            else
            {
                Console.WriteLine("x Wins!\nThanks for Playing!\n");
            }
        }
    }
}

