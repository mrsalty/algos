using Algos.Arrays;
using Xunit;

namespace Algos.Tests.Unit
{
    public class QuickSortTests
    {
        private readonly QuickSort _sut;

        public QuickSortTests()
        {
            _sut = new QuickSort();
        }

        [Theory]
        [InlineData(new[] { 1, }, new[] { 1 })]
        [InlineData(new[] { 50, 5, 21, 12, 1, 0 }, new[] { 0, 1, 5, 12, 21, 50 })]
        [InlineData(new[] { 1, 5, 34, 12, 7, 2, 21 }, new[] { 1, 2, 5, 7, 12, 21, 34 })]
        public void WhenQuickSortArray_ThenArrayIsSorted(int[] arr, int[] sorted)
        {
            _sut.Sort(arr, 0, arr.Length - 1);

            Assert.Equal(sorted, arr);
        }
    }
}
