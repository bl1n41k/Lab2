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
			arr1.print();
			arr2.print();
			arr3 = arr1 + arr2;
			arr3.print();
			arr3 = arr1 - arr2;
			arr3.print();
			arr3 = arr1 * 5;
			arr3.print();
			arr3.print();
			arr3 = arr3 / 2;
			arr3.print();
			arr3[0] = 7;
			arr3[2] = 7;
			arr3[4] = 7;
			arr3.print();
			search = arr3.search(7);
			for (int i = 0; i < search.Count(); i++)
				Console.Write(search[i]+" ");
			Console.WriteLine();
			arr3 = arr1 + arr2;
			arr3.print();
			arr3.printElement(3);
		}
	}
}
