using System;

class Program
{
    static void Main(string[] args)
    {
        // задаем двумерный массив
        int[,] arr = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

        // определяем количество строк и столбцов в массиве
        int rows = arr.GetLength(0);
        int cols = arr.GetLength(1);

        // создаем массив для хранения средних арифметических значений
        double[] averages = new double[cols];

        // проходим по каждому столбцу и находим среднее арифметическое
        for (int j = 0; j < cols; j++)
        {
            int col_sum = 0;
            for (int i = 0; i < rows; i++)
            {
                col_sum += arr[i, j];
            }
            double col_avg = (double)col_sum / rows;
            averages[j] = col_avg;
        }

        // выводим результаты
        for (int j = 0; j < cols; j++)
        {
            Console.WriteLine("Среднее арифметическое столбца {0}: {1}", j + 1, averages[j]);
        }
    }
}