namespace NumberLists.UI
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
                        NumberList allFactorsList = NumberListGenerators.GetFactorsList(NumberToFactor);
                        allFactorsList.WriteListWithSpacesAndNewLine();
                        allFactorsList.Save();
                        break;
                    case "2":
                        NumberToFactor = GetNumberToFactor();
                        NumberList primeFactorsList = NumberListGenerators.GetPrimeFactorsList(NumberToFactor);
                        primeFactorsList.WriteListWithSpacesAndNewLine();
                        primeFactorsList.Save();
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
