using System;
class Program
{
    static void Main(string[] args)
    {
        // Ввод первой строки
        Console.Write("Введите первую строку: ");
        string firstString = Console.ReadLine();
        // Ввод второй строки
        Console.Write("Введите вторую строку: ");
        string secondString = Console.ReadLine();
        // Проверка, является ли вторая строка подстрокой первой
        if (firstString.Contains(secondString))
        {
            Console.WriteLine($"Строка \"{secondString}\" является подстрокой строки \"{firstString}\".");
        }
        else
        {
            Console.WriteLine($"Строка \"{secondString}\" не является подстрокой строки \"{firstString}\".");
        }
    }
}
