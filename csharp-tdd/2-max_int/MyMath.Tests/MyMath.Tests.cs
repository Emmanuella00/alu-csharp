using NUnit.Framework;
using MyMath;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void Max_PositiveNumbers_ReturnsMax()
        {
            List<int> nums = new List<int> { 1, 2, 3, 4, 5 };
            Assert.AreEqual(5, Operations.Max(nums));
        }

        [Test]
        public void Max_NegativeNumbers_ReturnsMax()
        {
            List<int> nums = new List<int> { -1, -2, -3, -4, -5 };
            Assert.AreEqual(-1, Operations.Max(nums));
        }

        [Test]
        public void Max_EmptyList_ReturnsZero()
        {
            List<int> nums = new List<int>();
            Assert.AreEqual(0, Operations.Max(nums));
        }

        [Test]
        public void Max_NullList_ReturnsZero()
        {
            Assert.AreEqual(0, Operations.Max(null));
        }

        [Test]
        public void Max_SingleElement_ReturnsThatElement()
        {
            List<int> nums = new List<int> { 42 };
            Assert.AreEqual(42, Operations.Max(nums));
        }

        [Test]
        public void Max_MixedNumbers_ReturnsMax()
        {
            List<int> nums = new List<int> { -10, 0, 5, 3, -2 };
            Assert.AreEqual(5, Operations.Max(nums));
        }
    }
}