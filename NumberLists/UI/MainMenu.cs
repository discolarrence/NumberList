using System;

namespace NumberLists.UI
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
            Console.WriteLine("Welcome to Number Lists! You can generate, save, and display different kinds of number sequences and learn fun number facts.\n" +
                "Press any key to continue.");
            Console.ReadKey();
            Console.Clear();

            AddMenuItem("1", $"Arithmatic Sequences");
            AddMenuItem("2", $"Geometric & Power Sequences");
            AddMenuItem("3", $"Special Number Sequences");
            AddMenuItem("4", $"Factors");
            AddMenuItem("5", $"Number Facts");
            AddMenuItem("6", $"Saved Number Lists & Facts");
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
                    case "4":
                        FactorListMenu factorListMenu = new FactorListMenu();
                        factorListMenu.ExecuteFactorListMenuChoice();
                        break;
                    case "3":
                        SpecialNumberListMenu specialNumberListMenu = new SpecialNumberListMenu();
                        specialNumberListMenu.ExecuteSpecialNumberListMenuChoice();
                        break;
                    case "5":
                        NumberFactsMenu numberFactsMenu = new NumberFactsMenu();
                        numberFactsMenu.ExecuteNumberFactsMenuChoice();
                        break;
                    case "6":
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
