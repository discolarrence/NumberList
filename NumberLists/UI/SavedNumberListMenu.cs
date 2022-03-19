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

        public static void DisplayAllNumberLists(IEnumerable<NumberListContainer> savedNumberLists)
        {
            foreach (NumberListContainer savedNumberList in savedNumberLists)
            {
                Console.WriteLine($"{savedNumberList.ID}: {savedNumberList.Nickname} {savedNumberList.DateSaved}");
                savedNumberList.NumberList.WriteListWithSpacesAndNewLine();
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
                        DisplayAllNumberLists(NumberListContainer.RetrieveNumberLists());
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
