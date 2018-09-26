using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Text_Tests
    {
        [Test]
        public void firstNonRepeatingChar()
        {
            string test = "unique";
            int result = Text.Str.UniqueChar(test);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void noUniqueReturnsNegativeOne()
        {
            string test = "uuttee";
            int result = Text.Str.UniqueChar(test);
            Assert.AreEqual(-1, result);
        }
    }
}
