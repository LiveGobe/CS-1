using System;

namespace Task4 {
    class Program {
        static void Main(string[] args) {
            int a = Convert.ToInt32(args[0]);
            Console.WriteLine(a % 2 == 0);
        }
    }
}