using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rajastech.EGlass.Domain.Tests.Domain.Core
{
    [TestClass]
    public class ValueObjectTest
    {
        [TestMethod]
        public void test_equality_values()
        {
            var item = new ValueObjectClass(new object(), new object());

            Assert.IsTrue(item == item);
        }

        [TestMethod]
        public void test_equality_different_values()
        {
            var item = new ValueObjectClass(new object(), new object());
            var item2 = new ValueObjectClass(new object(), new object());

            Assert.IsFalse(item == item2);
        }

        [TestMethod]
        public void test_inequality_different_values()
        {
            var item = new ValueObjectClass(new object(), new object());
            var item2 = new ValueObjectClass(new object(), new object());

            Assert.IsTrue(item != item2);
        }

        [TestMethod]
        public void test_equality_different_intance_equal_values()
        {
            var obj1 = new object();
            var obj2 = new object();

            var item = new ValueObjectClass(obj1, obj2);
            var item2 = new ValueObjectClass(obj1, obj2);

            Assert.IsTrue(item == item2);
        }

        [TestMethod]
        public void test_equality_invalid_object()
        {
            var item = new ValueObjectClass(new object(), new object());

            Assert.IsFalse(item.Equals(new object()));
        }
    }
}
