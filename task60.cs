using System;

class Program
{
    static void Main(string[] args)
    {
        int[,,] arr = new int[2, 2, 2] { { { 66, 25 }, { 34, 41 } }, { { 27, 90 }, { 26, 55 } } };

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int k = 0; k < arr.GetLength(2); k++)
                {
                    Console.Write(arr[i, j, k] + "(" + i + "," + j + "," + k + ") ");
                }
                Console.WriteLine();
            }
        }
    }
}