using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;
using System.Linq;
using System.Threading;
using System.Diagnostics;

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
            //int[] arr = new int[] { 1, 2, 3, 4, 3, 2, 1, 5, 8, 4 };
            //int num1, num2;
            //FindNumAppearOne(arr, arr.Length, out num1, out num2);
            //for (int i = 0; i < arr.Length;i++ )
            //{
            //    Console.Write("{0},", arr[i]);
            //}
            //Console.WriteLine();
            //Console.WriteLine("只出现一次的数字{0},{1}",num1,num2);
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
            //Array.ForEach<Student>(students, (s) => Console.WriteLine(string.Format("{0}{1,2}岁了，他的分数是{2,3}", s.Name, s.Age, s.Score)));

            //Console.WriteLine("----------按分数排序输出------------");
            //Array.Sort(students, new StudentScoreComparer());
            //Array.ForEach<Student>(students, (s) => Console.WriteLine(string.Format("{0}{1,2}岁了，他的分数是{2,3}", s.Name, s.Age, s.Score)));

            //Console.WriteLine("----------按分数排序输出----------");
            //Array.Sort(students, (s1, s2) => s1.Score.CompareTo(s2.Score));
            //Array.ForEach<Student>(students, (s) => Console.WriteLine(string.Format("{0}{1,2}岁了，他的分数是{2,3}", s.Name, s.Age, s.Score)));
            #endregion

            #region n个骰子和问题
            //递归解
            //string inNum = Console.ReadLine();
            //int number = int.Parse(inNum);
            //if (number < 1)
            //    return;

            //int maxSum = number * g_maxValue;
            //int[] pProbabilities = new int[maxSum - number + 1];
            //for (int i = number; i <= maxSum; ++i)
            //    pProbabilities[i - number] = 0;

            //SumProbabilityOfDices(number, pProbabilities);

            ////int total = pow((float)g_maxValue, number);
            //double total=Math.Pow((double)g_maxValue,(double)number);
            //for (int i = number; i <= maxSum; ++i)
            //{
            //    double ratio = (double)pProbabilities[i - number] / total;
            //    Console.WriteLine("{0:d2}: {1:F8}\n", i, ratio);
            //}
            //非递归解
            //此种方式定义，初始化数组中值为0
            //int[,] arr=new int[2,3];
            //Console.WriteLine("int[1,2]:{0}", arr[1, 2]);

#endregion

            #region 数组中出现次数超过长度一半的数字
            //主要思路有三种，其一是对数组进行排序，统计其中每个数字出现的个数，然后找到最后一个即为满足条件的结果，要求假设必须满足
            //其二可以使用hashtable，将数字和出现的次数分别作为键和值，存在的问题是如果数字的范围非常大，hashtable需要设置非常大，浪费空间
            //其三考虑利用数字的特性，既然出现次数超过一半，可以考虑在遍历数据时保存两个值，其一是当前值，其二是出现次数。当遍历到下一个数字时
            //如果相等则计数器+1，如果不等则-1，为0时重新置为1，最后一次把数字置为1时对应的数字即为应求结果
            //int[] arr = new int[] { 1, 2, 3, 2, 2, 4, 2, 2, 2,1 };
            //bool g_binputinvalid = false;
            //int result = arr[0];
            //int times = 1;
            //for (int i = 1; i < arr.length;i++ )
            //{
            //    if (times == 0)
            //    {
            //        result = arr[i];
            //        times = 1;
            //    }
            //    else if (arr[i]==result)
            //    {
            //        times += 1;
            //    }
            //    else
            //    {
            //        times -= 1;
            //    }
            //    console.write("{0:d},", arr[i]);
            //} 
            //console.writeline("出现次数最多的数字是{0:d}:", result);
#endregion

            #region 字符串匹配
            //string source = "abcdaddacdaddraruaaed";
            //string target = "ddr";
            //int pos=0;
            //int index = FindIndex(source, target, pos);
            //Console.WriteLine("source:{0}\r\ntarget:{1}\r\nindex:{2}", source, target, index);

            //int[] next;
            //get_next(target, target.Length, out next);
            //index = KMP_Search(source, target, next, pos);
            //Console.WriteLine("index:{0}", index);
