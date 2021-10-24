using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop1_tiktactoe
{
    public class UC3
    {

        UC3 obj = new UC3();


        public static void showboard()
        {
            char[] board = new char[10];

            for (int i = 1; i < 10; i++)
            {
                board[i] = ' ';
            }

            //display the dashboard

            //Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[1], board[2], board[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[4], board[5], board[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[7], board[8], board[9]);
            //Console.WriteLine("     |     |      ");


        }

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
