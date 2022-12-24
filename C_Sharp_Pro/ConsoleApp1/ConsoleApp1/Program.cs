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
        static void Main(string[] args)
        {
            pre a = new pre();
            a.pp();
            string name;
            Console.WriteLine("第一个 C# 程序");
            name = Console.ReadLine();
            Console.Write("当前用户是：" + name);

            Class1 stu1 = new Class1();
            Class1 stu2 = new Class1();
            stu2 = stu1;
            stu1.name = "aa";
            stu2.name = "bb";
            Console.WriteLine("学生1：" + stu1.name);
            Console.WriteLine("学生2：" + stu2.name);
            Console.ReadLine();

            object s1 = "AAA";
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
