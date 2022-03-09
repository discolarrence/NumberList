﻿using CodeLouisvilleLibrary;

namespace NumberLists
{
    class GeometricListMenu : NumberListMenuBase
    {
        private int _termsInList;
        private int _multiplier;
        
        public int TermsInList
        {
            get { return _termsInList; }
            set { _termsInList = value; }
        }

        public int Multiplier
        {
            get { return _multiplier; }
            set { _multiplier = value; }
        }

        public GeometricListMenu()
        {
            //set min and max numbers
            _termsInList = CodeLouisvilleAppBase.Prompt4Integer("How many numbers would you like in your list?\n");
            
            //build menu with user number choices
            AddMenuItem("1", $"List the first {_termsInList} numbers multiplied by {_multiplier}, starting with 1");
            AddMenuItem("2", $"List the first {_termsInList} numbers multiplied by {_multiplier}, starting with X");
            AddMenuItem("X", $"Exit {_exit}");
        }
        public string GetMenuChoice()
        {
            return CodeLouisvilleAppBase.Prompt4MenuItem("Choose a type of geometric sequence to display.", this);
        }

        public void ExecuteSpecialNumberListMenuChoice()
        {
            while (CurrentMenuChoice != "X")
            {
                CurrentMenuChoice = GetMenuChoice();

                switch (CurrentMenuChoice)
                {
                    case "1":
                        NumberList exponentialList = ListGenerator.ExponentialList(_termsInList, _multiplier);
                        exponentialList.WriteListWithSpacesAndNewLine();
                        break;
                    case "2":
                        
                        break;
                   
                    default:
                        break;
                }
            }
        }
    }
}
