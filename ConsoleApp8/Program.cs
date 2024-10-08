using System;
class Program
{
    // Метод для проверки, является ли число простым
    static bool IsPrime(int number)
    {
        if (number < 2) return false;
        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
    static void Main()
    {
        // Ввод значения K
        Console.Write("Введите количество простых чисел (K): ");
        int K = int.Parse(Console.ReadLine());
        // Массив для хранения простых чисел
        int[] primes = new int[K];
        int count = 0; // Счётчик простых чисел
        int number = 2; // Первое число для проверки на простоту
        // Поиск простых чисел
        while (count < K)
        {
            if (IsPrime(number))
            {
                primes[count] = number;
                count++;
            }
            number++;
        }
        // Вывод простых чисел по 10 в строке
        Console.WriteLine("Первые {0} простых чисел:", K);
        for (int i = 0; i < K; i++)
        {
            Console.Write(primes[i] + "\t");
            if ((i + 1) % 10 == 0) // Переход на новую строку каждые 10 чисел
            {
                Console.WriteLine();
            }
        }
        Console.WriteLine(); // Для завершения вывода новой строкой
    }
}
