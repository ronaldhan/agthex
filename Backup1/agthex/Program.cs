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
            #region �ƶ�����ʾ��
            ////������������
            //int[] myIntArray ={ 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ////��������ʾ�ڿ���̨��
            //Console.WriteLine("ԭʼ����Ϊ��1, 2, 3, 4, 5, 6, 7, 8, 9 ");
            ////�ӿ���̨��ȡ���������ֵ
            //string input = "";
            //Console.WriteLine("������һ������ֵ�����س���������");
            //input = Console.ReadLine();
            ////ת��Ϊ����ֵ
            //int k;
            //k = Convert.ToInt32(input);
            ////�ƶ�����
            //for (int i = 0; i < k; i++)
            //{
            //    for (int j = 0; j < myIntArray.Length - 1; j++)
            //    {
            //        int temp;
            //        //ʹ��һ������Ĵ洢�ռ�
            //        temp = myIntArray[j];
            //        //�����һ��ֵ����
            //        myIntArray[j] = myIntArray[myIntArray.Length - 1];
            //        //�洢ֵ�������һ������Ԫ��
            //        myIntArray[myIntArray.Length - 1] = temp;
            //    }
            //}
            //Console.Write("��λ���Ϊ��");
            ////��λ��������ʾ������̨
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

            #region ���������
            ////���ڻ����ܴ�������ֵ��ȵ����
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
            //Console.WriteLine("�������: ");
            //bst.InOrder(bst.root);
            //Console.WriteLine();
            //Console.WriteLine("�������: ");
            //bst.PreOrder(bst.root);
            //Console.WriteLine();
            //Console.WriteLine("�������: ");
            //bst.PostOrder(bst.root);
            #endregion

            #region �ڽӱ�
            //AdjacencyList<char> a = new AdjacencyList<char>();
            ////���Ӷ���
            //a.AddVertex('A');
            //a.AddVertex('B');
            //a.AddVertex('C');
            //a.AddVertex('D');
            ////���ӱ�
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

            #region ���ȶ���
            //int[] arr = new int[20];
            //Random r=new Random();
            //for (int i = 0; i < arr.Length;i++ )
            //{
            //    arr[i] = r.Next(1, 100);
            //}
            //PriorityQueue<int> pq = new PriorityQueue<int>();
            //pq.Sort(arr);
            #endregion

            #region ��֪�������������������
            //string pre = "GDAFEMHZ";
            //string mid = "ADEFGHMZ";
            //PreMid(pre, mid);
#endregion
            
            #region ������������
            //int[] a ={ 1, 2, 5, -1, -9, 6, 2, 3, -5, 9 };
            //int sum = MaxSubsequenceSum(a, a.Length);
            //Console.WriteLine("the max sum is: {0}", sum);
#endregion

            #region LIS���������
            //int[] arr = {1,-1,2,-3,4,-5,6,-7};
            //Console.WriteLine("����Ϊ��{0}", LIS(arr, arr.Length));
            //Console.WriteLine();
            //outputLIS(arr, arr.Length - 1);
#endregion

            #region �ж������Ƿ�Ϊ2�ķ���
            //���ַ�����������
            //���������һλ�Ƿ�Ϊ1
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
            //    Console.WriteLine("����������");
            //}
            //һ�仰�ܸ㶨
            //isPower = (num & num - 1)==0 ? true : false;
            //result = isPower ? "��" : "����";
            //Console.WriteLine("�����{0}{1}2�ķ���", num, result);

#endregion

            #region ��������Ψһ�������ε�������
            //������ֻ���������ǳ���һ�εģ������ҳ�����������Ҫ��ʱ�临�Ӷ�ΪO(n)���ռ临�Ӷ�ΪO(1)
            //int[] arr = new int[] { 1, 2, 3, 4, 3, 2, 1, 5, 8, 4 };
            //int num1, num2;
            //FindNumAppearOne(arr, arr.Length, out num1, out num2);
            //for (int i = 0; i < arr.Length;i++ )
            //{
            //    Console.Write("{0},", arr[i]);
            //}
            //Console.WriteLine();
            //Console.WriteLine("ֻ����һ�ε�����{0},{1}",num1,num2);
