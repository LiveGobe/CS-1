using System;

class Program {
    static void Main() {
        int[,] array = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 }, { 5, 2, 6, 7 } };

        int minSum = array[0, 0] + array[0, 1] + array[0, 2] + array[0, 3]; // предполагаем, что строка с индексом 0 имеет наименьшую сумму элементов
        int minIndex = 0;

        for (int i = 1; i < array.GetLength(0); i++)
        {
            int currentSum = array[i, 0] + array[i, 1] + array[i, 2] + array[i, 3];
            if (currentSum < minSum)
            {
                minSum = currentSum;
                minIndex = i;
            }
        }

        Console.WriteLine("Строка с наименьшей суммой элементов: " + (minIndex + 1));
    }
}