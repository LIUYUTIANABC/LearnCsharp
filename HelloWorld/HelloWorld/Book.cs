using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Book
    {
        // 定义字段
        private int id;
        private string name;
        private double price;

        // 定义属性
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value >= 0)
                {
                    price = value;
                }
                else
                {
                    price = 0;
                }
            }
        }

        public void PrintMsg()
        {
            Console.WriteLine("图书编号：" + Id);
            Console.WriteLine("图书名称：" + Name);
            Console.WriteLine("图书价格：" + Price);
        }
    }
}
