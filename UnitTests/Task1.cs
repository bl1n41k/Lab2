using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1;
namespace UnitTests
{
	[TestClass]
	public class Task1
	{
		[TestMethod]
		public void TestMethod1()
		{
			Complex a = new Complex();
			Assert.AreEqual("0", a.ToString());
		}
		[TestMethod]
		public void TestMethod2()
		{
			Complex a = new Complex(0, 0);
			Assert.AreEqual("0", a.ToString());
		}
		[TestMethod]
		public void TestMethod3()
		{
			double Re = -2;
			Complex a = new Complex(Re, 0);
			Assert.AreEqual($"{Re}", a.ToString());
		}
		[TestMethod]
		public void TestMethod4()
		{
			double Im = -2;
			Complex a = new Complex(0, Im);
			Assert.AreEqual($"{Im}*i", a.ToString());
		}
		[TestMethod]
		public void TestMethod5()
		{
			double Re = -2, Im = 2;
			Complex a = new Complex(Re, Im);
			Assert.AreEqual($"{Re}+{Im}*i", a.ToString());
		}
		[TestMethod]
		public void TestMethod6()
		{
			double Re = -2, Im = -2;
			Complex a = new Complex(Re, Im);
			Assert.AreEqual($"{Re}{Im}*i", a.ToString());
		}
		[TestMethod]
		public void TestOperation1() // '+'
		{
			double a_Re = -2, a_Im = -5, b_Re = -5, b_Im = -5;
			Complex a = new Complex(a_Re, a_Im);
			Complex b = new Complex(b_Re, b_Im);
			Complex c = a + b;
			double res_Re = a_Re + b_Re;
			double res_Im = a_Im + b_Im;
			Complex res = new Complex(res_Re, res_Im);
			Assert.AreEqual(c.ToString(), res.ToString());
		}
		[TestMethod]
		public void TestOperation2() // '-'
		{
			double a_Re = -2, a_Im = -5, b_Re = -5, b_Im = -5;
			Complex a = new Complex(a_Re, a_Im);
			Complex b = new Complex(b_Re, b_Im);
			Complex c = a - b;
			double res_Re = a_Re - b_Re;
			double res_Im = a_Im - b_Im;
			Complex res = new Complex(res_Re, res_Im);
			Assert.AreEqual(c.ToString(), res.ToString());
		}
		[TestMethod]
		public void TestOperation3() // '*'
		{
			double a_Re = -2, a_Im = -5, b_Re = -5, b_Im = -5;
			Complex a = new Complex(a_Re, a_Im);
			Complex b = new Complex(b_Re, b_Im);
			Complex c = a - b;
			double res_Re = a_Re - b_Re;
			double res_Im = a_Im - b_Im;
			Complex res = new Complex(res_Re, res_Im);
			Assert.AreEqual(c.ToString(), res.ToString());
		}
		[ExpectedException(typeof(DivideByZeroException))]
		[TestMethod]
		public void TestOperation4() // '/'
		{
			double a_Re = -2, a_Im = -5, b_Re = 0, b_Im = 0;
			Complex a = new Complex(a_Re, a_Im);
			Complex b = new Complex(b_Re, b_Im);
			Complex c = a / b;
			Assert.Equals(typeof(DivideByZeroException), c);
		}
		[TestMethod]
		public void TestOperation5() // '/'
		{
			double a_Re = -2, a_Im = -5, b_Re = -5, b_Im = -5;
			Complex a = new Complex(a_Re, a_Im);
			Complex b = new Complex(b_Re, b_Im);
			Complex c = a / b;
			double res_Re = (a_Re * b_Re + a_Im * b_Im) / (b_Re * b_Re + b_Im * b_Im);
			double res_Im = (a_Im * b_Re - a_Re * b_Im) / (b_Re * b_Re + b_Im * b_Im);
			Complex res = new Complex(res_Re, res_Im);
			Assert.AreEqual(c.ToString(), res.ToString());
		}
		[ExpectedException(typeof(Exception))]
		[TestMethod]
		public void ComplexRoot1() 
		{
			double Re = -2, Im = -5;
			Complex a = new Complex(Re, Im);
			Assert.Equals(typeof(Exception), a.ComplexRoot(0));
		}
		[TestMethod]
		public void ComplexRoot2()
		{
			double Re = -2, Im = -5; 
			int root = 5;
			Complex a = new Complex(Re, Im);
			Complex[] b = a.ComplexRoot(root);
			Complex[] res = new Complex[root];
			double arg = Math.Atan(Im / Re);
			for (int i = 0; i < b.Length; i++)
			{
				Re = Math.Round(((double)Math.Pow(Math.Sqrt(Re * Re + Im * Im), 1 / root) * Math.Cos((arg + 2 * Math.PI * i) / root)), 4);
				Im = Math.Round(((double)Math.Pow(Math.Sqrt(Re * Re + Im * Im), 1 / root) * Math.Sin((arg + 2 * Math.PI * i) / root)), 4);
				res[i] = new Complex(Re, Im);
			}
			for (int i = 0; i < res.Length; i++)
				Assert.AreEqual(res[i].ToString(), b[i].ToString());
		}
		[TestMethod]
		public void ComplexDegree1()
		{
			double Re = 2, Im = 5;
			int n = 5;
			Complex a = new Complex(Re, Im);
			Complex b = a.ComplexDegree(n);
			double pwabs = Math.Pow(Math.Sqrt(Re * Re + Im * Im), n);
			double arg = Math.Atan(Im / Re);
			Re = pwabs * Math.Cos(n * arg);
			Im = pwabs * Math.Sin(n * arg);
			Complex res = new Complex(Re, Im);
			Assert.AreEqual(res.ToString(), b.ToString());
		}
		[TestMethod]
		public void ComplexDegree2()
		{
			double Re = 2, Im = 5;
			int n = 0;
			Complex a = new Complex(Re, Im);
			Complex b = a.ComplexDegree(n);
			Assert.AreEqual(new Complex(1, 0).ToString(), b.ToString());
		}
	}
}
