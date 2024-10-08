using System;
class Program
{
    static void Main(string[] args)
    {
        // Создаем объект для генерации случайных чисел
        Random random = new Random();
        int targetNumber = random.Next(1, 101); // Генерируем случайное число от 1 до 100
        int guess = 0;  // Переменная для хранения догадок пользователя
        int attempts = 0;  // Переменная для подсчета попыток
        Console.WriteLine("Игра 'Угадай число'!");
        Console.WriteLine("Я загадал число от 1 до 100. Попробуй его угадать!");
        // Цикл продолжается, пока пользователь не угадает число
        while (guess != targetNumber)
        {
            Console.Write("\nВведите ваше число: ");
            // Считываем ввод от пользователя и проверяем его на корректность
            if (int.TryParse(Console.ReadLine(), out guess))
            {
                attempts++;  // Увеличиваем количество попыток
                if (guess < targetNumber)
                {
                    Console.WriteLine("Загаданное число больше.");
                }
                else if (guess > targetNumber)
                {
                    Console.WriteLine("Загаданное число меньше.");
                }
                else
                {
                    Console.WriteLine($"Поздравляю! Вы угадали число {targetNumber} с {attempts} попытки.");
                }
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите корректное целое число.");
            }
        }
    }
}
