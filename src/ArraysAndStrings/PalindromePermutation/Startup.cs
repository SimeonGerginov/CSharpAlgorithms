using System;

namespace PalindromePermutation
{
    public class Startup
    {
        private const int CharactersCount = 128;

        public static void Main()
        {
            var charactersString = Console.ReadLine().ToLower();

            var result = IsPermutationPalindrome(charactersString);

            Console.WriteLine(result);
        }

        /// <summary>
        /// Algorithm to check if permutation is palindrome.
        /// </summary>
        private static bool IsPermutationPalindrome(string charactersString)
        {
            var charactersArray = new char[CharactersCount];
            
            foreach (var character in charactersString)
            {
                if (character < 'a' || character > 'z')
                {
                    continue;
                }

                charactersArray[character]++;
            }

            bool foundOdd = false;

            for (int i = 0; i < charactersArray.Length; i++)
            {
                if (charactersArray[i] % 2 == 1)
                {
                    if (foundOdd)
                    {
                        return false;
                    }

                    foundOdd = true;
                }
            }

            return true;
        }
    }
}
