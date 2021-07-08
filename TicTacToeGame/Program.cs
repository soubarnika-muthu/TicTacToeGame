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
            UC1.DisplayBoard(UC1.CreateBoard());
          //  char[] result = UC1.CreateBoard();
            ChoosingPlayer player = new ChoosingPlayer();
            player.ReadPlayerInput();
            player.ReadComputerInput(player.ReadPlayerInput());
        }
    }
}
