using NUnit.Framework;

namespace MergeSortTest
{
    
    [TestFixture()]
    public class EvenNumberOfItemsSpec
    {
        private int[] _items;
        private int[] _result;

        [OneTimeSetUp]
        public void Setup()
        {
            // Given
            _items = new [] {3,7,2, 4};

            // When
            _result = MergeSort.MergeSort.SortAsync(_items).Result;
        }

        [Test]
        public void ItShouldHaveFourItems()
        {
            Assert.AreEqual(_result.Length, 4);
        }

        [Test]
        public void ItShouldBeInTheCorrectOrder()
        {
            Assert.AreEqual(_result[0], 2);
            Assert.AreEqual(_result[1], 3);
            Assert.AreEqual(_result[2], 4);
            Assert.AreEqual(_result[3], 7);
        }
    }
}