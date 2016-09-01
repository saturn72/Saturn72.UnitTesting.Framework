using NUnit.Framework;

namespace Saturn72.UnitTesting.Framework.Tests
{
    public class AssertorTests
    {
        [Test]
        public void Asserter_Greater()
        {
            Assertor.Greater(2, 1);
            Assertor.Greater(2, 1, "message");
        }

        [Test]
        public void Asserter_GreaterOrEqual()
        {
            Assertor.GreaterOrEqual(2, 1);
            Assertor.GreaterOrEqual(2, 1, "message");
            Assertor.GreaterOrEqual(2, 2);
            Assertor.GreaterOrEqual(2, 2, "message");
        }

        [Test]
        public void Asserter_Smaller()
        {
            Assertor.Smaller(2, 3);
            Assertor.Smaller(2, 3, "message");
        }

        [Test]
        public void Asserter_SmallerOrEqual()
        {
            Assertor.SmallerOrEqual(2, 3);
            Assertor.SmallerOrEqual(2, 3, "message");
            Assertor.SmallerOrEqual(2, 2);
            Assertor.SmallerOrEqual(2, 2, "message");
        }

        [Test]
        public void True_NoMessage()
        {
            Assertor.True(true);
            Assertor.True(true, "message");
        }
    }
}
