using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace NumberLists.UI
{
    class NumberFactsMenu : NumberListMenuBase
    {
        private static readonly HttpClient client = new HttpClient();

        public NumberFactsMenu()
        {
            AddMenuItem("1", $"Math fact");
            AddMenuItem("2", $"Number trivia");
            AddMenuItem("X", $"Exit {_exit}");
        }

        private static async Task GetNumberFact(string number, string type)
        {
            string url = "http://numbersapi.com/" + number + "/" + type;
            var stringTask = client.GetStringAsync(url);
            var msg = await stringTask;
            Console.Write(msg);
        }

        public void ExecuteNumberFactsMenuChoice()
        {
            while (CurrentMenuChoice.ToUpper() != "X")
            {
                CurrentMenuChoice = GetMenuChoice("Number Facts Menu");

                switch (CurrentMenuChoice)
                {
                    case "1":
                        string mathNumber = Get1To9999IntAsString();
                        GetNumberFact(mathNumber, "math");
                        break;
                    case "2":
                        string triviaNumber = Get1To9999IntAsString();
                        GetNumberFact(triviaNumber, "trivia");
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