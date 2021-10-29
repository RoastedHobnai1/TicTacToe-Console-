using System;

namespace TicTacToe
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            DrawTable(numbers);
        }

        public static void DrawTable(int [,] numbers)
        {
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    if (j == 0 || j == 1)
                    {
                        Console.Write(numbers[i, j] + "|");
                    }
                    else
                    {
                        Console.Write(numbers[i, j]+"\n");
                        Console.WriteLine("-----");
                    }
                    
                }
            }
        }

    }
}
 