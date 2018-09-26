using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Text_Tests
    {
        [Test]
        public void oneWord()
        {
            string test = "one";
            int result = Text.Str.CamelCase(test);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void twoWords()
        {
            string test = "twoWords";
            int result = Text.Str.CamelCase(test);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void emptyString()
        {
            string test = "";
            int result = Text.Str.CamelCase(test);
            Assert.AreEqual(0, result);
        }
    }
}
