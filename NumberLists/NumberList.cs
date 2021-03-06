using NumberLists.UI;
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
            bool wantsToSave = NumberListMenuBase.AskToSave("list");
            if (wantsToSave)
            {
                SaverContainer numberListSaver = new SaverContainer();
                numberListSaver.Description = NumberListMenuBase.GetDescription();
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
