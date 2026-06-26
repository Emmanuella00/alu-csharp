using NUnit.Framework;
using Text;

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void CamelCase_OneWord_ReturnsOne()
        {
            Assert.AreEqual(1, Str.CamelCase("hello"));
        }

        [Test]
        public void CamelCase_TwoWords_ReturnsTwo()
        {
            Assert.AreEqual(2, Str.CamelCase("helloWorld"));
        }

        [Test]
        public void CamelCase_ThreeWords_ReturnsThree()
        {
            Assert.AreEqual(3, Str.CamelCase("camelCaseString"));
        }

        [Test]
        public void CamelCase_EmptyString_ReturnsZero()
        {
            Assert.AreEqual(0, Str.CamelCase(""));
        }

        [Test]
        public void CamelCase_NullString_ReturnsZero()
        {
            Assert.AreEqual(0, Str.CamelCase(null));
        }

        [Test]
        public void CamelCase_SingleChar_ReturnsOne()
        {
            Assert.AreEqual(1, Str.CamelCase("a"));
        }

        [Test]
        public void CamelCase_MultipleWords_ReturnsCorrectCount()
        {
            Assert.AreEqual(5, Str.CamelCase("myNameIsJohnDoe"));
        }
    }
}