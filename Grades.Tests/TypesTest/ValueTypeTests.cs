using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Grades.Tests.TypesTest
{
    [TestClass]
    public class ValueTypeTests
    {


        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2015, 1, 1);
            date = date.AddDays(1);

            Assert.AreEqual(2, date.Day);
        }

        [TestMethod]
        public void ValueTypePassByValue()
        {
            int x = 46;
            IncrementNumber(x);

            Assert.AreEqual(46, x);
            Assert.AreNotEqual(47, x);
        }

        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;

            Assert.AreNotEqual(x1, x2);
        }

        private void IncrementNumber(int number)
        {
            number += 1;
        }
    }
}
