using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop1_tiktactoe
{
    class UC2
    {
        UC2 obj = new UC2();
        public static void tictactoe()
        {
            char[] board = new char[10];

            for (int i = 1; i < 10; i++)
            {
                board[i] = ' ';
            }

        }
        //for choosing the letter choosemethod is written
        public static void chooseletter()
        {
            string userletter = " ";
            string computerletter = " ";


            while (true)
            {
                Console.WriteLine("Choose the letter X or O");

                userletter = Console.ReadLine();

                if (userletter == "X" || userletter == "x")
                {
                    computerletter = "O";
                    break;
                }
                else if (userletter == "O" || userletter == "o")
                {
                    computerletter = "X";
                    break;
                }
                else
                {
                    Console.WriteLine(" you entered Invalid Letter");
                }
            }
            Console.WriteLine("userLetter : " + userletter + " computerLetter : " + computerletter);
        }

    }
}

