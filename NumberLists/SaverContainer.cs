using CodeLouisvilleLibrary.Serialization.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;


namespace NumberLists
{
    public class SaverContainer : IEntityWithID
    {
        public SaverContainer() 
        {

        }

        public int ID { get; set; }
        public string Description { get; set; }
        public NumberList NumberList { get; set; }
        public DateTime DateSaved { get; set; }

        public static IEnumerable<SaverContainer> RetrieveNumberLists()
        {
            NumberListSerializationService numberListSerializationService = new NumberListSerializationService();
            return numberListSerializationService.GetAllAsync().Result; 
        }

        public static IEnumerable<SaverContainer> RetrieveNumberFacts()
        {
            NumberFactSerializationService numberFactSerializationService = new NumberFactSerializationService();
            return numberFactSerializationService.GetAllAsync().Result;
        }


        public static void DisplayAllNumberLists()
        {
            IEnumerable<SaverContainer> savedNumberLists = RetrieveNumberLists();
            try
            {
                foreach (SaverContainer savedNumberList in savedNumberLists)
                {
                    Console.WriteLine($"{savedNumberList.ID}:{savedNumberList.Description} Saved:{savedNumberList.DateSaved}");
                    savedNumberList.NumberList.WriteListWithSpacesAndNewLine();
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("\nYou haven't saved any number lists yet.");
            }
            
        }

        public static void DisplayAllNumberListInformation()
        {
            IEnumerable<SaverContainer> savedNumberLists = RetrieveNumberLists();
            try
            {
                foreach (SaverContainer savedNumberList in savedNumberLists)
                {
                    Console.WriteLine($"{savedNumberList.ID}:{savedNumberList.Description} Saved:{savedNumberList.DateSaved}");
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("\nYou haven't saved any number lists yet.");
            }
        }

        public static void DisplayListByID(string userSelection)
        {
            DisplayAllNumberListInformation();
            if (File.Exists("UserLists.json"))
            {
                NumberListSerializationService numberListSerializationService = new NumberListSerializationService();
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
        }

        public static void DisplayAllNumberFacts()
        {
            IEnumerable<SaverContainer> savedNumberFacts = SaverContainer.RetrieveNumberFacts();
            try
            {
                foreach (SaverContainer savedNumberFact in savedNumberFacts)
                {
                    Console.WriteLine($"{savedNumberFact.Description}");
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("\nYou haven't saved any number lists yet.");
            }
        }
    }



}
