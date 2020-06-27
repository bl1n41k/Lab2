using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	class Program
	{
		static void Main(string[] args)
		{  
			Complex a = new Complex(-2, -5);
			Complex b = new Complex(-5, -5);
			Complex c = new Complex(-2,-2);
			Console.WriteLine(c.ToString());
			Complex[] d;
			c = a + b;
			Console.WriteLine(c.ToString());
			c = a - b;
			Console.WriteLine(c.ToString());
			c = a * b;
			Console.WriteLine(c.ToString());
			c = a / b;
			Console.WriteLine(c.ToString());
			a.ComplexDegree(3);
			Console.WriteLine(a.ToString());
			a = new Complex(3, 4);
			Console.WriteLine("Корни:");
			d = a.ComplexRoot(3);
			for (int i=0;i<3;i++)
			Console.WriteLine(d[i].ToString());
		}
	}
}
