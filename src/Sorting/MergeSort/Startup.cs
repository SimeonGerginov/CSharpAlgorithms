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

            MergeSortAlgorithm(arrayOfNumbers);

            Console.WriteLine("Sorted array:");
            Console.WriteLine(string.Join(" ", arrayOfNumbers));
        }

        public static void MergeSortAlgorithm(int[] arrayOfNumbers)
        {
            var helperArray = new int[arrayOfNumbers.Length];

            MergeSortAlgorithm(arrayOfNumbers, helperArray, 0, arrayOfNumbers.Length - 1);
        }

        public static void MergeSortAlgorithm(int[] arrayOfNumbers, int[] helperArray, int low, int high)
        {
            if (low < high)
            {
                int middle = (low + high) / 2;

                MergeSortAlgorithm(arrayOfNumbers, helperArray, low, middle);
                MergeSortAlgorithm(arrayOfNumbers, helperArray, middle + 1, high);

                Merge(arrayOfNumbers, helperArray, low, middle, high);
            }
        }

        public static void Merge(int[] arrayOfNumbers, int[] helperArray, int low, int middle, int high)
        {
            for (int i = low; i <= high; i++)
            {
                helperArray[i] = arrayOfNumbers[i];
            }

            var helperLeft = low;
            var helperRight = middle + 1;
            var current = low;

            while (helperLeft <= middle && helperRight <= high)
            {
                if (helperArray[helperLeft] <= helperArray[helperRight])
                {
                    arrayOfNumbers[current] = helperArray[helperLeft];
                    helperLeft++;
                }
                else
                {
                    arrayOfNumbers[current] = helperArray[helperRight];
                    helperRight++;
                }

                current++;
            }

            var remaining = middle - helperLeft;

            for (int i = 0; i <= remaining; i++)
            {
                arrayOfNumbers[current + i] = helperArray[helperLeft + i];
            }
        }
    }
}
