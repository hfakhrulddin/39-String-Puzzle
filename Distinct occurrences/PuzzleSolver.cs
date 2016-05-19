using System;
using System.Linq;

namespace Distinct_occurrences
{
        public static class PuzzleSolver
        {
            public static string[] DICTIONARY = { "OX", "CAT", "TOY", "AT", "DOG", "CATAPULT", "T" };

            public static bool IsWord(string testWord)
            {
            if (DICTIONARY.Contains(testWord)) {

                Console.WriteLine(testWord);
                return true;
            }
                return false;
            }
        }
}
