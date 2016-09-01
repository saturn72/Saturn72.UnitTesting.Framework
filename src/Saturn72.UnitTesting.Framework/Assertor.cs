#region

using NUnit.Framework;

#endregion

namespace Saturn72.UnitTesting.Framework
{
    public static class Assertor
    {
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