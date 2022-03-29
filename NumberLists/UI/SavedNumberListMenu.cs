using System;
using System.Collections.Generic;

namespace NumberLists.UI
{
    class SavedNumberListMenu : NumberListMenuBase
    {
        public SavedNumberListMenu()
        {
            AddMenuItem("1", "View all saved lists");
            AddMenuItem("2", "Choose a list by ID");
            AddMenuItem("3", "View all saved facts");
            AddMenuItem("X", $"Exit { _exit }");
        }

        public static void DisplayAllNumberLists(IEnumerable<SaverContainer> savedNumberLists)
        {
            foreach (SaverContainer savedNumberList in savedNumberLists)
            {
                Console.WriteLine($"{savedNumberList.ID}:{savedNumberList.Description} Saved:{savedNumberList.DateSaved}");
                savedNumberList.NumberList.WriteListWithSpacesAndNewLine();
            }
        }

        public static void DisplayAllNumberListInformation(IEnumerable<SaverContainer> savedNumberLists)
        {
            foreach (SaverContainer savedNumberList in savedNumberLists)
            {
                Console.WriteLine($"{savedNumberList.ID}:{savedNumberList.Description} Saved:{savedNumberList.DateSaved}");
            }
        }

        public static void DisplayListByID(IEnumerable<SaverContainer> savedNumberLists)
        {
            DisplayAllNumberListInformation(savedNumberLists);
            Console.WriteLine("Enter the ID number of the list you'd like to see.\n");
            NumberListSerializationService numberListSerializationService = new NumberListSerializationService();
            string userSelection = Console.ReadLine();
            if (int.TryParse(userSelection, out int selectedID))
            {
                SaverContainer selectedNumberListContainer = numberListSerializationService.GetByID(selectedID).Result;
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

        public static void DisplayAllNumberFacts(IEnumerable<SaverContainer> savedNumberFacts)
        {
            foreach (SaverContainer savedNumberFact in savedNumberFacts)
            {
                Console.WriteLine($"{savedNumberFact.Description} Saved:{savedNumberFact.DateSaved}");
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
                        DisplayAllNumberLists(SaverContainer.RetrieveNumberLists());
                        break;
                    case "2":
                        DisplayListByID(SaverContainer.RetrieveNumberLists());
                        break;
                    case "3":
                        DisplayAllNumberFacts(SaverContainer.RetrieveNumberFacts());
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
