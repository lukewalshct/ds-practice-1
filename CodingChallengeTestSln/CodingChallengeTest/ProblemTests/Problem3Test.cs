using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingChallenge.Problems;
using CodingChallengeTest.TestServices;

namespace CodingChallengeTest.ProblemTests
{
    [TestClass]
    public class Problem3Test
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
            "Total moves must be between 1 and 2,000.")]
        public void IfMovesTooLowThrowArgException()
        {
            Problem3.maxStep(0, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
            "Total moves must be between 1 and 2,000.")]
        public void IfMovesTooHighThrowArgException()
        {
            Problem3.maxStep(2001, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
            "Bad step number must be between 1 and 4,000,000")]
        public void IfBadStepTooLowThrowArgException()
        {
            Problem3.maxStep(5, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
            "Bad step number must be between 1 and 4,000,000")]
        public void IfBadStepTooHighThrowArgException()
        {
            Problem3.maxStep(5, 40000001);
        }

        [TestMethod]
        public void TestBadStepSkippedOutput()
        {
            int output = Problem3.maxStep(2, 2);
            Assert.AreEqual(3, output);
            TestLogger.log("Problem3", new string[] { "2", "2" }, new string[] { output.ToString() });
        }

        [TestMethod]
        public void TestBadStepHitOutput()
        {
            int output = Problem3.maxStep(2, 1);
            Assert.AreEqual(2, output);
            TestLogger.log("Problem3", new string[] { "2", "1" }, new string[] { output.ToString() });
        }

        [TestMethod]
        public void TestMinInputValues()
        {
            int output = Problem3.maxStep(1, 1);
            Assert.AreEqual(0, output);
            TestLogger.log("Problem3", new string[] { "1", "1" }, new string[] { output.ToString() });
        }

        [TestMethod]
        public void TestMaxInputValues()
        {
            int output = Problem3.maxStep(2000, 4000000);
            Assert.AreEqual(2001000, output);
            TestLogger.log("Problem3", new string[] { "2000", "4000000" }, new string[] { output.ToString() });
        }
    }
}
