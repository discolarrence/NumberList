using System;
using System.Collections.Generic;

namespace DisplayNumberLists
{
    public class NumberList : List<int>
    {
        public NumberList()
        {

        }

        //display numbers in one line with spaces between
        public static void WriteListWithSpacesAndNewLine(NumberList numberList)
        {
            Console.WriteLine();
            foreach (int number in numberList)
            {
                Console.Write($"{number} ");
            }
            Console.Write("\n\n");
        }
    }
}
