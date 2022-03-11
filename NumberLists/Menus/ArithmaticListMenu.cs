using CodeLouisvilleLibrary;

namespace NumberLists
{
    class ArithmaticListMenu : NumberListMenuBase
    {
        private int _minNumber;
        private int _maxNumber;
        private string _menuTitle = "Arithmatic Sequences";

        public ArithmaticListMenu()
        {
            //set min and max numbers
            _minNumber = CodeLouisvilleAppBase.Prompt4Integer("What is the minimum number for the number list?\n");
            //check that max number > min number
            while (_maxNumber < _minNumber)
            {
                _maxNumber = CodeLouisvilleAppBase.Prompt4Integer("What is the maximum number for the number list?\n");
            }
            //build menu with user number choices
            AddMenuItem("1", $"List all the even numbers from {_minNumber} to {_maxNumber}");
            AddMenuItem("2", $"List all the odd numbers from {_minNumber} to {_maxNumber}");
            AddMenuItem("3", $"List all the multiples of X between {_minNumber} and v {_maxNumber}");
            AddMenuItem("X", $"Exit {_exit}");
        }

        public int MinNumber
        {
            get { return _minNumber; }
            set { _minNumber = value; }
        }

        public int MaxNumber
        {
            get { return _maxNumber; }
            set { _maxNumber = value; }
        }

        public void ExecuteArithmaticMenuChoice()
        {
            while (CurrentMenuChoice.ToUpper() != "X")
            {
                CurrentMenuChoice = GetMenuChoice("Choose a type of arithmatic sequence to display.");

                switch (CurrentMenuChoice)
                {
                    case "1":
                        NumberList evenNumberList = ListGenerators.ListEvenNumbers(MinNumber, MaxNumber);
                        evenNumberList.WriteListWithSpacesAndNewLine();
                        break;
                    case "2":
                        NumberList oddNumberList = ListGenerators.ListOddNumbers(MinNumber, MaxNumber);
                        oddNumberList.WriteListWithSpacesAndNewLine();
                        break;
                    case "3":
                        int divisor = CodeLouisvilleAppBase.Prompt4Integer("What number would you like to list multiples of?\n");
                        NumberList multiplesList = ListGenerators.ListMultiples(MinNumber, MaxNumber, divisor);
                        multiplesList.WriteListWithSpacesAndNewLine();
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
