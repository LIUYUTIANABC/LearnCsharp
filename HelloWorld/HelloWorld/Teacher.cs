using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Teacher:Person
    {
        public string Title { get; set; }
        public string WageNo { get; set; }

        public new void Print()
        {
            base.Print();
            Console.WriteLine("职称：" + Title);
            Console.WriteLine("工资号：" + WageNo);
        }
    }
}
