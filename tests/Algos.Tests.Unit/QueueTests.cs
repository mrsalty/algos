using System;
using System.Collections.Generic;
using Algos.Lists;
using Xunit;

namespace Algos.Tests.Unit
{
    public class QueueTests
    {
        private readonly Lists.Queue<int> _sut;

        public QueueTests()
        {
            _sut = new Lists.Queue<int>();
        }

        [Theory]
        [InlineData(new[] { 1 }, 1, new[] { 1 })]
        [InlineData(new[] { 1, 3 }, 2, new[] { 1, 3 })]
        [InlineData(new[] { 1, 3, 4, 6 }, 3, new[] { 1, 3, 4 })]
        public void WhenEnqueueItems_ThenShouldDequeueItemsInRightOrder(int[] items, int dequeueMany, int[] expectedToBeDequeued)
        {
            foreach (var item in items)
            {
                _sut.Enqueue(item);
            }

            var dequeued = new List<int>();

            for (var i = 0; i < dequeueMany; i++)
            {
                dequeued.Add(_sut.Dequeue().Value);
            }

            Assert.Equal(expectedToBeDequeued, dequeued);
        }
    }
}
