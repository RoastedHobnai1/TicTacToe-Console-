using System;

namespace TicTacToe
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            bool isPlayerOne = true;
            int [,] numbers = { { 1, 2, 3}, { 4, 5, 6}, { 7, 8, 9 }};
            DrawTable(numbers);
            bool win=false;
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    if
                        (
                        (numbers[0, j] == 0 && numbers[1, j] == 0 && numbers[2, j] == 0) ||
                        (numbers[i, 0] == 0 && numbers[i, 1] == 0 && numbers[i, 2] == 0) ||
                        (numbers[0, 0] == 0 || numbers[0,2] == 0) && numbers[1, 1] == 0 && (numbers[2, 2] == 0|| numbers[2, 0] == 0) 
                        )
                    {
                        win = true;
                        Console.WriteLine("Player 1 won");
                        break;
                    }
                    else if (
                            (numbers[0, j] == 1 && numbers[1, j] == 1 && numbers[2, j] == 1) ||
                            (numbers[i, 0] == 1 && numbers[i, 1] == 1 && numbers[i, 2] == 1) ||
                            (numbers[0, 0] == 1 || numbers[0, 2] == 1) && numbers[1, 1] == 1 && (numbers[2, 2] == 1 || numbers[2, 0] == 1)
                            )
                    {
                        win = true;
                        Console.WriteLine("Player 2 won");
                        break;
                    }
                    ChangeElement(numbers, isPlayerOne);
                }
                if (win)
                {
                    break;
                }
            }
            
        }

        public static void DrawTable(int [,] numbers)
        {
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    if (j < numbers.GetLength(1)-1)
                    {
                        Console.Write(numbers[i,j] + "|");
                    }
                    else
                    {
                        Console.Write(numbers[i, j]+"\n");
                        if (i < numbers.GetLength(0) - 1)
                        {
                            Console.WriteLine("-----");
                        }
                    }
                }
            }
        }
        public static void ChangeElement(int[,] numbers, bool isPlayerOne)
        {
            
            int playerInput;
            bool isNumber = int.TryParse(Console.ReadLine(), out playerInput);
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    if (isPlayerOne == true && numbers[i, j] == playerInput)
                    {
                        numbers[i, j] = 0;
                        isPlayerOne = false;
                    }
                    if (isPlayerOne == false && numbers[i, j] == playerInput)
                    {
                        numbers[i, j] = 1;
                        isPlayerOne = true;
                    }
                    Console.WriteLine(isPlayerOne);
                }
            }
            DrawTable(numbers);
        }

    }
}
 