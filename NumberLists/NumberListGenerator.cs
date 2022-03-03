using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayNumberLists
{
    public static class NumberListGenerator
    {
        public static NumberList ListEvenNumbers(int startNumber, int endNumber)
        {
            int i = startNumber;
            //Check that start number is even
            if (startNumber % 2 != 0)
            {
                i += 1;
            }
            NumberList numberList = new NumberList();

            while (i <= endNumber)
            {
                numberList.Add(i);
                i += 2;
            }

            return numberList;
        }

        public static NumberList ListOddNumbers(int startNumber, int endNumber)
        {
            int i = startNumber;
            //Check that start number is odd
            if (startNumber % 2 == 0)
            {
                i += 1;
            }
                NumberList numberList = new NumberList();
          
            while (i <= endNumber)
            {
                numberList.Add(i);
                i += 2;
            }
            return numberList;
        }

        public static NumberList ListPrimeNumbers(int startNumber, int endNumber)
        {
            NumberList numberList = new NumberList();
            for (int i = startNumber; i <= endNumber; i++)
            {
                if (IsPrimeNumber(i))
                {
                    numberList.Add(i);
                }
            }
            return numberList;
        }

        public static NumberList ListMultiples(int startNumber, int endNumber, int divisor)
        {
            NumberList numberList = new NumberList();
            for (int i = startNumber; i <= endNumber; i++)
            {
                if (i % divisor == 0)
                {
                    numberList.Add(i);
                }
            }
            return numberList;
        }

        public static bool IsPrimeNumber(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
