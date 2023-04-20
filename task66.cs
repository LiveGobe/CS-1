using System;

class Program {
    static int SumRange(int m, int n) {
        if (m == n) {
            return m;
        } else {
            return m + SumRange(m+1, n);
        }
    }

    static void Main(string[] args) {
        int M = 1;
        int N = 15;
        Console.WriteLine(SumRange(M, N)); // 120
    }
}