#endregion

            #region 某公司2013年笔试题
            //List<int> ints = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var query = from i in ints
            //            where i % 2 == 0 || i % 3 == 0
            //            select i;
            //ints.RemoveAt(1);
            //int result = query.Count();
            //Console.WriteLine("count:{0}", result);
            //输出结果为Cleanup Generic catch
            //先处理finall的结果，之后才是外部的catch语句
            //try
            //{
            //    try
            //    {
            //        int i = 0;
            //        object value = 1 / i;
            //    }
            //    catch (NullReferenceException Exception)
            //    {
            //        Console.Write("Null Re Ex");
            //    }
            //    finally
            //    {
            //        Console.Write("Cleanup ");
            //    }
            //}
            //catch
            //{
            //    Console.Write("Generic catch ");
            //} 
            //先调用B自己的static构造函数，之后是继承的A的static构造函数，之后是A的非static构造函数，最后是B的非static构造函数
            //B b = new B();
            //object obj = "2.0";
            //Console.Write(string.Format("{0:0.00}", obj));
            //LINQ测试
            //var query = from r in Formula1.GetChampions()
            //            where r.Country == "Brazil"
            //            orderby r.Wins descending
            //            select r;
            //foreach (Racer r in query)
            //{
            //    Console.WriteLine("{0:A}", r);
            //}
            //C c = new C();
            //Console.WriteLine("count个数为：{0}\r\ncount_this:{1}", c.Count, c.Count_this);
            //string x = "Hello"; int y = 9; x = x + y;
            //Console.WriteLine(x);

#endregion

            #region 入栈序列出栈序列
            //未解决
            //int[] arr = {1,2,3,4,5};
            //Stack<int> stkValues = new Stack<int>();
            //Stack<int> stkOutput = new Stack<int>();;
            //Stack<int> tmp = new Stack<int>();
            //for (int i = 0; i < arr.Length;i++ )
            //{
            //    stkValues.Push(arr[i]);
            //}
            //allPopSeq(stkValues, tmp, stkOutput);
            //Console.WriteLine("所有出栈序列数为：{0}", count);
#endregion
            
            #region 不安全代码示例
            //TestCode();
#endregion

            #region 阿里笔试中擦黑板的题目
            //HashSet<int> hsr = new HashSet<int>();
            //int[] result;
            //int flag = 3000;
            //int count = flag;9
            //string inStr;
            //int inNum;
            //Console.WriteLine("请输入试验次数：");
            //inStr=Console.ReadLine();
            //if (int.TryParse(inStr,out inNum))
            //{
            //    flag= flag > inNum ? flag : inNum;
            //    count = flag;
            //    while (flag > 0)
            //    {
            //        ArrayList hs = new ArrayList();
            //        for (int i = 1; i <= 50; i++)
            //        {
            //            hs.Add(i);
            //        }
            //        int hsCount;
            //        Random rand = new Random();
            //        for (int j = 0; j < 49; j++)
            //        {
            //            int r1, r2, delta;
            //            int e1, e2;

            //            hsCount = hs.Count;
            //            r1 = rand.Next(0, hsCount);
            //            e1 = (int)hs[r1];
            //            hs.RemoveAt(r1);
            //            hsCount = hs.Count;
            //            r2 = rand.Next(0, hsCount);
            //            e2 = (int)hs[r2];
            //            hs.RemoveAt(r2);
            //            delta = Math.Abs(e2 - e1);
            //            hs.Add(delta);
            //        }
            //        if (hs.Count > 0)
            //        {
            //            Console.Write("第{0:d3}次试验:", flag);
            //            foreach (int e in hs)
            //            {
            //                Console.Write("{0:d2}", e);
            //                if (!hsr.Contains(e))
            //                {
            //                    hsr.Add(e);
            //                }
            //            }
            //        }
            //        flag -= 1;
            //        Thread.Sleep(20);
            //        Console.WriteLine();
            //    }
            //    result = (int[])hsr.ToArray();
            //    Array.Sort(result);
            //    Console.WriteLine("{0:d4}次试验结果：", count);
            //    for (int k = 0; k < result.Length; k++)
            //    {
            //        if (!k.Equals(result.Length - 1))
            //        {
            //            Console.Write("{0:d2},", result[k]);
            //        }
            //        else
            //        {
            //            Console.Write("{0:d2}", result[k]);
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("请输入正确的整数!");
            //    Environment.Exit(0);
            //}
            
#endregion
            
            #region 数值的整数次方
            //double baseNum = 7.2;
            //int exponent = 8;
            //double result = PowerWithExponent(baseNum, exponent);
            //Console.WriteLine("{0:D2} Exponent of {1:F4} is {2:F6}", exponent, baseNum, result);
#endregion

            #region 各种测试
            //string的各种修改是不修改本身值的，除非将修改后的值赋予自身
            //string str = "hello";
            //str.ToUpper();
            //str.Insert(0, "world");
            //Console.WriteLine("{0}", str);
            //////////////////////////////////////////////////////////////////////////
            //B b = new B();
            //////////////////////////////////////////////////////////////////////////
            //充分地说明string是一个引用类型，modify函数虽然局部修改了值，但没有家out或ref关键字
            //string str = "hello";
            //ValueOrRef(str.GetType());
            //ModifyString(str);
            //Console.WriteLine(str);
            //////////////////////////////////////////////////////////////////////////
            //int a = 2;
            //int b = 3;
            //int result=AddWithoutArithmetic(a, b);
            //Console.WriteLine("{0} + {1} = {2}", a, b, result);
            //////////////////////////////////////////////////////////////////////////
            #endregion
            
            #region 八皇后问题
            //EightQueen();
