using System;

namespace Task4 {
    class Program {
        static void Main(string[] args) {
            int a = Convert.ToInt32(args[0]);
            for(int i = 1; i <= a; i++) {
                if (i % 2 == 0) Console.Write(Convert.ToString(i) + " ");
            }
        }
    }
}