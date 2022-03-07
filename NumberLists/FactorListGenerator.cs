using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberLists
{
    class FactorListGenerator
    {
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
                    n = n / i;
                    i = 2;
                }
                else
                {
                    i++;
                }
            }
            return numberList;
        }
    }
}
