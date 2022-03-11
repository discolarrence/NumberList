using CodeLouisvilleLibrary;

namespace NumberLists
{
    class FactorListMenu : NumberListMenuBase
    {
        private int _numberToFactor;

        public FactorListMenu()
        {
            _numberToFactor = CodeLouisvilleAppBase.Prompt4Integer("What number would you like to factor?");

            AddMenuItem("1", $"List all factors of {_numberToFactor}");
            AddMenuItem("2", $"List prime factors of {_numberToFactor}");
            AddMenuItem("X", $"Exit {_exit}");
        }

        public int NumberToFactor
        {
            get { return _numberToFactor; }
            set { _numberToFactor = value; }
        }

        public void ExecuteFactorListMenuChoice()
        {
            while(CurrentMenuChoice.ToUpper() == "X")
            {
                CurrentMenuChoice = GetMenuChoice("Choose a factor number list to display.");
                switch (CurrentMenuChoice)
                {
                    case "1":
                        NumberList allFactorsList = ListGenerators.GetFactorsList(_numberToFactor);
                        allFactorsList.WriteListWithSpacesAndNewLine();
                        break;
                    case "2":
                        NumberList primeFactorsList = ListGenerators.GetPrimeFactorsList(_numberToFactor);
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
