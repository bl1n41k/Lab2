using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task3;

namespace UnitTest3
{
	[TestClass]
	public class Task3
    {
        [TestMethod]
        public void TestFrom8To10()
        {
            int a = NumberSystem8.From8To10(13);
            Assert.AreEqual(a.ToString(), "11");
        }

        [TestMethod]
        public void TestSum1()
        {
            int a = 3, b = 6;
            int c = NumberSystem8.Sum(a, b);
            int res = int.Parse(Convert.ToString(NumberSystem8.From8To10(a) + NumberSystem8.From8To10(b),8));
            Assert.AreEqual(res, c);
        }
        [ExpectedException(typeof(NotSupportedException))]
        [TestMethod]
        public void TestSum2()
        {
            int a = 99, b = 11;
            Assert.Equals(NumberSystem8.Sum(a, b), typeof(NotSupportedException));
        }
        [TestMethod]
        public void TestSum3()
        {
            int a = -10, b = 3;
            int c = NumberSystem8.Sum(a, b);
            Assert.IsTrue(c < 0);
        }

        [TestMethod]
        public void TestSub1()
        {
            int a = 6, b = 3;
            int c = NumberSystem8.Sub(a, b);
            int res = int.Parse(Convert.ToString(NumberSystem8.From8To10(a) - NumberSystem8.From8To10(b), 8));
            Assert.AreEqual(res, c);
        }
        [ExpectedException(typeof(NotSupportedException))]
        [TestMethod]
        public void TestSub2()
        {
            int a = 99, b = 11;
            Assert.Equals(NumberSystem8.Sub(a, b), typeof(NotSupportedException));
        }
        [TestMethod]
        public void TestSub3()
        {
            int a = 3, b = 6;
            int c = NumberSystem8.Sub(a, b);
            int res = -1 * int.Parse(Convert.ToString(NumberSystem8.From8To10(b) - NumberSystem8.From8To10(a), 8));
            Assert.AreEqual(res, c);
        }
        [TestMethod]
        public void TestAND1()
        {
            int a = 0, b = 6;
            Assert.AreEqual(0, NumberSystem8.AND(a, b));
        }

        [ExpectedException(typeof(NotSupportedException))]
        [TestMethod]
        public void TestAND2()
        {
            int a = -3, b = 6;
            Assert.Equals(NumberSystem8.AND(a, b), typeof(NotSupportedException));
        }
        [TestMethod]
        public void TestAND3()
        {
            int a = 4, b = 6;
            Assert.AreEqual(100, NumberSystem8.AND(a, b));
        }
        [ExpectedException(typeof(NotSupportedException))]
        [TestMethod]
        public void TestOR2()
        {
            int a = 99, b = 3;
            Assert.Equals(NumberSystem8.OR(a, b), typeof(NotSupportedException));
        }
        [TestMethod]
        public void TestOR1()
        {
            int a = 3, b = 6;
            Assert.AreEqual(NumberSystem8.OR(a, b), 111);
        }
        [ExpectedException(typeof(NotSupportedException))]
        [TestMethod]
        public void TestOR3()
        {
            int a = -3, b = 6;
            Assert.Equals(NumberSystem8.OR(a, b), typeof(NotSupportedException));
        }
    }
}
