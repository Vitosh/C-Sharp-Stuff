namespace Fibonacci
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;


    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        public void TestWith10()
        {
            long l_fib = 10;
            FibonacciChecks.my_memo = new long[l_fib + 1];

            long l_result = FibonacciChecks.FibWithMemo(l_fib);
            Assert.AreEqual(l_result, 55);
        }

        [TestMethod]
        public void TestWith20()
        {
            long l_fib = 20;
            FibonacciChecks.my_memo = new long[l_fib + 1];

            long l_result = FibonacciChecks.FibWithMemo(l_fib);
            Assert.AreEqual(l_result, 6765);
        }

        [TestMethod]
        public void TestWith0()
        {
            long l_fib = 0;
            FibonacciChecks.my_memo = new long[l_fib + 1];

            long l_result = FibonacciChecks.FibWithMemo(l_fib);
            Assert.AreEqual(l_result, 0);
        }

        [TestMethod]
        public void TestWith1()
        {
            long l_fib = 1;
            FibonacciChecks.my_memo = new long[l_fib + 1];

            long l_result = FibonacciChecks.FibWithMemo(l_fib);
            Assert.AreEqual(l_result, 1);
        }


        [TestMethod]
        public void TestWith2()
        {
            long l_fib = 2;
            FibonacciChecks.my_memo = new long[l_fib + 1];

            long l_result = FibonacciChecks.FibWithMemo(l_fib);
            Assert.AreEqual(l_result, 1);
        }

    }
}
