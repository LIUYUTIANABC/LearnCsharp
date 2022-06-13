using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public partial class Course
    {
        public void PrintMsg()
        {
            this.Id = LambdaClass.Add(100, 200);
            this.Name = LambdaClass.Add("Liu", 10);
            this.Point = 32.8125;
            Console.WriteLine("卡号：" + Id);
            Console.WriteLine("名字：" + Name);
            Console.WriteLine("点：" + Point);
        }
    }
    class LambdaClass
    {
        public static int Add(int a, int b) => a + b;
        public static string Add(string a, int b) => "字符串" + a + b;
    }
}
