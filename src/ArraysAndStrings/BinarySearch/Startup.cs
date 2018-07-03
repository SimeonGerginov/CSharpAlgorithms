using System;
using System.Linq;

namespace BinarySearch
{
    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Please enter the array of numbers:");

            int[] arrayOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine();

            Console.WriteLine("Please enter the number to search for:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int result = BinarySearchAlgorithm(arrayOfNumbers, number);

            if (result == -1)
            {
                Console.WriteLine("Number not found!");
            }
            else
            {
                Console.WriteLine($"Number found at position {number}");
            }
        }

        public static int BinarySearchAlgorithm(int[] arrayOfNumbers, int number)
        {
            return BinarySearchAlgorithm(arrayOfNumbers, 0, arrayOfNumbers.Length - 1, number);
        }

        public static int BinarySearchAlgorithm(int[] arrayOfNumbers, int low, int high, int number)
        {
            if (high >= low)
            {
                var middle = (low + high) / 2;

                if (arrayOfNumbers[middle] == number)
                {
                    return middle;
                }
                else if (arrayOfNumbers[middle] > number)
                {
                    return BinarySearchAlgorithm(arrayOfNumbers, low, middle - 1, number);
                }
                else
                {
                    return BinarySearchAlgorithm(arrayOfNumbers, middle + 1, high, number);
                }
            }

            return -1;
        }
    }
}
