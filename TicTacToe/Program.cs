using System;

namespace TicTacToe
{
    internal class Program
    {
        static char[,] numbers =
            {
                { '1', '2', '3' },
                { '4', '5', '6' },
                { '7', '8', '9' }
            };
        static int turns = 0;
        static void Main(string[] args)
        {
            int player = 2;
            int input = 0;
            bool inputCorrect = true;
            do
            {
                
                if (player == 2)
                {
                    player = 1;
                    ChangeCharacter(player, input);
                }
                else if (player == 1)
                {
                    player = 2;
                    ChangeCharacter(player, input);
                }
                DrawTable();
                char[] playerChars = { 'X', '0' };
                foreach(char playerChar in playerChars)
                {
                    if (
                       ((numbers[0, 0] == playerChar) && (numbers[0, 1] == playerChar) && (numbers[0, 2] == playerChar)) ||
                       ((numbers[1, 0] == playerChar) && (numbers[1, 1] == playerChar) && (numbers[1, 2] == playerChar)) ||
                       ((numbers[2, 0] == playerChar) && (numbers[2, 1] == playerChar) && (numbers[2, 2] == playerChar)) ||
                       ((numbers[0, 0] == playerChar) && (numbers[1, 0] == playerChar) && (numbers[2, 0] == playerChar)) ||
                       ((numbers[0, 1] == playerChar) && (numbers[1, 1] == playerChar) && (numbers[2, 1] == playerChar)) ||
                       ((numbers[0, 2] == playerChar) && (numbers[1, 2] == playerChar) && (numbers[2, 2] == playerChar)) ||
                       ((numbers[0, 0] == playerChar) && (numbers[1, 1] == playerChar) && (numbers[2, 2] == playerChar)) ||
                       ((numbers[0, 2] == playerChar) && (numbers[1, 1] == playerChar) && (numbers[2, 0] == playerChar))
                       )
                    {
                        if (playerChar == 'X')
                        {
                            Console.WriteLine("\nPlayer 2 has won");
                        }
                        else
                        {
                            Console.WriteLine("\nPlayer 1 has won");
                        }
                        Console.WriteLine("Please press any key to reset the game.");
                        Console.ReadKey();
                        ResetGame();
                        break;
                    }
                    else if (turns == 10)
                    {
                        Console.WriteLine("\nDraw");
                        Console.WriteLine("Please press any key to reset the game.");
                        Console.ReadKey();
                        ResetGame();
                        break;
                    }
                }



                do
                {
                    Console.WriteLine("\nPlayer {0}: Choose your field!", player);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a number from 1 to 9");
                    }
                    if ((input == 1) && (numbers[0, 0] == '1'))
                        inputCorrect = true;
                    else if ((input == 2) && (numbers[0, 1] == '2'))
                        inputCorrect = true;
                    else if ((input == 3) && (numbers[0, 2] == '3'))
                        inputCorrect = true;
                    else if ((input == 4) && (numbers[1, 0] == '4'))
                        inputCorrect = true;
                    else if ((input == 5) && (numbers[1, 1] == '5'))
                        inputCorrect = true;
                    else if ((input == 6) && (numbers[1, 2] == '6'))
                        inputCorrect = true;
                    else if ((input == 7) && (numbers[2, 0] == '7'))
                        inputCorrect = true;
                    else if ((input == 8) && (numbers[2, 1] == '8'))
                        inputCorrect = true;
                    else if ((input == 9) && (numbers[2, 2] == '9'))
                        inputCorrect = true;
                    else
                    {
                        Console.WriteLine("\nIncorrect Input. Please use another field");
                        inputCorrect = false;
                    }
                } while (!inputCorrect);
            } while (true);
        }
        public static void DrawTable()
        {
            Console.Clear();
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", numbers[0,0], numbers[0, 1], numbers[0, 2]);
            Console.WriteLine("     |     |     ");
            Console.WriteLine("-----------------");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", numbers[1, 0], numbers[1, 1], numbers[1, 2]);
            Console.WriteLine("     |     |     ");
            Console.WriteLine("-----------------");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", numbers[2, 0], numbers[2, 1], numbers[2, 2]);
            Console.WriteLine("     |     |     ");
            turns++;
        }
        public static void ChangeCharacter(int player, int input)
        {
            char playerChar = ' ';
            if (player == 1)
                playerChar = 'X';
            else if (player == 2)
                playerChar = '0';
            switch (input)
            {
                case 1: numbers[0, 0] = playerChar; break;
                case 2: numbers[0, 1] = playerChar; break;
                case 3: numbers[0, 2] = playerChar; break;
                case 4: numbers[1, 0] = playerChar; break;
                case 5: numbers[1, 1] = playerChar; break;
                case 6: numbers[1, 2] = playerChar; break;
                case 7: numbers[2, 0] = playerChar; break;
                case 8: numbers[2, 1] = playerChar; break;
                case 9: numbers[2, 2] = playerChar; break;
            }
        }
        public static void ResetGame()
        {
            char[,] numbersInitial =
            {
                { '1', '2', '3' },
                { '4', '5', '6' },
                { '7', '8', '9' }
            };
            numbers = numbersInitial;
            DrawTable();
            turns = 0;
        }
    }
}
 