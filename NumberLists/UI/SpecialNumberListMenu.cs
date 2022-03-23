namespace NumberLists.UI
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
                        NumberList primeNumberList = NumberListGenerators.ListPrimeNumbers(NumberOfTerms);
                        primeNumberList.WriteListWithSpacesAndNewLine();
                        primeNumberList.Save();
                        break;
                    case "2":
                        NumberOfTerms = GetTermsInList();
                        NumberList triangleNumberList = NumberListGenerators.ListTriangleNumbers(NumberOfTerms);
                        triangleNumberList.WriteListWithSpacesAndNewLine();
                        triangleNumberList.Save();
                        break;
                    case "3":
                        NumberOfTerms = GetTermsInList();
                        NumberList fibonacciNumberList = NumberListGenerators.ListFibonacciNumbers(NumberOfTerms);
                        fibonacciNumberList.WriteListWithSpacesAndNewLine();
                        fibonacciNumberList.Save();
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
