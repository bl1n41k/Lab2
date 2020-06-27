using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	class Program
	{
		static void Main(string[] args)
		{
			Arr arr1 = new Arr(5); 
			Arr arr2 = new Arr(5);
			Arr arr3 = new Arr(5);
			int[] search;
			Console.WriteLine(arr1.ToString());
			Console.WriteLine(arr2.ToString());
			arr3 = arr1 + arr2;
			Console.WriteLine(arr3.ToString());
			arr3 = arr1 - arr2;
			Console.WriteLine(arr3.ToString());
			arr3 = arr1 * 5;
			Console.WriteLine(arr3.ToString());
			arr3 = arr3 / 2;
			Console.WriteLine(arr3.ToString());
			arr3[0] = 7;
			arr3[2] = 7;
			arr3[4] = 7;
			Console.WriteLine(arr3.ToString());
			search = arr3.Search(7);
			for (int i = 0; i < search.Count(); i++)
				Console.Write(search[i]+" ");
			Console.WriteLine();
			arr3 = arr1 + arr2;
			Console.WriteLine(arr3.ToString());
			Console.WriteLine(arr3.PrintElement(3));
		}
	}
}
