using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingChallenge.Problems;
using CodingChallengeTest.TestServices;

namespace CodingChallengeTest.ProblemTests
{
    [TestClass]
    public class Problem2Test
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            "Input string cannot be null.")]
        public void IfNullStringThrowNullArgException()
        {
            Problem2.isPangram(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
            "String must be between 1 and 103 characters.")]
        public void IfStringLengthZeroThrowArgException()
        {
            Problem2.isPangram("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
            "String must be between 1 and 103 characters.")]
        public void IfStringLenthTooLargeThrowArgException()
        {
            string s = new string(' ', 200);
            Assert.IsTrue(s.Length > 103);
            Problem2.isPangram(s);
        }

        [TestMethod]
        public void IfPangramReturn1()
        {
            string s = "We promptly judged antique ivory buckles for the next prize";
            int output = Problem2.isPangram(s);
            Assert.AreEqual(1, output);
            TestLogger.log("Problem2", new string[] { s }, new string[] { output.ToString() });
        }

        [TestMethod]
        public void IfNotPangramReturn0()
        {
            string s = "We promptly judged antique ivory buckles for the prize";
            int output = Problem2.isPangram(s);
            Assert.AreEqual(0, Problem2.isPangram(s));
            TestLogger.log("Problem2", new string[] { s }, new string[] { output.ToString() });
        }
    }
}
