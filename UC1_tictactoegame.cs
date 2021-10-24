using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop1_tiktactoe
{
    public class UC1_tictactoegame
    {

        UC1_tictactoegame obj = new UC1_tictactoegame();


        public static void tictactoe()
        {
            //declaring array
            char[] board = new char[10];

            for (int i = 1; i < 10; i++)
            {
                //assigning empty value
                board[i] = ' ';
            }
        }
    }
}
