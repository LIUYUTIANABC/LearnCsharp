using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14;

            int a = 10;
            byte b = 20;
            string s = "I love china";
            string s1 = "我爱中国";
            bool choose = true;

            Console.WriteLine("请输入一个数：");
            string sTemp = Console.ReadLine();
            int point = int.Parse(sTemp);
            Console.WriteLine(sTemp);

        // goto login;

            int sum = 0;
            for (int i = 1; i <= point; i++)
            {
                Console.WriteLine("for is " + i);
                sum += i;
            }
            Console.WriteLine("sum = " + sum);

            switch (point)
            {
                case 8:
                    Console.WriteLine("switch is 8!");
                    break;
                case 9:
                    Console.WriteLine("switch is 9!");
                    break;
                case 10:
                    Console.WriteLine("switch is 10!");
                    break;
                case 11:
                    Console.WriteLine("switch is 11!");
                    break;
                default:
                    Console.WriteLine("switch is default!");
                    break;
            }

        login:
            if (point < 10)
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine("Hello World!");
            }
            else if (point < 20)
            {
                Console.Write("Hello World!");
                Console.Write("这是中文!");
                Console.WriteLine("圆：" + PI * 3);
            }

            if (!choose)
            {
                Console.WriteLine(s);
                Console.WriteLine(s1);
            }

            User us = new User("张三", "1333", "1313");
            us.PrintMsg();
            Test t1 = new Test();
            // t1.PrintMsg();
            // Compute c1 = new Compute();

            Book book = new Book();
            book.Id = 1;
            book.Price = 34.5;
            book.PrintMsg();

            // Book1 book1 = new Book1();
            //book1.SetBook(3, "C#编程", 35.5);
            //book1.PrintMsg();
            //book1.Id = book.Id;
            //book1.PrintMsg();

            Book1.SetBook(4, "C#编程", 50.5);
            Book1.PrintMsg();

        }
    }
}
