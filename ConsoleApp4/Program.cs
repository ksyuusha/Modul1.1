using System;

class Program
{
    static void Main(string[] args)
    {
        // Создаем объект для генерации случайных чисел
        Random random = new Random();

        // Инициализируем массив на 10 элементов
        int[] numbers = new int[10];

        // Заполняем массив случайными числами от 1 до 100
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 101); // Диапазон [1, 100]
        }

        // Выводим элементы массива
        Console.WriteLine("Массив случайных чисел:");
        Console.WriteLine(string.Join(", ", numbers));

        // Вычисляем сумму всех элементов массива
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        // Выводим сумму элементов массива
        Console.WriteLine($"\nСумма всех элементов массива: {sum}");
    }
}
