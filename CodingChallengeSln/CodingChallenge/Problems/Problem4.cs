﻿using CodingChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Problems
{
    /// <summary>
    /// Problem4 is a static class containing the method that solves Problem4 of the 
    /// coding challenge.
    /// </summary>
    public static class Problem4
    {
        /// <summary>
        /// Calculates the population of the clinic with the maximum number of 
        /// immunized patients. 
        /// </summary>
        /// <param name="numCities">Number of cities.</param>
        /// <param name="numClinics">Number of clinics.</param>
        /// <param name="cityPops">City populations.</param>
        /// <returns></returns>
        public static int getMaxImmunized(int numCities, int numClinics, int[] cityPops)
        {
            if(cityPops == null)
            {
                throw new ArgumentNullException("Cannot pass null array.");
            }
            if (!(numCities >= 1 && numCities <= 500000))
            {
                throw new ArgumentOutOfRangeException("Number of cities must be between 1 and 500,000.");
            }
            if (!(numClinics >= 1 && numClinics <= 2000000))
            {
                throw new ArgumentOutOfRangeException("Number of clinics must be between 1 and 2000000");
            }
            if (numCities != cityPops.Length)
            {
                throw new ArgumentException("The number of populations must match the number of cities");
            }


            //create a max-on-top heap of the city populations and "assign" a clinic
            //to each of the cities
            CityMaxHeap cityHeap = new CityMaxHeap(cityPops);            

            //while there are still clinics left to be assigned, assign a clinic to the
            //the city at the top of the heap (i.e. has the largest max population per clinic)     
            //and update the max clinic population, and then re-heapify (handled by CityMaxHeap)
            for(int i = cityHeap.numCities; i <= numClinics; i++)
            {
                cityHeap.addClinic();
            }

            return cityHeap.peek();
        }        
    }
}
