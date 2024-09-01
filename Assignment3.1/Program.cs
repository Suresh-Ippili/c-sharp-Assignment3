using System.Reflection;

namespace Assignment3._1
{
    using System;

    class Program
    {
        static void Main()
        {
            int[] array = { 1, 2, 3, 2, 1, 5, 6, 7, 5, 5, 8 };

            int duplicatesCount = CountDuplicates(array);
            Console.WriteLine($"Total number of duplicate elements: {duplicatesCount}");
        }

        static int CountDuplicates(int[] array)
        {
            int count = 0;
            bool[] visited = new bool[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                if (visited[i])
                    continue;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                        visited[j] = true;
                    }
                }
            }

            return count;
        }
    }
}