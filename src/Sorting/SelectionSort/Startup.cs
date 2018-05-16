using System;
using System.Linq;

namespace SelectionSort
{
    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Please enter the array of numbers:");

            int[] arrayOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine();

            SelectionSortAlgorithm(arrayOfNumbers);

            Console.WriteLine("Sorted array:");
            Console.WriteLine(string.Join(" ", arrayOfNumbers));
        }

        private static void SelectionSortAlgorithm(int[] arrayOfNumbers)
        {
            int minIndex;
            for (int i = 0; i < arrayOfNumbers.Length - 1; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < arrayOfNumbers.Length; j++)
                {
                    if (arrayOfNumbers[j] < arrayOfNumbers[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = arrayOfNumbers[minIndex];
                arrayOfNumbers[minIndex] = arrayOfNumbers[i];
                arrayOfNumbers[i] = temp;
            }
        }
    }
}
