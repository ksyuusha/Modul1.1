using System;
class Program
{
    static void Main()
    {
        // Инициализация массива вещественных чисел
        double[] array = new double[10];
        Random rand = new Random();
        // Заполнение массива случайными значениями из диапазона [-10, 10)
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.NextDouble() * 20 - 10; // Генерация значения в диапазоне [-10, 10)
        }
        // Вывод исходного массива
        Console.WriteLine("Исходный массив:");
        foreach (var value in array)
        {
            Console.WriteLine(value);
        }
        // Создание массива индексов
        int[] indexArray = new int[array.Length];
        for (int i = 0; i < indexArray.Length; i++)
        {
            indexArray[i] = i;
        }
        // Сортировка индексов в порядке возрастания значений массива
        Array.Sort(array, indexArray);
        // Вывод массива индексов
        Console.WriteLine("\nМассив индексов в порядке возрастания значений:");
        foreach (var index in indexArray)
        {
            Console.WriteLine(index);
        }
    }
}
