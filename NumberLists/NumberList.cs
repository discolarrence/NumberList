using System;
using System.Collections.Generic;

namespace NumberLists
{
    public class NumberList : List<int>
    {
        public NumberList()
        {

        }

        //display numbers in one line with spaces between
        public void WriteListWithSpacesAndNewLine()
        {
            Console.WriteLine();
            foreach (int number in this)
            {
                Console.Write($"{number} ");
            }
            Console.Write("\n\n");
        }

        public bool Save()
        {
            return true;
        }
    }
}
