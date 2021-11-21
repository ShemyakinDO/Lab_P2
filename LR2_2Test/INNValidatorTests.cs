using Microsoft.VisualStudio.TestTools.UnitTesting;
using LR_2_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_2_2.Tests
{
    [TestClass()]
    public class INNValidatorTests
    {
        [TestMethod()]
        public void check10DigitInnTest()
        {
            var checkInn = new INNValidator();
            Assert.IsTrue(checkInn.check10DigitInn(new Int32[] { 7, 7, 0, 7, 0, 8, 3, 8, 9, 3 }));
            Assert.IsFalse(checkInn.check10DigitInn(new Int32[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 3 }));
        }

        [TestMethod()]
        public void check12DigitInnTest()
        {
            var checkInn = new INNValidator();
            Assert.IsTrue(checkInn.check12DigitInn(new Int32[] { 5, 9, 0, 5, 0, 5, 0, 0, 1, 4, 1, 6 }));
            Assert.IsFalse(checkInn.check12DigitInn(new Int32[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 3 }));
        }
    }
}