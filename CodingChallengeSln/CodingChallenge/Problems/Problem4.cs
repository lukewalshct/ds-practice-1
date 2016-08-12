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

            //create a max on top heap of the city populations and "assign" a clinic
            //to each of the cities
            CityMaxHeap cityHeap = new CityMaxHeap(cityPops);
            int maxPop;

            //while there are still clinics left to be assigned, assign a clinic to the
            //the city at the top of the heap (i.e. has the largest max population per clinic)     
            //and update the max clinic population, and then re-heapify
            for(int i = cityHeap.numCities; i <= B; i++)
            {
                cityHeap.addClinic();
            }

            return cityHeap.peek();
        }        
    }
}
