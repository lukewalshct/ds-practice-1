using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingChallenge.Problems;

namespace CodingChallengeTest.ProblemTests
{
    [TestClass]
    public class Problem1Test
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            "Cannot pass a null array.")]
        public void IfNullArrayThrowNullArgException()
        {
            Problem1.mergeArray(new int[3], null, 3);            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),  
            "Number of elements (parameter M) does not match array length specifications.")]
        public void IfIncorrectMValueThrowArgException()
        {
            Problem1.mergeArray(new int[3], new int[6], 4);
        }
    }
}