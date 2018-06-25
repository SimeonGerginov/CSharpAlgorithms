using System;
using System.Linq;

namespace InsertionSort
{
    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Please enter the array of numbers:");

            int[] arrayOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine();

            InsertionSortAlgorithm(arrayOfNumbers);

            Console.WriteLine("Sorted array:");
            Console.WriteLine(string.Join(" ", arrayOfNumbers));
        }

        private static void InsertionSortAlgorithm(int[] arrayOfNumbers)
        {
            for (int i = 1; i < arrayOfNumbers.Length; i++)
            {
                int element = arrayOfNumbers[i];
                int j = i - 1;

                while (j >= 0 && arrayOfNumbers[j] > element)
                {
                    arrayOfNumbers[j + 1] = arrayOfNumbers[j];
                    j--;
                }

                arrayOfNumbers[j + 1] = element;
            }
        }
    }
}
