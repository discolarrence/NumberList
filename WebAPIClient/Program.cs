using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace WebAPIClient
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            await GetNumberFacts();
        }

        private static async Task GetNumberFacts()
        {
            string number = "10";
            string url = "http://numbersapi.com/" + number + "/math";
            var stringTask = client.GetStringAsync(url);

            var msg = await stringTask;
            Console.Write(msg);
        }
    }
}
