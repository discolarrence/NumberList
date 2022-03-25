using System;

namespace NumberLists.UI
{
    class NumberFactsMenu : NumberListMenuBase
    {
        public NumberFactsMenu()
        {
            AddMenuItem("1", $"Math fact");
            AddMenuItem("2", $"Number trivia");
            AddMenuItem("3", $"Random math fact");
            AddMenuItem("4", $"Random number trivia");
            AddMenuItem("X", $"Exit {_exit}");
        }

        public void ExecuteNumberFactsMenuChoice()
        {
            while (CurrentMenuChoice.ToUpper() != "X")
            {
                CurrentMenuChoice = GetMenuChoice("Number Facts Menu");

                switch (CurrentMenuChoice)
                {
                    case "1":
                        string mathNumber = Get1To9999IntAsString();
                        string mathFact = NumberFact.GetNumberFact(mathNumber, "math");
                        Console.WriteLine(mathFact);
                        NumberFact.Save(mathNumber, mathFact);
                        break;
                    case "2":
                        string triviaNumber = Get1To9999IntAsString();
                        string triviaFact = NumberFact.GetNumberFact(triviaNumber, "trivia");
                        Console.WriteLine(triviaFact);
                        NumberFact.Save(triviaNumber, triviaFact);
                        break;
                    case "3":
                        Console.WriteLine(NumberFact.GetNumberFact("random", "math")); 
                        break;
                    case "4":
                        Console.WriteLine(NumberFact.GetNumberFact("random", "trivia")); 
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