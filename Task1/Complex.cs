using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	public class Complex
	{
		double Re, Im; 
		const double Pi = Math.PI;
		public Complex()
		{
			Re = 0;
			Im = 0;
		}
		public Complex(double Re, double Im)
		{
			this.Re = Re;
			this.Im = Im;
		}

		public void SetRe(double Re) => this.Re = Re;
		public void SetIm(double Im) => this.Im = Im;
		public double GetRe() => Re;
		public double GetIm() => Im;

		// арифметические операций + - * /
		public static Complex operator + (Complex vector1, Complex vector2)
		{	 
			return new Complex(vector1.Re + vector2.Re, vector1.Im + vector2.Im); 
		}
		public static Complex operator - (Complex vector1, Complex vector2)
		{
			return new Complex(vector1.Re - vector2.Re, vector1.Im - vector2.Im);
		}
		public static Complex operator * (Complex vector1, Complex vector2)
		{
			return new Complex(vector1.Re * vector2.Re - vector1.Im * vector2.Im, vector1.Im * vector2.Re + vector1.Re * vector2.Im); 
		}
		public static Complex operator / (Complex vector1, Complex vector2)
		{
			if (vector2.ToString() == "0") throw new DivideByZeroException(); // Если 2-ой вектор = 0
			else
			{
				return new Complex((vector1.Re * vector2.Re + vector1.Im * vector2.Im) / (vector2.Re * vector2.Re + vector2.Im * vector2.Im), (vector1.Im * vector2.Re - vector1.Re * vector2.Im) / (vector2.Re * vector2.Re + vector2.Im * vector2.Im));
			}
		}

		public Complex ComplexDegree(int n) // n - степень 
		{
			if (n == 0) return (new Complex(1, 0)); // Если степень = 0, возвращаем 1
			Complex initial = this;
			Complex temp = this;
			for (int i = 1; i < n; i++) 
				temp = initial * temp;
			Re = temp.Re; Im = temp.Im;
			return this;
		}
		public Complex[] ComplexRoot(int root) 
		{ 
			if (root == 0) throw new Exception(); // Если степень = 0
			Complex[] roots = new Complex[root]; // Кол-во корней = root, хранится значение каждого из корней
			for (int i = 0; i < root; i++)
			{
				roots[i] = new Complex();
				roots[i].Re = Math.Round((Math.Pow(Math.Sqrt(Re * Re + Im * Im), 1 / root) * Math.Cos((Math.Atan(Im / Re) + 2 * Pi * i) / root)), 4); 
				roots[i].Im = Math.Round((Math.Pow(Math.Sqrt(Re * Re + Im * Im), 1 / root) * Math.Sin((Math.Atan(Im / Re) + 2 * Pi * i) / root)), 4);
			}
			return roots;
		}

		public override string ToString()
		{
			if (Re == 0 && Im == 0) return ("0");
			else
				   if (Im == 0) return ($"{Re}");
			else
				   if (Re == 0) return ($"{Im}*i");
			else
				   if (Im < 0) return ($"{Re}{Im}*i");
			else
				return ($"{Re}+{Im}*i");
		}
    }
}
