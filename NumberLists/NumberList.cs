using CodeLouisvilleLibrary.Serialization.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

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
