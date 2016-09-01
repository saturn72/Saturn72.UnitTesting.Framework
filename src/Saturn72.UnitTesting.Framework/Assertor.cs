#region

using System;
using NUnit.Framework;

#endregion

namespace Saturn72.UnitTesting.Framework
{
    public static class Assertor
    {
        public static void Greater(IComparable actual, IComparable expected)
        {
            Greater(actual, expected, string.Format(
                   "Expected number greater than, but was smaller or equal. Actual: {0}, Expected greather than: {1}",
                   actual, expected));
        }
        public static void Greater(IComparable actual, IComparable expected, string message)
        {
            Assert.Greater(actual, expected, message);
        }

        public static void GreaterOrEqual(IComparable actual, IComparable expected)
        {
            GreaterOrEqual(actual, expected, string.Format(
                    "Expected greater or equal to, but was smaller. Actual: {0}, Expected greather than: {1}",
                    actual, expected));
        }

        public static void GreaterOrEqual(IComparable actual, IComparable expected, string message)
        {
            Assert.GreaterOrEqual(actual, expected, message);
        }

        public static void SmallerOrEqual(IComparable actual, IComparable expected)
        {
            SmallerOrEqual(actual, expected, string.Format(
                    "Expected number smaller or equal to, but was greater. Actual: {0}, Expected greather than: {1}",
                    actual, expected));
        }

        public static void SmallerOrEqual(IComparable actual, IComparable expected, string message)
        {
            Assert.LessOrEqual(actual, expected, message);
        }

        public static void Smaller(IComparable actual, IComparable expected)
        {
            Smaller(actual, expected,
            string.Format(
                    "Expected number smaller than, but was greater or equal. Actual: {0}, Expected greather than: {1}",
                    actual, expected));
        }
        public static void Smaller(IComparable actual, IComparable expected, string message)
        {
            Assert.Less(actual, expected, message);
        }

        public static void True(bool condition)
        {
            Assert.True(condition);
        }

        public static void True(bool condition, string msg)
        {
            Assert.True(condition, msg);
        }
    }
}