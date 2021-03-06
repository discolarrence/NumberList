using System;

namespace NumberLists
{
    public static class NumberListGenerators
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
                if (Positive(i))
                {
                    numberList.Add(i);
                }
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
                if (Positive(i))
                {
                    numberList.Add(i);
                }
                i += 2;
            }
            return numberList;
        }

        public static NumberList ListMultiples(int startNumber, int endNumber, int divisor)
        {
            NumberList numberList = new NumberList();
            for (int i = startNumber; i <= endNumber; i++)
            {
                if (i % divisor == 0 && Positive(i))
                {
                    numberList.Add(i);
                }
            }
            return numberList;
        }

        public static bool IsPrimeNumber(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static NumberList ListPrimeNumbers(int numberOfTerms)
        {
            NumberList numberList = new NumberList();
            int i = 1;
            while (numberList.Count < numberOfTerms)
            {
                if (IsPrimeNumber(i) && Positive(i))
                {
                    numberList.Add(i);
                }
                i++;
            }
            return numberList;
        }

        public static NumberList ListFibonacciNumbers(int numberOfTerms)
        {
            NumberList numberList = new NumberList();

            long n1 = 0;
            long n2 = 1;

            numberList.Add(n1);
            numberList.Add(n2);

            for (long i = 2; i < numberOfTerms && n2 > 0; i++)
            {
                long nFib = n1 + n2;
                if (nFib > 0)
                {
                    numberList.Add(nFib);
                }
                n1 = n2;
                n2 = nFib;
            }
            return numberList;
        }

        public static NumberList ListTriangleNumbers(int numberOfTerms)
        {
            NumberList numberList = new NumberList();

            int nTri = 0;

            for (int i = 1; i <= numberOfTerms; i++)
            {
                nTri += i;
                if (Positive(nTri))
                {
                    numberList.Add(nTri);
                }
            }

            return numberList;
        }

        public static NumberList GetFactorsList(int numberToFactor)
        {
            NumberList numberList = new NumberList();
            for (int i = 1; i <= numberToFactor; i++)
            {
                if (numberToFactor % i == 0)
                {
                    numberList.Add(i);
                }
            }
            return numberList;
        }

        public static NumberList GetPrimeFactorsList(int numberToFactor)
        {
            NumberList numberList = new NumberList();
            int i = 2;
            int n = numberToFactor;
            while (i <= n)
            {
                if (n % i == 0)
                {
                    numberList.Add(i);
                    n /= i;
                    i = 2;
                }
                else
                {
                    i++;
                }
            }
            return numberList;
        }

        public static NumberList GeometricList(int numberOfTerms, int baseNumber)
        {
            NumberList numberList = new NumberList();
            int x = 1;
            for (int i = 0; i < numberOfTerms; i++)
            {
                x *= baseNumber;
                if (Positive(x))
                {
                    numberList.Add(x);
                }
            }
            return numberList;
        }

        public static NumberList PowerList (int numberOfTerms, int exponent)
        {
            NumberList numberList = new NumberList();
            int x;
            for (int i = 1; i <= numberOfTerms; i++)
            {
                x = (int)Math.Pow(Convert.ToDouble(i), Convert.ToDouble(exponent));
                if (Positive(x))
                {
                    numberList.Add(x);
                }
            }
            return numberList;
        }
        public static NumberList StringToNumberList(string numberString)
        {
            int stringToInt = Convert.ToInt32(numberString);
            NumberList numberList = new NumberList();
            numberList.Add(stringToInt);
            return numberList;
        }

        public static bool Positive(int number)
        {
            if (number > 0)
            {
                return true;
            }
            else return false;
        }


    }
}

