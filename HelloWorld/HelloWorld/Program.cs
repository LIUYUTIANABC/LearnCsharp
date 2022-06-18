using System;
using System.Text.RegularExpressions;

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

        login:
            Console.WriteLine("请输入一个密码：");
            string sTemp = Console.ReadLine();
            int point = int.Parse(sTemp);

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 for 循环 -----------------");

            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            Console.WriteLine("sum = " + sum);

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 switch 选择 -----------------");

            switch (point)
            {
                case 8:
                    Console.WriteLine("Password switch is 8!");
                    break;
                case 9:
                    Console.WriteLine("Password switch is 9!");
                    break;
                case 10:
                    Console.WriteLine("Password switch is 10!");
                    break;
                case 11:
                    Console.WriteLine("Password switch is 11!");
                    break;
                default:
                    Console.WriteLine("Password switch is error!");
                    Console.WriteLine("请输入 8 - 11 之间的数， 为了调试 goto 语句");
                    goto login;
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 if 选择 -----------------");

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

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 bool 变量 -----------------");

            if (!choose)
            {
                Console.WriteLine(s);
                Console.WriteLine(s1);
            }

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 class 成员调用；构造函数；析构函数 -----------------");

            User us = new User("张三", "1333", "1313");
            us.PrintMsg();
            Test t1 = new Test();
            // t1.PrintMsg();
            // Compute c1 = new Compute();

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 get set 访问器 -----------------");

            Book book = new Book();
            book.Id = 1;
            book.Price = 34.5;
            book.PrintMsg();

            // Book1 book1 = new Book1();
            //book1.SetBook(3, "C#编程", 35.5);
            //book1.PrintMsg();
            //book1.Id = book.Id;
            //book1.PrintMsg();

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 static 属性，方法， 直接使用： 类.属性(方法) -----------------");

            Book1.SetBook(4, "C#编程", 50.5);
            Book1.PrintMsg();

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 方法重载 构造函数重载 -----------------");

            SumUtils su = new SumUtils();
            Console.WriteLine("两个整数的和：" + su.Sum(3, 5));
            Console.WriteLine("两个小数的和：" + su.Sum(3.2, 5.5));
            Console.WriteLine("两个字符串的和：" + su.Sum("C#", "方法重载"));
            Console.WriteLine("从 1 到 10 的和：" + su.Sum(10));

            SumUtils su1 = new SumUtils();
            SumUtils su2 = new SumUtils("小明");
            SumUtils su3 = new SumUtils("张三", 18);

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 方法的参数，引用参数，输出参数 -----------------");

            RefOutClass ro = new RefOutClass();

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 Lambda 表达式 -----------------");

            Console.WriteLine("Lambda 表达式：" + LambdaClass.Add(100, 200));
            Console.WriteLine("Lambda 表达式：" + LambdaClass.Add("string", 200));

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 递归 -----------------");

            Console.WriteLine("static 5 的阶乘：" + FactorialClass.Factorial(5));
            FactorialClass fc = new FactorialClass();
            fc.FactorialA(5);

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 嵌套类 -----------------");

            OuterClass.InnerClass.Diaplay();
            OuterClass.InnerClass ic = new OuterClass.InnerClass();
            ic.CardId = "10102";
            ic.Password = "123456";
            ic.PrintMsg();

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 部分类 -----------------");

            Course co = new Course();
            co.PrintMsg();

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 Console 类 -----------------");

            // int con_name = Console.Read();
            // Console.Write((char)con_name);
            // Console.WriteLine("请输入名字：");
            // string con_name1 = Console.ReadLine();
            // Console.WriteLine("请输入学校：");
            // string con_school = Console.ReadLine();
            // Console.WriteLine("{0} 同学在 {1} 学习", con_name1, con_school);

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 Math 类 -----------------");

            Console.WriteLine("Math.E: " + Math.E);
            Console.WriteLine("Math.PI: " + Math.PI);
            Console.WriteLine("Math.Abs: " + Math.Abs(-5));
            Console.WriteLine("Math.Ceiling: {0,5}", Math.Ceiling(7.33));
            Console.WriteLine("Math.Floor: {0, 3}", Math.Floor(7.33));
            Console.WriteLine("Math.Equals: " + Math.Equals(fc, co));
            Console.WriteLine("Math.Max: " + Math.Max(10, 100));
            Console.WriteLine("Math.Min: " + Math.Min(10, 100));
            Console.WriteLine("Math.Sqrt: " + Math.Sqrt(3));
            Console.WriteLine("Math.Round: " + Math.Round(7.88));

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 Random 类 -----------------");

            Random rd = new Random();
            Console.WriteLine("产生一个随机数：{0}", rd.Next());
            Console.WriteLine("产生一个10以内的随机数：{0}", rd.Next(10));
            Console.WriteLine("产生5 - 20之间的随机数：{0}", rd.Next(5, 20));
            Console.WriteLine("产生1.0-1.0的浮点数：{0,3}", rd.NextDouble());
            byte[] rdb = new byte[5];
            rd.NextBytes(rdb);
            Console.WriteLine("产生的 byte 类型的随机数组 for 循环输出");
            for (int i = 0; i < rdb.Length; i++)
            {
                Console.Write(rdb[i] + "  ");
            }
            Console.WriteLine();
            Console.WriteLine("产生的 byte 类型的随机数组 foreach 循环输出");
            foreach (byte i in rdb)
            {
                Console.Write(i + "  ");
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 DateTime 类 -----------------");

            DateTime dt = DateTime.Now;
            Console.WriteLine("当前日期为：{0}", dt);
            Console.WriteLine("当前是本月的第 {0} 天：{0}", dt.Day);
            Console.WriteLine("当前是：{0}", dt.DayOfWeek);
            Console.WriteLine("当前是本年度第 {0} 天", dt.DayOfYear);
            Console.WriteLine("30 天后的日期是 {0}", dt.AddDays(30));

            TimeSpan ts = new TimeSpan(6, 12, 56, 45, 23);
            Console.WriteLine("使用 Add(TimeSpan) {0}", dt.Add(ts));

            DateTime dt1 = new DateTime(2023, 1, 15);
            ts = dt1 - dt;
            Console.WriteLine("间隔的天数为：{0}", ts.Days);

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 字符串长度 string.Length -----------------");

            // string stl = Console.ReadLine();
            string stl = "AbcdEFgh";
            Console.WriteLine("字符串长度：" + stl.Length);
            Console.WriteLine("字符串第一个字符：" + stl[0]);
            Console.WriteLine("字符串最后一个字符：" + stl[stl.Length - 1]);
            Console.Write("顺序输出字符串：");
            foreach (char i in stl)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.Write("逆序输出字符串：");
            for (int i = stl.Length - 1; i >= 0; i--)
            {
                Console.Write(stl[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 查找字符串中的字符 -----------------");

            // string sti = Console.ReadLine();
            string sti = "1428585@qq.com";
            Console.WriteLine("要查找的字符串是：" + sti);
            if (sti.IndexOf("@") != -1)
            {
                Console.WriteLine("字符串中含有@，其出现的位置是{0}", sti.IndexOf("@") + 1);
            }
            else
            {
                Console.WriteLine("字符串中不含有@");
            }
            int firstIndex = sti.IndexOf("@");
            int lastIndex = sti.LastIndexOf("@");
            if (firstIndex != -1)
            {
                if (firstIndex == lastIndex)
                {
                    Console.WriteLine("在该字符串中仅含有一个@");
                }
                else
                {
                    Console.WriteLine("在该字符串中含有多个@");
                }
            }

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 字符串替换 -----------------");

            // string str = Console.ReadLine();
            string str = "aaa,bbb,ccc";
            Console.WriteLine("把字符串','替换为'_'：" + str);
            if (str.IndexOf(",") != -1)
            {
                str = str.Replace(",", "_");

            }
            Console.WriteLine("替换后的字符串：" + str);

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 字符串截取 -----------------");

            // string sts = Console.ReadLine();
            string sts = "123456789aa@qq.com";
            Console.WriteLine("输入邮箱，截取邮箱名：" + sts);
            firstIndex = sts.IndexOf("@");
            lastIndex = sts.LastIndexOf("@");
            if (firstIndex != -1 && firstIndex == lastIndex)
            {
                sts = sts.Substring(0, firstIndex);
            }
            Console.WriteLine("替换后的字符串：" + sts);

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 字符串插入 -----------------");

            sti = "aaaacccc";
            Console.WriteLine("在4的位置插入bbbb：" + sti);
            sti = sti.Insert(4, "bbbb");
            Console.WriteLine("替换后的字符串：" + sti);

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 隐式数据类型转换 -----------------");

            int aConvert = 10;
            double bConvert = aConvert;
            float cConvert = 1.2f;
            bConvert = cConvert;

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 强制数据类型转换 -----------------");

            double dbl_num = 11234567.123;
            int int_num = (int)dbl_num;
            Console.WriteLine("double 型 '{0}' 强制转换为 int 型 '{1}'", dbl_num, int_num);

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 字符串类型转换 Parse -----------------");

            int p_num1 = int.Parse("123");
            double p_num2 = double.Parse("123.456");
            bool p_num3 = bool.Parse("true");
            Console.WriteLine("字符串转任意类型 '{0}' '{1}' '{2}'", p_num1, p_num2, p_num3);

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 数据类型转换 Convert -----------------");

            float c_num1 = 82.53f;
            int integer;
            string c_string;
            integer = Convert.ToInt32(c_num1);
            c_string = Convert.ToString(c_num1);
            Console.WriteLine("数据类型转换 Convert '{0}' '{1}' '{2}'", c_num1, integer, c_string);

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 装箱和拆箱 -----------------");

            int o_a = 100;
            string o_str = o_a.ToString();    // 装箱
            o_a = int.Parse(o_str);           // 拆箱

            object obj = o_a;
            Console.WriteLine("装箱：对象的值 = {0}", obj);
            o_a = (int)obj;
            Console.WriteLine("拆箱：值类型的值 = {0}", o_a);

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 正则表达式 -----------------");

            // string email = "123456@qq.com";
            string email = Console.ReadLine() ;
            Regex regex = new Regex(@"^(\w)+(\.\w)*@(\w)+((\.\w+)+)$");
            if (regex.IsMatch(email))
            {
                Console.WriteLine("邮箱格式正确。");
            }
            else
            {
                Console.WriteLine("邮箱格式不正确。");
            }
        }
    }
}
