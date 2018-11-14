using System;
using Algos.Arrays;
using Xunit;

namespace Algos.Tests.Unit
{
    public class BinarySearchTests
    {
        private readonly BinarySearch _sut;

        public BinarySearchTests()
        {
            _sut = new BinarySearch();
        }

        [Theory]
        [InlineData(new int[] {}, 1, -1)]
        [InlineData(new[] { 1 }, 1, 0)]
        [InlineData(new[] { 5, 6 }, 6, 1)]
        [InlineData(new[] { 5, 6 }, 5, 0)]
        [InlineData(new[] { 1, 2, 3, 5, 9, 21 }, 21, 5)]
        [InlineData(new[] { 1, 2, 3, 5, 7, 9, 21 }, 3, 2)]
        public void WhenBinarySearch_FindsCorrectValue(int[] arr, int value, int foundIndex)
        {
            var result = _sut.SearchArray(arr, value);

            Assert.Equal(foundIndex, result);
        }
    }
}
