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
			num1 = _8_сс.From8To10(29);
			Console.WriteLine(num1);
			check = _8_сс.CheckRecord(19);
			_8_сс.From10To8(10, 32);
			num = _8_сс.GetNum();
			Console.WriteLine(num);
			num2 = _8_сс.From8To10(13);
			Console.WriteLine(num2);
			num = _8_сс.Sum(num1, num2);
			Console.WriteLine(num);
			num = _8_сс.Sub(num2, num1);
			Console.WriteLine(num);
			_8_сс.From10To8(10, 5);
			num1 = _8_сс.GetNum();
			_8_сс.From10To8(10, 13);
			num2 = _8_сс.GetNum();
			num = _8_сс.OR(num1, num2);
			Console.WriteLine(num);
			num = _8_сс.AND(num1, num2);
			Console.WriteLine(num);
		}
	}
}
