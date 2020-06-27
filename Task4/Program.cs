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
			Book text1 = new Book("Мертвые_души_Глава_1.txt"), text2 = new Book("Мертвые_души_Глава_2.txt");
			double comparison = Book.Compare(text1, text2);
			if (comparison + 1e-9 >= 1.0)
				Console.WriteLine("Схожие тексты!");
			else
				Console.WriteLine("Cos = {0}", comparison);
		}
	}
}
