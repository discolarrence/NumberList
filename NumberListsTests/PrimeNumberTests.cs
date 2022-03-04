using Microsoft.VisualStudio.TestTools.UnitTesting;
using DisplayNumberLists;

namespace DisplayNumberListsTests
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
            bool actual = NumberListGenerator.IsPrimeNumber(numberToTest);

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
            bool actual = NumberListGenerator.IsPrimeNumber(numberToTest);

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}