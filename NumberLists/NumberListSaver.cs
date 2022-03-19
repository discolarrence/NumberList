using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace NumberLists
{
    public class NumberListSaver
    {
        public NumberListSaver()
        {

        }

        public string Nickname { get; set; }
        public NumberList NumberList { get; set; }
        public DateTimeOffset Date { get; set; }

        public void WriteNumberLists(List<NumberListSaver> allNumberLists, string fileName)
        {
            string json = JsonConvert.SerializeObject(allNumberLists);

            using (StreamWriter streamWriter = new StreamWriter(fileName))
            {
                streamWriter.Write(json);
            }
        }

        public List<NumberListSaver> ReadNumberLists(string fileName)
        {
            using (StreamReader streamReader = new StreamReader(fileName))
            {
                string json = streamReader.ReadToEnd();
                return JsonConvert.DeserializeObject<List<NumberListSaver>>(json);
            }
        }

        internal void AddListToUserLists(NumberList numberList, string fileName)
        {
            NumberList = numberList;
            Nickname = NumberListMenuBase.GetNickname();
            List<NumberListSaver> allNumberLists = ReadNumberLists(fileName);
            if (allNumberLists != null)
            {
                allNumberLists.Add(this);
            }
            else
            {

            }
            WriteNumberLists(allNumberLists, fileName);

        }
    }
}
