using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Tests
{
    [TestFixture]
    public class ArrayToolsTests
    {
        [TestCase(new int[] { 1, 100, 50, -51, 1, 1 }, ExpectedResult = 1)]
        [TestCase(new int[] { 1, 2, 3, 4, 3, 2, 1 }, ExpectedResult = 3)]
        [TestCase(new int[] { 14, 21, -12, 32, -139, 67 }, ExpectedResult = -1)]
        public int FindArrayCenter_PassingValidArrayOfNumbers_ExpectedPositiveTest(int[] array)
        {
            return ArrayTools.FindArrayCenter(array);
        }

        [TestCase(new int[] { })]
        public void FindArrayCenter_PassingArrayOfNumbersWithInvalidLength_ThrowsArgumentOutOfRangeException(int[] array)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => ArrayTools.FindArrayCenter(array));
        }

        [TestCase(null)]
        public void FindArrayCenter_PassingNullReference_ThrowsArgumentNullException(int[] array)
        {
            Assert.Throws<ArgumentNullException>(() => ArrayTools.FindArrayCenter(array));
        }
    }
}
