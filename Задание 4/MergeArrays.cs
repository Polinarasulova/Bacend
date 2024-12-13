using System;

namespace Задание4
{
    public class MergeArrays
    {
        // Метод для слияния двух массивов
        public static int[] Merge(int[] array1, int[] array2)
        {
            int[] result = new int[array1.Length + array2.Length];
            Array.Copy(array1, result, array1.Length);
            Array.Copy(array2, 0, result, array1.Length, array2.Length);
            return result;
        }
    }
}