using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class TicTacToeGame
    {
        class TicTacToe_Game
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to the TicTacToe Game!");
                CreateBoard();
            }
            static char[] CreateBoard()
            {
                char[] board = new char[10];
                for (int i = 1; i < board.Length; i++)
                {
                    board[i] = ' ';
                }
                return board;
            }
        }

    }
}
