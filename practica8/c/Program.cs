namespace c;

class Program
{
    static void Main(string[] args)
    {
        // Задача 6: Объявление и инициализация пустого массива
            int[] массив = new int[4];
            Console.WriteLine("Пустой массив длиной 4 создан.");

            // Задача 7: Создание массива с помощью оператора new
            int[] масив = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Массив из пяти чисел создан с помощью оператора new: " + string.Join(", ", масив));

            // Задача 8: Инициализация массива символов
            char[] полина = { 'A', 'B', 'C' }; // Инициализируем массив из трёх символов
            Console.WriteLine("Массив символов: " + string.Join(", ", полина));

            // Задача 9: Заполнение массива данными вручную
            int[] manualArray = new int[5]; 
            Console.WriteLine("Введите 5 чисел для заполнения массива:");
            for (int i = 0; i < manualArray.Length; i++)
            {
                Console.Write($"число {i + 1}: ");
                manualArray[i] = int.Parse(Console.ReadLine()); 
            }

            
            Console.WriteLine("массив: " + string.Join(", ", manualArray));
    }
}

