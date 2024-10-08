using System;
class Program
{
    static void Main()
    {
        // Инициализация целочисленного массива из 10 элементов
        int[] array = { 1, 5, 3, 9, 2, 8, 4, 7, 6, 0 };
        // Вывод исходного массива
        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        // Ввод целого числа для замены максимального элемента
        Console.Write("Введите целое число для замены максимального элемента: ");
        int newValue = int.Parse(Console.ReadLine());
        // Поиск индекса максимального элемента
        int maxIndex = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[maxIndex])
            {
                maxIndex = i;
            }
        }
        // Замена максимального элемента на введенное число
        array[maxIndex] = newValue;
        // Вывод измененного массива
        Console.WriteLine("Измененный массив:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}
