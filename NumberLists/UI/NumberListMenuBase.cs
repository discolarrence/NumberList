using CodeLouisvilleLibrary;
using System;

namespace NumberLists.UI
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

        public int Prompt4PositiveInteger(string prompt)
        {
            int positiveInt = CodeLouisvilleAppBase.Prompt4Integer(prompt);
            if (positiveInt < 0)
            {
                Prompt4PositiveInteger(prompt);
            }
            return positiveInt;
        }

        public string GetMenuChoice(string menuTitle)
        {
            return CodeLouisvilleAppBase.Prompt4MenuItem($"\n***{menuTitle}***\nChoose a list to display.", this);
        }

        public int GetDivisor()
        {
            return Prompt4PositiveInteger("What number would you like to list multiples of?\n");
        }

        public int GetMultiplier()
        {
            return Prompt4PositiveInteger("What number would you like to multiply by?\n");
        }

        public int GetNumberToFactor()
        {
            return Prompt4PositiveInteger("What number would you like to factor?\n");
        }

        public int GetMinimum()
        {
            return Prompt4PositiveInteger("What is the minimum number for the number list?\n");
        }

        public int GetMaximum(int minimum)
        {
            int maximum = Prompt4PositiveInteger("What is the maximum number for the number list?\n");
            if (minimum >= maximum) GetMaximum(minimum);
            return maximum;
        }

        public int GetTermsInList()
        {
            return Prompt4PositiveInteger("How many numbers would you like in the list?\n");
        }

        public static bool AskToSave()
        {
            return CodeLouisvilleAppBase.Prompt4YesNo("Would you like to save your number list? (y/n)\n");
        }

        public static string GetNickname()
        {
            Console.WriteLine("What would you like to name your number list?");
            return Console.ReadLine();
        }

        public string Get1To9999IntAsString()
        {
            int number;
            do
            {
                number = Prompt4PositiveInteger("What number would you like to see a fact about?");
            } while (number < 1 || number > 9999);
            return Convert.ToString(number);
        }
    }
}
