using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 4;  // размер массива
        int[,] arr = new int[n, n];  // создаем пустой массив

        // определяем границы заполнения массива
        int top = 0;
        int bottom = n - 1;
        int left = 0;
        int right = n - 1;

        int num = 1;  // начальное значение для заполнения массива

        while (top <= bottom && left <= right)
        {
            // заполняем верхнюю строку
            for (int i = left; i <= right; i++)
            {
                arr[top, i] = num;
                num++;
            }
            top++;

            // заполняем правый столбец
            for (int i = top; i <= bottom; i++)
            {
                arr[i, right] = num;
                num++;
            }
            right--;

            // заполняем нижнюю строку
            for (int i = right; i >= left; i--)
            {
                arr[bottom, i] = num;
                num++;
            }
            bottom--;

            // заполняем левый столбец
            for (int i = bottom; i >= top; i--)
            {
                arr[i, left] = num;
                num++;
            }
            left++;
        }

        // выводим массив на экран
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,2} ", arr[i, j]);
            }
            Console.WriteLine();
        }
    }
}