namespace _14;

class Program
{
    static void Main(string[] args)
    {
        int[] sortedArray = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
        int target = 7;

        int index = BinarySearch(sortedArray, target, 0, sortedArray.Length - 1);

        if (index != -1)
        {
            Console.WriteLine($"Элемент {target} найден на индексе {index}.");
        }
        else
        {
            Console.WriteLine($"Элемент {target} не найден в массиве.");
        }
    }

    static int BinarySearch(int[] array, int target, int left, int right)
    {
        
        if (left > right)
        {
            return -1; 
        }

       int mid = left + (right - left) / 2;

       
        if (array[mid] == target)
        {
            return mid; 
        }
        else if (array[mid] > target)
        {
            return BinarySearch(array, target, left, mid - 1);
        }
        else
        {
            return BinarySearch(array, target, mid + 1, right);
        }
    }
}