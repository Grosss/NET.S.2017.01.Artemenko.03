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
            "TestCase1",
            DataAccessMethod.Sequential)]
        [DeploymentItem("Task3.MSUnitTests\\Data.xml")]

        [TestMethod]
        public void PassNumbersAndBits_SecondNumberIsInsertedInFirst_ExpectedPositiveTest()
        {
            //Arrange
            if (TestContext.DataRow["firstNumb"].ToString() == "int.MaxValue")
                TestContext.DataRow["firstNumb"] = int.MaxValue;
            else if (TestContext.DataRow["firstNumb"].ToString() == "int.MinValue")
                TestContext.DataRow["firstNumb"] = int.MinValue;

            if (TestContext.DataRow["secondNumb"].ToString() == "int.MaxValue")
                TestContext.DataRow["secondNumb"] = int.MaxValue;
            else if (TestContext.DataRow["secondNumb"].ToString() == "int.MinValue")
                TestContext.DataRow["secondNumb"] = int.MinValue;

            if (TestContext.DataRow["ExpectedResult"].ToString() == "int.MaxValue")
                TestContext.DataRow["ExpectedResult"] = int.MaxValue;
            else if (TestContext.DataRow["ExpectedResult"].ToString() == "int.MinValue")
                TestContext.DataRow["ExpectedResult"] = int.MinValue;

            var firstNumber = Convert.ToInt32(TestContext.DataRow["firstNumb"]);
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
            "TestCase2",
            DataAccessMethod.Sequential)]
        [DeploymentItem("Task3.MSUnitTests\\Data.xml")]

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void PassNumbersAndBits_SecondNumberIsInsertedInFirst_ThrowsArgumentOutOfRangeException()
        {
            if (TestContext.DataRow["firstNumb"].ToString() == "int.MaxValue")
                TestContext.DataRow["firstNumb"] = int.MaxValue;
            else if (TestContext.DataRow["firstNumb"].ToString() == "int.MinValue")
                TestContext.DataRow["firstNumb"] = int.MinValue;

            if (TestContext.DataRow["secondNumb"].ToString() == "int.MaxValue")
                TestContext.DataRow["secondNumb"] = int.MaxValue;
            else if (TestContext.DataRow["secondNumb"].ToString() == "int.MinValue")
                TestContext.DataRow["secondNumb"] = int.MinValue;

            var firstNumber = Convert.ToInt32(TestContext.DataRow["firstNumb"]);
            var secondNumber = Convert.ToInt32(TestContext.DataRow["secondNumb"]);
            var firstBitPos = Convert.ToInt32(TestContext.DataRow["firstBitPos"]);
            var secondBitPos = Convert.ToInt32(TestContext.DataRow["secondBitPos"]);
            var actual = BitInsertion.PassNumbersAndBits(firstNumber, secondNumber, firstBitPos, secondBitPos);
        }

        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.XML",
            "|DataDirectory|\\Data.xml",
            "TestCase3",
            DataAccessMethod.Sequential)]
        [DeploymentItem("Task3.MSUnitTests\\Data.xml")]

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PassNumbersAndBits_SecondNumberIsInsertedInFirst_ThrowsArgumentException()
        {
            if (TestContext.DataRow["firstNumb"].ToString() == "int.MaxValue")
                TestContext.DataRow["firstNumb"] = int.MaxValue;
            else if (TestContext.DataRow["firstNumb"].ToString() == "int.MinValue")
                TestContext.DataRow["firstNumb"] = int.MinValue;

            if (TestContext.DataRow["secondNumb"].ToString() == "int.MaxValue")
                TestContext.DataRow["secondNumb"] = int.MaxValue;
            else if (TestContext.DataRow["secondNumb"].ToString() == "int.MinValue")
                TestContext.DataRow["secondNumb"] = int.MinValue;

            var firstNumber = Convert.ToInt32(TestContext.DataRow["firstNumb"]);
            var secondNumber = Convert.ToInt32(TestContext.DataRow["secondNumb"]);
            var firstBitPos = Convert.ToInt32(TestContext.DataRow["firstBitPos"]);
            var secondBitPos = Convert.ToInt32(TestContext.DataRow["secondBitPos"]);
            var actual = BitInsertion.PassNumbersAndBits(firstNumber, secondNumber, firstBitPos, secondBitPos);
        }

    }
}