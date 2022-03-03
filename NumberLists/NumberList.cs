using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayNumberLists
{
    public class NumberList : List<int>
    {
        public NumberList()
        {

        }

        public static void WriteListWithSpacesAndNewLine(NumberList numberList)
        {
            foreach(int number in numberList)
            {
                Console.Write($"{number} ");
            }
            Console.Write("\n");
        }
    }
}
