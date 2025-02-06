namespace a;

class Program
{
    static void Main(string[] args)
    { 
        //1 задание
        int[] массив = new int[] { 1, 2, 3, 4, 5,  };
            
            Console.WriteLine("массив целых чисел длины 5:");
            for (int i = 0; i < массив.Length; i++)
            {
                Console.WriteLine($"Элемент {i}: {массив[i]}");
            }

            //2 задание
            string[] массивСтрок = new string[3] { "1 строка","2 строка","3 строка"};
            
             Console.WriteLine("массив из трех строк:");
            for (int i = 0; i < массивСтрок.Length; i++)
            {
                Console.WriteLine($"Элемент {i}: {массивСтрок[i]}");
            }
     }
}
