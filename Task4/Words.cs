using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task4
{
    class Words
    {
        public Dictionary<string, int> words = new Dictionary<string, int>();
        private int TextSize;
        public Words(string fileName)
        {
            string[] text;
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string[] SplitStr = { " ", "@", "!", "?", ",", ":", ";", ".", "\n", "\r", "-", "—", "\t", "...", "\"", "«", "»" };
                    text = sr.ReadToEnd().Split(SplitStr, StringSplitOptions.RemoveEmptyEntries);
                }
            }
            catch
            {
                throw new Exception("Файл не найден!");
            }
            TextSize = text.Length;
            for (int i = 0; i < text.Count(); ++i)
            {
                if (words.ContainsKey(text[i].ToLower()))
                    ++words[text[i].ToLower()];
                else words.Add(text[i].ToLower(), 1);
            }
        }
        public int SizeText
        {
            get => TextSize;
        }
    }
}