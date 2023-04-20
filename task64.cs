using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Введите значение N: ");
        int n = int.Parse(Console.ReadLine());
        PrintNumbers(n);
    }

    static void PrintNumbers(int n) {
        if (n == 1) {
            Console.Write(n);
        } else {
            Console.Write(n + ", ");
            PrintNumbers(n-1);
        }
    }
}