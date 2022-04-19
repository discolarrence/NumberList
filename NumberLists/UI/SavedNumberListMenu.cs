namespace NumberLists.UI
{
    class SavedNumberListMenu : NumberListMenuBase
    {
        public SavedNumberListMenu()
        {
            AddMenuItem("1", "View all saved lists");
            AddMenuItem("2", "Choose a list by ID");
            AddMenuItem("3", "View all saved facts");
            AddMenuItem("X", $"Exit { _exit }");
        }

        public void ExecuteSavedNumberListMenuChoice()
        {
            while (CurrentMenuChoice.ToUpper() != "X")
            {
                CurrentMenuChoice = GetMenuChoice("Saved Number List Menu");

                switch (CurrentMenuChoice)
                {
                    case "1":
                        SaverContainer.DisplayAllNumberLists();
                        break;
                    case "2":
                        SaverContainer.DisplayListByID(GetListID());
                        break;
                    case "3":
                        SaverContainer.DisplayAllNumberFacts();
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
