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
#pragma warning disable 1718
            Assert.IsTrue(item == item);
#pragma warning restore 1718
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

        [TestMethod]
        public void test_equality_null_class()
        {
            var item = new ValueObjectClass(new object(), new object());

            Assert.IsFalse(item.Equals(null));
        }

        [TestMethod]
        public void test_equality_null_object()
        {
            var item = new ValueObjectClass(new object(), new object());

            Assert.IsFalse(item.Equals((object)null));
        }

        [TestMethod]
        public void test_equality_no_public_properts()
        {
            var item = new ValueObjectBlankClass();

            Assert.IsTrue(item.Equals(item));
        }

        [TestMethod]
        public void test_equality_references()
        {
            var item = new ValueObjectBlankClass();

            Assert.IsTrue(item.Equals((object)item));
        }

        [TestMethod]
        public void test_get_hash_code()
        {
            var item = new ValueObjectClass(new object(), new object());
            var hash = item.GetHashCode();
        }

        [TestMethod]
        public void test_get_hash_code_propert_null()
        {
            var item = new ValueObjectClass(null, null);
            var hash = item.GetHashCode();
        }

        [TestMethod]
        public void test_get_hash_code_blank()
        {
            var item = new ValueObjectBlankClass();
            var hash = item.GetHashCode();
        }
    }
}
