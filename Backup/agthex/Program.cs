using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;

namespace agthex
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 移动数组示例
            ////定义整形数组
            //int[] myIntArray ={ 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ////将数组显示在控制台上
            //Console.WriteLine("原始数据为：1, 2, 3, 4, 5, 6, 7, 8, 9 ");
            ////从控制台获取输入的整数值
            //string input = "";
            //Console.WriteLine("请输入一个整数值，按回车结束输入");
            //input = Console.ReadLine();
            ////转变为整数值
            //int k;
            //k = Convert.ToInt32(input);
            ////移动数据
            //for (int i = 0; i < k; i++)
            //{
            //    for (int j = 0; j < myIntArray.Length - 1; j++)
            //    {
            //        int temp;
            //        //使用一个额外的存储空间
            //        temp = myIntArray[j];
            //        //和最后一个值交换
            //        myIntArray[j] = myIntArray[myIntArray.Length - 1];
            //        //存储值赋给最后一个数组元素
            //        myIntArray[myIntArray.Length - 1] = temp;
            //    }
            //}
            //Console.Write("移位结果为：");
            ////移位后数据显示到控制台
            ////foreach (int b in myIntArray)
            ////{
            ////    Console.Write("{0}, ",b);
            ////}
            ////Console.ReadKey();
            //for (int n = 0; n < myIntArray.Length; n++)
            //{
            //    if (n < myIntArray.Length - 1)
            //    {
            //        Console.Write("{0}, ", myIntArray[n]);
            //    }
            //    else
            //    {
            //        Console.Write("{0}", myIntArray[n]);
            //    }
            //}
            #endregion

            #region 二叉查找树
            ////现在还不能处理插入值相等的情况
            //BinarySearchTree bst = new BinarySearchTree();
            //bst.Insert(23);
            //bst.Insert(2);
            //bst.Insert(16);
            //bst.Insert(45);
            //bst.Insert(5);
            //bst.Insert(20);
            //bst.Insert(99);
            //bst.Insert(50);
            //bst.Insert(34);
            //Console.WriteLine("中序遍历: ");
            //bst.InOrder(bst.root);
            //Console.WriteLine();
            //Console.WriteLine("先序遍历: ");
            //bst.PreOrder(bst.root);
            //Console.WriteLine();
            //Console.WriteLine("后序遍历: ");
            //bst.PostOrder(bst.root);
            #endregion

            #region 邻接表
            //AdjacencyList<char> a = new AdjacencyList<char>();
            ////添加顶点
            //a.AddVertex('A');
            //a.AddVertex('B');
            //a.AddVertex('C');
            //a.AddVertex('D');
            ////添加边
            //a.AddEdge('A', 'B');
            //a.AddEdge('A', 'C');
            //a.AddEdge('A', 'D');
            //a.AddEdge('B', 'D');
            ////Console.WriteLine(a.ToString());
            //AdjacencyList<string> a = new AdjacencyList<string>();
            //a.AddVertex("V1");
            //a.AddVertex("V2");
            //a.AddVertex("V3");
            //a.AddVertex("V4");
            //a.AddVertex("V5");
            //a.AddVertex("V6");
            //a.AddVertex("V7");
            //a.AddVertex("V8");
            //a.AddEdge("V1", "V2");
            //a.AddEdge("V1", "V3");
            //a.AddEdge("V2", "V4");
            //a.AddEdge("V2", "V5");
            //a.AddEdge("V3", "V6");
            //a.AddEdge("V3", "V7");
            //a.AddEdge("V4", "V8");
            //a.AddEdge("V5", "V8");
            //a.AddEdge("V6", "V8");
            //a.AddEdge("V7", "V8");
            //a.DFSTraverse();
            //Console.WriteLine();
            //a.BFSTraverse();
            #endregion

            #region 优先队列
            //int[] arr = new int[20];
            //Random r=new Random();
            //for (int i = 0; i < arr.Length;i++ )
            //{
            //    arr[i] = r.Next(1, 100);
            //}
            //PriorityQueue<int> pq = new PriorityQueue<int>();
            //pq.Sort(arr);
            #endregion

            #region 已知两个序列求另外的序列
            //string pre = "GDAFEMHZ";
            //string mid = "ADEFGHMZ";
            //PreMid(pre, mid);
