using CodeLouisvilleLibrary;
using System;

namespace DisplayNumberLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This app displays lists of numbers. Press any key to continue.");
            Console.ReadKey();
            Console.Clear();

            MainMenu mainMenu = new MainMenu();
            string mainMenuChoice = "";
            
            while (mainMenuChoice != "0")
            {
                mainMenuChoice = mainMenu.GetMenuChoice();

                switch (mainMenuChoice)
                {
                    case "1":
                        NumberList evenNumberList = NumberListGenerator.ListEvenNumbers(mainMenu.StartNumber, mainMenu.EndNumber);
                        evenNumberList.WriteListWithSpacesAndNewLine();
                        break;
                    case "2":
                        NumberList oddNumberList = NumberListGenerator.ListOddNumbers(mainMenu.StartNumber, mainMenu.EndNumber);
                        oddNumberList.WriteListWithSpacesAndNewLine();
                        break;
                    case "3":
                        NumberList primeNumberList = NumberListGenerator.ListPrimeNumbers(mainMenu.StartNumber, mainMenu.EndNumber);
                        primeNumberList.WriteListWithSpacesAndNewLine();
                        break;
                    case "4":
                        int divisor = CodeLouisvilleAppBase.Prompt4Integer("What number would you like to list multiples of?\n");
                        NumberList multiplesList = NumberListGenerator.ListMultiples(mainMenu.StartNumber, mainMenu.EndNumber, divisor);
                        multiplesList.WriteListWithSpacesAndNewLine();
                        break;
                    case "9":
                        mainMenu = new MainMenu();
                        break;
                }
            }
        }
       

    }
}
