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
        public static void mergeArray(int[] a, int[] b, int M)
        {
            //Contract.Requires<ArgumentNullException>(a != null && b != null, 
            //    "Cannot pass a null array.");
            //Contract.Requires<ArgumentException>(M == a.Length && M == 2*b.Length, 
            //    "Invalid value for parameter M.");
            
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
    }
}
