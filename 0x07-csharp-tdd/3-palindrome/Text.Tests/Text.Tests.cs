using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Text_Tests
    {
        [Test]
        public void isPalindrome()
        {
            string test = "dad";
            bool result = Text.Str.IsPalindrome(test);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void isNotPalindrome()
        {
            string test = "da";
            bool result = Text.Str.IsPalindrome(test);
            Assert.AreEqual(false, result);
        }

        [Test]
        public void hasCapitalsReturnsTrue()
        {
            string test = "Dad";
            bool result = Text.Str.IsPalindrome(test);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void hasPunctuationReturnsTrue()
        {
            string test = "A man, a plan, a canal: Panama.";
            bool result = Text.Str.IsPalindrome(test);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void emptyStringReturnsTrue()
        {
            string test = "";
            bool result = Text.Str.IsPalindrome(test);
            Assert.AreEqual(true, result);
        }
    }
}
