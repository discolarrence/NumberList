using CodeLouisvilleLibrary;
using System;
using System.Collections.Generic;

namespace DisplayNumberLists
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = CodeLouisvilleAppBase.Prompt4Integer("What is the first number for the number list?\n");
            int endNumber = CodeLouisvilleAppBase.Prompt4Integer("What is the last number for the number list?\n");

            Menu<string> mainMenu = new Menu<string>();

            mainMenu.AddMenuItem("1", $"List all the even numbers from {startNumber} to {endNumber}");
            mainMenu.AddMenuItem("2", $"List all the odd numbers from {startNumber} to {endNumber}");
            mainMenu.AddMenuItem("3", $"List all the prime numbers from {startNumber} to {endNumber}");
            mainMenu.AddMenuItem("4", $"List all the multiples of X between {startNumber} and {endNumber}");
            mainMenu.AddMenuItem("9", "Choose new range for list");
            mainMenu.AddMenuItem("0", "Exit");

            string mainMenuChoice = "";
            while (mainMenuChoice != "0")
            {
                mainMenuChoice = CodeLouisvilleAppBase.Prompt4MenuItem("Choose a type of number list to display.", mainMenu);

                switch (mainMenuChoice)
                {
                    case "1":
                        NumberList evenNumberList = NumberListGenerator.ListEvenNumbers(startNumber, endNumber);
                        NumberList.WriteListWithSpacesAndNewLine(evenNumberList);
                        break;
                    case "2":
                        NumberList oddNumberList = NumberListGenerator.ListOddNumbers(startNumber, endNumber);
                        NumberList.WriteListWithSpacesAndNewLine(oddNumberList);
                        break;
                    case "3":
                        NumberList primeNumberList = NumberListGenerator.ListPrimeNumbers(startNumber, endNumber);
                        NumberList.WriteListWithSpacesAndNewLine(primeNumberList);
                        break;
                    case "4":
                        int divisor = CodeLouisvilleAppBase.Prompt4Integer("What number would you like to list multiples of?\n");
                        NumberList multiplesList = NumberListGenerator.ListMultiples(startNumber, endNumber, divisor);
                        NumberList.WriteListWithSpacesAndNewLine(multiplesList);
                        break;
                }
            }
        }
       

    }
}
