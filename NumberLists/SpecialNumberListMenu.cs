using CodeLouisvilleLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberLists
{
    class SpecialNumberListMenu : NumberListMenuBase
    {
        private int _termsInList;

        public SpecialNumberListMenu()
        {
            //set min and max numbers
            _termsInList = CodeLouisvilleAppBase.Prompt4Integer("How many numbers would you like in your list?\n");
           
            //build menu with user number choices
            AddMenuItem("1", $"List the first {_termsInList} prime numbers");
            AddMenuItem("2", $"List the first {_termsInList} triangle numbers");
            AddMenuItem("3", $"List the first {_termsInList} Fibonacci numbers");
            AddMenuItem("X", $"Exit {_exit}");
        }

        public int TermsInList
        {
            get { return _termsInList; }
            set { _termsInList = value; }
        }


        public string GetMenuChoice()
        {
            return CodeLouisvilleAppBase.Prompt4MenuItem("Choose a type of special number list to display.", this);
        }

        public void ExecuteSpecialNumberListMenuChoice()
        {
            while (CurrentMenuChoice != "X")
            {
                CurrentMenuChoice = GetMenuChoice();

                switch (CurrentMenuChoice)
                {
                    case "1":
                        NumberList primeNumberList = SpecialNumberListGenerator.ListPrimeNumbers(_termsInList);
                        primeNumberList.WriteListWithSpacesAndNewLine();
                        break;
                    case "2":
                        NumberList triangleNumberList = SpecialNumberListGenerator.ListTriangleNumbers(_termsInList);
                        triangleNumberList.WriteListWithSpacesAndNewLine();
                        break;
                    case "3":
                        NumberList fibonacciNumberList = SpecialNumberListGenerator.ListFibonacciNumbers(_termsInList);
                        fibonacciNumberList.WriteListWithSpacesAndNewLine();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
