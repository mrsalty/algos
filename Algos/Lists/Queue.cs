using System.Collections.Generic;
using System.Threading;

namespace Algos.Lists
{

    public class Queue<T>
    {
        private readonly IList<QueueItem<T>> _items;

        public int Count;

        public Queue()
        {
            _items = new List<QueueItem<T>>();
        }


        public void Enqueue(T value)
        {
            var newItem = new QueueItem<T>(value);

            if (Count > 0)
            {
                newItem.SetNext(_items[0]);
            }

            _items.Add(newItem);
            Count++;
        }

        public QueueItem<T> Dequeue()
        {
            if (Count > 0)
            {
                var dequeued = _items[0];
                _items.RemoveAt(0);
                return dequeued;
            }
            return null;
        }
    }

    public class QueueItem<T>
    {
        public QueueItem(T value)
        {
            Value = value;
        }

        public QueueItem(T value, QueueItem<T> next)
        {
            Value = value;
            Next = next;
        }

        public QueueItem<T> Next { get; private set; }

        public T Value { get; private set; }

        public void SetNext(QueueItem<T> next)
        {
            Next = next;
        }
    }
}
