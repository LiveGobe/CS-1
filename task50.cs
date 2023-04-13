using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] arr = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

        Console.Write("Введите номер строки: ");
        int row = int.Parse(Console.ReadLine());

        Console.Write("Введите номер столбца: ");
        int col = int.Parse(Console.ReadLine());

        object element = GetElement(arr, row, col);
        Console.WriteLine(element);
    }

    static object GetElement(int[,] arr, int row, int col)
    {
        if (row < 0 || row >= arr.GetLength(0) || col < 0 || col >= arr.GetLength(1))
        {
            return "такого элемента нет";
        }
        else
        {
            return arr[row, col];
        }
    }
}