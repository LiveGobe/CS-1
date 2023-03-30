using System;

class Program {
    static void Main(string[] args) {
        double x1, y1, z1, x2, y2, z2, distance;

        Console.Write("Введите координату x первой точки: ");
        x1 = double.Parse(Console.ReadLine());

        Console.Write("Введите координату y первой точки: ");
        y1 = double.Parse(Console.ReadLine());

        Console.Write("Введите координату z первой точки: ");
        z1 = double.Parse(Console.ReadLine());

        Console.Write("Введите координату x второй точки: ");
        x2 = double.Parse(Console.ReadLine());

        Console.Write("Введите координату y второй точки: ");
        y2 = double.Parse(Console.ReadLine());

        Console.Write("Введите координату z второй точки: ");
        z2 = double.Parse(Console.ReadLine());

        distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

        Console.WriteLine("Расстояние между точками: " + distance);
    }
}