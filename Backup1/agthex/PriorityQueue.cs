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

        /// <summary>
        /// ����һ��ֵ�����ȷŵ���β��֮��������ϲ��ƶ�
        /// </summary>
        /// <param name="v"></param>
        public void Push(T v)
        {
            if (count >= heap.Length) Array.Resize(ref heap, count * 2);
            heap[count] = v;
            SiftUp(count++);
        }

        /// <summary>
        /// �����ѵĸ�Ԫ�أ�����β��Ԫ����ʱ�ŵ�����λ�ã�֮��������²��ƶ�
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            //ԭ����ΪʲôҪʹ��var�����أ�ֱ��ʹ��T��������
            T v = Top();
            heap[0] = heap[--count];
            if (count > 0) SiftDown(0);
            return v;
        }

        public T Top()
        {
            if (count > 0) return heap[0];
            throw new InvalidOperationException("���ȶ���Ϊ��");
        }

        void SiftUp(int n)
        {
            T v = heap[n];
            //�븸�ڵ�Ƚϴ�С��������ڸ��ڵ㣬����������γɴ󶥶�
            //�²�������
            //�޸�ΪС����
            //for (int n2 = n / 2; n > 0 && comparer.Compare(v, heap[n2]) > 0; n = n2, n2 /= 2) heap[n] = heap[n2];
            for (int n2 = n / 2; n > 0 && comparer.Compare(v, heap[n2]) < 0; n = n2, n2 /= 2) heap[n] = heap[n2];
            heap[n] = v;
        }

        void SiftDown(int n)
        {
            T v = heap[n];
            for (int n2 = n * 2; n2 < count; n = n2, n2 *= 2)
            {
                //����������ϴ�
                //if (n2 + 1 < count && comparer.Compare(heap[n2 + 1], heap[n2]) > 0) n2++;
                if (n2 + 1 < count && comparer.Compare(heap[n2 + 1], heap[n2]) <= 0) n2++;
                //��ʱ�������ϴ�
                //if (comparer.Compare(v, heap[n2]) >= 0) break;
                if (comparer.Compare(v, heap[n2]) <= 0) break;
                //�븸�����н���
                heap[n] = heap[n2];
            }
            heap[n] = v;
        }

        //���Ӳ���������
        public void Sort(T[] data)
        {
            int i;
            PriorityQueue<T> pq = new PriorityQueue<T>(data.Length);
            for (i = 0; i < data.Length;i++ )
            {
                pq.Push(data[i]);
            }

            //��ӡ����
            Print(pq);
        }

        #region ��ӡ����
        public static void Print(PriorityQueue<T> pq)
        {
            int length = pq.Count;
            if (length == 0) return;
            string format = "D";
            Type type = typeof(T);
            string typeName = type.ToString().ToUpper();
            switch (typeName)
            {
                case "DOUBLE":
                    format = "F4";
                    break;
                case "CHAR":
                    format = "g";
                    break;
                default:
                    break;
            }
            //�˴�����ʹ��pop�ķ�ʽ����Ϊ��ӡ������ɾ�������е�Ԫ�أ��������һ��������ת��Ϊ����ķ���
            //�����ǽ��˶��и���һ��
            PriorityQueue<T> tmp = new PriorityQueue<T>();
            tmp = pq;
            for (int i = 0; i < length; i++)
            {
                if (i < length - 1)
                {
                    Console.Write("{0:" + format + "}, ", tmp.Pop());
                }
                else
                {
                    Console.Write("{0:" + format + "}", tmp.Pop());
                }
            }
            Console.WriteLine();

        }
        #endregion


    }
}