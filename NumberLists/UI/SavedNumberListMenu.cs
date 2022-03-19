using System;
using System.Collections.Generic;

namespace NumberLists
{
    class SavedNumberListMenu : NumberListMenuBase
    {
        public SavedNumberListMenu()
        {
            AddMenuItem("1", "View all saved lists");
            AddMenuItem("2", "Choose a list by ID");
            AddMenuItem("X", $"Exit { _exit }");
        }

        public static void DisplayAllNumberLists(IEnumerable<NumberListContainer> savedNumberLists)
        {
            foreach (NumberListContainer savedNumberList in savedNumberLists)
            {
                Console.WriteLine($"{savedNumberList.ID}:{savedNumberList.Nickname} Saved:{savedNumberList.DateSaved}");
                savedNumberList.NumberList.WriteListWithSpacesAndNewLine();
            }
        }

        public static void DisplayAllNumberListInformation(IEnumerable<NumberListContainer> savedNumberLists)
        {
            foreach (NumberListContainer savedNumberList in savedNumberLists)
            {
                Console.WriteLine($"{savedNumberList.ID}:{savedNumberList.Nickname} Saved:{savedNumberList.DateSaved}");
            }
        }

        public static void DisplayListByID(IEnumerable<NumberListContainer> savedNumberLists)
        {
            DisplayAllNumberListInformation(savedNumberLists);
            Console.WriteLine("Enter the ID number of the list you'd like to see.\n");
            NumberListSerializationService numberListSerializationService = new NumberListSerializationService();
            string userSelection = Console.ReadLine();
            if (int.TryParse(userSelection, out int selectedID))
            {
                NumberListContainer selectedNumberListContainer = numberListSerializationService.GetByID(selectedID).Result;
                if (selectedNumberListContainer != null)
                {
                    selectedNumberListContainer.NumberList.WriteListWithSpacesAndNewLine();
                }
                else
                {
                    Console.WriteLine("No list with that ID");
                }
            }
            else
            {
                Console.WriteLine("Try again.");
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
                        DisplayListByID(NumberListContainer.RetrieveNumberLists());
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
