using System;
using System.Collections.Generic;
using System.Text;

namespace agthex
{
    public class Node
    {
        public int Data;
        public Node Left;
        public Node Right;
        public void DisplayNode()
        {
            Console.Write(Data + " ");
        }
    }
    public class BinarySearchTree
    {
        public Node root;
        public BinarySearchTree()
        {
            root = null;
        }
#region 方法
        /// <summary>
        /// 插入新结点
        /// </summary>
        /// <param name="i"></param>
        public void Insert(int i)
        {
            Node newNode = new Node();
            newNode.Data = i;
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                Node parent = new Node();
                while (true)
                {
                    parent = current;
                    if (i < parent.Data)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = newNode;
                            break;
                        }
                    }
                }
            }
        }

        //三种遍历树的方式

        /// <summary>
        /// 中序遍历
        /// </summary>
        /// <param name="theRoot"></param>
        public void InOrder(Node theRoot)
        {
            if (theRoot !=null)
            {
                InOrder(theRoot.Left);
                theRoot.DisplayNode();
                InOrder(theRoot.Right);
            }
        }

        /// <summary>
        /// 先序遍历
        /// </summary>
        /// <param name="theRoot"></param>
        public void PreOrder(Node theRoot)
        {
            if (theRoot != null)
            {
                theRoot.DisplayNode();
                PreOrder(theRoot.Left);
                PreOrder(theRoot.Right);
            }
        }

        /// <summary>
        /// 先序遍历
        /// </summary>
        /// <param name="theRoot"></param>
        public void PostOrder(Node theRoot)
        {
            if (theRoot != null)
            {
                PostOrder(theRoot.Left);
                PostOrder(theRoot.Right);
                theRoot.DisplayNode();
            }
        }

        //查找一个值
        public Node Find(int key)
        {
            Node current = root;
            while (current.Data !=key)
            {
                if (key<current.Data)
                {
                    current = current.Left;
                } 
                else
                {
                    current = current.Right;
                }
            }
            return current;
        }
#endregion
        

    }
}
