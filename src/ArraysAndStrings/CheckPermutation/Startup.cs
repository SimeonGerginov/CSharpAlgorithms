using System;

namespace CheckPermutation
{
    public class Startup
    {
        public static void Main()
        {
            var firstString = Console.ReadLine();
            var secondString = Console.ReadLine();

            bool checkIfPermutation = CheckIfPermutation(firstString, secondString);

            Console.WriteLine(checkIfPermutation);
        }

        /// <summary>
        ///  Given two strings check if one is a permutation of the other.
        /// </summary>
        private static bool CheckIfPermutation(string firstString, string secondString)
        {
            if (firstString.Length != secondString.Length)
            {
                return false;
            }

            firstString = SortString(firstString);
            secondString = SortString(secondString);

            return firstString == secondString;
        }

        private static string SortString(string stringToSort)
        {
            var stringAsCharArray = stringToSort.ToCharArray();
            Array.Sort(stringAsCharArray);

            return new string(stringAsCharArray);
        }
    }
}
