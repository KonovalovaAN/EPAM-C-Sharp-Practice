using NUnit.Framework;
using static FindMaximumTask.ArrayExtension;

namespace FindMaximumTask.Tests
{
    public class ArrayExtensionTests
    {
        private int[]? array;
        private int max;

        [SetUp]
        public void Setup()
        {
            this.max = 10_000_000;
            this.array = Enumerable.Range(1, this.max).ToArray();
        }

        [Order(1)]
        [TestCase(new int[] { 0, 50 }, ExpectedResult = 50)]
        [TestCase(new int[] { 100 }, ExpectedResult = 100)]
        [TestCase(new int[] { int.MaxValue, int.MaxValue, int.MinValue, 50 }, ExpectedResult = int.MaxValue)]
        [TestCase(new int[] { 50, int.MinValue, 25, 25 }, ExpectedResult = 50)]
        [TestCase(new int[] { 25, 25, 10, 25, 25, 100 }, ExpectedResult = 100)]
        [TestCase(new int[] { -50, -25, -20, -5, 500, -100 }, ExpectedResult = 500)]
        [TestCase(new int[] { -50, -25, -20, -5, -500, -100 }, ExpectedResult = -5)]
        [TestCase(new int[] { -50, -25, -20, 0, -500, -100 }, ExpectedResult = 0)]
        [TestCase(new int[] { 0, 0, 0, 0, 0, 0 }, ExpectedResult = 0)]
        [TestCase(new int[] { 0, 1, 0, 0, 0, 0 }, ExpectedResult = 1)]
        public int FindMaximum_ReturnMaximumElement(int[] source)
        {
            return FindMaximum(source);
        }

        [Test]
        public void FindMaximum_ArrayIsNull_ThrowArgumentNullException()
        {
#pragma warning disable CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
            Assert.Throws<ArgumentNullException>(() => FindMaximum(null), message: "source cannot be null.");
#pragma warning restore CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
        }

        [Test]
        public void FindMaximum_ArrayIsEmpty_ThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => FindMaximum(Array.Empty<int>()), message: "source cannot be empty.");
        }

        [Test]
        [Order(0)]
        [Timeout(5_000)]
        public void FindMaximum_TestForLargeArray()
        {
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            int expected = this.max;
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            int actual = FindMaximum(this.array);
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            Assert.AreEqual(expected, actual);
        }
    }
}