#endregion

            #region �����ıȽ�
            //Student[] students = new Student[]{
            //    new Student(){Age = 10,Name="����",Score=70},
            //    new Student(){Age = 12,Name="����",Score=97},
            //    new Student(){Age = 11,Name="����",Score=80},
            //    new Student(){Age = 9,Name="����",Score=66},
            //    new Student(){Age = 12,Name="˾��",Score=90},
            //};
            //Console.WriteLine("--------------Ĭ���������--------");
            //Array.Sort(students);
            //Array.ForEach<Student>(students, (s) => Console.WriteLine(string.Format("{0}{1,2}���ˣ����ķ�����{2,3}", s.Name, s.Age, s.Score)));

            //Console.WriteLine("----------�������������------------");
            //Array.Sort(students, new StudentScoreComparer());
            //Array.ForEach<Student>(students, (s) => Console.WriteLine(string.Format("{0}{1,2}���ˣ����ķ�����{2,3}", s.Name, s.Age, s.Score)));

            //Console.WriteLine("----------�������������----------");
            //Array.Sort(students, (s1, s2) => s1.Score.CompareTo(s2.Score));
            //Array.ForEach<Student>(students, (s) => Console.WriteLine(string.Format("{0}{1,2}���ˣ����ķ�����{2,3}", s.Name, s.Age, s.Score)));
            #endregion

            #region n�����Ӻ�����
            //�ݹ��
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
            //�ǵݹ��
            //���ַ�ʽ���壬��ʼ��������ֵΪ0
            //int[,] arr=new int[2,3];
            //Console.WriteLine("int[1,2]:{0}", arr[1, 2]);

#endregion

            #region �����г��ִ�����������һ�������
            //��Ҫ˼·�����֣���һ�Ƕ������������ͳ������ÿ�����ֳ��ֵĸ�����Ȼ���ҵ����һ����Ϊ���������Ľ����Ҫ������������
            //�������ʹ��hashtable�������ֺͳ��ֵĴ����ֱ���Ϊ����ֵ�����ڵ�������������ֵķ�Χ�ǳ���hashtable��Ҫ���÷ǳ����˷ѿռ�
            //���������������ֵ����ԣ���Ȼ���ִ�������һ�룬���Կ����ڱ�������ʱ��������ֵ����һ�ǵ�ǰֵ������ǳ��ִ���������������һ������ʱ
            //�������������+1�����������-1��Ϊ0ʱ������Ϊ1�����һ�ΰ�������Ϊ1ʱ��Ӧ�����ּ�ΪӦ����
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
            //console.writeline("���ִ�������������{0:d}:", result);
#endregion

            #region �ַ���ƥ��
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

            #region ĳ��˾2013�������
            //List<int> ints = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var query = from i in ints
            //            where i % 2 == 0 || i % 3 == 0
            //            select i;
            //ints.RemoveAt(1);
            //int result = query.Count();
            //Console.WriteLine("count:{0}", result);
            //������ΪCleanup Generic catch
            //�ȴ���finall�Ľ����֮������ⲿ��catch���
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
            //�ȵ���B�Լ���static���캯����֮���Ǽ̳е�A��static���캯����֮����A�ķ�static���캯���������B�ķ�static���캯��
            //B b = new B();
            //object obj = "2.0";
            //Console.Write(string.Format("{0:0.00}", obj));
            //LINQ����
            //var query = from r in Formula1.GetChampions()
            //            where r.Country == "Brazil"
            //            orderby r.Wins descending
            //            select r;
            //foreach (Racer r in query)
            //{
            //    Console.WriteLine("{0:A}", r);
            //}
            //C c = new C();
            //Console.WriteLine("count����Ϊ��{0}\r\ncount_this:{1}", c.Count, c.Count_this);
            //string x = "Hello"; int y = 9; x = x + y;
            //Console.WriteLine(x);

