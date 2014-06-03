using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rajastech.EGlass.Domain.Core;

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

#pragma warning disable 1718
            Assert.IsTrue(item == item);
#pragma warning restore 1718
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
        public void test_inequality_new_classes_same_id()
        {
            var item = new EntityClass() { Id = Guid.NewGuid() };
            var item2 = new EntityClass() { Id = item.Id };

            Assert.IsTrue(item == item2);
        }

        [TestMethod]
        public void test_equality_invalid_object()
        {
            var item = new EntityClass();

            Assert.IsFalse(item.Equals(new object()));
        }

        [TestMethod]
        public void test_get_hash_code_transient_entity()
        {
            var item = new EntityClass();
            var hash = item.GetHashCode();
        }

        [TestMethod]
        public void test_get_hash_code_no_transient_entity()
        {
            var item = new EntityClass() { Id = Guid.NewGuid() };
            var hash = item.GetHashCode();
        }

        [TestMethod]
        public void test_get_id_entity_base()
        {
            var item = new EntityClass() { Id = Guid.NewGuid() };
            var itemInteface = (IEntity)item;

            Assert.IsTrue(item.Id == (Guid)itemInteface.Id);
        }
    }
}
