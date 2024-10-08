using System;
class Program
{
    // Статический метод для вычисления НОД двух чисел (метод Евклида)
    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    static void Main()
    {
        // Ввод числителя и знаменателя с клавиатуры
        Console.Write("Введите числитель (неотрицательное число): ");
        int numerator = int.Parse(Console.ReadLine());
        Console.Write("Введите знаменатель (положительное число): ");
        int denominator = int.Parse(Console.ReadLine());
        // Проверка на корректность введённых данных
        if (denominator == 0)
        {
            Console.WriteLine("Ошибка: знаменатель не может быть равен нулю.");
            return;
        }
        // Вычисление НОД
        int gcd = GCD(numerator, denominator);
        // Вывод НОД
        Console.WriteLine("Наибольший общий делитель: " + gcd);
        // Сокращение дроби
        int reducedNumerator = numerator / gcd;
        int reducedDenominator = denominator / gcd;
        // Вывод сокращённой дроби
        Console.WriteLine("Сокращённая дробь: {0}/{1}", reducedNumerator, reducedDenominator);
    }
}
