using CodeLouisvilleLibrary;

namespace NumberLists
{
    class NumberListMenuBase : Menu<string>
    {
        protected string _currentMenuChoice = "0";

        public NumberListMenuBase()
        {
            AddMenuItem("X", "Exit");
        }
       
        public string CurrentMenuChoice
        {
            get { return _currentMenuChoice; }
            set { _currentMenuChoice = value; }
        }

        public string GetMenuChoice(string promptText)
        {
            return CodeLouisvilleAppBase.Prompt4MenuItem(promptText, this);
        }

    }
}
