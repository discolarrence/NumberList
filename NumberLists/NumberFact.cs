using NumberLists.UI;
using System;
using System.Net;

namespace NumberLists
{
    public class NumberFact
    {
        private static readonly WebClient client = new WebClient();

        public static string GetNumberFact(string number, string type)
        {
            string url = "http://numbersapi.com/" + number + "/" + type;
            return client.DownloadString(url);
        }

        public static bool Save(string number, string fact)
        {
            bool wantsToSave = NumberListMenuBase.AskToSave("fact");
            if (wantsToSave)
            {
                SaverContainer numberFactSaver = new SaverContainer();
                numberFactSaver.Description = fact;
                numberFactSaver.NumberList = NumberListGenerators.StringToNumberList(number);
                numberFactSaver.DateSaved = DateTime.Now;
                NumberFactSerializationService numberFactSerializationService = new NumberFactSerializationService();
                _ = numberFactSerializationService.SaveAsync(numberFactSaver);
                Console.WriteLine("Your number fact has been saved.");
                return true;
            }
            return false;
        }
    }
}
