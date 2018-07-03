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

            QuickSortAlgorithm(arrayOfNumbers);

            Console.WriteLine("Sorted array:");
            Console.WriteLine(string.Join(" ", arrayOfNumbers));
        }

        public static void QuickSortAlgorithm(int[] arrayOfNumbers)
        {
            QuickSortAlgorithm(arrayOfNumbers, 0, arrayOfNumbers.Length - 1);
        }

        public static void QuickSortAlgorithm(int[] arrayOfNumbers, int left, int right)
        {
            var index = Partition(arrayOfNumbers, left, right);

            if (left < index - 1)
            {
                QuickSortAlgorithm(arrayOfNumbers, left, index - 1);
            }
            if (index < right)
            {
                QuickSortAlgorithm(arrayOfNumbers, index, right);
            }
        }

        public static int Partition(int[] arrayOfNumbers, int left, int right)
        {
            var pivot = arrayOfNumbers[(left + right) / 2];

            while (left <= right)
            {
                while (arrayOfNumbers[left] < pivot)
                {
                    left++;
                }

                while (arrayOfNumbers[right] > pivot)
                {
                    right--;
                }

                if (left <= right)
                {
                    var tempNumber = arrayOfNumbers[left];
                    arrayOfNumbers[left] = arrayOfNumbers[right];
                    arrayOfNumbers[right] = tempNumber;

                    left++;
                    right--;
                }
            }

            return left;
        }
    }
}
