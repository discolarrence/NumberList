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
            AddMenuItem("2", $"Exponential Sequences");
            AddMenuItem("3", $"Factors");
            AddMenuItem("4", $"Special Numbers");
            AddMenuItem("5", $"Saved Number Lists");
            AddMenuItem("X", $"Exit {_exit}");
        }

        public void ExecuteMainMenuChoice()
        {
            while (CurrentMenuChoice.ToUpper() != "X")
            {
                CurrentMenuChoice = GetMenuChoice("Number List Main Menu");

                switch (CurrentMenuChoice)
                {
                    case "1":
                        ArithmaticListMenu arithmaticListMenu = new ArithmaticListMenu();
                        arithmaticListMenu.ExecuteArithmaticMenuChoice();
                        break;
                    case "2":
                        ExponentialListMenu exponentialListMenu = new ExponentialListMenu();
                        exponentialListMenu.ExecuteExponentialNumberListMenuChoice();
                        break;
                    case "3":
                        FactorListMenu factorListMenu = new FactorListMenu();
                        factorListMenu.ExecuteFactorListMenuChoice();
                        break;
                    case "4":
                        SpecialNumberListMenu specialNumberListMenu = new SpecialNumberListMenu();
                        specialNumberListMenu.ExecuteSpecialNumberListMenuChoice();
                        break;
                    case "5":
                        SavedNumberListMenu savedNumberListMenu = new SavedNumberListMenu();
                        savedNumberListMenu.ExecuteSavedNumberListMenuChoice();
                        break;
                    case "X":
                        CurrentMenuChoice = "X";
                        break;
                    default:
                        CurrentMenuChoice = "0";
                        break;
                }
            }
        }
    }
}
