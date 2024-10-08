using System;
class Program
{
    static void Main()
    {
        // Ввод значений K, A и B
        Console.Write("Введите размер массива (K): ");
        int K = int.Parse(Console.ReadLine());
        Console.Write("Введите начальное значение диапазона (A): ");
        int A = int.Parse(Console.ReadLine());
        Console.Write("Введите конечное значение диапазона (B): ");
        int B = int.Parse(Console.ReadLine());
        // Инициализация массива и генерация случайных значений
        int[] array = new int[K];
        Random rand = new Random();
        for (int i = 0; i < K; i++)
        {
            array[i] = rand.Next(A, B); // Генерация случайного значения в диапазоне [A, B)
        }
        // Вывод массива
        Console.WriteLine("Сгенерированный массив:");
        for (int i = 0; i < K; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        // Поиск индексов минимального и максимального элементов
        int minIndex = 0;
        int maxIndex = 0;
        for (int i = 1; i < K; i++)
        {
            if (array[i] < array[minIndex])
            {
                minIndex = i;
            }
            if (array[i] > array[maxIndex])
            {
                maxIndex = i;
            }
        }
        // Определение диапазона вывода
        int startIndex = Math.Min(minIndex, maxIndex);
        int endIndex = Math.Max(minIndex, maxIndex);
        // Вывод элементов между минимальным и максимальным (включая их)
        Console.WriteLine("Элементы между минимальным и максимальным значениями (включая):");
        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}
