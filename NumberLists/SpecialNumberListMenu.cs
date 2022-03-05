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
        private int _terms;

        public SpecialNumberListMenu()
        {
            //set min and max numbers
            _terms = CodeLouisvilleAppBase.Prompt4Integer("How many numbers would you like in your list?\n");
           
            //build menu with user number choices
            AddMenuItem("1", $"List the first {_terms} prime numbers");
            AddMenuItem("2", $"List the first {_terms} triangle numbers");
            AddMenuItem("3", $"List the first {_terms} Fibonacci numbers");
        }

        public int Terms
        {
            get { return _terms; }
            set { _terms = value; }
        }


        public string GetMenuChoice()
        {
            return CodeLouisvilleAppBase.Prompt4MenuItem("Choose a type of special number list to display.", this);
        }

        public void ExecuteSpecialNumberListMenuChoice()
        {
            while (CurrentMenuChoice.ToUpper() != "X")
            {
                CurrentMenuChoice = GetMenuChoice();

                switch (CurrentMenuChoice)
                {
                    case "1":
                        NumberList primeNumberList = SpecialNumberListGenerator.ListPrimeNumbers(_terms);
                        primeNumberList.WriteListWithSpacesAndNewLine();
                        break;
                    case "2":
                        NumberList triangleNumberList = SpecialNumberListGenerator.ListTriangleNumbers(_terms);
                        triangleNumberList.WriteListWithSpacesAndNewLine();
                        break;
                    case "3":
                        NumberList fibonacciNumberList = SpecialNumberListGenerator.ListFibonacciNumbers(_terms);
                        fibonacciNumberList.WriteListWithSpacesAndNewLine();
                        break;
                    default:
                        CurrentMenuChoice = "0";
                        break;
                }
            }
        }
    }
}