#endregion

            #region 二分法求根
            //double tmp = 5.0;
            //Console.WriteLine("the sqrt of  is {0:F4}", mySqrt(tmp));
#endregion

            #region 堆排序（二叉堆）
            //int[] arr = new int[] { 1, 2, 4, 5, 6, 9, 10, 12, 3, 8 };
            //Print(arr);
            //PriorityQueue<int> pq = new PriorityQueue<int>();
            //pq.Sort(arr);
            //Heap<int> hp = new Heap<int>();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    hp.Push(arr[i]);
            //}
            //hp.Sort(arr);
            
            #endregion
            //double max = double.MaxValue;
            //double nmax = max + 1;
            //Console.WriteLine("{0:F6},{1:F6}", max, nmax);
            #region Queue的遍历
            //实现了IEnumerator接口，所以可以使用foreach的方式进行遍历
            //Queue<int> q = new Queue<int>();
            //for (int i = 0; i < 10;i++ )
            //{
            //    q.Enqueue(i);
            //}
            //foreach (int e in q)
            //{
            //    Console.Write("{0:D}\t", e);
            //}
#endregion

            #region 字符串全排列问题
            //string tmp = "acdac";
            //计算可能的组合数，首先选出来不重复的字符，做全排列，之后将剩余的字符插入
            //acd全排列为6，插入a时只有三个位置可选，得到6*3=18，插入c时只有四个位置可选，18*4=72
            //Permutation(tmp, 0,tmp.Length-1);
            //PermutationWithoutRepeat(tmp, 0, tmp.Length - 1);
#endregion

            #region 字符串最长对称字串
            //string tmp = "agaaabbccddddccbbaaaf";
            //string result = findLongSymmetry(tmp);
            //Console.WriteLine("输入的字符串为:{0}\n最长对称字串为:{1}", tmp, result);
#endregion

            #region 字串相似度
            //string s = "abcde";
            //string t = "bcaed";
            ////int dist = LevenshteinDistance(s, s.Length, t, t.Length);
            //int dist = LevenshteinDistance(s, t);
            //Console.WriteLine("编辑距离为：{0}", dist);
            #endregion

            #region 华为亮灯机试题
            Console.WriteLine("请输入灯数目");
            string tmp = Console.ReadLine();
            int count = int.Parse(tmp);
            List<int> list = LightOn(count);
            int left = list.Count;
            Console.WriteLine("输入的数字为{0}:",count);
            Console.WriteLine("最后剩余灯个数为：{0}", left);
            Console.WriteLine("最后剩余灯序号为");
            foreach (int ele in list)
            {
                Console.Write("{0}\t", ele);
            }
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

        #region n个骰子和问题
        public static int g_maxValue = 6;
        public static void SumProbabilityOfDices(int number, int[] pProbabilities)
        {
            for (int i = 1; i <= g_maxValue; i++)
                SumProbabilityOfDices(number, number, i, 0, pProbabilities);
        }
        public static void SumProbabilityOfDices(int original, int current, int value, int tempSum, int[] pProbabilities)
        {
            if (current == 1)
            {
                int sum = value + tempSum;
                pProbabilities[sum - original] +=1;
            }
            else
            {
                for (int i = 1; i <= g_maxValue; i++)
                {
                    int sum = value + tempSum;
                    SumProbabilityOfDices(original, current - 1, i, sum, pProbabilities);
                }
            }
        }
