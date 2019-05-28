using System;

namespace TicTacToe2
{
    class Program
    {
        //numbers for board
        public static string[,] numbers = 
        {
                {"1", "2", "3"},
                {"4", "5", "6"},
                {"7", "8", "9"}
        };

        //player 1 or 2
        public static int player = 1;
        //checks if players won, 1 for win
        public static int winCheck = 0;
        //decides who turn it is
        public static int turn;


        static void Main(string[] args)
        {

        }

        static void DrawBoard()
        {
            Console.WriteLine("   |   |   ");
            Console.WriteLine("   |   |   ");
        }
    }
}
