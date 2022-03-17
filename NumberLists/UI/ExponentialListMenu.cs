namespace NumberLists
{
    class ExponentialListMenu : NumberListMenuBase
    {
        public ExponentialListMenu()
        {
            AddMenuItem("1", "List of squares");
            AddMenuItem("2", "List of cubes");
            AddMenuItem("3", "Exponential list");
            AddMenuItem("X", $"Exit {_exit}");
        }
        
        public void ExecuteExponentialNumberListMenuChoice()
        {
            while (CurrentMenuChoice != "X")
            {
                CurrentMenuChoice = GetMenuChoice("Exponential Sequences Menu");

                switch (CurrentMenuChoice)
                {
                    case "1":
                        NumberOfTerms = GetTermsInList();
                        NumberList squareList = ListGenerators.ExponentialList(NumberOfTerms, 2);
                        squareList.WriteListWithSpacesAndNewLine();
                        break;
                    case "2":
                        NumberOfTerms = GetTermsInList();
                        NumberList cubeList = ListGenerators.ExponentialList(NumberOfTerms, 3);
                        cubeList.WriteListWithSpacesAndNewLine();
                        break;
                    case "3":
                        NumberOfTerms = GetTermsInList();
                        Multiplier = GetMultiplier();
                        NumberList exponentialList = ListGenerators.ExponentialList(NumberOfTerms, Multiplier);
                        exponentialList.WriteListWithSpacesAndNewLine();
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

