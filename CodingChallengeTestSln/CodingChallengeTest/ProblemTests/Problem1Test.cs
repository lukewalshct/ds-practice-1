using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingChallenge.Problems;
using System.Linq;
using CodingChallengeTest.TestServices;

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
           "Length of array b must equal twice the number of elements (M).")]
        public void IfIncorrectMValueThrowArgException()
        {
            Problem1.mergeArray(new int[3], new int[8], 3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
           "Input arrays must be sorted.")]
        public void IfUnsortedInputThrowArgException()
        {
            int[] a = new int[] { 1, 3, 2 };
            int[] b = new int[] { 4, 5, 7, 0, 0, 0, };

            Problem1.mergeArray(a, b, 3);
        }

        [TestMethod]
        public void IfCorrectInputNoExtraSpaceCorrectOutput()
        {
            int[] a = new int[] { 8, 12, 16 };
            int[] b = new int[] { 4, 5, 7, 0, 0, 0 };

            //save input as string for logger
            string input1 = ArrayToStringConverter.convert(a);
            string input2 = ArrayToStringConverter.convert(b);

            Problem1.mergeArray(a, b, 3);

            Assert.IsTrue(Enumerable.SequenceEqual(b, new int[] { 4, 5, 7, 8, 12, 16 }));

            //save output as string for logger and log to txt file
            string output = ArrayToStringConverter.convert(b);
            TestLogger.log("Problem1", new string[] { input1, input2 }, new string[] { output });
        }

        [TestMethod]
        public void IfCorrectInputExtraSpaceCorrectOutput()
        {
            int[] a = new int[] { 8, 12, 16, 0, 0, 0, 0, 0 };
            int[] b = new int[] { 4, 5, 7, 0, 0, 0 };

            //save input as string for logger
            string input1 = ArrayToStringConverter.convert(a);
            string input2 = ArrayToStringConverter.convert(b);

            Problem1.mergeArray(a, b, 3);

            Assert.IsTrue(Enumerable.SequenceEqual(b, new int[] { 4, 5, 7, 8, 12, 16 }));

            //save output as string for logger and log to txt file
            string output = ArrayToStringConverter.convert(b);
            TestLogger.log("Problem1", new string[] { input1, input2 }, new string[] { output });
        }

        [TestMethod]
        public void IfEmptyInputArraysReturnEmpty()
        {
            int[] a = new int[] { };
            int[] b = new int[] { };

            //save input as string for logger
            string input1 = ArrayToStringConverter.convert(a);
            string input2 = ArrayToStringConverter.convert(b);

            Problem1.mergeArray(a, b, 0);

            Assert.IsTrue(Enumerable.SequenceEqual(b, new int[] {}));

            //save output as string for logger and log to txt file
            string output = ArrayToStringConverter.convert(b);
            TestLogger.log("Problem1", new string[] { input1, input2 }, new string[] { output });
        }
    }
}