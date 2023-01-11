using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTest;

namespace ConsoleApp1
{
    internal class Program
    {
        string str1 = "aaaa";
        static string str2 = "bbbb";

        const int PRICE1 = PRICE2 + 2;
        const int PRICE2 = 10;
        static readonly int PRICE3 = PRICE4 + 2;
        static readonly int PRICE4 = 11;

        static void Main(string[] args)
        {
            pre a = new pre();
            a.pp();
            string name;
            Console.WriteLine("第一个 C# 程序");
            name = Console.ReadLine();
            Console.Write("当前用户是：" + name);

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 变量 -----------------");

            Class1 stu1 = new Class1();
            Class1 stu2 = new Class1();
            stu2 = stu1;
            stu1.name = "aa";
            stu2.name = "bb";
            Console.WriteLine("学生1：" + stu1.name);
            Console.WriteLine("学生2：" + stu2.name);

            object s1 = "AAA";

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 常量 -----------------");

            Console.WriteLine("测试常量：'{0}', '{1}', '{2}', '{3}' ", PRICE1, PRICE2, PRICE3, PRICE4);

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 字符串 -----------------");

            Console.WriteLine("is 运算符" + name is int);
            Char ch = 'A';
            Char ch1 = '\\';
            Console.WriteLine("Char 的方法 IsUpper: " + Char.IsUpper(ch));
            Console.WriteLine("Char 的方法 IsLower: " + Char.IsLower(ch));
            Console.WriteLine(@"C:\Windoes\MM\V4.0");

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 字符串格式 -----------------");

            Console.WriteLine(string.Format("金钱的格式 {0:C4}", 102));
            Console.WriteLine(string.Format("科学计数 {0:E}", 102));
            Console.WriteLine(string.Format("分割数字 {0:N0}", 1023456));
            Console.WriteLine(string.Format("浮点数显示 {0:F2}", 102));
            Console.WriteLine(string.Format("十六进制 {0:X4}", 102));
            Console.WriteLine(string.Format("百分比 {0:P0}", 0.90));

            int formatInt1 = 100;
            Console.WriteLine("使用 ToString 方法" + formatInt1.ToString("E"));

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 字符串格式日期时间 -----------------");

            DateTime strDate = DateTime.Now;
            Console.WriteLine(string.Format("短日期格式 {0:d}", strDate));
            Console.WriteLine(string.Format("长日期格式 {0:D}", strDate));
            Console.WriteLine(string.Format("完整日期时间格式 {0:f}", strDate));
            Console.WriteLine(string.Format("短时间格式 {0:t}", strDate));
            Console.WriteLine(string.Format("长时间格式 {0:T}", strDate));
            Console.WriteLine(string.Format("月日格式 {0:M}", strDate));
            Console.WriteLine(string.Format("年月格式 {0:Y}", strDate));

            Console.WriteLine("使用 ToString 方法" + strDate.ToString("D"));

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 字符串截取 -----------------");

            string fileName = "Program.txt";
            Console.WriteLine("截取文件名: " + fileName.Substring(0,fileName.IndexOf(".")));
            Console.WriteLine("截取扩展名: " + fileName.Substring(fileName.IndexOf(".")+1));

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 字符串分割 -----------------");

            string strSplit = "123.456.789.1011";
            string[] strs = strSplit.Split(new char[] { '.', '0' }, 2);
            foreach (string s in strs)
            {
                Console.WriteLine("按 . 分割后的数据: " + s);
            }

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 字符串插入 -----------------");

            string strInsert = "Keep on never give up";
            Console.WriteLine(strInsert.Insert(8,"going "));

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 字符串删除 -----------------");

            Console.WriteLine("删除第 7 个字符之后的所有字符：" + strInsert.Remove(7));
            Console.WriteLine("删除第 7 个字符之后的 6 个所有字符：" + strInsert.Remove(7, 6));

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 字符串复制 -----------------");

            string strCopy = String.Copy(strInsert);
            Console.WriteLine(strInsert);
            Console.WriteLine("全部复制: " + strCopy);

            char[] strCopyChar = new char[10];
            strCopy.CopyTo(strInsert.IndexOf("never"), strCopyChar, 2, 5);
            Console.WriteLine(strCopyChar);

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 字符串替换 -----------------");

            string strReplace = strInsert.Replace("Keep","Don't");
            Console.WriteLine("替换后的字符串：" + strReplace);

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 StringBuilder -----------------");

            StringBuilder sTitle = new StringBuilder("(),(),(),2,4,6,7,8");
            Console.WriteLine(sTitle);
            sTitle.Remove(0,9);
            sTitle.Insert(0,"(门前大桥下),(游过一群鸭),(快来快来数一数),");
            Console.WriteLine(sTitle);
            Console.WriteLine("String 和 StringBuilder 执行效率");
            String strB = "";
            long startTime = DateTime.Now.Millisecond;
            for (int i = 0; i < 10000; i++)
            {
                strB += i;
            }
            long endTime = DateTime.Now.Millisecond;
            Console.WriteLine("String 消耗的时间：" + (endTime - startTime));
            StringBuilder strB1 = new StringBuilder("");
            startTime = DateTime.Now.Millisecond;
            for (int i = 0; i < 10000; i++)
            {
                strB1.Append(i);
            }
            endTime = DateTime.Now.Millisecond;
            Console.WriteLine("StringBuilder 消耗的时间：" + (endTime - startTime));

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 数组 -----------------");

            int[] arr = new int[5] { 5,11,50,18,20};
            int tempArr = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > tempArr)
                {
                    tempArr = arr[i];
                }
            }
            Console.WriteLine("数组中的最大值是：" + tempArr);

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 多维数组 -----------------");

