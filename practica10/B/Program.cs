namespace B;

class Program
{
    static void Main(string[] args)
    {
         
        int[] array = { 1, 2, 3, 4, 5 };
        int k = 2;
        Console.WriteLine("Исходный массив: " + string.Join(", ", array));
        RotateArray(array, k);
        Console.WriteLine("Измененный массив после ротации на " + k + " позиций: " + string.Join(", ", array));

        int[] array1 = { 1, 2, 3, 4, 5 };
        int[] array2 = { 4, 5, 6, 7, 8 };
        var commonElements = GetCommonElements(array1, array2);
        Console.WriteLine("Общие элементы: " + string.Join(", ", commonElements));
    }

    static void RotateArray(int[] arr, int k)
    {
        int n = arr.Length;
        k %= n; 
        Array.Reverse(arr, 0, n);
        Array.Reverse(arr, 0, k);
        Array.Reverse(arr, k, n - k);
    }

    static List<int> GetCommonElements(int[] arr1, int[] arr2)
    {
        HashSet<int> set1 = new HashSet<int>(arr1);
        HashSet<int> set2 = new HashSet<int>(arr2);
        set1.IntersectWith(set2); /
        return new List<int>(set1);
    }
}
    