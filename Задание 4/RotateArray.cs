using System;

namespace Задание4
{
    public class RotateArray
    {
        // Метод для ротации массива
        public static void Rotate(int[] array, int positions)
        {
            int length = array.Length;
            positions = positions % length; // Обработка случаев, когда positions > length
            Reverse(array, 0, length - 1);
            Reverse(array, 0, positions - 1);
            Reverse(array, positions, length - 1);
        }

        // Метод для реверсирования части массива
        private static void Reverse(int[] array, int start, int end)
        {
            while (start < end)
            {
                int temp = array[start];
                array[start] = array[end];
                array[end] = temp;
                start++;
                end--;
            }
        }
    }
}