#endregion 

        #region 字符串匹配
        //BF方法
        public static int FindIndex(string source, string target, int pos)
        {
            char[] s = source.ToCharArray();
            char[] t = target.ToCharArray();
            int i = pos;
            int j = 0, k = 0;
            while (i< s.Length && j < t.Length)
            {
                if (s[i+k] == t[j])
                {
                    k += 1;
                    j += 1;
                } 
                else
                {
                    i += 1;
                    j = 0;
                    k = 0;
                }
            }
            if (j >= t.Length)
            {
                return i;
            }
            else
            {
                return 0;
            }
        }

        //KMP匹配算法
        //求Next数组，该数组是衡量当前以字符开头的后缀，与以开头字符开始的前缀字符的相似程度
        public static void get_next(string target, int length, out int[] nextval)
        {
            char[] ptrn = target.ToCharArray();
            int i = 0;
            nextval = new int[length];
            nextval[i] = -1;
            int j = -1;
            while (i < length -1)
            {
                if (j == -1 || ptrn[i] == ptrn[j])
                {
                    i += 1;
                    j += 1;
                    if (ptrn[i] != ptrn[j])
                    {
                        nextval[i] = j;
                    }
                    else
                    {
                        nextval[i] = nextval[j];
                    }
                } 
                else
                {
                    j = nextval[j];
                }
            }
        }

        public static int KMP_Search(string source, string target, int[] nextval, int pos)
        {
            int i = pos;
            int j = 0;
            char[] s=source.ToCharArray();
            char[] t=target.ToCharArray();
            int slength = source.Length;
            int tlength = target.Length;
            while (i < slength && j < tlength)
            {
                if (j == -1 || s[i] == t[j])
                {
                    i += 1;
                    j += 1;
                } 
                else
                {
                    j = nextval[j];
                }
            }
            if (j >= tlength)
            {
                return i - tlength;
            }
            else
            {
                return -1;
            }
        }

#endregion

        #region 某公司面试题
        /*
        class B : A
        {
            static B()
            {
                Console.Write("B static ");
            }
            public B()
            {
                Console.Write("B base ");
            }
        }
        class A
        {
            static A()
            {
                Console.Write("A static ");
            }
            public A()
            {
                Console.Write("A base ");
            }
        }
        
        class C
        {
            public int Count { get; private set; }
            public int Count_this { get; private set; }
            private List<int> items = new List<int>();
            private void Func(List<int> items)
            {
                items.Add(1);
                this.items.Add(2);
                items = new List<int>();
                items.Add(1);
                this.items.Add(2);
                Count = items.Count;
                Count_this = this.items.Count;
            }
            static void Main()
            {
                C c = new C();
                c.Func(c.items);
                Console.WriteLine("count个数为：{0}\r\ncount_this:{1}", c.Count, c.Count_this);
                Console.ReadKey();
            }
        }
        */
#endregion

        #region 不安全代码示例
        /*
        public static unsafe void TestCode()
        {
            int x = 10;
            short y = -1;
            byte y2 = 4;
            double z = 1.5;
            int* pX = &x;
            short* pY = &y;
            double* pZ = &z;

            Console.WriteLine("Address of x is 0x{0:X}, size is {1}, value is {2}",
               (uint)&x, sizeof(int), x);
            Console.WriteLine(
               "Address of y is 0x{0:X}, size is {1}, value is {2}",
               (uint)&y, sizeof(short), y);
            Console.WriteLine(
               "Address of y2 is 0x{0:X}, size is {1}, value is {2}",
               (uint)&y2, sizeof(byte), y2);
            Console.WriteLine(
               "Address of z is 0x{0:X}, size is {1}, value is {2}",
               (uint)&z, sizeof(double), z);
            Console.WriteLine(
               "Address of pX=&x is 0x{0:X}, size is {1}, value is 0x{2:X}",
               (uint)&pX, sizeof(int*), (uint)pX);
            Console.WriteLine(
               "Address of pY=&y is 0x{0:X}, size is {1}, value is 0x{2:X}",
               (uint)&pY, sizeof(short*), (uint)pY);
            Console.WriteLine(
               "Address of pZ=&z is 0x{0:X}, size is {1}, value is 0x{2:X}",
               (uint)&pZ, sizeof(double*), (uint)pZ);

            *pX = 20;
            Console.WriteLine("After setting *pX, x = {0}", x);
            Console.WriteLine("*pX = {0}", *pX);

            pZ = (double*)pX;
            Console.WriteLine("x treated as a double = {0}", *pZ);
        }
         * */
#endregion

        #region 入栈序列出栈序列问题
        //未解决
        //static int count = 0;
        //public static void outprint(Stack<int> q)
        //{
        //    while (q.Count() > 0)
        //    {
        //        Console.Write("{0} -> ", q.Peek());
        //        q.Pop();
        //    }
        //    Console.WriteLine();
        //    count++;
        //    return;
        //}
        //public static void allPopSeq(Stack<int> q, Stack<int> stk, Stack<int> output)
        //{
        //    if ((q.Count() == 0) && (stk.Count() == 0) && (output.Count() == 5))
        //    {
        //        outprint(output);
        //        return;
        //    }
        //    //入栈
        //    if (q.Count() >0)
        //    {
        //        int v = q.Peek();
        //        stk.Push(v);
        //        q.Pop();
        //        allPopSeq(q, stk, output);
        //        stk.Pop();
        //        q.Push(v);//回溯恢复
        //    }
        //    //出栈
        //    if (stk.Count() >0)
        //    {
        //        int v = stk.Peek();
        //        output.Push(v);
        //        allPopSeq(q, stk, output);
        //        output.Pop();
        //        stk.Push(v);
        //    }
        //    return;
        //}
