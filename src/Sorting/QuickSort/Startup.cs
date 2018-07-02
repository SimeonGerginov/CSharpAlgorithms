using System;
using System.Linq;

namespace QuickSort
{
    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Please enter the array of numbers:");

            int[] arrayOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine();

            QuickSortAlgorithm(arrayOfNumbers, 0, arrayOfNumbers.Length - 1);

            Console.WriteLine("Sorted array:");
            Console.WriteLine(string.Join(" ", arrayOfNumbers));
        }

        public static void QuickSortAlgorithm(int[] arrayOfNumbers, int startIndex, int endIndex)
        {
            if (startIndex < endIndex)
            {
                int pivotIndex = Partition(arrayOfNumbers, startIndex, endIndex);

                QuickSortAlgorithm(arrayOfNumbers, startIndex, pivotIndex - 1);
                QuickSortAlgorithm(arrayOfNumbers, pivotIndex + 1, endIndex);
            }
        }

        public static int Partition(int[] arrayOfNumbers, int startIndex, int endIndex)
        {
            var pivot = arrayOfNumbers[endIndex];
            var index = startIndex - 1;
            var tempNumber = 0;

            for (int i = startIndex; i < endIndex; i++)
            {
                if (arrayOfNumbers[i] <= pivot)
                {
                    index++;
                    tempNumber = arrayOfNumbers[i];
                    arrayOfNumbers[i] = arrayOfNumbers[index];
                    arrayOfNumbers[index] = tempNumber;
                }
            }

            tempNumber = arrayOfNumbers[index + 1];
            arrayOfNumbers[index + 1] = arrayOfNumbers[endIndex];
            arrayOfNumbers[endIndex] = tempNumber;

            return index + 1;
        }
    }
}
