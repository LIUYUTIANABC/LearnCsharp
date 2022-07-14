﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Cardid { get; set; }
        public string Tel { get; set; }

        public void Print()
        {
            Console.WriteLine("编号：" + Id);
            Console.WriteLine("姓名：" + Name);
            Console.WriteLine("性别：" + Sex);
            Console.WriteLine("身份证号：" + Cardid);
            Console.WriteLine("联系方式：" + Tel);
        }

        public virtual int Area(int x, int y)
        {
            Console.WriteLine("父类 person 中的 Area 方法；");
            return x * y;
        }
    }
}