#endregion

        #region 数值的整数次方
        //一般的方法是使用遍历，进行连乘，更好的方式是将次方表示为二进制
        public static double PowerWithExponent(double baseNum, int exponent)
        {
            //有一个问题没有搞明白，为什么用Convert.ToString(exponent, 2)得到的二进制表示是逆序的呢？
            char[] exp = (char[])Convert.ToString(exponent, 2).ToCharArray().Reverse().ToArray();
            if (exp.Count()==0)
            {
                return 1.0;
            }
            int numberof1 = exp.Count();
            double[] multiplication = new double[32];
            for (int i = 0; i < 32;i++ )
            {
                multiplication[i] = 1.0;
            }
            int count = 0;
            double power = 1.0;
            for (int j = 0; j < 32 && count < numberof1;j++ )
            {
                if (j==0)
                {
                    power = baseNum;
                }
                else
                {
                    power *= power;
                }
                if (exp[j].Equals('1'))
                {
                    multiplication[j] = power;
                }
                count += 1;
            }
            power = 1.0;
            for (int k = 0; k < count;k++ )
            {
                if (exp[k].Equals('1'))
                {
                    power *= multiplication[k];
                }
            }
            return power;
        }
#endregion

        #region C#有关语法面试题
        //静态类成员与静态构造函数的问题
        //静态函数先初始化自己的成员变量，所以是先构造a1，静态构造函数在类型B的代码之前执行
        class A
        {
            public A(string text)
            {
                Console.WriteLine(text);
            }
        }
        class B
        {
            static A a1 = new A("a1");
            A a2 = new A("a2");
            //添加此行代码是为了说明，即使在静态构造函数中不调用a1，换为a3，结果不改变，还是先初始化a1,
            //static A a3;
            static B()
            {
                a1 = new A("a3");
            }
            public B()
            {
                a2 = new A("a4");
            }
        }
        //有关string引用类型的实例
        public static void ValueOrRef(Type type)
        {
            string result = "the type " + type.Name;
            if (type.IsValueType)
            {
                Console.WriteLine(result + " is a value type.");
            }
            else
            {
                Console.WriteLine(result + "is a ref type");
            }
        }
        internal static void ModifyString(string text)
        {
            text = "world";
        }
#endregion

        #region 不使用运算符号的加法实现
        //主要的原理是模拟加法的步骤，使用二进制进行运算
        public static int AddWithoutArithmetic(int num1, int num2)
        {
            //使用递归时要首先设定终止条件
            if (num2 == 0)
            {
                return num1;
            }
            //异或操作符，相当于二进制的相加但没有进位
            int sum = num1 ^ num2;
            int carry = (num1 & num2) << 1;

            return AddWithoutArithmetic(sum, carry);
        }
