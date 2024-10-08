using System;
using System.Linq;
class Program
{
    // Метод для проверки, является ли буква согласной
    static bool IsConsonant(char letter)
    {
        // Массив согласных букв русского алфавита
        char[] consonants = { 'б', 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ' };
        return consonants.Contains(char.ToLower(letter));
    }
    static void Main()
    {
        // Ввод размера массива K
        Console.Write("Введите размер массива (K): ");
        int K = int.Parse(Console.ReadLine());
        // Массив русского алфавита
        char[] russianAlphabet = "абвгдеёжзийклмнопрстуфхцчшщыэюя".ToCharArray();
        // Инициализация символьного массива и генерация случайных букв
        char[] array = new char[K];
        Random rand = new Random();
        for (int i = 0; i < K; i++)
        {
            // Присваиваем случайную букву из русского алфавита
            array[i] = russianAlphabet[rand.Next(russianAlphabet.Length)];
        }
        // Создание нового массива только с согласными буквами
        char[] consonantArray = array.Where(IsConsonant).ToArray();
        // Вывод исходного массива
        Console.WriteLine("Исходный массив:");
        foreach (char c in array)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine();
        // Вывод массива с согласными буквами
        Console.WriteLine("Массив с согласными буквами:");
        foreach (char c in consonantArray)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine();
    }
}
