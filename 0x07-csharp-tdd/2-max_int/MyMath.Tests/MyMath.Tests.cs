using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    public class MyMath_Tests
    {
        [Test]
        public void isListEmpty()
        {
            List<int> list = new List<int>();
            int result = MyMath.Operations.Max(list);
            Assert.AreEqual(0, result);
        }
        [Test]
        public void defaultCase()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            int result = MyMath.Operations.Max(list);
            Assert.AreEqual(2, result);
        }
    }
}
