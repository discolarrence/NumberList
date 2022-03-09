using CodeLouisvilleLibrary;
using System;

namespace NumberLists
{
    class MainMenu : NumberListMenuBase
    {
        private new string _exit = "the Number List application";

        public new string Exit
        {
            get { return _exit; }
            set { _exit = value; }
        }

        public MainMenu()
        {
            Console.WriteLine("This app displays lists of numbers. Press any key to continue.");
            Console.ReadKey();
            Console.Clear();

            AddMenuItem("1", $"Arithmatic Sequences");
            AddMenuItem("2", $"Geometric Sequences");
            AddMenuItem("3", $"Factors");
            AddMenuItem("4", $"Special Numbers");
            AddMenuItem("X", $"Exit {_exit}");
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
                        FactorListMenu factorListMenu = new FactorListMenu();
                        factorListMenu.ExecuteFactorListMenuChoice();
                        break;
                    case "4":
                        SpecialNumberListMenu specialNumberListMenu = new SpecialNumberListMenu();
                        specialNumberListMenu.ExecuteSpecialNumberListMenuChoice();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
