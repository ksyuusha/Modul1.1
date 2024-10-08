using System;
class Program
{
    static void Main()
    {
        // Ввод ограничивающей суммы от пользователя
        Console.Write("Введите максимальную сумму элементов массива: ");
        int maxSum = int.Parse(Console.ReadLine());
        // Инициализация генератора случайных чисел
        Random rand = new Random();
        // Создание массива с динамическим количеством элементов
        int[] array = new int[0];
        int currentSum = 0;
        // Заполнение массива случайными числами от 1 до 9
        while (currentSum <= maxSum)
        {
            // Генерация случайного числа в диапазоне [1, 9]
            int randomValue = rand.Next(1, 10);
            // Условие завершения (если добавление числа превысит сумму)
            if (currentSum + randomValue > maxSum)
            {
                break;
            }
            // Расширение массива и добавление нового элемента
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = randomValue;
            // Обновление суммы
            currentSum += randomValue;
        }
        // Вывод результатов
        Console.WriteLine("Сгенерированный массив:");
        foreach (int value in array)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Сумма элементов: " + currentSum);
    }
}
