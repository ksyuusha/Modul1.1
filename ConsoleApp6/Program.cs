using System;
class Program
{
    static void Main()
    {
        // Вводим размер массива
        Console.Write("Введите размер массива (N): ");
        int N = int.Parse(Console.ReadLine());
        // Создаем массив
        double[] array = new double[N];
        // Вводим значения элементов массива
        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < N; i++)
        {
            array[i] = double.Parse(Console.ReadLine());
        }
        // Находим максимальный по модулю элемент
        double maxAbsValue = Math.Abs(array[0]);
        for (int i = 1; i < N; i++)
        {
            if (Math.Abs(array[i]) > maxAbsValue)
            {
                maxAbsValue = Math.Abs(array[i]);
            }
        }
        // Нормируем элементы массива, деля их на максимальный по модулю элемент
        for (int i = 0; i < N; i++)
        {
            array[i] /= maxAbsValue;
        }
        // Выводим нормированные элементы массива
        Console.WriteLine("Нормированные элементы массива:");
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}
