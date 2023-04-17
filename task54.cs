using System;

class Program {
    static void Main() {
        const int ROWS = 3;
        const int COLS = 4;
        int[,] arr = {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};

        // сортировка каждой строки по убыванию
        for (int i = 0; i < ROWS; i++) {
            for (int j = 0; j < COLS - 1; j++) {
                for (int k = j + 1; k < COLS; k++) {
                    if (arr[i, j] < arr[i, k]) {
                        int temp = arr[i, j];
                        arr[i, j] = arr[i, k];
                        arr[i, k] = temp;
                    }
                }
            }
        }

        // вывод отсортированного массива
        for (int i = 0; i < ROWS; i++) {
            for (int j = 0; j < COLS; j++) {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}