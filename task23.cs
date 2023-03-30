using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Введите число: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++) {
        Console.Write(Math.Pow(i, 3));
        if (i != n) Console.Write(", ");
        }
    }
}