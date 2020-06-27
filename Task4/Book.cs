using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Task4
{
	class Book
    {
		class Words
		{
			
			public Dictionary<string, int> words = new Dictionary<string, int>();
			
			private int Textsize;
			public Words(string fileName)
			{
				string[] text;
				try
				{
					using (StreamReader sr = new StreamReader(fileName))
					{
                        Regex regex = new Regex(@"\W+");
                        text = regex.Split(sr.ReadToEnd());
					}
				}
				catch
				{
					throw new Exception("Файл не найден.");
				}
				Textsize = text.Length;
				for (int i = 0; i < text.Count(); ++i)
				{
					if (words.ContainsKey(text[i].ToLower()))
						++words[text[i].ToLower()];
					else 
						words.Add(text[i].ToLower(), 1);
				}
			}
			public int SizeText
			{
				get => Textsize;
			}
		}

		private List<double> X = new List<double>();

		public Book(string fileName)
		{
			Words T = new Words(fileName);
			foreach (var pair in T.words)
		       X.Add((double)pair.Value / (double)T.SizeText);
		}

		static public double Compare(Book first,Book second)
        {
			double findCos = 0;
			double VectorLength(Book a)
            {
                double length = 0;
                foreach(double element in a.X)
                    length += Math.Pow(element, 2);
                return Math.Sqrt(length);
            }
            for (int i = 0; i < Math.Min(first.Size, second.Size); i++)
                findCos += first[i] * second[i];
            return findCos / (VectorLength(first)*VectorLength(second));
        }
        public double this[int index]
        {
            get => X[index];
        }
        public int Size
        {
            get => X.Count;
        }
    }
}
