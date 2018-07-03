using System;
using System.Linq;

namespace CountingSort
{
    public class Startup
    {
        private const int arrayLength = 10;

        public static void Main()
        {
            Console.WriteLine("Each number should be between 0 and 9!");
            Console.WriteLine("Please enter the array of numbers:");

            int[] arrayOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine();

            arrayOfNumbers = CountingSortAlgorithm(arrayOfNumbers);

            Console.WriteLine("Sorted array:");
            Console.WriteLine(string.Join(" ", arrayOfNumbers));
        }

        public static int[] CountingSortAlgorithm(int[] arrayOfNumbers)
        {
            var countArray = new int[arrayLength];
            var sortedArray = new int[arrayLength];
            var currentIndex = 0;

            foreach (var number in arrayOfNumbers)
            {
                countArray[number]++;
            }

            for (int number = 0; number < countArray.Length; number++)
            {
                var count = countArray[number];

                for (int i = 0; i < count; i++)
                {
                    sortedArray[currentIndex] = number;
                    currentIndex++;
                }
            }

            return sortedArray;
        }
    }
}
