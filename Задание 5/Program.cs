using System;

namespace Задание5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Поиск часто встречающегося элемента
            int[] array = { 1, 2, 3, 1, 2, 1, 4, 5 };
            int mostFrequent = MostFrequentElement.FindMostFrequent(array);
            Console.WriteLine("Most Frequent Element: " + mostFrequent);

            // Транспонирование матрицы
            int[,] matrix = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };
            int[,] transposedMatrix = TransposeMatrix.Transpose(matrix);
            Console.WriteLine("Transposed Matrix:");
            TransposeMatrix.PrintMatrix(transposedMatrix);
        }
    }
}