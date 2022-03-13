using System;
using System.Collections.Generic;

namespace NumberLists
{
    public class NumberList : List<long>
    {
        //display numbers in one line with spaces between
        public void WriteListWithSpacesAndNewLine()
        {
            Console.WriteLine();
            foreach (long number in this)
            {
                Console.Write($"{number} ");
            }
            Console.Write("\n\n");
        }
    }
}
