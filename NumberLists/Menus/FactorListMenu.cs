namespace NumberLists
{
    class FactorListMenu : NumberListMenuBase
    {
        public FactorListMenu()
        {
            AddMenuItem("1", $"List factors");
            AddMenuItem("2", $"List prime factors");
            AddMenuItem("X", $"Exit {_exit}");
        }

        public void ExecuteFactorListMenuChoice()
        {
            while(CurrentMenuChoice.ToUpper() != "X")
            {
                CurrentMenuChoice = GetMenuChoice("Factor Lists Menu");

                switch (CurrentMenuChoice)
                {
                    case "1":
                        NumberToFactor = GetNumberToFactor();
                        NumberList allFactorsList = ListGenerators.GetFactorsList(NumberToFactor);
                        allFactorsList.WriteListWithSpacesAndNewLine();
                        break;
                    case "2":
                        NumberToFactor = GetNumberToFactor();
                        NumberList primeFactorsList = ListGenerators.GetPrimeFactorsList(NumberToFactor);
                        primeFactorsList.WriteListWithSpacesAndNewLine();
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