#endregion

        #region 八皇后问题
        /*
        public static int g_number = 0;
        public const int queen = 8;
        public static void EightQueen()
        {
            int[] ColumnIndex = new int[queen];
            for (int i = 0; i < queen;i++ )
            {
                ColumnIndex[i] = i;
            }
            Permutation(ColumnIndex, queen, 0);
        }

        private static void Permutation(int[] ColumnIndex, int length, int index)
        {
            //为什么使用这个判断条件？
            //思路是一行一行的放棋子，如果达到length时证明有正确解了
            if (index ==length )
            {
                if (CheckIfAnyTwoInLine(ColumnIndex,length))
                {
                    g_number += 1;
                    PrintQueen(ColumnIndex, length);
                }
            } 
            else
            {
                //从第一行开始，直到最后一行
                for (int i = index; i < length;i++ )
                {
                    //没看懂这里面是什么意思
                    int temp = ColumnIndex[i];
                    ColumnIndex[i] = ColumnIndex[index];
                    ColumnIndex[index] = temp;

                    Permutation(ColumnIndex, length, index + 1);

                    temp = ColumnIndex[index];
                    ColumnIndex[index] = ColumnIndex[i];
                    ColumnIndex[i] = temp;
                }
            }
        }

        private static void PrintQueen(int[] ColumnIndex, int length)
        {
            Console.WriteLine("solution {0} ", g_number);
            for (int i = 0; i < length;i++ )
            {
                Console.Write("{0:d}\t", ColumnIndex[i]);
            }
            Console.WriteLine();
        }

        private static bool CheckIfAnyTwoInLine(int[] ColumnIndex, int length)
        {
            for (int i = 0; i < length;i++ )
            {
                for (int j = i + 1; j < length;j++ )
                {
                    if ((i-j==ColumnIndex[i]-ColumnIndex[j]) || (j-i==ColumnIndex[i]-ColumnIndex[j]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        */
        //非递归的回溯法求解八皇后问题
        //public static void EightQueen()
        //{
        //    int n = 0;
        //    int i = 0, j = 0;
        //    while (i < queen)
        //    {
        //        while (j < queen)        //对i行的每一列进行探测，看是否可以放置皇后  
        //        {
        //            if (valid(i, j))      //该位置可以放置皇后  
        //            {
        //                a[i] = j;        //第i行放置皇后  
        //                j = 0;           //第i行放置皇后以后，需要继续探测下一行的皇后位置，所以此处将j清零，从下一行的第0列开始逐列探测  
        //                break;
        //            }
        //            else
        //            {
        //                ++j;             //继续探测下一列  
        //            }
        //        }
        //        if (a[i] == INITIAL)         //第i行没有找到可以放置皇后的位置  
        //        {
        //            if (i == 0)             //回溯到第一行，仍然无法找到可以放置皇后的位置，则说明已经找到所有的解，程序终止  
        //                break;
        //            else                    //没有找到可以放置皇后的列，此时就应该回溯  
        //            {
        //                --i;
        //                j = a[i] + 1;        //把上一行皇后的位置往后移一列  
        //                a[i] = INITIAL;      //把上一行皇后的位置清除，重新探测  
        //                continue;
        //            }
        //        }
        //        if (i == queen - 1)          //最后一行找到了一个皇后位置，说明找到一个结果，打印出来  
        //        {
        //            printf("answer %d : \n", ++n);
        //            print();
        //            //不能在此处结束程序，因为我们要找的是N皇后问题的所有解，此时应该清除该行的皇后，从当前放置皇后列数的下一列继续探测。  
        //            //_sleep(600);  
        //            j = a[i] + 1;             //从最后一行放置皇后列数的下一列继续探测  
        //            a[i] = INITIAL;           //清除最后一行的皇后位置  
        //            continue;
        //        }
        //        ++i;              //继续探测下一行的皇后位置  
        //    }
        //}
#endregion

        #region 二分法求解任意数的平方根
        //使用的最简单的方法是二分求根法
        private const double EPSION=0.000001;
        private static double mySqrt(double des)
        {
            //需要处理的是大于1和小于1的情况
            double low = EPSION;
            double high = EPSION;
            double mid = 0.0;
            double sqr = 0.0;
            high = des > 1.0 ? des : des + 1.0;
            while (Math.Abs(des - sqr) > EPSION)
            {
                mid = (high + low) / 2;
                sqr = mid * mid;
                if (sqr > des)
                {
                    high = mid;
                } 
                else
                {
                    low = mid;
                }
            }
            return mid;
        }
#endregion

        #region 打印数组(泛型)
        //此处应该注意print后面的<T>参数，如果没有的话会报找不到类型的错误
        public static void Print<T>(T[] Tarray)
        {
            int length = Tarray.Length;
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
            for (int i = 0; i < length;i++ )
            {
                if (i<length-1)
                {
                    Console.Write("{0:" + format + "}, ", Tarray[i]);
                }
                else
                {
                    Console.Write("{0:" + format + "}", Tarray[i]);
                }
            }
            Console.WriteLine();
            
        }
