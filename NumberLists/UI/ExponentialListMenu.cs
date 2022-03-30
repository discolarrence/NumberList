namespace NumberLists.UI
{
    class ExponentialListMenu : NumberListMenuBase
    {
        public ExponentialListMenu()
        {
            AddMenuItem("1", "Geometric sequence");
            AddMenuItem("2", "Power list");
            AddMenuItem("3", "List of squares");
            AddMenuItem("4", "List of cubes");
            AddMenuItem("X", $"Exit {_exit}");
        }
        
        public void ExecuteExponentialNumberListMenuChoice()
        {
            while (CurrentMenuChoice != "X")
            {
                CurrentMenuChoice = GetMenuChoice("Geometric Sequences Menu");

                switch (CurrentMenuChoice)
                {
                    case "1":
                        NumberOfTerms = GetTermsInList();
                        Multiplier = GetMultiplier();
                        NumberList geometricList = NumberListGenerators.GeometricList(NumberOfTerms, Multiplier);
                        geometricList.WriteListWithSpacesAndNewLine();
                        geometricList.Save();
                        break;
                    case "2":
                        NumberOfTerms = GetTermsInList();
                        Multiplier = GetExponent();
                        NumberList exponentialList = NumberListGenerators.PowerList(NumberOfTerms, Multiplier);
                        exponentialList.WriteListWithSpacesAndNewLine();
                        exponentialList.Save();
                        break;
                    case "3":
                        NumberOfTerms = GetTermsInList();
                        NumberList squareList = NumberListGenerators.PowerList(NumberOfTerms, 2);
                        squareList.WriteListWithSpacesAndNewLine();
                        squareList.Save();
                        break;
                    case "4":
                        NumberOfTerms = GetTermsInList();
                        NumberList cubeList = NumberListGenerators.PowerList(NumberOfTerms, 3);
                        cubeList.WriteListWithSpacesAndNewLine();
                        cubeList.Save();
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