#endregion

            #region ��ջ���г�ջ����
            //δ���
            //int[] arr = {1,2,3,4,5};
            //Stack<int> stkValues = new Stack<int>();
            //Stack<int> stkOutput = new Stack<int>();;
            //Stack<int> tmp = new Stack<int>();
            //for (int i = 0; i < arr.Length;i++ )
            //{
            //    stkValues.Push(arr[i]);
            //}
            //allPopSeq(stkValues, tmp, stkOutput);
            //Console.WriteLine("���г�ջ������Ϊ��{0}", count);
#endregion
            
            #region ����ȫ����ʾ��
            //TestCode();
#endregion

            #region ��������в��ڰ����Ŀ
            //HashSet<int> hsr = new HashSet<int>();
            //int[] result;
            //int flag = 3000;
            //int count = flag;9
            //string inStr;
            //int inNum;
            //Console.WriteLine("���������������");
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
            //            Console.Write("��{0:d3}������:", flag);
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
            //    Console.WriteLine("{0:d4}����������", count);
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
            //    Console.WriteLine("��������ȷ������!");
            //    Environment.Exit(0);
            //}
            
#endregion
            
            #region ��ֵ�������η�
            //double baseNum = 7.2;
            //int exponent = 8;
            //double result = PowerWithExponent(baseNum, exponent);
            //Console.WriteLine("{0:D2} Exponent of {1:F4} is {2:F6}", exponent, baseNum, result);
#endregion

            #region ���ֲ���
            //string�ĸ����޸��ǲ��޸ı���ֵ�ģ����ǽ��޸ĺ��ֵ��������
            //string str = "hello";
            //str.ToUpper();
            //str.Insert(0, "world");
            //Console.WriteLine("{0}", str);
            //////////////////////////////////////////////////////////////////////////
            //B b = new B();
            //////////////////////////////////////////////////////////////////////////
            //��ֵ�˵��string��һ���������ͣ�modify������Ȼ�ֲ��޸���ֵ����û�м�out��ref�ؼ���
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
            
            #region �˻ʺ�����
            //EightQueen();
#endregion

            #region ���ַ����
            //double tmp = 5.0;
            //Console.WriteLine("the sqrt of  is {0:F4}", mySqrt(tmp));
#endregion

            #region �����򣨶���ѣ�
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
            #region Queue�ı���
            //ʵ����IEnumerator�ӿڣ����Կ���ʹ��foreach�ķ�ʽ���б���
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

            #region �ַ���ȫ��������
            //string tmp = "acdac";
            //������ܵ������������ѡ�������ظ����ַ�����ȫ���У�֮��ʣ����ַ�����
            //acdȫ����Ϊ6������aʱֻ������λ�ÿ�ѡ���õ�6*3=18������cʱֻ���ĸ�λ�ÿ�ѡ��18*4=72
            //Permutation(tmp, 0,tmp.Length-1);
            //PermutationWithoutRepeat(tmp, 0, tmp.Length - 1);
#endregion

            #region �ַ�����Գ��ִ�
            //string tmp = "agaaabbccddddccbbaaaf";
            //string result = findLongSymmetry(tmp);
            //Console.WriteLine("������ַ���Ϊ:{0}\n��Գ��ִ�Ϊ:{1}", tmp, result);
#endregion

            #region �ִ����ƶ�
            //string s = "abcde";
            //string t = "bcaed";
            ////int dist = LevenshteinDistance(s, s.Length, t, t.Length);
            //int dist = LevenshteinDistance(s, t);
            //Console.WriteLine("�༭����Ϊ��{0}", dist);
            #endregion

            #region ��Ϊ���ƻ�����
            Console.WriteLine("���������Ŀ");
            string tmp = Console.ReadLine();
            int count = int.Parse(tmp);
            List<int> list = LightOn(count);
            int left = list.Count;
            Console.WriteLine("���������Ϊ{0}:",count);
            Console.WriteLine("���ʣ��Ƹ���Ϊ��{0}", left);
            Console.WriteLine("���ʣ������Ϊ");
            foreach (int ele in list)
            {
                Console.Write("{0}\t", ele);
            }
