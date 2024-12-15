namespace _4;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите числа массива через запятую: ");
        string input = Console.ReadLine();
        int[] arr = Array.ConvertAll(input.Split(','), int.Parse); // Преобразуем строку в массив целых чисел
        int sum = SumArray(arr, arr.Length);
        Console.WriteLine("Сумма элементов массива: " + sum);
    }
    static int SumArray(int[] arr, int n)
    {
        if (n <= 0) 
            return 0;
        return arr[n - 1] + SumArray(arr, n - 1); 
    }
}