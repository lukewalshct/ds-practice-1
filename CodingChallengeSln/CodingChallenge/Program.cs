using CodingChallenge.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 3, 5, 7 };
            int[] b = new int[] { 2, 4, 6, 0, 0, 0 };
            printArray(a);
            printArray(b);
            Problem1.mergeArray(a, b, a.Length);
            printArray(b);
        }

        private static void printArray(int[] a)
        {
            Console.WriteLine("{");
            for(int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + ", ");
            }
            Console.WriteLine("}");
        }
    }
}
