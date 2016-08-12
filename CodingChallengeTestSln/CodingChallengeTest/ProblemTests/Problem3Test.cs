using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingChallenge.Problems;

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
            Assert.AreEqual(3, Problem3.maxStep(2, 2));
        }

        [TestMethod]
        public void TestBadStepHitOutput()
        {
            Assert.AreEqual(2, Problem3.maxStep(2, 1));
        }

        [TestMethod]
        public void TestMinInputValues()
        {
            Assert.AreEqual(0, Problem3.maxStep(1, 1));
        }

        [TestMethod]
        public void TestMaxInputValues()
        {            
            Assert.AreEqual(2001000, Problem3.maxStep(2000, 4000000));
        }
    }
}
