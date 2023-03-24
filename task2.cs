using System;

namespace Task2 {
    class Program {
        static void Main(string[] args) {
            int a = Convert.ToInt32(args[0]);
            int b = Convert.ToInt32(args[1]);
            int max = Math.Max(a, b);
            Console.WriteLine(max);
        }
    }
}