using System;

class Program
{
    static void Main(string[] args)
    {
        // создаем массив из 10 случайных чисел от -100 до 100
        int[] arr = new int[10];
        Random rnd = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(-100, 101);
        }

        // находим сумму элементов, стоящих на нечетных позициях
        int sum_odd = 0;
        for (int i = 1; i < arr.Length; i += 2)
        {
            sum_odd += arr[i];
        }

        // выводим результат на экран
        Console.WriteLine("Сумма элементов на нечетных позициях: {0}", sum_odd);
    }
}