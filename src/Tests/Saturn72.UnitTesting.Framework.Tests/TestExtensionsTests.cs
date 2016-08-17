#region

using System;
using System.Collections.Generic;
using NUnit.Framework;

#endregion

namespace Saturn72.UnitTesting.Framework.Tests
{
    public class TestExtensionsTests
    {
        [Test]
        public void True()
        {
            true.True();
        }

        [Test]
        public void True_WithMessage()
        {
            true.True("message");
        }

        [Test]
        public void ShouldNotBeNull()
        {
            new TestClass().ShouldNotBeNull();
            "rrr".ShouldNotBeNull();
        }

        [Test]
        public void ShouldNotBeNull_WithMessage()
        {
            new TestClass().ShouldNotBeNull("message");
            "rrr".ShouldNotBeNull("message");
        }

        [Test]
        public void ShouldNotEqual()
        {
            new TestClass().ShouldNotEqual(new TestClass());
            1.ShouldNotEqual(0);
            "ttt".ShouldNotEqual("rrr");
        }

        [Test]
        public void ShouldNotEqual_WithMessage()
        {
            "ttt".ShouldNotEqual("rrr", "message");
        }

        [Test]
        public void ShouldEqual()
        {
            var instance = new TestClass();
            instance.ShouldEqual(instance);
            1.ShouldEqual(1);
            "ttt".ShouldEqual("ttt");
        }

        /// <summary>
        ///     Asserts that two objects are equal.
        /// </summary>
        /// <param name="actual"></param>
        /// <param name="expected"></param>
        /// <param name="message"></param>
        [Test]
        public void ShouldEqual_WithMessage()
        {
            "ttt".ShouldEqual("ttt", "message");
        }

        [Test]
        public void ShouldBeThrownBy()
        {
            typeof (NullReferenceException).ShouldBeThrownBy(() => { throw new NullReferenceException(); }
                );
        }

        [Test]
        public void ShouldBeThrownBy_WithMessage()
        {
            typeof (NullReferenceException).ShouldBeThrownBy(() => { throw new NullReferenceException(); }
                , "Object reference not set to an instance of an object.");
        }

        [Test]
        public void ShouldBe()
        {
            "ttt".ShouldBe<string>();
        }

        [Test]
        public void ShouldBeType()
        {
            "ttt".GetType().ShouldBeType<string>();
        }

        [Test]
        public void ShouldBeNull()
        {
            ((object) null).ShouldBeNull();
        }

        [Test]
        public void ShouldBeTheSameAs()
        {
            var actual = new TestClass();
            var expected = actual;
            actual.ShouldBeTheSameAs(expected);
        }

        [Test]
        public void ShouldBeNotBeTheSameAs()
        {
            var actual = new TestClass();
            var expected = new TestClass();
            actual.ShouldBeNotBeTheSameAs(expected);
        }

        [Test]
        public void ShouldBeTrue()
        {
            true.ShouldBeTrue();
        }

        [Test]
        public void ShouldBeTrue_WitrhMessage()
        {
            true.ShouldBeTrue("message");
        }

        [Test]
        public void ShouldBeFalse()
        {
            false.ShouldBeFalse();
        }

        [Test]
        public void AssertSameStringAs()
        {
            "ttt".AssertSameStringAs("ttt");
        }

        [Test]
        public void ShouldContainInstance()
        {
            var instance = new TestClass();
            var source = new List<TestClass> {new TestClass(), instance, new TestClass()};

            source.ShouldContainInstance(instance);
        }

        [Test]
        public void ShouldContainType()
        {
            var instance = new TestClass();
            var source = new List<TestClass> {new TestClass(), instance, new TestClass()};

            source.ShouldContainType(instance.GetType());
        }

        [Test]
        public void ShouldBeEmpty()
        {
            new List<TestClass>().ShouldBeEmpty();
        }

        [Test]
        public void ShouldCount()
        {
            var source = new List<TestClass> {new TestClass(), new TestClass(), new TestClass()};
            source.ShouldCount(3);
        }

        [Test]
        public void PropertyValuesAreEquals()
        {
            var instance1 = new TestClass
            {
                DecimalValue = 1,
                StringValue = "T",
                ExcludedProp = "111",
            };

            var instance2 = new TestClass
            {
                DecimalValue = 1,
                StringValue = "T",
                ExcludedProp = "eeecd",
            };
            instance1.PropertyValuesAreEquals(instance2, new[] {"ExcludedProp"});
        }
    }

    public class TestClass
    {
        public int DecimalValue { get; set; }
        public string StringValue { get; set; }
        public string ExcludedProp { get; set; }
    }
}