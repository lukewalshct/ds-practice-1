using CodingChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Problems
{
    class Problem4
    {
        public static int getMaxImmunized(int N, int B, int[] cityPops)
        {
            if(cityPops == null)
            {
                throw new ArgumentNullException("Cannot pass null array.");
            }
            if(N != cityPops.Length)
            {
                throw new ArgumentException("The number of populations must match the number of cities");
            }

            //create a mzx on top heap of the city populations
            MaxHeap maxPopHeap = new MaxHeap(cityPops);
            int maxPop;

            //While the num items in heap is < num clinics, remove the largest population from
            //heap, split it in half, and insert the two "sub-populations"            
            for(int i = maxPopHeap.numItems; i < B; i++)
            {
                maxPop = maxPopHeap.remove();

                int[] popSplits = split(maxPop);
                addSplitPops(maxPopHeap, popSplits);                
            }

            return maxPopHeap.peek();
        }

        private static int[] split(int maxPop)
        {
            int[] split = new int[2];

            if(maxPop % 2 ==1)
            {
                split[0] = maxPop / 2;
                split[1] = (maxPop / 2) + 1;
            }
            else
            {
                split[0] = split[1] = maxPop / 2;
            }

            return split;
        }

        private static void addSplitPops(MaxHeap heap, int[] toAdd)
        {
            for(int i = 0; i < toAdd.Length; i++)
            {
                heap.insert(toAdd[i]);
            }
        }
    }
}
