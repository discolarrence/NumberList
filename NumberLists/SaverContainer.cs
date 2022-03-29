using CodeLouisvilleLibrary.Serialization.Interfaces;
using System;
using System.Collections.Generic;

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
    }



}
