using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberLists;

namespace NumberListTest
{
    [TestClass]
    public class NumberListsTest

    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int numberToTest = 5569;
            bool expected = true;

            //Act
            bool actual = IsPrimeNumber(numberToTest);

            //Assert
        }
    }
}
