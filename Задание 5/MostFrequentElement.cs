using System;
using System.Collections.Generic;

namespace Задание5
{
    public class MostFrequentElement
    {
        public static int FindMostFrequent(int[] array)
        {
            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
            foreach (var num in array)
            {
                if (frequencyMap.ContainsKey(num))
                {
                    frequencyMap[num]++;
                }
                else
                {
                    frequencyMap[num] = 1;
                }
            }

            int maxCount = 0;
            int mostFrequent = array[0];
            foreach (var kvp in frequencyMap)
            {
                if (kvp.Value > maxCount)
                {
                    maxCount = kvp.Value;
                    mostFrequent = kvp.Key;
                }
            }

            return mostFrequent;
        }
    }
}