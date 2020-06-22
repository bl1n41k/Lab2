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
			Complex c;
			Complex[] d;
			c = a + b;
			c.print();
			c = a - b;
			c.print();
			c = a * b;
			c.print();
			c = a / b;
			c.print();
			a.ComplexDegree(3);
			a.print();
			a = new Complex(3, 4);
			Console.WriteLine("Корни:");
			d = a.ComplexRoot(3);
			for (int i=0;i<3;i++)
			d[i].print();
		}
	}
}
