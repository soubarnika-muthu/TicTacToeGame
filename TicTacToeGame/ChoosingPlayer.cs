using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    class ChoosingPlayer
    {
        public char  ReadPlayerInput()
        {
            Console.WriteLine("Choose Letter To play X or O");
            char Player = Convert.ToChar(Console.ReadLine());
            return Player;
        }
        public char ReadComputerInput(char Player)
        {
            char computerValue;
            if(Player=='X'||Player=='x')
            {
                computerValue = 'O';
            }
            else
            {
                computerValue = 'X';
            }

            return computerValue;
        }
    }
}
