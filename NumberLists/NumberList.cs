using CodeLouisvilleLibrary.Serialization.Interfaces;
using System;
using System.Collections.Generic;

namespace NumberLists
{
    public class NumberList : List<long>, IEntityWithID
    {
        public int ID { get ; set ; }
        public string Nickname { get ; set ; }

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

        public static bool Save(NumberList numberList)
        {
            bool wantsToSave = NumberListMenuBase.AskToSave();
            if (wantsToSave)
            {
                numberList.Nickname = NumberListMenuBase.GetNickname();
                ListSaver listSaver = new ListSaver();
                _ = listSaver.SaveAsync(numberList);
                return true;
            }
            return false;
        }
    }
}
