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
