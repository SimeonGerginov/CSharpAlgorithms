using System;

namespace UniqueCharacters
{
    public class Startup
    {
        private const int CharactersCount = 128;

        public static void Main()
        {
            var charactersString = Console.ReadLine();

            bool hasAllUniqueCharacters = HasAllUniqueCharacters(charactersString);

            Console.WriteLine(hasAllUniqueCharacters);
        }

        /// <summary>
        /// Algorithm to determine if a string has all unique characters.
        /// </summary>
        private static bool HasAllUniqueCharacters(string charactersString)
        {
            var charactersSet = new bool[CharactersCount];

            foreach (var character in charactersString)
            {
                if (charactersSet[character])
                {
                    return false;
                }

                charactersSet[character] = true;
            }

            return true;
        }
    }
}
