using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace NumberLists
{
    class SavedNumberListMenu : NumberListMenuBase
    {
        public SavedNumberListMenu()
        {
            AddMenuItem("1", "View all saved lists");
            AddMenuItem("2", "Choose a list by nickname");
            AddMenuItem("X", $"Exit { _exit }");
        }

        public static List<NumberListSaver> GetAllNumberLists()
        {
            var json = File.ReadAllText("UserLists.json");
            return JsonConvert.DeserializeObject<List<NumberListSaver>>(json);
        }

        public static void DisplayAllNumberLists()
        {
            List<NumberListSaver> savedNumberLists = GetAllNumberLists();
            foreach (NumberListSaver savedNumberList in savedNumberLists)
            {
                Console.WriteLine($"{savedNumberList.Date}: {savedNumberList.Nickname}: {savedNumberList.NumberList}");
            } 
        }

        public void ExecuteSavedNumberListMenuChoice()
        {
            while (CurrentMenuChoice.ToUpper() != "X")
            {
                CurrentMenuChoice = GetMenuChoice("Saved Number List Menu");

                switch (CurrentMenuChoice)
                {
                    case "1":
                        DisplayAllNumberLists();
                        break;
                    case "2":
                        Console.WriteLine("choose list by nickname");
                        break;
                    case "X":
                        CurrentMenuChoice = "X";
                        break;
                    default:
                        CurrentMenuChoice = "0";
                        break;
                }
            }
        }
    }
}
