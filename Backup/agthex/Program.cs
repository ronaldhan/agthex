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
            ////���ڻ����ܴ������ֵ��ȵ����
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
            ////��Ӷ���
            //a.AddVertex('A');
            //a.AddVertex('B');
            //a.AddVertex('C');
            //a.AddVertex('D');
            ////��ӱ�
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
            int[] arr = new int[] { 1, 2, 3, 4, 3, 2, 1, 5, 8, 4 };
            int num1, num2;
            FindNumAppearOne(arr, arr.Length, out num1, out num2);
            for (int i = 0; i < arr.Length;i++ )
            {
                Console.Write("{0},", arr[i]);
            }
            Console.WriteLine();
            Console.WriteLine("ֻ����һ�ε�����{0},{1}",num1,num2);
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
            //Array.ForEach<Student>(students, (s) =>Console.WriteLine(string.Format("{0}{1,2}���ˣ����ķ�����{2,3}", s.Name, s.Age, s.Score)));

            //Console.WriteLine("----------�������������------------");
            //Array.Sort(students, new StudentScoreComparer());
            //Array.ForEach<Student>(students, (s) => Console.WriteLine(string.Format("{0}{1,2}���ˣ����ķ�����{2,3}", s.Name, s.Age, s.Score)));
 
            //Console.WriteLine("----------�������������----------");
            //Array.Sort(students, (s1, s2) => s1.Score.CompareTo(s2.Score));
            //Array.ForEach<Student>(students, (s) => Console.WriteLine(string.Format("{0}{1,2}���ˣ����ķ�����{2,3}", s.Name, s.Age, s.Score)));
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

    }
}
