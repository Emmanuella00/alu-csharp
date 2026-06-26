using NUnit.Framework;
using Text;

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void UniqueChar_FirstCharUnique_ReturnsZero()
        {
            Assert.AreEqual(0, Str.UniqueChar("abcdef"));
        }

        [Test]
        public void UniqueChar_UniqueInMiddle_ReturnsIndex()
        {
            Assert.AreEqual(2, Str.UniqueChar("aabccd"));
        }

        [Test]
        public void UniqueChar_NoUniqueChar_ReturnsNegativeOne()
        {
            Assert.AreEqual(-1, Str.UniqueChar("aabb"));
        }

        [Test]
        public void UniqueChar_EmptyString_ReturnsNegativeOne()
        {
            Assert.AreEqual(-1, Str.UniqueChar(""));
        }

        [Test]
        public void UniqueChar_NullString_ReturnsNegativeOne()
        {
            Assert.AreEqual(-1, Str.UniqueChar(null));
        }

        [Test]
        public void UniqueChar_SingleChar_ReturnsZero()
        {
            Assert.AreEqual(0, Str.UniqueChar("z"));
        }

        [Test]
        public void UniqueChar_UniqueAtEnd_ReturnsLastIndex()
        {
            Assert.AreEqual(4, Str.UniqueChar("aabbcd"));
        }

        [Test]
        public void UniqueChar_AllSameChar_ReturnsNegativeOne()
        {
            Assert.AreEqual(-1, Str.UniqueChar("aaaa"));
        }
    }
}