using CodeLouisvilleLibrary;

namespace NumberLists
{
    class NumberListMenuBase : Menu<string>
    {
        protected string _currentMenuChoice = "0";
        protected string _exit = "to Main Menu";
        protected int _minNumber;
        protected int _maxNumber;
        protected int _numberOfTerms;
        protected int _multiplier;
        protected int _divisor;
        protected int _numberToFactor;

        public string CurrentMenuChoice
        {
            get { return _currentMenuChoice; }
            set { _currentMenuChoice = value; }
        }

        public string Exit
        {
            get { return _exit; }
            set { _exit = value; }
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

        public int NumberOfTerms
        {
            get { return _numberOfTerms; }
            set { _numberOfTerms = value; }
        }

        public int Multiplier
        {
            get { return _multiplier; }
            set { _multiplier = value; }
        }

        public int Divisor
        {
            get { return _divisor; }
            set { _divisor = value; }
        }

        public int NumberToFactor
        {
            get { return _numberToFactor; }
            set { _numberToFactor = value; }
        }

        public string GetMenuChoice(string menuTitle)
        {
            return CodeLouisvilleAppBase.Prompt4MenuItem($"\n***{menuTitle}***\nChoose a list to display.", this);
        }

        public int GetDivisor()
        {
            return CodeLouisvilleAppBase.Prompt4Integer("What number would you like to list multiples of?\n");
        }

        public int GetMultiplier()
        {
            return CodeLouisvilleAppBase.Prompt4Integer("What number would you like to multiply by?\n");
        }

        public int GetNumberToFactor()
        {
            return CodeLouisvilleAppBase.Prompt4Integer("What number would you like to factor?\n");
        }

        public int GetMinimum()
        {
            return CodeLouisvilleAppBase.Prompt4Integer("What is the minimum number for the number list?\n");
        }

        public int GetMaximum(int minimum)
        {
            int maximum = 0;
            while (maximum < minimum)
            {
                maximum = CodeLouisvilleAppBase.Prompt4Integer("What is the maximum number for the number list?\n");
            }
            return maximum;
        }

        public int GetTermsInList()
        {
            return CodeLouisvilleAppBase.Prompt4Integer("How many numbers would you like in the list?\n");
        }
    }
}