#endregion
            
            #region 求子数组和最大
            //int[] a ={ 1, 2, 5, -1, -9, 6, 2, 3, -5, 9 };
            //int sum = MaxSubsequenceSum(a, a.Length);
            //Console.WriteLine("the max sum is: {0}", sum);
#endregion

            #region LIS最长递增序列
            //int[] arr = {1,-1,2,-3,4,-5,6,-7};
            //Console.WriteLine("长度为：{0}", LIS(arr, arr.Length));
            //Console.WriteLine();
            //outputLIS(arr, arr.Length - 1);
#endregion

            #region 判断整数是否为2的方幂
            //这种方法笨成翔了
            //二进制最后一位是否为1
            //string input = Console.ReadLine();
            //int num = int.Parse(input);
            //bool isPower=false;
            //string result;
            //int count=0;
            //if (IsNum(input))
            //{
            //    int num = int.Parse(input);
            //    string str = Convert.ToString(num, 2);
            //    for (int i = 0; i < str.Length-1;i++ )
            //    {
            //        if (str.Substring(i,1).Equals("1"))
            //        {
            //            count += 1;
            //        }
            //    }
            //    if (count == 1)
            //    {
            //        isPower = true;
            //    }               
            //}
            //else
            //{
            //    Console.WriteLine("请输入数字");
            //}
            //一句话能搞定
            //isPower = (num & num - 1)==0 ? true : false;
            //result = isPower ? "是" : "不是";
            //Console.WriteLine("输入的{0}{1}2的方幂", num, result);

#endregion

            #region 求数组中唯一出现两次的两个数
            //数组中只有两个数是出现一次的，尝试找出这两个数，要求时间复杂度为O(n)，空间复杂度为O(1)
            int[] arr = new int[] { 1, 2, 3, 4, 3, 2, 1, 5, 8, 4 };
            int num1, num2;
            FindNumAppearOne(arr, arr.Length, out num1, out num2);
            for (int i = 0; i < arr.Length;i++ )
            {
                Console.Write("{0},", arr[i]);
            }
            Console.WriteLine();
            Console.WriteLine("只出现一次的数字{0},{1}",num1,num2);
#endregion

            #region 类对象的比较
            //Student[] students = new Student[]{
            //    new Student(){Age = 10,Name="张三",Score=70},
            //    new Student(){Age = 12,Name="李四",Score=97},
            //    new Student(){Age = 11,Name="王五",Score=80},
            //    new Student(){Age = 9,Name="赵六",Score=66},
            //    new Student(){Age = 12,Name="司马",Score=90},
            //};
            //Console.WriteLine("--------------默认排序输出--------");
            //Array.Sort(students);
            //Array.ForEach<Student>(students, (s) =>Console.WriteLine(string.Format("{0}{1,2}岁了，他的分数是{2,3}", s.Name, s.Age, s.Score)));

            //Console.WriteLine("----------按分数排序输出------------");
            //Array.Sort(students, new StudentScoreComparer());
            //Array.ForEach<Student>(students, (s) => Console.WriteLine(string.Format("{0}{1,2}岁了，他的分数是{2,3}", s.Name, s.Age, s.Score)));
 
            //Console.WriteLine("----------按分数排序输出----------");
            //Array.Sort(students, (s1, s2) => s1.Score.CompareTo(s2.Score));
            //Array.ForEach<Student>(students, (s) => Console.WriteLine(string.Format("{0}{1,2}岁了，他的分数是{2,3}", s.Name, s.Age, s.Score)));
            #endregion

            Console.ReadKey();
        }

        #region 已知遍历序列求二叉树
        //private static void PreMid(string pre, string mid)
        //{
        //    char[] chars=pre.ToCharArray();
        //    if (pre.Length ==1)
        //    {
        //        Console.Write(pre + ";");
        //        return;
        //    }
        //    //int k = mid.IndexOf(char.Parse(pre.Substring(0, 1)));
        //    int k = find(mid, chars[0]);
        //    string pretmp = pre.Substring(1, k);
        //    string midtmp = mid.Substring(0, k);
        //    PreMid(pretmp, midtmp);
        //    pretmp = pre.Substring(k + 1, pre.Length - k - 1);
        //    midtmp = mid.Substring(k + 1, mid.Length - k - 1);
        //    PreMid(pretmp, midtmp);
        //    Console.Write(pre.Substring(0, 1));
        //}
        //private static int find(string str, char c)
        //{
        //    char[] chars = str.ToCharArray();
        //    for (int i = 0; i < chars.Length; i++)
        //    {
        //        if (c.Equals(chars[i]))
        //        {
        //            return i;
        //        }
        //    }
        //    return -1;
        //}
        #endregion

        #region 子数组和最大
        private static int MaxSubsequenceSum( int[] A, int N )  
            {  
                int ThisSum, MaxSum, j;  
              
                ThisSum = MaxSum = 0;  
                for( j = 0; j < N; j++ )  
                {  
                    ThisSum += A[ j ];  
              
                    if( ThisSum > MaxSum )  
                        MaxSum = ThisSum;  
                    else if( ThisSum < 0 )  
                        ThisSum = 0;  
                }  
                return MaxSum;  
            }
