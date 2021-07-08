using System;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO TIC TAC TOE GAME!");
            TicTacToeUC1 UC1 = new TicTacToeUC1();
            char[] board = UC1.CreateBoard();
            ChoosingPlayer player = new ChoosingPlayer();
            char playerchoice = player.ReadPlayerInput();
            char computerchoice= player.ReadComputerInput(player.ReadPlayerInput());
            
            
             

            UC1.SelectLocation(board,playerchoice);
            UC1.DisplayBoard(board);
            
           
           
           
           
        }
    }
}
