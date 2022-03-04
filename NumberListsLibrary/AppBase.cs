using CodeLouisvilleLibrary;
using System;

namespace NumberListsLibrary
{
    public class AppBase : CodeLouisvilleAppBase
    {
        public string AppName { get; set; }
        public AppBase(string appName) : base(appName)
        {
            appName = AppName;
        }

        protected override bool Main()
        {
            return true;
        }
    }
}
