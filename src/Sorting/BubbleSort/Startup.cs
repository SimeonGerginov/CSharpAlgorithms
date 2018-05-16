using System;
using System.Linq;

namespace BubbleSort
{
    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Please enter the array of numbers:");

            int[] arrayOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine();

            BubbleSortAlgorithm(arrayOfNumbers);

            Console.WriteLine("Sorted array:");
            Console.WriteLine(string.Join(" ", arrayOfNumbers));
        }

        private static void BubbleSortAlgorithm(int[] arrayOfNumbers)
        {
            bool swapped;
            for (int i = 0; i < arrayOfNumbers.Length - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < arrayOfNumbers.Length - i - 1; j++)
                {
                    if (arrayOfNumbers[j] > arrayOfNumbers[j + 1])
                    {
                        int temp = arrayOfNumbers[j];
                        arrayOfNumbers[j] = arrayOfNumbers[j + 1];
                        arrayOfNumbers[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (!swapped)
                {
                    break;
                }
            }
        }
    }
}
