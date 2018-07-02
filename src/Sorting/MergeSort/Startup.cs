using System;
using System.Linq;

namespace MergeSort
{
    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Please enter the array of numbers:");

            int[] arrayOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine();

            MergeSortAlgorithm(arrayOfNumbers, 0, arrayOfNumbers.Length - 1);

            Console.WriteLine("Sorted array:");
            Console.WriteLine(string.Join(" ", arrayOfNumbers));
        }

        public static void MergeSortAlgorithm(int[] arrayOfNumbers, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSortAlgorithm(arrayOfNumbers, left, middle);
                MergeSortAlgorithm(arrayOfNumbers, middle + 1, right);

                Merge(arrayOfNumbers, left, middle, right);
            }
        }

        public static void Merge(int[] arrayOfNumbers, int left, int middle, int right)
        {
            var leftArrayLength = middle - left + 1;
            var rightArrayLength = right - middle;

            var leftArray = new int[leftArrayLength];
            var rightArray = new int[rightArrayLength];

            for (int i = 0; i < leftArrayLength; i++)
            {
                leftArray[i] = arrayOfNumbers[left + i];
            }

            for (int j = 0; j < rightArrayLength; j++)
            {
                rightArray[j] = arrayOfNumbers[middle + j + 1];
            }

            var leftIndex = 0;
            var rightIndex = 0;
            var mergeIndex = left;

            while (leftIndex < leftArrayLength && rightIndex < rightArrayLength)
            {
                if (leftArray[leftIndex] <= rightArray[rightIndex])
                {
                    arrayOfNumbers[mergeIndex] = leftArray[leftIndex];
                    leftIndex++;
                }
                else
                {
                    arrayOfNumbers[mergeIndex] = rightArray[rightIndex];
                    rightIndex++;
                }

                mergeIndex++;
            }

            while (leftIndex < leftArrayLength)
            {
                arrayOfNumbers[mergeIndex] = leftArray[leftIndex];
                leftIndex++;
                mergeIndex++;
            }

            while (rightIndex < rightArrayLength)
            {
                arrayOfNumbers[mergeIndex] = rightArray[rightIndex];
                rightIndex++;
                mergeIndex++;
            }
        }
    }
}
