using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LazyLoadDesignPattern.LazyInit
{
    [TestFixture]
    public class OrderShouldTest
    {
        [Test]
        public void PrintLabelWithGoodOrder_ShouldPass()
        {
            var order = new OrderGood();

            var result = order.PrintLabel();

            Assert.AreEqual("Company Name\nDefault Address", result);
        }

        [Test]
        public void PrintLabelWithBadOrder_ShouldFail()
        {
            var order = new OrderBad();

            var result = order.PrintLabel();

            Assert.AreEqual("Company Name\nDefault Address", result);
        }

        [Test]
        public void PrintLabelWithLazyOrder_ShouldPass()
        {
            var order = new OrderLazy();

            var result = order.PrintLabel();

            Assert.AreEqual("Company Name\nDefault Address", result);
        }
    }
}
