using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class SumUtils
    {
        // 定义字段
        private string s;

        // 定义属性
        public string S { get => s; set => s = value; }

        // 构造方法的重载
        public SumUtils()
        {
            Console.WriteLine(S);
        }
        public SumUtils(string s)
        {
            S = s;
            Console.WriteLine(S);
        }
        public SumUtils(string s, int age)
        {
            S = s;
            Console.WriteLine(S + age);
        }

        // 定义方法
        public int Sum(int a, int b)

        { 
            return a + b;
        }
        public double Sum(double a, double b)

        {
            return a + b;
        }
        public string Sum(string a, string b)

        {
            return a + b;
        }
        public int Sum(int a)

        {
            int sum = 0;
            for (int i = 0; i < a; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
