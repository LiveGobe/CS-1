using System;

namespace Task4 {
    class Program {
        static void Main(string[] args) {
            int a = Convert.ToInt32(args[0]);
            int b = Convert.ToInt32(args[1]);
            int c = Convert.ToInt32(args[2]);
            int max = Math.Max(a, b);
            max = Math.Max(max, c);
            Console.WriteLine(max);
        }
    }
}