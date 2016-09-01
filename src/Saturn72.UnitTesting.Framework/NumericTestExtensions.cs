using System;
using NUnit.Framework;

namespace Saturn72.UnitTesting.Framework
{
    public class NumericTestExtensions
    {
        [Test]
        public void ShouldBeGreaterThan_Int()
        {
            3.ShouldBeGreaterThan(2);
        }

        [Test]
        public void ShouldBeGreaterOrEqualTo_Int()
        {
            3.ShouldBeGreaterOrEqualTo(3);
            3.ShouldBeGreaterOrEqualTo(2);
        }

        [Test]
        public void ShouldBeSmallerThan_Int()
        {
            2.ShouldBeSmallerThan(3);
        }

        [Test]
        public void ShouldBeSmallerOrEqualTo_Int()
        {
            3.ShouldBeSmallerOrEqualTo(3);
            1.ShouldBeSmallerOrEqualTo(2);
        }

        [Test]
        public void ShouldBeGreaterThan_Long()
        {
            long.MaxValue.ShouldBeGreaterThan(long.MaxValue-1);
        }

        [Test]
        public void ShouldBeGreaterOrEqualTo_Long()
        {
            long.MaxValue.ShouldBeGreaterOrEqualTo(long.MaxValue);
            long.MaxValue.ShouldBeGreaterOrEqualTo(long.MinValue);
        }

        [Test]
        public void ShouldBeSmallerThan_Long()
        {
            long.MinValue.ShouldBeSmallerOrEqualTo(long.MaxValue);
        }

        [Test]
        public void ShouldBeSmallerOrEqualTo_Long()
        {
            long.MinValue.ShouldBeSmallerOrEqualTo(long.MaxValue);
            long.MinValue.ShouldBeSmallerOrEqualTo(long.MinValue);
        }

        [Test]
        public void ShouldBeGreaterThan_Decimal()
        {
            decimal.MaxValue.ShouldBeGreaterThan(decimal.MaxValue-1);
        }

        [Test]
        public void ShouldBeGreaterOrEqualTo_Decimal()
        {
            decimal.MaxValue.ShouldBeGreaterOrEqualTo(decimal.MaxValue);
            decimal.MaxValue.ShouldBeGreaterOrEqualTo(decimal.MinValue);
        }

        [Test]
        public void ShouldBeSmallerThan_Decimal()
        {
            decimal.MinValue.ShouldBeSmallerOrEqualTo(decimal.MaxValue);
        }

        [Test]
        public void ShouldBeSmallerOrEqualTo_Decimal()
        {
            decimal.MinValue.ShouldBeSmallerOrEqualTo(decimal.MaxValue);
            decimal.MinValue.ShouldBeSmallerOrEqualTo(decimal.MinValue);
        }
    }
}
