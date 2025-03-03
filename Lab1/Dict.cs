using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Dict
    {
       
        public Dictionary<string, string> dict { get; set; }
        public Dict()
        {
            dict = new Dictionary<string, string>();
        }

        public void PrintDict()
        {
            if (dict.Count == 0)
            {
                Console.WriteLine("Словник порожній.");
                return;
            }

            Console.WriteLine("Вміст словника:");
            foreach (var pair in dict)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }

        public void IsEqual()
        {
            Dictionary<string, string> equal = new Dictionary<string, string>();
            if (dict.Count == 0)
            {
                Console.WriteLine("Словник порожній.");
                return;
            }
            foreach (var pair in dict)
            {
                if (pair.Key == pair.Value)
                {
                    equal.Add(pair.Key, pair.Value);
                }

            }
            if (equal.Count == 0)
            {
                Console.WriteLine("Немає пар, де ключ дорівнює значенню.");
                return;
            }
            
            Console.WriteLine("Пари, де ключ і значення однакові:");
            foreach (var pair in equal)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
            
            SaveToJson(equal);
        }
        private void SaveToJson(Dictionary<string, string> data)
        {
            string json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("equal_words.json", json);
            Console.WriteLine("Результат збережено у файл equal_words.json");
        }

    }

}
