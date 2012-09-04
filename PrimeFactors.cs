using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class PrimeFactors
    {
        [TestMethod]
        public void TestMethod1()
        {           
            var p = new PrimeFactorFinder();
            Assert.AreEqual(3, p.GetPrimeFactors(9).Count );
            Assert.AreEqual(3, p.GetPrimeFactors(9).Count);
            Assert.IsTrue(p.GetPrimeFactors(9).Contains(1));
            Assert.IsTrue(p.GetPrimeFactors(9).Contains(3));
            Assert.IsTrue(p.GetPrimeFactors(9).Contains(9));
           
            Assert.IsTrue(p.IsPrime(1));
            Assert.IsTrue(p.IsPrime(3));
            Assert.IsTrue(p.IsPrime(5));
            Assert.IsTrue(p.IsPrime(7));
            Assert.IsTrue(p.IsPrime(11));

            Assert.IsFalse(p.IsPrime(4));
            Assert.IsFalse(p.IsPrime(6));
            Assert.IsFalse(p.IsPrime(9));
            Assert.IsFalse(p.IsPrime(12));
            Assert.IsFalse(p.IsPrime(14));

            var factors = p.GetPrimeFactors(112344443341230);
            Assert.IsTrue(factors.Count > 0);
        }
    }

    public class PrimeFactorFinder
    {
        public List<Int64> GetPrimeFactors(Int64 i)
        {
            var prime_factors = new List<Int64>() { i };
            int counter = 1;
            while (counter <= i)
            {
                if ( ((i % counter) == 0 ) && this.IsPrime(counter) ) {
                    prime_factors.Add(counter);
                }
                counter++;
            }
            //return primes that have a mod of 0
            return prime_factors;
        }

        public bool IsPrime(Int64 i)
        {
            int counter = 2;
            while (counter < i)
            {
                if ((i % counter) == 0)
                {
                    return false;
                }
                counter++;
            }
            return true;
        }
    }

}
