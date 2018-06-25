using System;
using System.Linq;

namespace RecursiveInsertionSort
{
    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Please enter the array of numbers:");

            int[] arrayOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int arrayLength = arrayOfNumbers.Length;
            Console.WriteLine();

            RecursiveInsertionSortAlgorithm(arrayOfNumbers, arrayLength);

            Console.WriteLine("Sorted array:");
            Console.WriteLine(string.Join(" ", arrayOfNumbers));
        }

        private static void RecursiveInsertionSortAlgorithm(int[] arrayOfNumbers, int arrayLength)
        {
            if (arrayLength <= 1)
            {
                return;
            }

            RecursiveInsertionSortAlgorithm(arrayOfNumbers, arrayLength - 1);

            int element = arrayOfNumbers[arrayLength - 1];
            int j = arrayLength - 2;

            while (j >= 0 && arrayOfNumbers[j] > element)
            {
                arrayOfNumbers[j + 1] = arrayOfNumbers[j];
                j--;
            }

            arrayOfNumbers[j + 1] = element;
        }
    }
}
