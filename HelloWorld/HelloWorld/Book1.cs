using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Book1
    {
        // 定义字段
        private static int id;
        private static string name;
        private static double price;

        // 定义属性
        public static int Id { get => id; set => id = value; }
        public static string Name { get => name; set => name = value; }
        public static double Price { get => price; set => price = value; }

        // 定义方法
        // set book
        public static void SetBook(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
        public static void PrintMsg()
        {
            Console.WriteLine("图书编号：" + Id);
            Console.WriteLine("图书名称：" + Name);
            Console.WriteLine("图书价格：" + Price);
        }
    }
}
