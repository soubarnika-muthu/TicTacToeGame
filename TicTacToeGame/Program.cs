using System;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO TIC TAC TOE GAME!");
            TicTacToeUC1 UC1 = new TicTacToeUC1();
            UC1.CreateBoard();
            ChoosingPlayer player = new ChoosingPlayer();
            char choice= player.ReadComputerInput(player.ReadPlayerInput());

            UC1.SelectLocation(UC1.CreateBoard(),choice);
            UC1.DisplayBoard(UC1.CreateBoard());
            
            char[] board = UC1.CreateBoard();
           
           
           
        }
    }
}
