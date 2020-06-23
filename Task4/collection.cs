using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.SymbolStore;
using System.Collections.ObjectModel;
using System.Collections;

namespace Task4
{
    class collections
    {
        public SortedDictionary<string, int> dictionary;
        public HashSet<string> value; // Формируем набор значений
        public collections(string str, collections collection) // Заполняем словарь
        {
            dictionary = new SortedDictionary<string, int>();
            foreach (string word in collection.value)
                dictionary[word] = 0;
            foreach (string word in new string(str.Where((x) => Char.IsLetter(x) || Char.IsWhiteSpace(x)).ToArray()).Split())
                if (dictionary.ContainsKey(word)) dictionary[word]++;
        }
        public collections(string str1, string str2)
        {
            string str = str1 + " " + str2;
            value = new HashSet<string>(new string(str1.Where((x) => Char.IsLetter(x) || Char.IsWhiteSpace(x)).ToArray()).Split());
            value.Remove("");
        }    
    }
}
