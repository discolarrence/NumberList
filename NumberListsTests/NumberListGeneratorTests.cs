using Microsoft.VisualStudio.TestTools.UnitTesting;
using DisplayNumberLists;

namespace DisplayNumberListsTests
{
    [TestClass]
    public class NumberListGeneratorTests
    {
        [TestMethod]
        public void ListEvenNumbersStartNumberIsEven()
        {
            //--Arrange
            int startNumber = 4;
            int endNumber = 10;
            NumberList expected = new NumberList { 4, 6, 8, 10 };

            //--Act
            NumberList actual = NumberListGenerator.ListEvenNumbers(startNumber, endNumber);

            //--Assert
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void ListEvenNumbersStartNumberIsOdd()
        {
            //--Arrange
            int startNumber = 3;
            int endNumber = 10;
            NumberList expected = new NumberList { 4, 6, 8, 10 };

            //--Act
            NumberList actual = NumberListGenerator.ListEvenNumbers(startNumber, endNumber);

            //--Assert
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void ListOddNumbersStartNumberIsOdd()
        {
            //--Arrange
            int startNumber = 5;
            int endNumber = 10;
            NumberList expected = new NumberList { 5, 7, 9 };

            //--Act
            NumberList actual = NumberListGenerator.ListOddNumbers(startNumber, endNumber);

            //--Assert
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void ListOddNumbersStartNumberIsEven()
        {
            //--Arrange
            int startNumber = 4;
            int endNumber = 10;
            NumberList expected = new NumberList { 5, 7, 9};

            //--Act
            NumberList actual = NumberListGenerator.ListOddNumbers(startNumber, endNumber);

            //--Assert
            CollectionAssert.AreEquivalent(expected, actual);
        }

        

    }
}
