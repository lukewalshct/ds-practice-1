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
    static class Problem1
    {
        static void mergeArray(int[] a, int[] b, int M)
        {
            Contract.Requires<ArgumentNullException>(a != null && b != null, 
                "Cannot pass a null array.");
            Contract.Requires<ArgumentException>(M == a.Length && M == b.Length, 
                "Integer M must match both array lengths.");
            Contract.Requires<ArgumentException>(M == a.Length && M == b.Length, 
        }
    }
}
