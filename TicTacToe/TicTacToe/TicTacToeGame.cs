﻿using System;
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
                Console.WriteLine("Tic TaC Toe board created.");
                ChooseUserLetter();
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
            static char ChooseUserLetter()
            {
                Console.WriteLine("Please Choose your letter from X or O");
                char UserLetter = Console.ReadLine()[0];
                UserLetter = char.ToUpper(UserLetter);
                while (UserLetter != 'X' && UserLetter != 'O')
                {
                    Console.WriteLine("Invalid move.\nChoose again from X/O: ");
                    UserLetter = Console.ReadLine()[0];
                }
                return UserLetter;
            }
        }

    }
}
