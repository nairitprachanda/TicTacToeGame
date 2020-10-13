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
                for (int spaceIndex = 1; spaceIndex < board.Length; spaceIndex++)
                {
                    board[spaceIndex] = ' ';
                }
                return board;
            }
        }

    }
}
