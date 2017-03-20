using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Tests
{
    [TestFixture]
    public class StringHelperTests
    {
        [TestCase("xyaabbbccccdefww", "xxxxyyyyabklmopq", ExpectedResult = "abcdefklmopqwxy")]
        [TestCase("abcdefghijklmnopqrstuvwxyz", "abcdefghijklmnopqrstuvwxyz", ExpectedResult = "abcdefghijklmnopqrstuvwxyz")]
        public string ConcatAndSort_PassingValidStrings_ExpectedPositiveTest(string str1, string str2)
        {
            return StringHelper.ConcatAndSort(str1, str2);
        }

        [TestCase(null, null)]
        [TestCase(null, "asedfsa")]
        public void ConcatAndSort_PassingNullReferenceString_ThrowsArgumentNullException(string str1, string str2)
        {
            Assert.Throws<ArgumentNullException>(() => StringHelper.ConcatAndSort(str1, str2));
        }

        [TestCase("", "")]
        public void ConcatAndSort_PassingTwoEmptyStrings_ThrowsArgumentException(string str1, string str2)
        {
            Assert.Throws<ArgumentException>(() => StringHelper.ConcatAndSort(str1, str2));
        }        
    }
}
