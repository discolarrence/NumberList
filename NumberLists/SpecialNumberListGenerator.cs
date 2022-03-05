namespace NumberLists
{
    public class SpecialNumberListGenerator
    {
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

        public static NumberList ListPrimeNumbers(int numberOfTerms)
        {
            NumberList numberList = new NumberList();
            int i = 1;
            while (numberList.Count < numberOfTerms)
            {
                if (IsPrimeNumber(i))
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

            int n1 = 0;
            int n2 = 1;

            numberList.Add(n1);
            numberList.Add(n2);

            for (int i = 2; i < numberOfTerms; i++)
            { 
                int nFib = n1 + n2;
                numberList.Add(nFib);
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
                nTri = nTri + i;
                numberList.Add(nTri);
            }

            return numberList;
        }
    }
}
