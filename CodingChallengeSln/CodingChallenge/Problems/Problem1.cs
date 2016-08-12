using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Problems
{
    /// <summary>
    /// Problem1 is a static class containing the method that solves Problem1 of the 
    /// coding challenge.
    /// </summary>
    public static class Problem1
    {
        /// <summary>
        /// Merges two sorted input arrays, a and b and returns sorted result. 
        /// Both arrays must have M elements, and the capacity of the second array
        /// must equal 2*M.
        /// </summary>
        /// <param name="a">First array.</param>
        /// <param name="b">Second array (capacity = 2*M).</param>
        /// <param name="M">Number elements in each input array.</param>
        public static void mergeArray(int[] a, int[] b, int M)
        {
            if(a == null || b == null)
            {
                throw new ArgumentNullException("Cannot pass a null array.");
            }            
            if (2*M != b.Length)
            {
                throw new ArgumentException("Length of array b must equal twice the number of elements (M).");
            }
            if(!(isSorted(a, M) && isSorted(b, M)))
            {
                throw new ArgumentException("Input arrays must be sorted");
            }

            int indexA = M - 1;
            int indexB = M - 1;

            for (int i = b.Length-1; i >=0; i--)
            {
                if(indexA >= 0 && a[indexA] > b[indexB])
                {
                    b[i] = a[indexA];
                    indexA--;
                }
                else
                {
                    b[i] = b[indexB];
                    indexB--;
                }
            }            
        }

        /// <summary>
        /// Checks that the input array is sorted.
        /// </summary>
        /// <param name="a">Input array.</param>
        /// <param name="M">Number of elements.</param>
        /// <returns></returns>
        private static bool isSorted(int[] a, int M)
        {
            if(a.Length == 0)
            {
                return true;
            }

            int prev = a[0];

            for (int i = 1; i < a.Length && i < M; i++)
            {
                if (a[i]  < prev)
                {
                    return false;
                }
                prev = a[i];
            }

            return true;
        }
    }
}
