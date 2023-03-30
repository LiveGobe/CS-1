using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Введите пятизначное число: ");
        string number = Console.ReadLine();
        if (number.Length != 5) {
            Console.WriteLine("Ошибка! Введите пятизначное число.");
        } else {
            if (number[0] == number[4] && number[1] == number[3]) {
                Console.WriteLine("Да, это палиндром.");
            } else {
                Console.WriteLine("Нет, это не палиндром.");
            }
        }
    }
}