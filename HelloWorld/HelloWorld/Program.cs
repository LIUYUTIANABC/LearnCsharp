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

            string email = "123456@qq.com";
            // string email = Console.ReadLine();
            Regex regex = new Regex(@"^(\w)+(\.\w)*@(\w)+((\.\w+)+)$");
            if (regex.IsMatch(email))
            {
                Console.WriteLine("邮箱格式正确。");
            }
            else
            {
                Console.WriteLine("邮箱格式不正确。");
            }

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 一维数组 -----------------");

            int[] arr = { 1, 2, 3 };
            Console.WriteLine("数组长度：" + arr.Length);
            Console.WriteLine("数组第一位：" + arr[0]);
            Console.WriteLine("数组最后一位：" + arr[arr.Length - 1]);
            string[] str_arr = new string[3];
            str_arr[1] = "bbb";
            foreach (string i in str_arr)
            {
                Console.Write("{0}     ", i);
            }
            Console.WriteLine();
            double[] dou_arr = new double[2] { 11.1, 12.2 };
            Console.Write("{0}     {1}", dou_arr[0], dou_arr[1]);
            Console.WriteLine();
            // dou_arr[0] = double.Parse(Console.ReadLine());
            dou_arr[0] = double.Parse("222.34");
            Console.Write("{0}     {1}", dou_arr[0], dou_arr[1]);
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 多维数组 -----------------");

            double[,] points = { { 90, 80 }, { 100, 89 }, { 88.5, 86 } };
            for (int i = 0; i < points.GetLength(0); i++)
            {
                Console.WriteLine("第" + (i + 1) + "个学生成绩：");
                for (int j = 0; j < points.GetLength(1); j++)
                {
                    Console.Write(points[i, j] + "   ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 锯齿形数组 -----------------");

            int[][] array1 = new int[3][];
            // array1[0] = new int[] {1,2};
            // array1[1] = new int[] {3,4,5};
            // array1[2] = new int[] {6,7,8,9};.
            array1[0] = new int[3];
            array1[1] = new int[2];
            array1[2] = new int[4];
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine("第 {0} 维数组元素如下：", i);
                for (int j = 0; j < array1[i].Length; j++)
                {
                    // array1[i][j] = int.Parse(Console.ReadLine());
                    array1[i][j] = i + j;
                    Console.WriteLine("第 {0} 列数据为： {1}", j, array1[i][j]);
                }
            }

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 foreach 循环 -----------------");

            double[] dou_foreach = { 80.5, 81.5, 90, 100.5, 88 };
            double sum_foreach = 0;
            double avg_foreach = 0;
            foreach (double point_for in dou_foreach)
            {
                sum_foreach += point_for;
            }
            avg_foreach = sum_foreach / dou_foreach.Length;
            Console.WriteLine("总成绩为：{0} \n平均值为：{1}", sum_foreach, avg_foreach);

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 Split 将字符串拆分成数组 -----------------");

            string str_split = "abc,def,ghs,ijksrt";
            string[] condition = { ",", "s" };
            string[] result = str_split.Split(condition, StringSplitOptions.None);
            foreach (string str_sp in result)
            {
                Console.WriteLine(str_sp);
            }

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 冒泡排序 -----------------");

            int[] arr_sort = { 5, 1, 7, 8, 3, 15 };
            for (int i = 0; i < arr_sort.Length; i++)
            {
                for (int j = 0; j < arr_sort.Length - i - 1; j++)
                {
                    if (arr_sort[j] < arr_sort[j + 1])
                    {
                        int temp_s = arr_sort[j];
                        arr_sort[j] = arr_sort[j + 1];
                        arr_sort[j + 1] = temp_s;
                    }
                }
            }
            Console.WriteLine("降序排序后的结果为：");
            foreach (int i in arr_sort)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 System.Array 数组基类方法 -----------------");

            Console.WriteLine("调用 Array.Sort(arr) 从小到大排列数组元素:");
            Array.Sort(arr_sort);
            foreach (int i in arr_sort)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("调用 Array.Reverse(arr) 逆序排列:");
            Array.Reverse(arr_sort);
            foreach (int i in arr_sort)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("调用 Array.Clear(arr) 清空数组:");
            Array.Clear(arr_sort, 2, 3);
            foreach (int i in arr_sort)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("调用 Array.Indexof() 查找数组元素:");
            Console.WriteLine("数据第一次出现在数组第几位：" + Array.IndexOf(arr_sort, 0));
            Console.WriteLine("调用 Array.LastIndexof() 查找数组元素:");
            Console.WriteLine("数据最后一次出现在数组第几位：" + Array.LastIndexOf(arr_sort, 0));

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 Enum 枚举类型 -----------------");

            Console.WriteLine("Enum " + EnumTest.Title.助教 + ": " + (int)EnumTest.Title.助教);
            Console.WriteLine("Enum " + EnumTest.Title.讲师 + ": " + (int)EnumTest.Title.讲师);
            Console.WriteLine("Enum " + EnumTest.Title.副教授 + ": " + (int)EnumTest.Title.副教授);
            Console.WriteLine("Enum " + EnumTest.Title.教授 + ": " + (int)EnumTest.Title.教授);

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 struct 结构体类型 -----------------");

            student struct_stu = new student();
            struct_stu.Name = "张三";
            struct_stu.Age = -18;
            Console.WriteLine("结构体构造器，姓名：" + struct_stu.Name);
            Console.WriteLine("结构体构造器，年龄：" + struct_stu.Age);

            struct_stu = new student("李四", 25);
            Console.WriteLine("下面是使用结构体构造函数：");
            struct_stu.PrintStudent();

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 Object 类 Equals 方法 -----------------");

            bool e_flag = Equals(struct_stu, struct_stu);
            Console.WriteLine("比较结构体：" + e_flag);
            Console.WriteLine("比较类：" + struct_stu.Equals(fc));

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 Object 类 GetHashCode 方法 -----------------");

            Console.WriteLine("获得一个类的 Hash 值：" + su.GetHashCode());
            Console.WriteLine("获得一个类的 Hash 值：" + fc.GetHashCode());

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 Object 类 GetType 方法 -----------------");

            Console.WriteLine("查看整型：" + a.GetType());
            Console.WriteLine("查看字符型：" + str.GetType());
            Console.WriteLine("查看字符型：" + su.GetType());

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 Object 类 ToString 方法 -----------------");

            Console.WriteLine("值类型（int）的字符串表现形式：" + a.ToString());
            Console.WriteLine("字符串的字符串表现形式：" + str.ToString());
            Console.WriteLine("引用类型的字符串表现形式：" + su.ToString());
            Console.WriteLine("结构体的字符串表现形式：" + struct_stu.ToString());

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 类图的使用 -----------------");

            Console.WriteLine("请查看 InheritanceDiagram.cd");

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 base 使用 -----------------");

            Console.WriteLine("继承 Person 类的 Student； Print 方法被覆盖");
            Student In_Stu = new Student();
            In_Stu.Print();
            Console.WriteLine("继承 Person 类的 Teacher； Print 中包含父类方法");
            Teacher In_Tea = new Teacher();
            In_Tea.Print();
            Console.WriteLine("父类 Person； Print 方法");
            Person In_Per = new Person();
            In_Per.Print();

            Console.WriteLine();
            Console.WriteLine("----------------- 调试 virtual 使用 -----------------");

            int In_vir_t = In_Per.Area(4,5);
            Console.WriteLine("父类的虚方法返回值：" + In_vir_t);
            In_vir_t = In_Tea.Area(4,5);
            Console.WriteLine("子类重载父类虚方法返回值：" + In_vir_t);
            Console.WriteLine("重写类中 ToString() 方法");
            Console.WriteLine(In_Tea.ToString());
        }
    }

    public struct student
    {
        // 定义字段
        private string name;
        private int age;
        // 定义属性
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                else
                {
                    age = value;
                }
            }
        }
        public student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void PrintStudent()
        {
            Console.WriteLine("结构体方法，姓名：" + name);
            Console.WriteLine("结构体方法，年龄：" + age);
        }
    }
}
