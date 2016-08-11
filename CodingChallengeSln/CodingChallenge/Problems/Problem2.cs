using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Problems
{
    public static class Problem2
    {
        public static int isPangram(string N)
        {
            if(N == null)
            {
                throw new ArgumentNullException("String cannot be null.");
            }
            if (N.Length == 0 || N.Length > 103)
            {
                throw new ArgumentOutOfRangeException("String must be between 1 and 103 characters.");
            }

            HashSet<char> remainingChars = createRemainingCharsSet();

            for(int i = 0; i < N.Length; i++)
            {
                remainingChars.Remove(N[i]);
            }

            return remainingChars.Count == 0 ? 1 : 0;
        }

        private static HashSet<char> createRemainingCharsSet()
        {
            HashSet<char> remainingChars = new HashSet<char>();

            for(char c = 'a'; c <= 'z'; c++)
            {
                remainingChars.Add(c);
            }

            return remainingChars;
        }
    }
}
