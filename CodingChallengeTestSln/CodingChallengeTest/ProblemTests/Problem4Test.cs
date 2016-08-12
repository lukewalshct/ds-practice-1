using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingChallenge.Problems;
using CodingChallengeTest.TestServices;

namespace CodingChallengeTest.ProblemTests
{
    [TestClass]
    public class Problem4Test
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            "Cannot pass null array.")]
        public void IfNullCitiesArrayThrowNullArgException()
        {
            Problem4.getMaxImmunized(1, 1, null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "The number of populations must match the number of cities")]
        public void IfNumCitiesNotEqualArrayLengthThrowArgException()
        {
            Problem4.getMaxImmunized(1, 1, new int[] { 100, 200 });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
            "Number of cities must be between 1 and 500,000.")]
        public void IfNumCitiesTooLowThrowArgException()
        {
            Problem4.getMaxImmunized(0, 1, new int[] { 100, 200 });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
            "Number of cities must be between 1 and 500,000.")]
        public void IfNumCitiesTooHighThrowArgException()
        {
            Problem4.getMaxImmunized(500001, 1, new int[] { 100, 200 });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
            "Number of clinics must be between 1 and 2000000")]
        public void IfNumClinicsTooLowThrowArgException()
        {
            Problem4.getMaxImmunized(1, 0, new int[] { 100, 200 });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
            "Number of clinics must be between 1 and 2000000")]
        public void IfNumClinicsTooHighThrowArgException()
        {
            Problem4.getMaxImmunized(1, 2000001, new int[] { 100, 200 });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
            "City populations must be between 1 and 5,000,000.")]
        public void IfCityPopTooLowThrowArgException()
        {
            Problem4.getMaxImmunized(1, 1, new int[] { 0 });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
            "City populations must be between 1 and 5,000,000.")]
        public void IfCityPopTooHighThrowArgException()
        {
            Problem4.getMaxImmunized(1, 1, new int[] { 5000001 });
        }

        [TestMethod]
        public void TestCorrectInput()
        {
            int output = Problem4.getMaxImmunized(2, 7, new int[] { 200000, 500000 });
            Assert.AreEqual(100000, output);
            TestLogger.log("Problem4", new string[] { "2", "7" }, new string[] { output.ToString() });
        }

        [TestMethod]
        public void TestMinInputValues()
        {
            int output = Problem4.getMaxImmunized(1, 1, new int[] { 1 });
            Assert.AreEqual(1, output);
            TestLogger.log("Problem4", new string[] { "1", "1" }, new string[] { output.ToString() });
        }

        [TestMethod]
        public void TestMaxInputValues()
        {
            int[] citiesPops = new int[500000];
            for(int i = 0; i < citiesPops.Length; i++)
            {
                citiesPops[i] = 5000000;
            }
            int result = Problem4.getMaxImmunized(500000, 2000000, citiesPops);
            Assert.AreEqual(1250000, result );
            //did not log results due to large input size
        }
    }
}
