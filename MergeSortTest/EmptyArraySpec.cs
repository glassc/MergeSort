using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MergeSortTest
{
    [TestFixture()]
    public class EmptyArraySpec
    {
        private int[] _items;
        private int[] _result;

        [OneTimeSetUp]
        public void Setup()
        {
            // Given
            _items = new int[0];

            // When
            _result = MergeSort.MergeSort.SortAsync(_items).Result;
        }

        [Test]
        public void ItShouldBeEmpty()
        {
            Assert.AreEqual(_result.Length, 0);
        }
    }
}
