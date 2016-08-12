using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Problems
{
     /// <summary>
    /// Problem2 is a static class containing the method that solves Problem2 of the 
    /// coding challenge.
    /// </summary>
    public static class Problem2
    {
        /// <summary>
        /// Checks if a string is a pangram.
        /// </summary>
        /// <param name="s">String to check for pangram property.</param>
        /// <returns>1 if is pangram else 0.</returns>
        public static int isPangram(string s)
        {
            if(s == null)
            {
                throw new ArgumentNullException("Input string cannot be null.");
            }
            if (s.Length == 0 || s.Length > 103)
            {
                throw new ArgumentOutOfRangeException("String must be between 1 and 103 characters.");
            }

            s = s.ToLower();
            //create hashset that represents chars that haven't been found yet in the string
            HashSet<char> remainingChars = createRemainingCharsSet();

            for(int i = 0; i < s.Length; i++)
            {                
                remainingChars.Remove(s[i]);
            }

            return remainingChars.Count == 0 ? 1 : 0;
        }

        /// <summary>
        /// Creates hashset of all lowercase alphabet (a-z) characters.
        /// </summary>
        /// <returns>Hashset of all lowercase alphabet (a-z) characters.</returns>
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
