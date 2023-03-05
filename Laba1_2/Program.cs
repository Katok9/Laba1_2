using Newtonsoft.Json;
using System.IO;

namespace Laba1_2
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            dictionary.Add("I", "S001");
            dictionary.Add("II", "S002");
            dictionary.Add("III", "S001");
            dictionary.Add("IV", "S005");
            dictionary.Add("V", "S005");
            dictionary.Add("VI", "S009");
            dictionary.Add("VII", "S007");

            Dictionary<string, string> uniqueDictionary = new Dictionary<string, string>();

            foreach (KeyValuePair<string, string> pair in dictionary)
            {
                if (uniqueDictionary.ContainsValue(pair.Value) == false)
                {
                    uniqueDictionary.Add(pair.Key, pair.Value);
                }
            }

            string json = JsonConvert.SerializeObject(uniqueDictionary);

            string path = "json.txt";

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(json);
            }

        }
    }
}