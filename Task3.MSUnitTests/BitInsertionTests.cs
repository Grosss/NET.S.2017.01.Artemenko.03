using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task3;


namespace Task3.MSUnitTests
{
    [TestClass]
    public class BitInsertionTests
    {
        public TestContext TestContext { get; set; }
                
        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.XML",
            "|DataDirectory|\\Data.xml",
            "TestCase",
            DataAccessMethod.Sequential)]
        [DeploymentItem("Task3.MSUnitTests\\Data.xml")]

        [TestMethod]
        public void PassNumbersAndBits_SecondNumberIsInsertedInFirst_ExpectedPositiveTest()
        {
            //Arrange
            if (TestContext.DataRow["FirstNumb"].ToString() == "int.MaxValue")
                TestContext.DataRow["FirstNumb"] = int.MaxValue;
            else if (TestContext.DataRow["FirstNumb"].ToString() == "int.MinValue")
                TestContext.DataRow["FirstNumb"] = int.MinValue;
            var firstNumber = Convert.ToInt32(TestContext.DataRow["firstNumb"]);

            if (TestContext.DataRow["FirstNumb"].ToString() == "int.MaxValue")
                TestContext.DataRow["FirstNumb"] = int.MaxValue;
            else if (TestContext.DataRow["FirstNumb"].ToString() == "int.MinValue")
                TestContext.DataRow["FirstNumb"] = int.MinValue;
            var secondNumber = Convert.ToInt32(TestContext.DataRow["secondNumb"]);

            var firstBitPos = Convert.ToInt32(TestContext.DataRow["firstBitPos"]);
            var secondBitPos = Convert.ToInt32(TestContext.DataRow["secondBitPos"]);

            var expected = Convert.ToInt32(TestContext.DataRow["ExpectedResult"]);

            //Act
            var actual = BitInsertion.PassNumbersAndBits(firstNumber, secondNumber, firstBitPos, secondBitPos);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.XML",
            "|DataDirectory|\\Data.xml",
            "TestCase1",
            DataAccessMethod.Sequential)]

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void PassNumbersAndBits_SecondNumberIsInsertedInFirst_ThrowsArgumentOutOfRangeException()
        {
            var firstNumber = Convert.ToInt32(TestContext.DataRow["FirstNumb"]);
            var secondNumber = Convert.ToInt32(TestContext.DataRow["secondNumb"]);
            var firstBitPos = Convert.ToInt32(TestContext.DataRow["firstBitPos"]);
            var secondBitPos = Convert.ToInt32(TestContext.DataRow["secondBitPos"]);
            var actual = BitInsertion.PassNumbersAndBits(firstNumber, secondNumber, firstBitPos, secondBitPos);
        }

        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.XML",
            "|DataDirectory|\\Data.xml",
            "TestCase2",
            DataAccessMethod.Sequential)]


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PassNumbersAndBits_SecondNumberIsInsertedInFirst_ThrowsArgumentException()
        {
            var firstNumber = Convert.ToInt32(TestContext.DataRow["FirstNumb"].ToString());
            var secondNumber = Convert.ToInt32(TestContext.DataRow["secondNumb"]);
            var firstBitPos = Convert.ToInt32(TestContext.DataRow["firstBitPos"]);
            var secondBitPos = Convert.ToInt32(TestContext.DataRow["secondBitPos"]);
            var actual = BitInsertion.PassNumbersAndBits(firstNumber, secondNumber, firstBitPos, secondBitPos);

        }

    }
}