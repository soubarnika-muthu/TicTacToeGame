using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    class TicTacToeUC1
    {
         char[] board;
        public  char[] CreateBoard()
        {
            //Creating new array and initializing to empty space
            char[] board = new char[10];

            for (int i=0;i<board.Length;i++)
            {
                board[i] = ' ';

            }
            board[0] = '0';

            return board;

        }
        public void DisplayBoard(char[] board)
        {
            Console.WriteLine ("     |     |     \n");
            Console.WriteLine("  {0}  | {1}   | {2}  \n", board[1], board[2], board[3]);

            Console.WriteLine("_____|_____|_____\n");
            Console.WriteLine("     |     |     \n");

            Console.WriteLine("  {0}   | {1}   | {2}  \n", board[4], board[5], board[6]);

            Console.WriteLine("_____|_____|_____\n");
            Console.WriteLine("     |     |     \n");

            Console.WriteLine("  {0}   | {1}  |  {2}  \n", board[7], board[8], board[9]);

            Console.WriteLine("     |     |     \n\n");

        }
        
        
    }
}
