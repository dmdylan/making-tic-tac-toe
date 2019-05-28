using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Program
    {
        //numbers for board
        public static string[] numbers = {"1", "2", "3","4", "5", "6","7", "8", "9"};
        //player 1 or 2
        public static int player = 1;
        //checks if players won, 1 for win
        public static int winCheck = 0;
        //decides who turn it is
        public static int choice = 0;
        //counts number of turns
        public static int count = 0;
        static void Main(string[] args)
        {
            DrawBoard();
            PlayerTurn();
            Console.ReadLine();
        }

        static void PlayerTurn()
        {
            do
            {
                if (player == 1)
                {
                    Console.WriteLine("Player {0}'s turn!", player);
                }
                else
                {
                    Console.WriteLine("Player {0}'s turn!", player);
                }


                try
                {
                    choice = int.Parse(Console.ReadLine()); ;
                    if (numbers[choice - 1] == "X" || numbers[choice - 1] == "O")
                    {
                        Console.WriteLine("That choice is already taken, please choose another!");
                    }
                    else if (numbers[choice - 1] != "X" || numbers[choice - 1] != "O")
                    {
                        if (player == 1)
                        {
                            numbers[choice - 1] = "X";
                            player++;
                            count++;
                        }
                        else
                        {
                            numbers[choice - 1] = "O";
                            player--;
                            count++;
                        }
                    }

                    if (numbers[choice - 1] == "X" || numbers[choice - 1] == "O")
                    {
                        Console.WriteLine("That choice is already taken, please choose another!");
                    }
                    else if (numbers[choice - 1] != "X" || numbers[choice - 1] != "O")
                    {
                        if (player == 1)
                        {
                            numbers[choice - 1] = "X";
                            player++;
                            count++;
                        }
                        else
                        {
                            numbers[choice - 1] = "O";
                            player--;
                            count++;
                        }
                    }
                }
                catch(System.FormatException)
                {
                   Console.WriteLine("Please enter a number 1-9!");
                }
                catch (System.IndexOutOfRangeException)
                {
                    Console.WriteLine("Please enter a number 1-9!");
                }
   
                Console.Clear();
                DrawBoard();
                WinCondition();
            }
            while (winCheck != 1 && winCheck != -1);
            
        }



        static void DrawBoard()
        {
            Console.WriteLine("     |     |   ");
            Console.WriteLine("  {0}  |  {1}  |  {2} ", numbers[0], numbers[1], numbers[2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |   ");
            Console.WriteLine("  {0}  |  {1}  |  {2} ", numbers[3], numbers[4], numbers[5]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |   ");
            Console.WriteLine("  {0}  |  {1}  |  {2} ", numbers[6], numbers[7], numbers[8]);
            Console.WriteLine("     |     |   ");
        }


        static void WinCondition()
        {
            //horizontal X win conditions
            //row zero
            if ((numbers[0] == "X") && (numbers[1] == "X") && (numbers[2] == "X"))
            {
                winCheck++;
                Console.WriteLine("Player 1 wins!");
            }
            //row one
            else if ((numbers[3] == "X") && (numbers[4] == "X") && (numbers[5] == "X"))
            {
                winCheck++;
                Console.WriteLine("Player 1 wins!");
            }
            //row two
            else if ((numbers[6] == "X") && (numbers[7] == "X") && (numbers[8] == "X"))
            {
                winCheck++;
                Console.WriteLine("Player 1 wins!");
            }
            //horizontal O win conditions
            //row zero
            else if ((numbers[0] == "O") && (numbers[1] == "O") && (numbers[2] == "O"))
            {
                winCheck++;
                Console.WriteLine("Player 2 wins!");
            }
            //row one
            else if ((numbers[3] == "O") && (numbers[4] == "O") && (numbers[5] == "O"))
            {
                winCheck++;
                Console.WriteLine("Player 2 wins!");
            }
            //row two
            else if ((numbers[6] == "O") && (numbers[7] == "O") && (numbers[8] == "O"))
            {
                winCheck++;
                Console.WriteLine("Player 2 wins!");
            }
            //vertical column X win conditions
            //column one
            else if ((numbers[0] == "X") && (numbers[3] == "X") && (numbers[6] == "X"))
            {
                winCheck++;
                Console.WriteLine("Player 1 wins!");
            }
            //column two
            else if ((numbers[1] == "X") && (numbers[4] == "X") && (numbers[7] == "X"))
            {
                winCheck++;
                Console.WriteLine("Player 1 wins!");
            }
            //column three
            else if ((numbers[2] == "X") && (numbers[5] == "X") && (numbers[8] == "X"))
            {
                winCheck++;
                Console.WriteLine("Player 1 wins!");
            }
            //vertical column O win conditions
            //column one
            else if ((numbers[0] == "O") && (numbers[3] == "O") && (numbers[6] == "O"))
            {
                winCheck++;
                Console.WriteLine("Player 2 wins!");
            }
            //column two
            else if ((numbers[1] == "O") && (numbers[4] == "O") && (numbers[7] == "O"))
            {
                winCheck++;
                Console.WriteLine("Player 2 wins!");
            }
            //column three
            else if ((numbers[2] == "O") && (numbers[5] == "O") && (numbers[8] == "O"))
            {
                winCheck++;
                Console.WriteLine("Player 2 wins!");
            }
            //diagonal X win conditions
            //column one
            else if ((numbers[0] == "X") && (numbers[4] == "X") && (numbers[8] == "X"))
            {
                winCheck++;
                Console.WriteLine("Player 1 wins!");
            }
            else if ((numbers[2] == "X") && (numbers[4] == "X") && (numbers[6] == "X"))
            {
                winCheck++;
                Console.WriteLine("Player 1 wins!");
            }
            //diagonal O win conditions
            //column one
            else if ((numbers[0] == "O") && (numbers[4] == "O") && (numbers[8] == "O"))
            {
                winCheck++;
                Console.WriteLine("Player 2 wins!");
            }
            else if ((numbers[2] == "O") && (numbers[4] == "O") && (numbers[6] == "O"))
            {
                winCheck++;
                Console.WriteLine("Player 2 wins!");
            }
            else if (count == 9)
            {
                winCheck--;
                Console.WriteLine("Tie Game!");
            }
        }
    }
}
