namespace NumberLists
{
    class ArithmaticListMenu : NumberListMenuBase
    {
        public ArithmaticListMenu()
        {
            AddMenuItem("1", $"Even number list");
            AddMenuItem("2", $"Odd number list");
            AddMenuItem("3", $"Multiples list");
            AddMenuItem("X", $"Exit {_exit}");
        }

        public void ExecuteArithmaticMenuChoice()
        {
            while (CurrentMenuChoice.ToUpper() != "X")
            {
                CurrentMenuChoice = GetMenuChoice("Arithmatic Sequences Menu");

                switch (CurrentMenuChoice)
                {
                    case "1":
                        MinNumber = GetMinimum();
                        MaxNumber = GetMaximum(MinNumber);
                        NumberList evenNumberList = NumberListGenerators.ListEvenNumbers(MinNumber, MaxNumber);
                        evenNumberList.WriteListWithSpacesAndNewLine();
                        evenNumberList.Save();
                        break;
                    case "2":
                        MinNumber = GetMinimum();
                        MaxNumber = GetMaximum(MinNumber);
                        NumberList oddNumberList = NumberListGenerators.ListOddNumbers(MinNumber, MaxNumber);
                        oddNumberList.WriteListWithSpacesAndNewLine();
                        break;
                    case "3":
                        MinNumber = GetMinimum();
                        MaxNumber = GetMaximum(MinNumber);
                        Divisor = GetDivisor();
                        NumberList multiplesList = NumberListGenerators.ListMultiples(MinNumber, MaxNumber, Divisor);
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
