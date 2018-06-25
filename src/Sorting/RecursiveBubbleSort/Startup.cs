using System;
using System.Linq;

namespace RecursiveBubbleSort
{
    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Please enter the array of numbers:");

            int[] arrayOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int arrayLength = arrayOfNumbers.Length;
            Console.WriteLine();

            RecursiveBubbleSortAlgorithm(arrayOfNumbers, arrayLength);

            Console.WriteLine("Sorted array:");
            Console.WriteLine(string.Join(" ", arrayOfNumbers));
        }

        private static void RecursiveBubbleSortAlgorithm(int[] arrayOfNumbers, int arrayLength)
        {
            if (arrayLength == 1)
            {
                return;
            }

            for (int i = 0; i < arrayLength - 1; i++)
            {
                if (arrayOfNumbers[i] > arrayOfNumbers[i + 1])
                {
                    int temp = arrayOfNumbers[i];
                    arrayOfNumbers[i] = arrayOfNumbers[i + 1];
                    arrayOfNumbers[i + 1] = temp;
                }
            }

            RecursiveBubbleSortAlgorithm(arrayOfNumbers, arrayLength - 1);
        }
    }
}
