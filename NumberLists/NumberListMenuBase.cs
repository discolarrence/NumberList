using CodeLouisvilleLibrary;

namespace NumberLists
{
    class NumberListMenuBase : Menu<string>
    {
        protected string _currentMenuChoice = "0";
        protected string _exit = "to Main Menu";

        public NumberListMenuBase()
        {
            AddMenuItem("X", $"Exit {_exit}");
        }
       
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


        public string GetMenuChoice(string promptText)
        {
            return CodeLouisvilleAppBase.Prompt4MenuItem(promptText, this);
        }

    }
}
