#region

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using NUnit.Framework;

#endregion

namespace Saturn72.UnitTesting.Framework
{
    public static class TestExtensions
    {
        public static void True(this bool b)
        {
            Assert.True(b);
        }

        public static void True(this bool b, string message)
        {
            Assert.True(b, message);
        }

        public static void ShouldNotBeNull<T>(this T obj)
        {
            Assert.NotNull(obj);
        }

        public static void ShouldNotBeNull<T>(this T obj, string message)
        {
            var condition = obj != null;
            Assert.True(condition, message);
        }

        public static void ShouldNotEqual<T>(this T actual, object expected)
        {
            Assert.AreNotEqual(expected, actual);
        }

        public static void ShouldNotEqual<T>(this T actual, object expected, string message)
        {
            var result = expected.Equals(actual);
            Assert.False(result, message);
        }

        public static void ShouldEqual<T>(this T actual, object expected)
        {
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///     Asserts that two objects are equal.
        /// </summary>
        /// <param name="actual"></param>
        /// <param name="expected"></param>
        /// <param name="message"></param>
        public static void ShouldEqual(this object actual, object expected, string message)
        {
            Assert.AreEqual(expected, actual);
        }

        public static Exception ShouldBeThrownBy(this Type exceptionType, Action testCode)
        {
            return Assert.Throws(exceptionType, () => testCode());
        }

        public static Exception ShouldBeThrownBy(this Type exceptionType, Action testCode, string exceptionMEssage)
        {
            var t = new Task(() => { });
            var exception = Assert.Throws(exceptionType, () => testCode());
            Assert.AreEqual(exceptionMEssage, exception.Message);

            return exception;
        }

        public static void ShouldBe<T>(this object actual)
        {
            Assert.AreEqual(typeof(T), actual.GetType());
        }

        public static void ShouldBeType<T>(this Type actual)
        {
            Assert.AreEqual(typeof(T), actual);
        }

        public static void ShouldBeNull(this object actual)
        {
            Assert.Null(actual);
        }

        public static void ShouldBeTheSameAs(this object actual, object expected)
        {
            Assert.AreSame(expected, actual);
        }

        public static void ShouldBeNotBeTheSameAs(this object actual, object expected)
        {
            Assert.AreNotSame(expected, actual);
        }

        public static void ShouldBeTrue(this bool source)
        {
            True(source);
        }

        public static void ShouldBeTrue(this bool source, string message)
        {
            True(source, message);
        }

        public static void ShouldBeFalse(this bool source)
        {
            Assert.False(source);
        }


        /// <summary>
        ///     Compares the two strings (case-insensitive).
        /// </summary>
        /// <param name="actual"></param>
        /// <param name="expected"></param>
        public static void AssertSameStringAs(this string actual, string expected)
        {
            if (!string.Equals(actual, expected, StringComparison.InvariantCultureIgnoreCase))
            {
                var message = string.Format("Expected {0} but was {1}", expected, actual);
                throw new ArgumentException(message);
            }
        }

        public static void ShouldContainInstance<T>(this ICollection<T> source, T instance)
        {
            Assert.Contains(instance, source.ToArray());
        }

        public static void ShouldContainType(this ICollection source, Type expectedType)
        {
            var result = source.Cast<object>().Any(s => s.GetType() == expectedType);
            Assert.True(result);
        }

        public static void ShouldBeEmpty(this ICollection source)
        {
            CollectionAssert.IsEmpty(source);
        }

        public static void ShouldCount(this ICollection source, int expected)
        {
            source.Count.ShouldEqual(expected);
        }

        public static void PropertyValuesAreEquals<TType>(this TType actual, TType expected, string[] execludeProperties)
        {
            var properties = expected.GetType().GetProperties();
            foreach (var property in properties)
            {
                if(execludeProperties.Contains(property.Name, StringComparer.InvariantCultureIgnoreCase))
                    continue;

                object expectedValue = property.GetValue(expected, null);
                object actualValue = property.GetValue(actual, null);

                if (actualValue is IDictionary)
                {
                    AssertDictionariesAreEquals(property, (IDictionary) actualValue, (IDictionary) expectedValue);
                    continue;
                }
                if (actualValue is IList)
                {
                    AssertListsAreEquals(property, (IList) actualValue, (IList) expectedValue);
                    continue;
                }

                if (!Equals(expectedValue, actualValue))
                {
                    Assert.Fail("Property {0}.{1} does not match. Expected: {2} but was: {3}",
                        property.DeclaringType.Name, property.Name, expectedValue, actualValue);
                }
            }
        }

        private static void AssertDictionariesAreEquals(PropertyInfo property, IDictionary actual, IDictionary expected)
        {
            if (actual.Count != expected.Count)
                Assert.Fail(
                    "Property {0}.{1} does not match. Expected IDictionary containing {2} elements but was IDictionary containing {3} elements",
                    property.PropertyType.Name, property.Name, expected.Count, actual.Count);

            for (int i = 0; i < actual.Count; i++)
                if (!Equals(actual[i], expected[i]))
                    Assert.Fail(
                        "Property {0}.{1} does not match. Expected IDictionary with element {1} equals to {2} but was IDictionary with element {1} equals to {3}",
                        property.PropertyType.Name, property.Name, expected[i], actual[i]);
        }

        private static void AssertListsAreEquals(PropertyInfo property, IList actualList, IList expectedList)
        {
            if (actualList.Count != expectedList.Count)
                Assert.Fail(
                    "Property {0}.{1} does not match. Expected IList containing {2} elements but was IList containing {3} elements",
                    property.PropertyType.Name, property.Name, expectedList.Count, actualList.Count);

            for (int i = 0; i < actualList.Count; i++)
                actualList[i].ShouldEqual(expectedList[i], 
                        string.Format("Property {0}.{1} does not match. Expected IList with element {1} equals to {2} but was IList with element {1} equals to {3}",
                        property.PropertyType.Name, property.Name, expectedList[i], actualList[i]));
        }
    }
}