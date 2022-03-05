using CodeLouisvilleLibrary;
using System;

namespace NumberLists
{
    class MainMenu : NumberListMenuBase
    {
        public MainMenu()
        {
            Console.WriteLine("This app displays lists of numbers. Press any key to continue.");
            Console.ReadKey();
            Console.Clear();

            AddMenuItem("1", $"Arithmatic Sequences");
            AddMenuItem("2", $"Geometric Sequences");
            AddMenuItem("3", $"Factors");
            AddMenuItem("4", $"Special Numbers");
        }

        public string GetMenuChoice()
        {
            return CodeLouisvilleAppBase.Prompt4MenuItem("Choose a type of list to display.", this);
        }

        public void ExecuteMainMenuChoice()
        {
            while (CurrentMenuChoice.ToUpper() != "X")
            {
                CurrentMenuChoice = GetMenuChoice();

                switch (CurrentMenuChoice)
                {
                    case "1":
                        ArithmaticListMenu arithmaticListMenu = new ArithmaticListMenu();
                        arithmaticListMenu.ExecuteArithmaticMenuChoice();
                        break;
                    case "2":
                        Console.WriteLine("geometric list menu coming");
                        break;
                    case "3":
                        Console.WriteLine("factor list menu coming");
                        break;
                    case "4":
                        Console.WriteLine("special number list menu coming");
                        break;
                }
            }
        }
    }
}
