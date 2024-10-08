using System;
using System.Linq;
class Program
{
    static void Main()
    {
        // Ввод размера матрицы (квадратная матрица)
        Console.Write("Введите размер матрицы: ");
        int n = int.Parse(Console.ReadLine());
        // Инициализация генератора случайных чисел
        Random rand = new Random();
        // Создание квадратной матрицы и заполнение случайными числами от -50 до 50
        int[,] matrix = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = rand.Next(-50, 51); // диапазон от -50 до 50 включительно
            }
        }
        // Вывод исходной матрицы
        Console.WriteLine("\nИсходная матрица:");
        PrintMatrix(matrix);
        // Массив для хранения сумм строк
        int[][] matrixRows = new int[n][];
        for (int i = 0; i < n; i++)
        {
            matrixRows[i] = new int[n];
            for (int j = 0; j < n; j++)
            {
                matrixRows[i][j] = matrix[i, j];
            }
        }
        // Сортировка строк матрицы по возрастанию суммы элементов
        var sortedRows = matrixRows.OrderBy(row => row.Sum()).ToArray();
        // Преобразование обратно в двумерный массив
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = sortedRows[i][j];
            }
        }
        // Вывод отсортированной матрицы
        Console.WriteLine("\nМатрица после сортировки строк по возрастанию суммы элементов:");
        PrintMatrix(matrix);
    }
    // Метод для вывода матрицы на экран
    static void PrintMatrix(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
