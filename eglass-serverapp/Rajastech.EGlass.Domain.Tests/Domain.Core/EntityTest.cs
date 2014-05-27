using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rajastech.EGlass.Domain.Tests.Domain.Core
{
    [TestClass]
    public class EntityTest
    {
        [TestMethod]
        public void is_transient_class()
        {
            var item = new EntityClass();

            Assert.IsTrue(item.IsTransient());
        }

        [TestMethod]
        public void is_not_transient_class()
        {
            var item = new EntityClass();
            item.Id = Guid.NewGuid();

            Assert.IsFalse(item.IsTransient());
        }

        [TestMethod]
        public void test_equality_new_class()
        {
            var item = new EntityClass();

            Assert.IsTrue(item == item);
        }

        [TestMethod]
        public void test_equality_new_classes()
        {
            var item = new EntityClass();
            var item2 = new EntityClass();

            Assert.IsFalse(item == item2);
        }

        [TestMethod]
        public void test_inequality_new_classes()
        {
            var item = new EntityClass();
            var item2 = new EntityClass();

            Assert.IsTrue(item != item2);
        }

        [TestMethod]
        public void test_equality_invalid_object()
        {
            var item = new EntityClass();

            Assert.IsFalse(item.Equals(new object()));
        }
    }
}
