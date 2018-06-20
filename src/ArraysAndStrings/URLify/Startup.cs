using System;
using System.Text;

namespace URLify
{
    public class Startup
    {
        public static void Main()
        {
            var charactersString = Console.ReadLine().TrimEnd(new [] {' '});

            var replacedString = ReplacedString(charactersString);

            Console.WriteLine(replacedString);
        }

        /// <summary>
        /// Method to replace all spaces in a string with '%20'.
        /// </summary>
        private static string ReplacedString(string charactersString)
        {
            var sb = new StringBuilder();

            foreach (var character in charactersString)
            {
                if (character != ' ')
                {
                    sb.Append(character);
                }
                else
                {
                    sb.Append("%20");
                }
            }

            return sb.ToString();
        }
    }
}
