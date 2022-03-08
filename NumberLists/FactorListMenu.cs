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

        public string GetMenuChoice()
        {
            return CodeLouisvilleAppBase.Prompt4MenuItem("Choose a factor number list to display.", this);
        }

        public void ExecuteFactorListMenuChoice()
        {
            CurrentMenuChoice = GetMenuChoice();

            switch (CurrentMenuChoice)
            {
                case "1":
                    NumberList allFactorsList = ListGenerator.GetFactorsList(_numberToFactor);
                    allFactorsList.WriteListWithSpacesAndNewLine();
                    break;
                case "2":
                    NumberList primeFactorsList = ListGenerator.GetPrimeFactorsList(_numberToFactor);
                    primeFactorsList.WriteListWithSpacesAndNewLine();
                    break;
                default:
                    break;
            }
        }
    }
}
