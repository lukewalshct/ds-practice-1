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
            //Problem1
            int[] a = new int[] { 3, 5, 7 };
            int[] b = new int[] { 2, 4, 6, 0, 0, 0 };
            printArray(a);
            printArray(b);
            Problem1.mergeArray(a, b, a.Length);
            printArray(b);

            //Problem2
            string n1 = "The quick brown fox jumps over the lazy dog";
            string n2 = "The quick brown fox jumps the lazy dog";
            string n3 = "We promptly judged antique ivory buckles for the next prize";
            string n4 = "We promptly judged antique ivory buckles for the prize";

            Console.WriteLine(Problem2.isPangram(n1));
            Console.WriteLine(Problem2.isPangram(n2));
            Console.WriteLine(Problem2.isPangram(n3));
            Console.WriteLine(Problem2.isPangram(n4));

            //problem 3
            Console.WriteLine("**********Problem3**********");
            Console.WriteLine(Problem3.maxStep(2, 2));
            Console.WriteLine(Problem3.maxStep(2, 1));
            Console.WriteLine(Problem3.maxStep(4, 6));
            Console.WriteLine(Problem3.maxStep(2000, 1000000));

            //problem4
            Console.WriteLine("***********Problem4**********");
            Console.WriteLine(Problem4.getMaxImmunized(2, 7, new int[] { 2000000, 5000000 }));
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
