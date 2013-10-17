using System;
using System.Collections.Generic;
using System.Text;

namespace agthex
{
    public class PriorityQueue<T>
    {
        IComparer<T> comparer;
        T[] heap;
        private int count;
        public int Count { get { return count;} set { count = value; } }
        public PriorityQueue() : this(null) { }
        public PriorityQueue(int capacity) : this(capacity, null) { }
        public PriorityQueue(IComparer<T> comparer) : this(16, comparer) { }

        public PriorityQueue(int capacity, IComparer<T> comparer)
        {
            this.comparer = (comparer == null) ? Comparer<T>.Default : comparer;
            this.heap = new T[capacity];
        }

        public void Push(T v)
        {
            if (count >= heap.Length) Array.Resize(ref heap, count * 2);
            heap[count] = v;
            SiftUp(count++);
        }

        public T Pop()
        {
            //原文中为什么要使用var变量呢，直接使用T不可以吗？
            T v = Top();
            heap[0] = heap[--count];
            if (count > 0) SiftDown(0);
            return v;
        }

        public T Top()
        {
            if (count > 0) return heap[0];
            throw new InvalidOperationException("优先队列为空");
        }

        void SiftUp(int n)
        {
            T v = heap[n];
            //与父节点比较大小，如果大于父节点，交换，最后形成大顶堆
            for (int n2 = n / 2; n > 0 && comparer.Compare(v, heap[n2]) > 0; n = n2, n2 /= 2) heap[n] = heap[n2];
            heap[n] = v;
        }

        void SiftDown(int n)
        {
            T v = heap[n];
            for (int n2 = n * 2; n2 < count; n = n2, n2 *= 2)
            {
                if (n2 + 1 < count && comparer.Compare(heap[n2 + 1], heap[n2]) > 0) n2++;
                if (comparer.Compare(v, heap[n2]) >= 0) break;
                heap[n] = heap[n2];
            }
            heap[n] = v;
        }

        //添加测试排序功能
        public void Sort(T[] data)
        {
            int i;
            PriorityQueue<T> pq = new PriorityQueue<T>(data.Length);
            for (i = 0; i < data.Length;i++ )
            {
                pq.Push(data[i]);
            }

            //打印出来
            for (i = 0; i < data.Length; i++)
            {
                T t=pq.Pop();
                Console.Write("{0} ", t.ToString());
            }
        }
    }
}
