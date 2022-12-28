using System;
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

            Console.WriteLine(name is int);
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