#endregion

        #region 八数码问题
        
        //使用双向搜索技术
        const int Num = 9;
        class TEight
        {
            protected int[] p = new int[Num];
            protected int last, spac;
            protected static int[] q=new int[Num];
            protected static int[] d = new int[] { 1, 3, -1, -3 };
            protected static int total = 0;

            public TEight() { }
            public TEight(string filename)
            {
                //从文件中读取初始状态和终止状态
                string fullPath = AppDomain.CurrentDomain.BaseDirectory + @"\" + filename;
                FileStream fs = new FileStream(fullPath,FileMode.Open,FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string tmp = sr.ReadLine();
                string[] arr = tmp.Split(' ');
                for (int i = 0; i < arr.Length;i++ )
                {
                    p[i] = Convert.ToInt32(arr[i]);
                }
                tmp = sr.ReadLine();
                spac = Convert.ToInt32(tmp);
                tmp = sr.ReadLine();
                arr = tmp.Split(' ');
                for (int j = 0; j < arr.Length;j++ )
                {
                    q[i] = Convert.ToInt32(arr[i]);
                }
                sr.Close();
                fs.Close();
                last = -1;
                total = 0;
            }
            public virtual void Search() { }
            protected void Print()
            {
                string resultFileName = "eight_result.txt";
                string fullPath = AppDomain.CurrentDomain.BaseDirectory + @"\" + resultFileName;
                FileStream fs = new FileStream(fullPath, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write("{0}\t", total);
                for (int i = 0; i < Num;i++ )
                {
                    sw.Write("\t{0}", p[i]);
                }
                sw.WriteLine();
                sw.Flush();
                sw.Close();
                fs.Close();
            }
            //判断与另外一个状态是否相同
            protected  bool Equals(TEight TE)
            {
                for (int i = 0; i < Num;i++ )
                {
                    if (TE.p[i] != p[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            //
            protected bool Extend(int i)
            {
                //
                //                 d[ ]       值        操作
                //0   1   2         0       1          -->
                //3   4   5         1       3            ↑
                //6   7   8         2      -1         <--
                //                    3      -3            ↓
                //在以下四种情况下空格是没有办法完成i对应的操作数
                if (i == 0 && spac % 3 == 2 || i == 1 && spac > 5 || i == 2 && spac % 3 == 0 || i == 3 && spac < 3)
                    return false;
                //移动后将目标位置与空格进行互换
                int temp = spac;
                spac += d[i];
                p[temp] = p[spac];
                p[spac] = 0;
                return true;
            }
        }
        public class TNode<T>
        {
            public TNode() { }
            public TNode(T dat) { }
            private TNode Next;
            private T data;
        }
        public class TBFS : TEight
        {
            public TBFS() { }
            public TBFS(string fileName) : base(fileName) { }

        }
#endregion

        #region 全排列问题
        //最简单粗暴的解决方案
        public static int num = 0;
        public static void Permutation(string pStr,int indexPointer)
        {
            //全排列就是从第一个数字起每个数分别与它后面的数字交换
            Debug.Assert(pStr != null, "请传入正确的字符串");
            Debug.Assert(indexPointer < pStr.Length, "字符串的索引位置出错");
            char[] chars = pStr.ToCharArray();
            string resultStr,tmpStr;
            
            if (indexPointer.Equals(chars.Length-1))
            {
                //遍历到了最后一个字符
                //字符串数字转换的两种方法，一种如下使用构造函数，另一种使用string的join方法
                resultStr = new string(chars);
                Console.WriteLine(resultStr);
            }
            else
            {
                for (int i = indexPointer; i < chars.Length;i++ )
                {
                    //交换第一个字符和indexPoint指向的字符
                    char tmpChar = chars[i];
                    chars[i] = chars[indexPointer];
                    chars[indexPointer] = tmpChar;
                    tmpStr = new string(chars);
                    pStr = tmpStr;
                    //递归调用完成调整后的全排列
                    Permutation(pStr, indexPointer + 1);
                    //计算完成后再交换回来调整的字符串，保证上面的交换是对原字符串进行
                    tmpChar = chars[i];
                    chars[i] = chars[indexPointer];
                    chars[indexPointer] = tmpChar;
                    tmpStr = new string(chars);
                    pStr = tmpStr;
                }
            }
            

        }

        //k表示当前选取到第几个数，m表示共有多少个数
        public static void Permutation(string pStr, int k, int m)
        {
            //全排列就是从第一个数字起每个数分别与它后面的数字交换
            Debug.Assert(pStr != null, "请传入正确的字符串");
            char[] chars = pStr.ToCharArray();
            string resultStr,tmpStr;

            if (k==m)
            {
                num += 1;
                resultStr = new string(chars);
                Console.WriteLine("{0}:\t{1}", num, resultStr);
            }
            else
            {
                for (int i = k; i <= m; i++)
                {
                    //交换第一个字符和indexPoint指向的字符
                    char tmpChar = chars[i];
                    chars[i] = chars[k];
                    chars[k] = tmpChar;
                    tmpStr = new string(chars);
                    pStr = tmpStr;
                    //递归调用完成调整后的全排列
                    Permutation(pStr, k + 1,m);
                    //计算完成后再交换回来调整的字符串，保证上面的交换是对原字符串进行
                    tmpChar = chars[i];
                    chars[i] = chars[k];
                    chars[k] = tmpChar;
                    tmpStr = new string(chars);
                    pStr = tmpStr;
                }
            }
        }


        //去重复的全排列，可能有问题
        //去重的全排列就是从第一个数字起每个数分别与它后面非重复出现的数字交换
        public static void PermutationWithoutRepeat(string pStr, int k, int m)
        {
            //全排列就是从第一个数字起每个数分别与它后面的数字交换
            Debug.Assert(pStr != null, "请传入正确的字符串");
            char[] chars = pStr.ToCharArray();
            string resultStr, tmpStr;

            if (k == m)
            {
                num += 1;
                resultStr = new string(chars);
                Console.WriteLine("{0}:\t{1}", num, resultStr);
            }
            else
            {
                for (int i = k; i <= m; i++)
                {
                    if (IsSwap(pStr,k,i))
                    {
                        //交换第一个字符和indexPoint指向的字符
                        char tmpChar = chars[i];
                        chars[i] = chars[k];
                        chars[k] = tmpChar;
                        tmpStr = new string(chars);
                        pStr = tmpStr;
                        //递归调用完成调整后的全排列
                        Permutation(pStr, k + 1, m);
                        //计算完成后再交换回来调整的字符串，保证上面的交换是对原字符串进行
                        tmpChar = chars[i];
                        chars[i] = chars[k];
                        chars[k] = tmpChar;
                        tmpStr = new string(chars);
                        pStr = tmpStr;
                    }
                    
                }
            }
        }

        //在[nBegin,nEnd)区间中是否有字符与下标为pEnd的字符相等
        private static bool IsSwap(string pStr,int k, int m)
        {
            char[] chars = pStr.ToCharArray();
            for (int i = k; i < m; i++)
            {
                if (chars[i].Equals(chars[m]))
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region 字符串最长对称字串
        public static string findLongSymmetry(string str)
        {
            string symmetryStr;
            int k;
            char[] chars;

            Debug.Assert(str !=null,"字符串为空");

            for (int i = str.Length - 1; i > 0;i-- )
            {
                for (int j = 0; j< i;j++ )
                {
                    symmetryStr = str.Substring(j, i -j + 1);
                    chars = symmetryStr.ToCharArray();
                    for (k = 0; k < chars.Length / 2;k++ )
                    {
                        if (! chars[k].Equals(chars[chars.Length-k-1]))
                        {
                            break;
                        }
                    }
                    if (k==chars.Length/2)
                    {
                        return symmetryStr;
                    }
                }
            }
            return "";
        }
        #endregion

        #region 字符串相似度
        //递归解法
        public static int LevenshteinDistance(string s, int len_s,string t,int len_t)
        {
            int cost;

            if (len_t==0)
            {
                return len_s;
            }
            if (len_s==0)
            {
                return len_t;
            }

            if (s[len_s-1].Equals(t[len_t-1]))
            {
                cost = 0;
            }
            else
            {
                cost = 1;
            }

            return Minimum(LevenshteinDistance(s, len_s - 1, t, len_t) + 1, LevenshteinDistance(s, len_s, t, len_t - 1) + 1, LevenshteinDistance(s, len_s - 1, t, len_t - 1) + cost);
        }

        private static int Minimum(int p, int p_2, int p_3)
        {
            int max = p;
            if (max > p_2)
            {
                max = p_2;
            }
            if (max > p_3)
            {
                max = p_3;
            }

            return max;
        }

        //非递归解法
        public static int LevenshteinDistance(string str1, string str2)
        {
            int[,] Matrix;
            int n = str1.Length;
            int m = str2.Length;

            int temp = 0;
            char ch1;
            char ch2;
            int i = 0;
            int j = 0;
            if (n == 0)
            {
                return m;
            }
            if (m == 0)
            {

                return n;
            }
            //Matrix[i,j]表示source[1..i]到target[1..j]之间的最小编辑距离
            Matrix = new int[n + 1, m + 1];

            for (i = 0; i <= n; i++)
            {
                //初始化第一列
                Matrix[i, 0] = i;
            }

            for (j = 0; j <= m; j++)
            {
                //初始化第一行
                Matrix[0, j] = j;
            }

            for (i = 1; i <= n; i++)
            {
                ch1 = str1[i - 1];
                for (j = 1; j <= m; j++)
                {
                    ch2 = str2[j - 1];
                    if (ch1.Equals(ch2))
                    {
                        temp = 0;
                    }
                    else
                    {
                        temp = 1;
                    }
                    //Matrix[i - 1, j] + 1-->source 删除字符
                    //Matrix[i, j - 1] + 1-->source 插入字符
                    //Matrix[i - 1, j - 1] + temp -->source 替换字符
                    Matrix[i, j] = Minimum(Matrix[i - 1, j] + 1, Matrix[i, j - 1] + 1, Matrix[i - 1, j - 1] + temp);
                }
            }
            return Matrix[n, m];
        }
        #endregion

        #region 华为机试亮灯问题
        public static List<int> LightOn(int Count)
        {
            Debug.Assert(Count >= 1 && Count <= 65535);
            bool[] isLightOn = new bool[Count];
            List<int> result = new List<int>();
            for (int i = 1; i <= Count;i++ )
            {
                if (Count % i==0)
                {
                    isLightOn[i - 1] = true;
                }
            }
            for (int j = 0; j < Count;j++ )
            {
                if (isLightOn[j])
                {
                    result.Add(j + 1);
                }
            }
            return result;
        }
#endregion

    }
}
