using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberLists;

namespace NumberListsTests
{
    [TestClass]
    public class PrimeNumberTests
    {
        [TestMethod]
        public void IsPrimeNumberTrue()
        {
            //--Arrange
            int numberToTest = 4513;
            bool expected = true;

            //--Act
            bool actual = NumberListGenerators.IsPrimeNumber(numberToTest);

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPrimeNumberFalse()
        {
            //--Arrange
            int numberToTest = 4514;
            bool expected = false;

            //--Act
            bool actual = NumberListGenerators.IsPrimeNumber(numberToTest);

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPrimeNumberOne()
        {
            //--Arrange
            int numberToTest = 1;
            bool expected = false;

            //--Act
            bool actual = NumberListGenerators.IsPrimeNumber(numberToTest);

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPrimeNumberZero()
        {
            //--Arrange
            int numberToTest = 0;
            bool expected = false;

            //--Act
            bool actual = NumberListGenerators.IsPrimeNumber(numberToTest);

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
