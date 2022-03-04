using CodeLouisvilleLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayNumberLists
{
    public class AppBase : CodeLouisvilleAppBase
    {
        public string AppName { get; set; } = "Number Lists";

        public AppBase(string appName) : base(appName)
        {
            appName = AppName;
        }

        protected override bool Main()
        {
            return true;
        }

        public void StartApp()
        {
            Welcome();
        }



    }
}
