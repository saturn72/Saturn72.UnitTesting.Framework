using NUnit.Framework;

namespace Saturn72.UnitTesting.Framework.Tests
{
    public class AssertorTests
    {
        [Test]
        public void True_NoMessage()
        {
            Assertor.True(true);
        }

        [Test]
        public void True_Message()
        {
            Assertor.True(true, "msg");
        }
    }
}