#endregion

            Console.ReadKey();
        }

        #region ��֪���������������
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

        #region ����������
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

        #region �����������LIS
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

        #region �ж������Ƿ�Ϊ����
        public static bool IsNum(string s)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(s, @"^\d+");
        }
        #endregion

        #region ��������һ�ε���
        //�ҵ����������е�һ��Ϊ1��λ��
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
        //�ж�һ�����Ķ�������ĳһλ���Ƿ�Ϊ1
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
                Console.WriteLine("��������鲻����");
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

        #region C#�е�����������

        public class Student : IComparable
        {
            public int Age { get; set; }

            public string Name { get; set; }

            public int Score { get; set; }

            /// <summary>
            /// ʵ��IComparable�ӿڣ���Age���Ƚ�
            /// </summary>
            /// <param name="obj">�Ƚ϶���</param>
            /// <returns>�ȽϽ��</returns>
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

        #region n�����Ӻ�����
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

        #region �ַ���ƥ��
        //BF����
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

        //KMPƥ���㷨
        //��Next���飬�������Ǻ�����ǰ���ַ���ͷ�ĺ�׺�����Կ�ͷ�ַ���ʼ��ǰ׺�ַ������Ƴ̶�
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

        #region ĳ��˾������
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
                Console.WriteLine("count����Ϊ��{0}\r\ncount_this:{1}", c.Count, c.Count_this);
                Console.ReadKey();
            }
        }
        */
