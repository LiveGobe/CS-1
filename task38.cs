using System;

class Program {
    static void Main(string[] args) {
        double[] arr = { 3.5, 1.2, 4.8, 2.1, 5.7 };
        double maxElem = arr[0];
        double minElem = arr[0];
        for (int i = 1; i < arr.Length; i++) {
            if (arr[i] > maxElem) {
                maxElem = arr[i];
            }
            if (arr[i] < minElem) {
                minElem = arr[i];
            }
        }
        double diff = maxElem - minElem;
        Console.WriteLine(diff);
    }
}