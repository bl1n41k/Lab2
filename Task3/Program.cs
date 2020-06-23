using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
	class Program
	{
		static void Main(string[] args)
		{
			int num1, num2, num;
			bool check;
			num1 = NumberSystem8.From8To10(29);
			Console.WriteLine(num1);
			check = NumberSystem8.CheckRecord(19);
			NumberSystem8.From10To8(10, 32);
			num = NumberSystem8.GetNum();
			Console.WriteLine(num);
			num2 = NumberSystem8.From8To10(13);
			Console.WriteLine(num2);
			num = NumberSystem8.Sum(num1, num2);
			Console.WriteLine(num);
			num = NumberSystem8.Sub(num2, num1);
			Console.WriteLine(num);
			NumberSystem8.From10To8(10, 5);
			num1 = NumberSystem8.GetNum();
			NumberSystem8.From10To8(10, 13);
			num2 = NumberSystem8.GetNum();
			num = NumberSystem8.OR(num1, num2);
			Console.WriteLine(num);
			num = NumberSystem8.AND(num1, num2);
			Console.WriteLine(num);
		}
	}
}
