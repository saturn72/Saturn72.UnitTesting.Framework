namespace Saturn72.UnitTesting.Framework
{
    public static partial class TestExtensions
    {
        public static void ShouldBeGreaterThan(this int actual, int num)
        {
            Assertor.True(actual>num, string.Format("Expected number greater than, but was smaller or equal. Actual: {0}, Expected greather than: {1}", actual, num));
        }

        public static void ShouldBeGreaterOrEqualTo(this int actual, int num)
        {
            Assertor.True(actual >= num, string.Format("Expected number greater or equal to, but was smaller. Actual: {0}, Expected greather than: {1}", actual, num));
        }

        public static void ShouldBeSmallerOrEqualTo(this int actual, int num)
        {
            Assertor.True(actual <= num, string.Format("Expected number smaller or equal to, but was greater. Actual: {0}, Expected greather than: {1}", actual, num));
        }

        public static void ShouldBeSmallerThan(this int actual, int num)
        {
            Assertor.True(actual < num, string.Format("Expected number smaller than, but was greater or equal. Actual: {0}, Expected greather than: {1}", actual, num));
        }

        public static void ShouldBeGreaterThan(this long actual, long num)
        {
            Assertor.True(actual > num, string.Format("Expected number greater than, but was smaller or equal. Actual: {0}, Expected greather than: {1}", actual, num));
        }

        public static void ShouldBeGreaterOrEqualTo(this long actual, long num)
        {
            Assertor.True(actual >= num, string.Format("Expected number greater or equal to, but was smaller. Actual: {0}, Expected greather than: {1}", actual, num));
        }

        public static void ShouldBeSmallerOrEqualTo(this long actual, long num)
        {
            Assertor.True(actual <= num, string.Format("Expected number smaller or equal to, but was greater. Actual: {0}, Expected greather than: {1}", actual, num));
        }

        public static void ShouldBeSmallerThan(this long actual, long num)
        {
            Assertor.True(actual < num, string.Format("Expected number smaller than, but was greater or equal. Actual: {0}, Expected greather than: {1}", actual, num));
        }

        public static void ShouldBeGreaterThan(this decimal actual, decimal num)
        {
            Assertor.True(actual > num, string.Format("Expected number greater than, but was smaller or equal. Actual: {0}, Expected greather than: {1}", actual, num));
        }

        public static void ShouldBeGreaterOrEqualTo(this decimal actual, decimal num)
        {
            Assertor.True(actual >= num, string.Format("Expected number greater or equal to, but was smaller. Actual: {0}, Expected greather than: {1}", actual, num));
        }

        public static void ShouldBeSmallerOrEqualTo(this decimal actual, decimal num)
        {
            Assertor.True(actual <= num, string.Format("Expected number smaller or equal to, but was greater. Actual: {0}, Expected greather than: {1}", actual, num));
        }

        public static void ShouldBeSmallerThan(this decimal actual, decimal num)
        {
            Assertor.True(actual < num, string.Format("Expected number smaller than, but was greater or equal. Actual: {0}, Expected greather than: {1}", actual, num));
        }
    }
}