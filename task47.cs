using System;

class Program
{
    static void Main(string[] args)
    {
        int m = 3; // количество строк
        int n = 4; // количество столбцов

        // создаем пустой двумерный массив
        double[,] arr = new double[m, n];

        // заполняем массив случайными вещественными числами
        Random rand = new Random();
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                arr[i, j] = rand.NextDouble();
            }
        }

        // выводим массив на экран
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}