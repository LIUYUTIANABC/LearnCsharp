using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class RefOutClass
    {
        

        int count;
        string s1;

        public RefOutClass()
        {
            this.AMethod(count);
            Console.WriteLine("(1)、 i=1;经过AMethod方法（加1），值传递之后  count=" + count);
            Console.WriteLine();
            this.BMethod(ref count);
            Console.WriteLine("(2)、 i=1;经过BMethod方法（加1），值传递之后  count=" + count);
            Console.WriteLine();
            this.CMethod(out count, out s1);
            Console.WriteLine("(3)、 i=1;经过CMethod方法  count=" + count + "," + s1);
            Console.WriteLine();
        }

        private void AMethod(int i)
        {
            i = i + 5;
        }
        private void BMethod(ref int i)
        {
            i = i + 4;
        }
        private void CMethod(out int i, out string j)
        {
            i = 5;
            j = "Out";
        }
    }
}
