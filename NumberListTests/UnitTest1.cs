using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace NumberListTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsPrimeNumberTrue()
        {
            //Arrange
            int numberToTest = 5569;
            bool expected = true;

            //Act
            bool actual = NumberLists.IsPrimeNumber(numberToTest);
            //Assert

        }
    }
}
