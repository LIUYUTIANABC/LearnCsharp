using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Teacher:Person
    {
        public string Title { get; set; }
        public string WageNo { get; set; }

        // 方法隐藏
        public new void Print()
        {
            base.Print();
            Console.WriteLine("职称：" + Title);
            Console.WriteLine("工资号：" + WageNo);
        }

        // 方法重写
        public override int Area(int x, int y)
        {
            // 重写方法中调用父类虚方法
            base.Area(x, y);
            Console.WriteLine("子类 teacher 中的 Area 方法；");
            return x + y;
        }

        public override string ToString()
        {
            this.Title = "C# 语言";
            this.Tel = "13635517894";
            return "Override ToString: " + this.Title + "," + this.Tel;
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
