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

        //display numbers in one line with spaces between
        public void WriteListWithSpacesAndNewLine()
        {
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
                NumberListSaver numberListSaver = new NumberListSaver();
                numberListSaver.AddListToUserLists(numberList, "UserLists.json");
                return true;
            }
            return false;
        }

//        public static void DisplayListChosenFromAllLists()
//        {
//            Console.WriteLine("Which saved list do you want to see?");
//            ListSaver listSaver = new ListSaver();
//            IEnumerable<NumberList> savedNumberLists = listSaver.GetAllAsync().Result;
//            foreach (NumberList savedNumberList in savedNumberLists)
//            {
//                Console.WriteLine($"{savedNumberList.ID}: {savedNumberList.Nickname}");
//            }
//            string userSelection = Console.ReadLine();
//            int selectedID;
//            if (int.TryParse(userSelection, out selectedID))
//            {
//                NumberList selectedNumberList = listSaver.GetByID(selectedID).Result;
//                if (selectedNumberList != null)
//                {
//                    selectedNumberList.WriteListWithSpacesAndNewLine();
//                }
//                else
//                {
//                    Console.WriteLine("No list with that ID");
//                }
//            }
//            else
//            {
//                Console.WriteLine("No list with that ID");
//            }
//        }
    }
}
