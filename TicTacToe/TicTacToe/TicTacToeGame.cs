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
                Console.WriteLine("Welcome to the TicTacToe Game!\n");
                char[] BOARD=CreateBoard();
                Console.WriteLine("Tic TaC Toe board created. \n");
                char letter=ChooseUserLetter();
                int moveIndex = UserMove(BOARD);
                Console.WriteLine("Showing Game Board\n");
                ShowBoard(BOARD, moveIndex, letter);
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
                while (UserLetter != 'X' && UserLetter != 'O' && UserLetter !='x' && UserLetter !='o')
                {
                    Console.WriteLine("Invalid move.\nChoose again from X/O: \n");
                    UserLetter = Console.ReadLine()[0];
                }
                return UserLetter;
            }
            static void ShowBoard(char [] BOARD, int moveIndex, char letter)
            {
                BOARD[moveIndex] =letter ;
                Console.WriteLine(BOARD[1] + "|" + BOARD[2] + "|" + BOARD[3] + "\n");
                Console.WriteLine("_______\n");
                Console.WriteLine(BOARD[4] + "|" + BOARD[5] + "|" + BOARD[6] + "\n");
                Console.WriteLine("_______\n");
                Console.WriteLine(BOARD[7] + "|" + BOARD[8] + "|" + BOARD[9] + "\n");
                return;
            }
            static int UserMove(char[] BOARD)
            {
                int moveIndex;
                Console.WriteLine("Enter index where to make move(1-9): ");
                moveIndex = Convert.ToInt32(Console.ReadLine());
                while (BOARD[moveIndex] != ' ' && BOARD[moveIndex] > 9 && BOARD[moveIndex]<0)
                {
                    Console.WriteLine("Invalid move.\nEnter index where to make move(1-9): ");
                    moveIndex = Convert.ToInt32(Console.ReadLine());
                }
                return moveIndex;
            }
        }

    }
}
