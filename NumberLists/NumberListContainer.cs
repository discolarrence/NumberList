﻿using CodeLouisvilleLibrary.Serialization.Interfaces;
using System;
using System.Collections.Generic;

namespace NumberLists
{
    public class NumberListContainer : IEntityWithID
    {
        public NumberListContainer() 
        {

        }

        public int ID { get; set; }
        public string Nickname { get; set; }
        public NumberList NumberList { get; set; }
        public DateTime DateSaved { get; set; }

        public static IEnumerable<NumberListContainer> RetrieveNumberLists()
        {
            NumberListSerializationService numberListSerializationService = new NumberListSerializationService();
            return numberListSerializationService.GetAllAsync().Result;
        }
    }



}