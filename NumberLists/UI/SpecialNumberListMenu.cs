namespace NumberLists
{
    class SpecialNumberListMenu : NumberListMenuBase
    {
        public SpecialNumberListMenu()
        {
            AddMenuItem("1", $"Prime numbers");
            AddMenuItem("2", $"Triangle numbers");
            AddMenuItem("3", $"Fibonacci numbers");
            AddMenuItem("X", $"Exit {_exit}");
        }

        public void ExecuteSpecialNumberListMenuChoice()
        {
            while (CurrentMenuChoice != "X")
            {
                CurrentMenuChoice = GetMenuChoice("Special Numbers Menu");

                switch (CurrentMenuChoice)
                {
                    case "1":
                        NumberOfTerms = GetTermsInList();
                        NumberList primeNumberList = ListGenerators.ListPrimeNumbers(NumberOfTerms);
                        primeNumberList.WriteListWithSpacesAndNewLine();
                        break;
                    case "2":
                        NumberOfTerms = GetTermsInList();
                        NumberList triangleNumberList = ListGenerators.ListTriangleNumbers(NumberOfTerms);
                        triangleNumberList.WriteListWithSpacesAndNewLine();
                        break;
                    case "3":
                        NumberOfTerms = GetTermsInList();
                        NumberList fibonacciNumberList = ListGenerators.ListFibonacciNumbers(NumberOfTerms);
                        fibonacciNumberList.WriteListWithSpacesAndNewLine();
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
