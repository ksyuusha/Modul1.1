using System;
class Program
{
    static void Main(string[] args)
    {
        // Ввод первого числа
        Console.Write("Введите первое число: ");
        double number1 = double.Parse(Console.ReadLine());
        // Ввод второго числа
        Console.Write("Введите второе число: ");
        double number2 = double.Parse(Console.ReadLine());
        // Ввод третьего числа
        Console.Write("Введите третье число: ");
        double number3 = double.Parse(Console.ReadLine());
        // Вычисление среднего арифметического
        double average = (number1 + number2 + number3) / 3;
        // Вывод результата
        Console.WriteLine($"Среднее арифметическое чисел {number1}, {number2}, {number3} = {average}");
    }
}
