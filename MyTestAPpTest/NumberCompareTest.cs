using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyTestAPp;
using System;

namespace MyTestAPpTest
{
    [TestClass]
    public class NumberCompareTest
    {
        [TestMethod]
        public void NumberGreaterThanZero()
        {
            NumberCompare nc = new NumberCompare();
            bool fromCall;
            fromCall = nc.GreaterThanZero("1");
            Assert.IsTrue(fromCall);
        }

        [TestMethod]
        public void NumberSmallerThanZero()
        {
            NumberCompare nc = new NumberCompare();
            bool fromCall;
            fromCall = nc.GreaterThanZero("-1");
            Assert.IsFalse(fromCall);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NumberNullOrEmpty_UsingAttribute()
        {
            NumberCompare nc = new NumberCompare();
            nc.GreaterThanZero("");      
        }


    }
}
