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
			Array arr1 = new Array(5); 
			Array arr2 = new Array(5);
			Array arr3 = new Array(5);
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
