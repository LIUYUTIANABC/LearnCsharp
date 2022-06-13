using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class FactorialClass
    {
        public static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }

        public void FactorialA(int n)
        {
            int rs = 1;
            for (int i = 1; i <= n; i++)
            {
                rs = rs * i;
            }
            Console.WriteLine("FactorialA n 的阶乘是" + rs);
        }
    }
}
