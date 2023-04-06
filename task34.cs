using System;

class Program
{
    static void Main(string[] args)
    {
        // создаем массив из 10 случайных трехзначных чисел
        int[] arr = new int[10];
        Random rand = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(100, 1000);
        }

        // считаем количество четных чисел в массиве
        int count = 0;
        foreach (int num in arr)
        {
            if (num % 2 == 0)
            {
                count++;
            }
        }

        // выводим результат на экран
        Console.WriteLine("Количество четных чисел в массиве: {0}", count);
    }
}