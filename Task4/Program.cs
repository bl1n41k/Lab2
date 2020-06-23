using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
	class Program
	{
		static void Main(string[] args)
		{
            double a = 0, b1 = 0, b2 = 0, result;
            string str1 = "", str2 = "";
            string[] s1 = File.ReadAllLines("Мертвые_души_Глава_1.txt"), s2 = File.ReadAllLines("Мертвые_души_Глава_2.txt");
            for (int i = 0; i < s1.Length; i++)
                str1 += " " + s1[i];
            for (int i = 0; i < s2.Length; i++)
                str2 += " " + s2[i];
            collections collection = new collections(str1, str2);
            collections text1 = new collections(str1, collection);
            collections text2 = new collections(str2, collection);
            foreach (string word in collection.value)
            {
                a += text1.dictionary[word] * text2.dictionary[word];
                b1 += text1.dictionary[word] * text1.dictionary[word];
                b2 += text2.dictionary[word] * text2.dictionary[word];
            }
            result = Math.Round((a / (Math.Sqrt(b1) * Math.Sqrt(b2))) * 100);
            Console.WriteLine("Схожесть текстов на " + "{0}", result + "%");
        }
	}
}
