using NUnit.Framework;
using NUnit.Framework.Internal;

namespace MergeSortTest
{
    [TestFixture()]
    public class SingleItemArraySpec
    {
        private int[] _items;
        private int[] _result;

        [OneTimeSetUp]
        public void Setup()
        {
            // Given
            _items = new [] {1};

            // When
            _result = MergeSort.MergeSort.SortAsync(_items).Result;
        }

        [Test]
        public void ItShouldHaveOneItem()
        {
            Assert.AreEqual(_result.Length, 1);
        }

        [Test]
        public void ItShouldTheItemInTheResult()
        {
            Assert.AreEqual(_result[0], 1);
        }
    }
}