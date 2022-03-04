using CodeLouisvilleLibrary;

namespace DisplayNumberLists
{
    class MainMenu : Menu<string>
    {
        private int _startNumber;
        private int _endNumber;

        public MainMenu()
        {
            //set starting and ending numbers
            _startNumber = CodeLouisvilleAppBase.Prompt4Integer("What is the first number for the number list?\n");
            //check that ending number > starting number
            while (_endNumber < _startNumber)
            {
                _endNumber = CodeLouisvilleAppBase.Prompt4Integer("What is the last number for the number list?\n");
            }
            //build menu with user number choices
            AddMenuItem("1", $"List all the even numbers from {_startNumber} to {_endNumber}");
            AddMenuItem("2", $"List all the odd numbers from {_startNumber} to {_endNumber}");
            AddMenuItem("3", $"List all the prime numbers from {_startNumber} to {_endNumber}");
            AddMenuItem("4", $"List all the multiples of X between {_startNumber} and {_endNumber}");
            AddMenuItem("9", "Choose new range for list");
            AddMenuItem("0", "Exit");
        }

        public int StartNumber
        {
            get { return _startNumber; }
            set { _startNumber = value; }
        }

        public int EndNumber
        {
            get { return _endNumber; }
            set { _endNumber = value; }
        }

        public string GetMenuChoice()
        {
            return CodeLouisvilleAppBase.Prompt4MenuItem("Choose a type of number list to display.", this);
        }

    }
}