            int[,] arrD = { {1,2,3 },{4,5,6 },{7,8,9 } };
            Console.WriteLine("把数组的行列互换；原数组为：");
            for (int i = 0; i < arrD.GetLength(0); i++)
            {
                for (int j = 0; j < arrD.GetLength(1); j++)
                {
                    Console.Write(" " + arrD[i,j]);
                }
                Console.WriteLine();
            }
            int arrDtemp = 0;
            for (int i = 0; i < arrD.GetLength(0); i++)
            {
                for (int j = 0; j < i; j++)
                {
                    arrDtemp = arrD[i,j];
                    arrD[i, j] = arrD[j, i];
                    arrD[j, i] = arrDtemp;
                }
            }
            Console.WriteLine("交换后的数组为：");
            for (int i = 0; i < arrD.GetLength(0); i++)
            {
                for (int j = 0; j < arrD.GetLength(1); j++)
                {
                    Console.Write(" " + arrD[i, j]);
                }
                Console.WriteLine();
            }
            int[] arrChiose = new int[] {11,2,20,14,60,30 };
            Console.WriteLine("选择排序，原数组：");
            for (int i = 0; i < arrChiose.Length; i++)
            {
                Console.Write(" " + arrChiose[i]);
            }
            Console.WriteLine();
            int min = 0;
            for (int i = 0; i < arrChiose.Length - 1; i++)
            {
                min = i;
                for (int j = i+1; j < arrChiose.Length; j++)
                {
                    if (arrChiose[j] < arrChiose[min])
                    {
                        min = j;
                    }
                }
                arrDtemp = arrChiose[min];
                arrChiose[min] = arrChiose[i];
                arrChiose[i] = arrDtemp;
            }
            Console.WriteLine("选择排序，后的数组：");
            for (int i = 0; i < arrChiose.Length; i++)
            {
                Console.Write(" " + arrChiose[i]);
            }

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 ArrayList -----------------");

            int[] arrlist = new int[] {1,2,3,4,5,6 };
            ArrayList list = new ArrayList(arrlist);
            foreach (int ilist in list)
            {
                Console.Write(" " + ilist);
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                list.Add(i + arr.Length);   // 在结尾处添加
            }
            Console.WriteLine("使用 Add 方法添加");
            foreach (int ilist in list)
            {
                Console.Write(" " + ilist);
            }
            Console.WriteLine();
            list.Insert(1,6);      // 在指定位置添加
            Console.WriteLine("使用 Insert 方法添加");
            foreach (int ilist in list)
            {
                Console.Write(" " + ilist);
            }
            Console.ReadLine();
        }
        void fun()
        {
            str1 = "";
            str2 = "";
            Program.str2 = "cccc";
        }
    }
}

namespace MyTest
{
    class pre
    {
        public void pp()
        {
            Console.WriteLine("重新创建一个命名空间");
        }
    }

    class pre1
    {
    }
}