#endregion

        #region ����ȫ����ʾ��
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

        #region ��ջ���г�ջ��������
        //δ���
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
        //    //��ջ
        //    if (q.Count() >0)
        //    {
        //        int v = q.Peek();
        //        stk.Push(v);
        //        q.Pop();
        //        allPopSeq(q, stk, output);
        //        stk.Pop();
        //        q.Push(v);//���ݻָ�
        //    }
        //    //��ջ
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

        #region ��ֵ�������η�
        //һ��ķ�����ʹ�ñ������������ˣ����õķ�ʽ�ǽ��η���ʾΪ������
        public static double PowerWithExponent(double baseNum, int exponent)
        {
            //��һ������û�и����ף�Ϊʲô��Convert.ToString(exponent, 2)�õ��Ķ����Ʊ�ʾ��������أ�
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

        #region C#�й��﷨������
        //��̬���Ա�뾲̬���캯��������
        //��̬�����ȳ�ʼ���Լ��ĳ�Ա�������������ȹ���a1����̬���캯��������B�Ĵ���֮ǰִ��
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
            //���Ӵ��д�����Ϊ��˵������ʹ�ھ�̬���캯���в�����a1����Ϊa3��������ı䣬�����ȳ�ʼ��a1,
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
        //�й�string�������͵�ʵ��
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

        #region ��ʹ��������ŵļӷ�ʵ��
        //��Ҫ��ԭ����ģ��ӷ��Ĳ��裬ʹ�ö����ƽ�������
        public static int AddWithoutArithmetic(int num1, int num2)
        {
            //ʹ�õݹ�ʱҪ�����趨��ֹ����
            if (num2 == 0)
            {
                return num1;
            }
            //�����������൱�ڶ����Ƶ���ӵ�û�н�λ
            int sum = num1 ^ num2;
            int carry = (num1 & num2) << 1;

            return AddWithoutArithmetic(sum, carry);
        }
#endregion

        #region �˻ʺ�����
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
            //Ϊʲôʹ������ж�������
            //˼·��һ��һ�еķ����ӣ�����ﵽlengthʱ֤������ȷ����
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
                //�ӵ�һ�п�ʼ��ֱ�����һ��
                for (int i = index; i < length;i++ )
                {
                    //û������������ʲô��˼
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
        //�ǵݹ�Ļ��ݷ����˻ʺ�����
        //public static void EightQueen()
        //{
        //    int n = 0;
        //    int i = 0, j = 0;
        //    while (i < queen)
        //    {
        //        while (j < queen)        //��i�е�ÿһ�н���̽�⣬���Ƿ���Է��ûʺ�  
        //        {
        //            if (valid(i, j))      //��λ�ÿ��Է��ûʺ�  
        //            {
        //                a[i] = j;        //��i�з��ûʺ�  
        //                j = 0;           //��i�з��ûʺ��Ժ���Ҫ����̽����һ�еĻʺ�λ�ã����Դ˴���j���㣬����һ�еĵ�0�п�ʼ����̽��  
        //                break;
        //            }
        //            else
        //            {
        //                ++j;             //����̽����һ��  
        //            }
        //        }
        //        if (a[i] == INITIAL)         //��i��û���ҵ����Է��ûʺ��λ��  
        //        {
        //            if (i == 0)             //���ݵ���һ�У���Ȼ�޷��ҵ����Է��ûʺ��λ�ã���˵���Ѿ��ҵ����еĽ⣬������ֹ  
        //                break;
        //            else                    //û���ҵ����Է��ûʺ���У���ʱ��Ӧ�û���  
        //            {
        //                --i;
        //                j = a[i] + 1;        //����һ�лʺ��λ��������һ��  
        //                a[i] = INITIAL;      //����һ�лʺ��λ�����������̽��  
        //                continue;
        //            }
        //        }
        //        if (i == queen - 1)          //���һ���ҵ���һ���ʺ�λ�ã�˵���ҵ�һ���������ӡ����  
        //        {
        //            printf("answer %d : \n", ++n);
        //            print();
        //            //�����ڴ˴�����������Ϊ����Ҫ�ҵ���N�ʺ���������н⣬��ʱӦ��������еĻʺ󣬴ӵ�ǰ���ûʺ���������һ�м���̽�⡣  
        //            //_sleep(600);  
        //            j = a[i] + 1;             //�����һ�з��ûʺ���������һ�м���̽��  
        //            a[i] = INITIAL;           //������һ�еĻʺ�λ��  
        //            continue;
        //        }
        //        ++i;              //����̽����һ�еĻʺ�λ��  
        //    }
        //}
#endregion

        #region ���ַ������������ƽ����
        //ʹ�õ���򵥵ķ����Ƕ��������
        private const double EPSION=0.000001;
        private static double mySqrt(double des)
        {
            //��Ҫ�������Ǵ���1��С��1�����
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

        #region ��ӡ����(����)
        //�˴�Ӧ��ע��print�����<T>���������û�еĻ��ᱨ�Ҳ������͵Ĵ���
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

        #region ����������
        
        //ʹ��˫����������
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
                //���ļ��ж�ȡ��ʼ״̬����ֹ״̬
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
            //�ж�������һ��״̬�Ƿ���ͬ
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
                //                 d[ ]       ֵ        ����
                //0   1   2         0       1          -->
                //3   4   5         1       3            ��
                //6   7   8         2      -1         <--
                //                    3      -3            ��
                //��������������¿ո���û�а취���i��Ӧ�Ĳ�����
                if (i == 0 && spac % 3 == 2 || i == 1 && spac > 5 || i == 2 && spac % 3 == 0 || i == 3 && spac < 3)
                    return false;
                //�ƶ���Ŀ��λ����ո���л���
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

        #region ȫ��������
        //��򵥴ֱ��Ľ������
        public static int num = 0;
        public static void Permutation(string pStr,int indexPointer)
        {
            //ȫ���о��Ǵӵ�һ��������ÿ�����ֱ�������������ֽ���
            Debug.Assert(pStr != null, "�봫����ȷ���ַ���");
            Debug.Assert(indexPointer < pStr.Length, "�ַ���������λ�ó���");
            char[] chars = pStr.ToCharArray();
            string resultStr,tmpStr;
            
            if (indexPointer.Equals(chars.Length-1))
            {
                //�����������һ���ַ�
                //�ַ�������ת�������ַ�����һ������ʹ�ù��캯������һ��ʹ��string��join����
                resultStr = new string(chars);
                Console.WriteLine(resultStr);
            }
            else
            {
                for (int i = indexPointer; i < chars.Length;i++ )
                {
                    //������һ���ַ���indexPointָ����ַ�
                    char tmpChar = chars[i];
                    chars[i] = chars[indexPointer];
                    chars[indexPointer] = tmpChar;
                    tmpStr = new string(chars);
                    pStr = tmpStr;
                    //�ݹ������ɵ������ȫ����
                    Permutation(pStr, indexPointer + 1);
                    //������ɺ��ٽ��������������ַ�������֤����Ľ����Ƕ�ԭ�ַ�������
                    tmpChar = chars[i];
                    chars[i] = chars[indexPointer];
                    chars[indexPointer] = tmpChar;
                    tmpStr = new string(chars);
                    pStr = tmpStr;
                }
            }
            

        }

        //k��ʾ��ǰѡȡ���ڼ�������m��ʾ���ж��ٸ���
        public static void Permutation(string pStr, int k, int m)
        {
            //ȫ���о��Ǵӵ�һ��������ÿ�����ֱ�������������ֽ���
            Debug.Assert(pStr != null, "�봫����ȷ���ַ���");
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
                    //������һ���ַ���indexPointָ����ַ�
                    char tmpChar = chars[i];
                    chars[i] = chars[k];
                    chars[k] = tmpChar;
                    tmpStr = new string(chars);
                    pStr = tmpStr;
                    //�ݹ������ɵ������ȫ����
                    Permutation(pStr, k + 1,m);
                    //������ɺ��ٽ��������������ַ�������֤����Ľ����Ƕ�ԭ�ַ�������
                    tmpChar = chars[i];
                    chars[i] = chars[k];
                    chars[k] = tmpChar;
                    tmpStr = new string(chars);
                    pStr = tmpStr;
                }
            }
        }


        //ȥ�ظ���ȫ���У�����������
        //ȥ�ص�ȫ���о��Ǵӵ�һ��������ÿ�����ֱ�����������ظ����ֵ����ֽ���
        public static void PermutationWithoutRepeat(string pStr, int k, int m)
        {
            //ȫ���о��Ǵӵ�һ��������ÿ�����ֱ�������������ֽ���
            Debug.Assert(pStr != null, "�봫����ȷ���ַ���");
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
                        //������һ���ַ���indexPointָ����ַ�
                        char tmpChar = chars[i];
                        chars[i] = chars[k];
                        chars[k] = tmpChar;
                        tmpStr = new string(chars);
                        pStr = tmpStr;
                        //�ݹ������ɵ������ȫ����
                        Permutation(pStr, k + 1, m);
                        //������ɺ��ٽ��������������ַ�������֤����Ľ����Ƕ�ԭ�ַ�������
                        tmpChar = chars[i];
                        chars[i] = chars[k];
                        chars[k] = tmpChar;
                        tmpStr = new string(chars);
                        pStr = tmpStr;
                    }
                    
                }
            }
        }

        //��[nBegin,nEnd)�������Ƿ����ַ����±�ΪpEnd���ַ����
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

        #region �ַ�����Գ��ִ�
        public static string findLongSymmetry(string str)
        {
            string symmetryStr;
            int k;
            char[] chars;

            Debug.Assert(str !=null,"�ַ���Ϊ��");

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

        #region �ַ������ƶ�
        //�ݹ�ⷨ
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

        //�ǵݹ�ⷨ
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
            //Matrix[i,j]��ʾsource[1..i]��target[1..j]֮�����С�༭����
            Matrix = new int[n + 1, m + 1];

            for (i = 0; i <= n; i++)
            {
                //��ʼ����һ��
                Matrix[i, 0] = i;
            }

            for (j = 0; j <= m; j++)
            {
                //��ʼ����һ��
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
                    //Matrix[i - 1, j] + 1-->source ɾ���ַ�
                    //Matrix[i, j - 1] + 1-->source �����ַ�
                    //Matrix[i - 1, j - 1] + temp -->source �滻�ַ�
                    Matrix[i, j] = Minimum(Matrix[i - 1, j] + 1, Matrix[i, j - 1] + 1, Matrix[i - 1, j - 1] + temp);
                }
            }
            return Matrix[n, m];
        }
        #endregion

        #region ��Ϊ������������
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