#endregion

        #region 最长递增子序列LIS
        static int[] dp=new int[30];
        static int lis;
        private static int LIS(int[] arr, int size)
        {
            for (int i = 0; i < size;i++ )
            {
                dp[i] = 1;
                for (int j = 0; j < i;j++ )
                {
                    if (arr[i]>arr[j] && dp[i] < dp[j] +1)
                    {
                        dp[i] = dp[j] + 1;
                        lis = dp[i];
                    }
                }
            }
            return lis;
        }
        private static void outputLIS(int[] arr, int index)
        {
            bool isLIS = false;
            if (index <0 || lis ==0)
            {
                return;
            }
            if (dp[index] == lis)
            {
                lis -=1;
                isLIS = true;
            }
            index -= 1;
            outputLIS(arr, index);
            if (isLIS)
            {
                Console.Write("\t {0}", arr[index + 1]);
            }
        }
#endregion

        #region 判断输入是否为数字
        public static bool IsNum(string s)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(s, @"^\d+");
        }
        #endregion

        #region 两个出现一次的数
        //找到二进制数中第一个为1的位置
        public static int FindFirstBitIS1(int num)
        {
            int indexBit = 0;
            while (((num & 1)==0) && (indexBit<32))
            {
                num = num >> 1;
                indexBit += 1;
            }
            return indexBit;
        }
        //判断一个数的二进制在某一位上是否为1
        public static bool IsBit1(int num, int indexBit)
        {
            num = num >> indexBit;
            return (num & 1) == 1 ? true : false;
        }
        public static void FindNumAppearOne(int[] arr, int length, out int num1, out int num2)
        {
            num1 = 0;
            num2 = 0;
            if (length < 2)
            {
                Console.WriteLine("输入的数组不合适");
                return;
            }
            int resultExclusiveOR = 0;
            for (int i = 0; i < length;i++ )
            {
                resultExclusiveOR ^= arr[i];
            }
            int indexOf1 = FindFirstBitIS1(resultExclusiveOR);
            for (int j = 0; j < length;j++ )
            {
                if (IsBit1(arr[j],indexOf1))
                {
                    num1 ^= arr[j];
                } 
                else
                {
                    num2 ^= arr[j];
                }
            }
        }

        #endregion

        #region C#中的类对象的排序

        public class Student : IComparable
        {
            public int Age { get; set; }

            public string Name { get; set; }

            public int Score { get; set; }

            /// <summary>
            /// 实现IComparable接口，用Age做比较
            /// </summary>
            /// <param name="obj">比较对象</param>
            /// <returns>比较结果</returns>
            public int CompareTo(object obj)
            {
                if (obj is Student)
                {
                    return Age.CompareTo(((Student)obj).Age);
                }

                return 1;
            }
        }

        public class StudentScoreComparer : IComparer<Student>
        {
            public int Compare(Student x, Student y)
            {
                return x.Score.CompareTo(y.Score);
            }
        }
#endregion

    }
}
