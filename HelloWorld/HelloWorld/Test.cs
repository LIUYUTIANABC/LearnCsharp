using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Test
    {
        // 定义字段
        private int id = 10001;
        private readonly string name = "asaa";
        internal static int age = 18;
        private const string major = "计算机";

        public string Name => name;

        public int Id { get => id; set => id = value; }

        private void PrintMsg()
        {
            Console.WriteLine("编号" + Id);
            Console.WriteLine("姓名" + Name);
            Console.WriteLine("年龄" + age);
            Console.WriteLine("专业" + major);
        }
    }
}
