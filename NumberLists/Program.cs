using CodeLouisvilleLibrary;
using System;

namespace NumberLists
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu<string> mainMenu = new Menu<string>();

            mainMenu.AddMenuItem("1", "1 List all the even numbers from 1 to X");
            mainMenu.AddMenuItem("2", "2 List all the odd numbers from 1 to X");
            mainMenu.AddMenuItem("3", "3 List all the prime numbers from 1 to X");
            mainMenu.AddMenuItem("4", "4 List all the numbers that are evenly divisible by Y that are between 1 and X");

            Console.WriteLine(mainMenu);
        }


    }
}
