namespace A;

class Program
{
    static void Main(string[] args)
    { Console.WriteLine("Выберите задачу:\n1. Подмассив с максимальной суммой\n2. Сортировка и анализ уникальных элементов\n3. Частотный анализ");
            int taskNumber = int.Parse(Console.ReadLine());

            switch (taskNumber)
            {
                case 1: MaxSumSubarray(); break; 
                case 2: SortAndUniqueCount(); break; 
                case 3: FrequencyAnalysis(); break;
            }
        }

        // Задание 1
        static void MaxSumSubarray()
        {
            Console.Write("Введите длину массива: ");
            int length = int.Parse(Console.ReadLine());
            int[] numbers = new int[length];

            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < length; i++) numbers[i] = int.Parse(Console.ReadLine());

            Console.Write("Введите длину подмассива N: ");
            int N = int.Parse(Console.ReadLine());

            int maxSum = int.MinValue, startIndex = 0;
            for (int i = 0; i <= length - N; i++)
            {
                int currentSum = 0;
                for (int j = 0; j < N; j++) currentSum += numbers[i + j];
                if (currentSum > maxSum) { maxSum = currentSum; startIndex = i; }
            }

            Console.WriteLine("Подмассив с максимальной суммой: " + string.Join(" ", numbers[startIndex..(startIndex + N)]));
        }

        // Задание 2
        static void SortAndUniqueCount()
        {
            Random random = new Random();
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++) numbers[i] = random.Next(1, 21);

            Array.Sort(numbers);
            HashSet<int> uniqueElements = new HashSet<int>(numbers);

            Console.WriteLine("Отсортированный массив: " + string.Join(" ", numbers));
            Console.WriteLine($"Количество уникальных элементов: {uniqueElements.Count}");
        }

        // Задание 3
        static void FrequencyAnalysis()
        {
            Console.Write("Введите длину массива: ");
            int length = int.Parse(Console.ReadLine());
            int[] numbers = new int[length];

            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < length; i++) numbers[i] = int.Parse(Console.ReadLine());

            var frequency = new Dictionary<int, int>();
            foreach (var number in numbers) frequency[number] = frequency.GetValueOrDefault(number, 0) + 1;

            int maxCount = 0;
            var mostFrequentNumbers = new List<int>();
            foreach (var pair in frequency)
            {
                if (pair.Value > maxCount)
                {
                    maxCount = pair.Value;
                    mostFrequentNumbers.Clear();
                    mostFrequentNumbers.Add(pair.Key);
                }
                else if (pair.Value == maxCount)
                {
                    mostFrequentNumbers.Add(pair.Key);
                }
            }

            Console.WriteLine($"Число(а), встречающееся чаще всего ({maxCount} раз): {string.Join(", ", mostFrequentNumbers)}");
        }
    }
