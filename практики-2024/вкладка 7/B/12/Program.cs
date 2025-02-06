namespace _12;

class Program
{
    static void Main(string[] args)
    {
       int[] array = { 34, 7, 23, 32, 5, 62 };
        
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        QuickSort(array, 0, array.Length - 1);

        Console.WriteLine("Отсортированный массив:");
        PrintArray(array);
    }

    static void QuickSort(int[] array, int low, int high)
    {
        if (low < high)
        {
            // Разделяем массив и получаем индекс опорного элемента
            int pivotIndex = Partition(array, low, high);

            // Рекурсивно сортируем элементы до и после опорного элемента
            QuickSort(array, low, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, high);
        }
    }

    static int Partition(int[] array, int low, int high)
    {
        // Выбираем опорный элемент (в данном случае последний элемент)
        int pivot = array[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            // Если текущий элемент меньше или равен опорному
            if (array[j] <= pivot)
            {
                i++;
                // Меняем местами элементы
                Swap(array, i, j);
            }
        }

        // Меняем местами опорный элемент с элементом после последнего меньшего
        Swap(array, i + 1, high);
        return i + 1; // Возвращаем индекс опорного элемента
    }

    static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    static void PrintArray(int[] array)
    {
        Console.WriteLine(string.Join(", ", array));
    }
}