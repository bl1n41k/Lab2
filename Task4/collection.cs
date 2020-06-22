using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class collection1
    {
        public SortedDictionary<string, int> dictionary;
        public collection1(string str, collection2 collection) // Заполняем словарь
        {
            dictionary = new SortedDictionary<string, int>();
            foreach (string word in collection.value)
                dictionary[word] = 0;
            foreach (string word in new string(str.Where((x) => Char.IsLetter(x) || Char.IsWhiteSpace(x)).ToArray()).Split())
                if (dictionary.ContainsKey(word)) dictionary[word]++;
        }
    }
    class collection2
    {
        public HashSet<string> value; // Формируем набор значений
        public collection2(string str1, string str2)
        {
            string str = str1 +" "+ str2;
            value = new HashSet<string>(new string(str1.Where((x) => Char.IsLetter(x) || Char.IsWhiteSpace(x)).ToArray()).Split());
            value.Remove("");
        }
    }
}
