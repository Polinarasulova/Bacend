namespace _8;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите элементы множества через запятую: ");
        string input = Console.ReadLine();
        string[] set = input.Split(',');

        Console.WriteLine("Все подмножества:");
        GenerateSubsets(set, 0, new string[0]);
    }
    static void GenerateSubsets(string[] set, int index, string[] currentSubset)
    {
       
       
       Console.WriteLine("{" + string.Join(", ", currentSubset) + "}");
        for (int i = index; i < set.Length; i++)
        {
           string[] newSubset = new string[currentSubset.Length + 1];
            Array.Copy(currentSubset, newSubset, currentSubset.Length);
            newSubset[currentSubset.Length] = set[i];

            GenerateSubsets(set, i + 1, newSubset);
        }
    }
}