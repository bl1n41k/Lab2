using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2;
namespace UnitTest2
{
    [TestClass]
    public class Task2
    {
        [TestMethod]
        public void TestMethod1()
        {
            Arr a = new Arr();
            Assert.AreEqual("", a.ToString());
        }

        [TestMethod]
        public void TestMethod2()
        {
            int n = 5;
            Arr a = new Arr(n);
            Assert.AreEqual("0 1 2 3 4 ", a.ToString());
        }

        [ExpectedException(typeof(IndexOutOfRangeException))]
        [TestMethod]
        public void TestMethod3()
        {   int n= 5;
            Arr a = new Arr(n);
            Assert.Equals(typeof(IndexOutOfRangeException), a[-1]);
        }

        [TestMethod]
        public void TestOperation1()// '+'
        {
            Arr arr1 = new Arr(0, 4);
            Arr arr2 = new Arr(0, 4);
            Arr arr = arr1 + arr2;
            Assert.AreEqual("0 2 4 6 8 ", arr.ToString());
        }
        [ExpectedException(typeof(NotSupportedException))]
        [TestMethod]
        public void TestOperation2()// '+'
        {
            Arr arr1 = new Arr(-1, 3);
            Arr arr2 = new Arr(0, 5);
            Arr arr = arr1 + arr2;
            Assert.Equals(typeof(IndexOutOfRangeException), arr);
        }
        [TestMethod]
        public void TestOperation3()// '-'
        {
            Arr arr1 = new Arr(0, 4);
            Arr arr2 = new Arr(0, 4);
            Arr arr = arr1 - arr2;
            Assert.AreEqual("0 0 0 0 0 ", arr.ToString());
        }
        [ExpectedException(typeof(NotSupportedException))]
        [TestMethod]
        public void TestOperation4()// '-'
        {
            Arr arr1 = new Arr(-1, 3);
            Arr arr2 = new Arr(0, 5);
            Arr arr = arr1 + arr2;
            Assert.Equals(typeof(IndexOutOfRangeException), arr);
        }
        [TestMethod]
        public void TestOperation5()// '*'
        {
            int n = 4;
            Arr arr1 = new Arr(n);
            Arr arr = arr1 * 2;
            Assert.AreEqual("0 2 4 6 ", arr.ToString());
        }
        [TestMethod]
        public void TestOperation6()// '/'
        {
            int n = 5;
            Arr arr1 = new Arr(n);
            for (int i = 0; i < n; i++) arr1[i] = i * 2;
            Arr arr = arr1 / 2;
            Assert.AreEqual("0 1 2 3 4 ", arr.ToString());
        }
        [ExpectedException(typeof(DivideByZeroException))]
        [TestMethod]
        public void TestOperation7()// '/'
        {
            int n = 5;
            Arr arr1 = new Arr(n);
            Arr arr = arr1 / 0;
            Assert.AreEqual((typeof(DivideByZeroException)), arr.ToString());
        }

        [TestMethod]
        public void TestSearch1()
        {
            Arr arr = new Arr(3);
            arr[0] = 1; 
            arr[1] = 4;
            arr[2] = 4;
            int[] res = new int[2] { 1,2 };
            Assert.AreEqual(arr.Search(4).ToString(), res.ToString());
        }
        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void TestSearch2()
        {
            Arr arr = new Arr(3);
            arr[0] = 1;
            arr[1] = 4;
            arr[2] = 4;
            int[] res = new int[2] { 1, 2 };
            Assert.AreEqual(arr.Search(10).ToString(), res.ToString());
        }

        [TestMethod]
        public void TestPrintElement1()
        { 
            Arr arr = new Arr(7);
            Assert.AreEqual(arr[4].ToString(), arr.PrintElement(4));
        }
        [ExpectedException(typeof(IndexOutOfRangeException))]
        [TestMethod]
        public void TestPrintElement2()
        {
            Arr arr = new Arr(7);
            Assert.AreEqual((typeof(IndexOutOfRangeException)), arr.PrintElement(10));
        }
    }
}

