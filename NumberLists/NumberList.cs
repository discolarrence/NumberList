using System;
using System.Collections.Generic;

namespace NumberLists
{
    public class NumberList : List<long>
    { 
        public void WriteListWithSpacesAndNewLine()
        {
            foreach (long number in this)
            {
                Console.Write($"{number} ");
            }
            Console.Write("\n\n");
        }

        public bool Save() 
        {
            bool wantsToSave = NumberListMenuBase.AskToSave();
            if (wantsToSave)
            {
                NumberListContainer numberListSaver = new NumberListContainer();
                numberListSaver.Nickname = NumberListMenuBase.GetNickname();
                numberListSaver.NumberList = this;
                numberListSaver.DateSaved = DateTime.Now;
                NumberListSerializationService numberListSerializationService = new NumberListSerializationService();
                _ = numberListSerializationService.SaveAsync(numberListSaver);
                return true;
            }
            return false;
        }
    }
}
