using Microsoft.VisualStudio.TestTools.UnitTesting;
using DisplayNumberLists;

namespace DisplayNumberListsTests
{
    [TestClass]
    public class NumberListTests
    {
        [TestMethod]
        public void ListEvenNumbersStartNumberEven()
        {
            //--Arrange
            int startNumberToTest = 2;
            int endNumber = 10;
            NumberList expected = new NumberList();
            expected.Add(2);
            expected.Add(4);
            expected.Add(6);
            expected.Add(8);
            expected.Add(10);

            //--Act
            NumberList actual = NumberListGenerator.ListEvenNumbers(startNumberToTest, endNumber);

            //--Assert
            Assert.AreEqual(expected, actual);
        }

    }
}

