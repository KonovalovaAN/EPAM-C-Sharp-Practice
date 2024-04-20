using NUnit.Framework;

namespace JaggedArrays.Tests
{
    [TestFixture]
    public class ArrayExtensionTests
    {
        [TestCaseSource(typeof(TestCasesDataSource), nameof(TestCasesDataSource.TestCasesForSumByAscending))]
        public void OrderByAscendingBySum_Tests(int[][] source, int[][] expected)
        {
            source.OrderByAscendingBySum();
            Assert.AreEqual(expected, source);
        }

        [Test]
        public void OrderByAscendingBySum_SourceIsNull_ThrowArgumentNullException()
        {
#pragma warning disable CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
            Assert.Throws<ArgumentNullException>(() => ArrayExtension.OrderByAscendingBySum(null));
#pragma warning restore CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
        }

        [TestCaseSource(typeof(TestCasesDataSource), nameof(TestCasesDataSource.TestCasesForSumByDescending))]
        public void OrderByDescendingBySum_Tests(int[][] source, int[][] expected)
        {
            source.OrderByDescendingBySum();
            Assert.AreEqual(expected, source);
        }

        [Test]
        public void OrderByDescendingBySum_SourceIsNull_ThrowArgumentNullException()
#pragma warning disable CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
        {
            Assert.Throws<ArgumentNullException>(() => ArrayExtension.OrderByDescendingBySum(null));
        }
#pragma warning restore CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.

        [TestCaseSource(typeof(TestCasesDataSource), nameof(TestCasesDataSource.TestCasesForMaxAscending))]
        public void OrderByAscendingByMax_Tests(int[][] source, int[][] expected)
        {
            source.OrderByAscendingByMax();
            Assert.AreEqual(expected, source);
        }

#pragma warning disable IDE0079 // Удалить ненужное подавление
#pragma warning disable CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
        [Test]
#pragma warning restore IDE0079 // Удалить ненужное подавление
#pragma warning disable IDE0079 // Удалить ненужное подавление
#pragma warning restore CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
        public void OrderByAscendingByMax_SourceIsNull_ThrowArgumentNullException()
#pragma warning restore IDE0079 // Удалить ненужное подавление
        {
#pragma warning disable CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
            Assert.Throws<ArgumentNullException>(() => ArrayExtension.OrderByAscendingByMax(null));
#pragma warning restore CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
        }

        [TestCaseSource(typeof(TestCasesDataSource), nameof(TestCasesDataSource.TestCasesForMaxDescending))]
        public void OrderByDescendingByMax_Tests(int[][] source, int[][] expected)
#pragma warning disable IDE0079 // Удалить ненужное подавление
#pragma warning disable CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
        {
            source.OrderByDescendingByMax();
            Assert.AreEqual(expected, source);
        }
#pragma warning restore IDE0079 // Удалить ненужное подавление
#pragma warning disable IDE0079 // Удалить ненужное подавление
#pragma warning restore CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.

        [Test]
#pragma warning restore IDE0079 // Удалить ненужное подавление
        public void OrderByDescendingByMax_SourceIsNull_ThrowArgumentNullException()
#pragma warning disable CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
        {
            Assert.Throws<ArgumentNullException>(() => ArrayExtension.OrderByDescendingByMax(null));
        }
#pragma warning restore CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
    }
}
