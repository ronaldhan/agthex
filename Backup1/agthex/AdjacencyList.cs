using System;
using System.Collections.Generic;
using System.Text;

namespace agthex
{
    
    public class AdjacencyList<T>
    {
        List<Vertex<T>> items; //图的顶点集合
        public AdjacencyList() //构造方法
        {
            items = new List<Vertex<T>>();
        } 
        public AdjacencyList(int capacity) //指定容量的构造方法
        {
            items = new List<Vertex<T>>(capacity);
        }

        public void AddVertex(T item) //添加一个顶点
        {   //不允许插入重复值
            if (Contains(item))
            {
                throw new ArgumentException("插入了重复顶点！");
            }
            items.Add(new Vertex<T>(item));
        }

        public void AddEdge(T from, T to) //添加无向边
        {
            Vertex<T> fromVer = Find(from); //找到起始顶点
            if (fromVer == null)
            {
                throw new ArgumentException("头顶点并不存在！");
            }
            Vertex<T> toVer = Find(to); //找到结束顶点
            if (toVer == null)
            {
                throw new ArgumentException("尾顶点并不存在！");
            }
            //无向边的两个顶点都需记录边信息
            AddDirectedEdge(fromVer, toVer);
            AddDirectedEdge(toVer, fromVer);
        }
        public bool Contains(T item) //查找图中是否包含某项
        {
            foreach (Vertex<T> v in items)
            {
                if (v.data.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }
        private Vertex<T> Find(T item) //查找指定项并返回
        {
            foreach (Vertex<T> v in items)
            {
                if (v.data.Equals(item))
                {
                    return v;
                }
            }
            return null;
        }

        //添加有向边
        private void AddDirectedEdge(Vertex<T> fromVer, Vertex<T> toVer)
        {
            if (fromVer.firstEdge == null) //无邻接点时
            {
                fromVer.firstEdge = new Node(toVer);
            }
            else
            {
                Node tmp, node = fromVer.firstEdge;
                do
                {   //检查是否添加了重复边
                    if (node.adjvex.data.Equals(toVer.data))
                    {
                        throw new ArgumentException("添加了重复的边！");
                    }
                    tmp = node;
                    node = node.next;
                } while (node != null);
                tmp.next = new Node(toVer); //添加到链表未尾
            }
        }
        public override string ToString() //仅用于测试
        {   //打印每个节点和它的邻接点
            string s = string.Empty;
            foreach (Vertex<T> v in items)
            {
                s += v.data.ToString() + ":";
                if (v.firstEdge != null)
                {
                    Node tmp = v.firstEdge;
                    while (tmp != null)
                    {
                        s += tmp.adjvex.data.ToString();
                        tmp = tmp.next;
                    }
                }
                s += "\r\n";
            }
            return s;
        }

        //嵌套类，表示存放于数组中的表头结点
        public class Vertex<TValue>
        {
            public TValue data; //数据
            public Node firstEdge; //邻接点链表头指针
            public bool visited; //访问标志,遍历时使用
            public Vertex(TValue value) //构造方法
            {
                data = value;
            }
        }

        //嵌套类，表示链表中的表结点
        public class Node
        {
            public Vertex<T> adjvex; //邻接点域
            public Node next; //下一个邻接点指针域
            public Node(Vertex<T> value)
            {
                adjvex = value;
            }
        }

        //两种访问方式
        /// <summary>
        /// 深度优先遍历
        /// </summary>
        public void DFSTraverse()
        {
            InitVisited(); //将visited标志全部置为false
            DFS(items[0]); //从第一个顶点开始遍历
        }

        private void DFS(Vertex<T> v)
        {
            //标记为已访问过
            v.visited = true;
            Console.Write(v.data + " ");
            Node node = v.firstEdge;
            
            //访问此顶点的所有邻接点
            while (node != null)
            {
                //如果邻接点未被访问，则递归访问它的边
                if (! node.adjvex.visited)
                {
                    //递归访问
                    DFS(node.adjvex);
                }
                //访问下一个邻接点
                node = node.next;
            }
        }

        /// <summary>
        /// 初始化标记
        /// </summary>
        private void InitVisited()
        {
            foreach (Vertex<T> v in items)
            {
                v.visited = false;
            }
        }

        /// <summary>
        /// 深度优先遍历
        /// </summary>
        public void BFSTraverse()
        {
            InitVisited(); //将visited标志全部置为false
            BFS(items[0]); //从第一个顶点开始遍历
        }

        private void BFS(Vertex<T> v)
        {
            Queue<Vertex<T>> queue = new Queue<Vertex<T>>();
            Console.Write(v.data + " ");
            v.visited = true;
            queue.Enqueue(v);
            //只要队不为空就循环
            while (queue.Count > 0)
            {
                Vertex<T> w = queue.Dequeue();
                Node node = w.firstEdge;
                //访问此顶点的所有邻接点
                while (node != null)
                {
                    //如果邻接点未被访问，则递归访问它的边
                    if (! node.adjvex.visited)
                    {
                        Console.Write(node.adjvex.data + " "); //访问
                        node.adjvex.visited = true; //设置访问标志
                        queue.Enqueue(node.adjvex); //进队
                    }
                    //访问下一个邻接点
                    node = node.next;
                }
            }
        }

    }
}
