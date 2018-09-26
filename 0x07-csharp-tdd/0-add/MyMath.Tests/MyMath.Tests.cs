using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class MyMath_Tests
    {
        [Test]
        public void twoPositiveIntegers()
        {
            int result = MyMath.Operations.Add(2, 2);
            Assert.AreEqual(4, result);
        }
        [Test]
        public void twoNegativeIntegers()
        {
            int result = MyMath.Operations.Add(-2, -2);
            Assert.AreEqual(-4, result);
        }
    }
}
