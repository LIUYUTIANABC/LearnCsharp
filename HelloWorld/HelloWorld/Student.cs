using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Student:Person
    {
        public string Major { get; set; }
        public string Grade { get; set; }

        public new void Print()
        {
            Console.WriteLine("专业：" + Major);
            Console.WriteLine("年级：" + Grade);
        }
    }
}
