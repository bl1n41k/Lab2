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
            double a = 0;
            double b1 = 0;
            double b2 = 0;
            string str1 = "", str2 = "";
            string[] s = File.ReadAllLines("Мертвые_души_Глава_1.txt"), s3 = File.ReadAllLines("Мертвые_души_Глава_2.txt");
            for (int i = 0; i < s.Length; i++)
                str1 += " " + s[i];
            for (int i = 0; i < s3.Length; i++)
                str2 += " " + s3[i];
            collection2 collection = new collection2(str1, str2);
            collection1 text1 = new collection1(str1, collection);
            collection1 text2 = new collection1(str2, collection);
            foreach (string word in collection.value)
            {
                a += text1.dictionary[word] * text2.dictionary[word];
                b1 += text1.dictionary[word] * text1.dictionary[word];
                b2 += text2.dictionary[word] * text2.dictionary[word];
            }
            Console.WriteLine("Схожесть текстов на " + "{0}", Math.Round((a / (Math.Sqrt(b1) * Math.Sqrt(b2)))*100) +"%");
        }
	}
}
