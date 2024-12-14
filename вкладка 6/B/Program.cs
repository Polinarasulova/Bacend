namespace B;

class Program
{
    static void Main(string[] args)
    {
       int[] array = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            var result = MaxSubArray(array);
            
            Console.WriteLine("Подмассив с максимальной суммой: " + string.Join(", ", result));
        }

        static int[] MaxSubArray(int[] nums)
        {
            int maxSoFar = int.MinValue; 
            int maxEndingHere = 0; 
            int start = 0;
            int end = 0; 
            int tempStart = 0; 

            for (int i = 0; i < nums.Length; i++)
            {
                maxEndingHere += nums[i];

                if (maxSoFar < maxEndingHere)
                {
                    maxSoFar = maxEndingHere;
                    start = tempStart; 
                    end = i; 
                }

                if (maxEndingHere < 0)
                {
                    maxEndingHere = 0; 
                    tempStart = i + 1; 
                }
            }

            // Возвращаем подмассив с максимальной суммой
            int[] maxSubArray = new int[end - start + 1];
            Array.Copy(nums, start, maxSubArray, 0, end - start + 1);
            return maxSubArray;
        }
    }

        