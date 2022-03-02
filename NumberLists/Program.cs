using CodeLouisvilleLibrary;
using System;
using System.Collections.Generic;

namespace NumberLists
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = CodeLouisvilleAppBase.Prompt4Integer("What is the max number for the number list?\n");

            Menu<string> mainMenu = new Menu<string>();

            mainMenu.AddMenuItem("1", $"1 List all the even numbers from 1 to {maxNumber}");
            mainMenu.AddMenuItem("2", $"2 List all the odd numbers from 1 to {maxNumber}");
            mainMenu.AddMenuItem("3", $"3 List all the prime numbers from 1 to {maxNumber}");
            mainMenu.AddMenuItem("4", $"4 List all the multiples of X between 1 and {maxNumber}");
            mainMenu.AddMenuItem("X", "Exit");

            CodeLouisvilleAppBase.Prompt4MenuItem<string>("Choose a type of number list to display.", mainMenu);

            int divisor = CodeLouisvilleAppBase.Prompt4Integer("What number would you like to list multiples of?\n");

            ListEvenNumbers(maxNumber).ForEach(Console.Write);
            ListOddNumbers(maxNumber).ForEach(Console.Write);
            ListPrimeNumbers(maxNumber).ForEach(Console.Write);
            ListMultiples(maxNumber, divisor).ForEach(Console.Write);
        }

        static List <int> ListEvenNumbers(int endNumber)
        {
            int i = 2;
            List<int> numberList = new List<int>();
            while (i <+ endNumber)
            {
                numberList.Add(i);
                i += 2;
            }
            return numberList;
        }

        static List<int> ListOddNumbers(int endNumber)
        {
            int i = 1;
            List<int> numberList = new List<int>();
            while (i <= endNumber)
            {
                numberList.Add(i);
                i += 2;
            }
            return numberList;
        }

        static List<int> ListPrimeNumbers(int endNumber)
        {
            List<int> numberList = new List<int>();
            for (int i = 0; i <= endNumber; i++)
            {
                if (CheckIfPrime(i))
                {
                    numberList.Add(i);
                }
            }
            return numberList;
        }

        static List<int> ListMultiples(int endNumber, int divisor)
        {
            List<int> numberList = new List<int>();
            for (int i = 0; i <= endNumber; i++)
            {
                if (i % divisor == 0)
                {
                    numberList.Add(i);
                }
            }
            return numberList;
        }

        static bool CheckIfPrime(int number)
        {
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
