# C# 学习笔记

- [C# 学习笔记](#c-学习笔记)
  - [命名规则](#命名规则)
    - [常用方法](#常用方法)
    - [命名](#命名)
  - [C# 类和对象](#c-类和对象)
    - [C# 类的定义（class）](#c-类的定义class)
    - [C# 访问修饰符、修饰符](#c-访问修饰符修饰符)
    - [C# 方法的定义](#c-方法的定义)
    - [C# get 和 set](#c-get-和-set)
    - [C# 调用类成员](#c-调用类成员)
    - [C# 构造函数](#c-构造函数)
    - [C# 析构函数](#c-析构函数)
    - [C# 方法重载](#c-方法重载)
    - [C# 方法的参数 - 引用参数和输出参数](#c-方法的参数---引用参数和输出参数)
    - [C# lambda 表达式](#c-lambda-表达式)
    - [C# 递归](#c-递归)
    - [C# 嵌套类](#c-嵌套类)
    - [C# 部分类](#c-部分类)
    - [C# Console类](#c-console类)
    - [C# Math类](#c-math类)
    - [C# Random类](#c-random类)
    - [C# DateTime类](#c-datetime类)
  - [C# 字符串](#c-字符串)
    - [C# 字符串及常用的方法](#c-字符串及常用的方法)
    - [C# 获取字符串长度（string.Length）](#c-获取字符串长度stringlength)
    - [C# 查找字符串中的字符（IndexOf 和 LastIndexOf）](#c-查找字符串中的字符indexof-和-lastindexof)
    - [C# 字符串替换（Replace）](#c-字符串替换replace)
    - [C# 字符串截取函数（Substring）](#c-字符串截取函数substring)
    - [C# 字符串插入（Insert）](#c-字符串插入insert)
    - [C# 数据类型转换](#c-数据类型转换)
    - [C# 隐式数据类型转换](#c-隐式数据类型转换)
    - [C# 强制数据类型转换](#c-强制数据类型转换)
    - [C# 字符串类型转换（Parse）](#c-字符串类型转换parse)
    - [C# 数据类型转换（Convert）](#c-数据类型转换convert)
    - [C# 装箱和拆箱（值类型和引用类型）](#c-装箱和拆箱值类型和引用类型)
    - [C# 正则表达式（Regex 类）](#c-正则表达式regex-类)
  - [C# 数组](#c-数组)
    - [C# 数组简介](#c-数组简介)
    - [C# 一维数组](#c-一维数组)
    - [C# 多维数组](#c-多维数组)
    - [C# foreach循环用法](#c-foreach循环用法)
    - [C# Split 将字符串拆分成数组](#c-split-将字符串拆分成数组)
    - [冒泡排序（Sort 方法）](#冒泡排序sort-方法)
    - [C# 枚举类型（enum）](#c-枚举类型enum)
    - [C# 结构体类型（struct）](#c-结构体类型struct)
  - [C# 继承和派生](#c-继承和派生)
    - [C# 基类和派生类](#c-基类和派生类)
    - [C# Object 类](#c-object-类)
    - [C# 判断两个对象是否相等（Equals）](#c-判断两个对象是否相等equals)
    - [C# 获取哈希码（GetHashCode）方法](#c-获取哈希码gethashcode方法)
    - [C# 获取对象 type 类型（GetType）](#c-获取对象-type-类型gettype)
    - [C# 返回对象实例的字符串（ToString）](#c-返回对象实例的字符串tostring)
    - [C# VS2015类图的使用](#c-vs2015类图的使用)
    - [C# 调用父类成员方法 base](#c-调用父类成员方法-base)
    - [C# virtual（虚拟）关键字详解](#c-virtual虚拟关键字详解)
      - [方法隐藏和方法重写的区别](#方法隐藏和方法重写的区别)
  - [知识积累](#知识积累)
    - [C#中 ??  ?  ?:  ?. ?\[ \] 问号](#c中----------问号)
    - [try...catch 异常处理](#trycatch-异常处理)
    - [C# 中的 IDisposable 模式用法详解](#c-中的-idisposable-模式用法详解)
  - [Learn\_WPF\_XAML](#learn_wpf_xaml)
  - [C# 特性(Attribute)之 Flag 特性](#c-特性attribute之-flag-特性)
  - [C# 中异步编程 Async 和 Await 的用法](#c-中异步编程-async-和-await-的用法)


## 命名规则

### 常用方法

- 常用的命名方法有两种，一种是 Pascal 命名法（帕斯卡命名法），另一种是 Camel 命名法（驼峰命名法）
- Pascal 命名法是指每个单词的首字母大写；Camel 命名法是指第一个单词小写，从第二个单词开始每个单词的首字母大写

### 命名

变量名

- 变量的命名规则遵循 Camel 命名法，例如：studentName
- 全局变量：gSystemCounter
- 局部变量：lMainTimer

常量的命名

- 全部大写，类似宏定义
- 常量： PIR_SET_TIME_SEC_5

类的命名

- 类的命名规则遵循 Pascal 命名法，例如：Student

接口的命名

- 接口的命名规则遵循 Pascal 命名法，通常用 I 开头
- 例如：ICompare

方法的命名

- 方法的命名规则遵循 Pascal 命名法，一般采用动宾来命名
- 例如： AddUser

参考类：Program.cs

## C# 类和对象

### C# 类的定义（class）

- 类的访问修饰符：用于设定对类的访问限制，包括 public、internal 或者不写，用 internal 或者不写时代表只能在当前项目中访问类；public 则代表可以在任何项目中访问类。
- 修饰符：修饰符是对类本身特点的描述，包括 abstract、sealed 和 static。abstract 是抽象的意思，使用它修饰符的类不能被实例化；sealed 修饰的类是密封类，不能 被继承；static 修饰的类是静态类，不能被实例化。
- 类名：类名用于描述类的功能，因此在定义类名时最好是具有实际意义，这样方便用户理解类中描述的内容。在同一个命名空间下类名必须是唯一的。
- 类的成员：在类中能定义的元素，主要包括字段、属性、方法。
- 一个命名空间中也可以定义多个类；但不建议使用这种方式，最好是每一个文件定义一个类

### C# 访问修饰符、修饰符

- 类的访问修饰符有 2 个：public， internal；
- 类的成员包括字段，属性，方法； 访问修饰符有 4 个： public， private， internal， protected；

> - public： 成员可以被任何代码访问。
> - private： 成员仅能被同一个类中的代码访问，如果在类成员前未使用任何访问修饰符，则默认为private。
> - internal： 成员仅能被同一个项目中的代码访问。
> - protected： 成员只能由类或派生类中的代码访问。

字段的定义

- 字段不是变量或常量
- 变量定义：数据类型  变量名
- 常量定义：const 数据类型 常量名 = 值;
- 字段定义：访问修饰符  修饰符  数据类型  字段名；

修饰符

- 字段的修饰符：readonly（只读），static（静态的）
- readonly：只读，不能赋值
- static：静态字段，可以直接通过类名访问该字段
- 需要注意的是常量不能使用 static 修饰符修饰。

参考类：Test.cs

### C# 方法的定义

```
访问修饰符    修饰符    返回值类型    方法名(参数列表)
{
    语句块;
}
```

- 访问修饰符：和类成员访问修饰符相同
- 修饰符：包括 virtual（虚拟的）、abstract（抽象的）、override（重写的）、static（静态的）、sealed（密封的）
- 返回值类型：和 C 语言一样
- 方法名：以 Pascal 命名规范
- 参数列表：（数据类型 参数名，数据类型 参数名）

参考类：Compute.cs

### C# get 和 set

属性与字段：属性是通过get和set访问器对字段进行访问，保证了字段的安全性

定义属性：

```
public    数据类型    属性名
{
    get
    {
        获取属性的语句块;
        return 值;
    }
    set
    {
        设置属性得到语句块;
    }
}
```

- get 访问器：获取属性值， 可以省略
- set 访问器：设置属性值， 可以省略
- 属性命名使用Pascal命名法；由于属性都是针对某个字段赋值，因此属性名应该和字段名一致
  - 例如： name 的字段，属性名则为 Name；

属性定义简化写法：

- 自动属性设置

```
public    数据类型    属性名{get;set;}
```

- 可以省略set访问器：public int Id{get;}=1;
- 可以将属性私有化：public int Id{private get; set;}
- 可以界面快速生成属性
  - “编辑”一“重构” 一 “封装字段”
  - 右击——“快速操作和重构”——“封装字段”

什么时候使用字段，什么时候使用属性？

- 字段定义为私有的，属性定义为公有的
- 属性会把字段封装成 get 和 set
- 外部可以访问属性，但不能访问字段，保证了字段的安全性
- 对 name 字段赋予不合法的名字，将会抛出异常

参考类：Book.cs, Book1.cs

### C# 调用类成员

- 创建类的对象: Book b = new Book();
- 调用类中的成员：b.PrintMsg(); b.Id = 1; b.Name = "计算机基础";
  - 注意只可以调用 public 修饰的成员
  - b.Id 是属性，包含get和set访问器，是公有访问修饰符
- 一般属性的设置用一个方法传参数 SetBook

static 修饰的类成员

- 如果使用 static 修饰的，访问方式是“类名.类成员”： Book.SetBook();
- 如果一个方法使用 static 修饰，该方法只能直接访问静态类成员
- 非静态成员通过类的对象调用才能访问

参考类：Book1.cs

### C# 构造函数

构造方法：创建类的对象 “类名 对象名 = new 类名()” 实际上就是调用了类的构造方法；

- 构造方法的名字和类的名称相同
- 如果类中没有定义构造方法，系统会自动生成一个构造方法，该构造方法不包含参数

```
访问修饰符  类名 (参数列表)
{
    语句块；
}
```

- 构造方法通常使用 public 访问修饰符
- 如果使用 private 修饰构造方法，就无法创建该类的对象
- 通常在创建类的时候，使用构造方法初始化类中成员
- this 表示当前类的对象

参考类：User.cs

### C# 析构函数

析构方法：是在垃圾回收，释放资源时使用的；

```
~类名()
{
    语句块；
}
```

- 程序员无法调用析构函数，析构函数由垃圾回收器决定是否调用
- 如果类有析构函数系统会调用，如果没有系统会自动判断
- 也可以强制回收，但大多数情况下可以不用这样做

参考类：User.cs

### C# 方法重载

方法重载：方法名称相同、参数列表不同。

- 一个类，可以有多个构造函数，可以初始化不同的参数，这是方法重载
- 方法重载主要是：参数列表不容，参数个数，或参数数据类型不同

参考类：SumUtils.cs

### C# 方法的参数 - 引用参数和输出参数

C# 含有引用参数和输出参数，用于保存传递的数据修改后的值

参考网址：https://www.cnblogs.com/dyf96966/p/5483411.html

- 形参：Add(int a,int b) a 和 b 是形式参数
- 实参：实际传递的值 Add(3,4) 参数 3 和 4 即为实际参数
- 正常值参数：函数内对参数操作，在函数执行完毕后，数据丢失，不会作用到实际参数
- 引用参数：相当于传递的指针，即传递的参数在函数内的修改会作用到实际的参数
  - 形参和实参都要用 ref 修饰
  - 由于传递的可变的值，所以，函数必须使用变量值，常量不能使用
  - 必须使用初始化过的变量
- 输出参数：也是传递的指针，在函数执行完毕后将值从传递返回给实际使用的变量
  - 形参和实参都要用 out 修饰
  - 需要传递变量
  - 不要求一定要初始化，赋值后使用
  - 使用赋值后的输出参数，调用函数后，存储在该变量之前的值会丢失，保存最后的赋值

注意事项：

- 输出参数，常用在一个方法需要返回多个数据的情况
- 未赋值的变量用作 ref 参数是非法的， 用作 out 是合法的

参考类：RefOutClass.cs

### C# lambda 表达式

Lambda表达式：是一个匿名函数，是一种高效的类似于函数式编程的表达式

- 简化了匿名委托的使用
- 减少了编写的代码量
- 这种形式只能用在方法中只有一条语句的情况下，方便方法的书写

```
访问修饰符    修饰符    返回值类型    方法名(参数列表) => 表达式;
```

参考类：LambdaClass.cs

### C# 递归

递归：用方法调用自身

列子：实现 5 的阶乘

参考类：FactorialClass.cs

### C# 嵌套类

嵌套类：在类中定义的类

- 因为是在类中，所以，嵌套类是类中的成员，使用类成员的访问修饰符合和修饰符
- 在访问嵌套类中的成员时，必须加上外层类的名称

```
外部类.嵌套类
外部类.嵌套类.静态成员
```

参考类：OuterClass.cs

### C# 部分类

部分类：用于表示一个类中的一部分

```
访问修饰符   修饰符   partial class   类名{……}
```

- 把一个类拆分成多个不同的块，每个块就是部分类
- 部分类可以分布在不同的类中
- 部分类也有访问修饰符，修饰符
- 部分类的名称必须相同
- 部分类使用方法和正常的类使用方法一致

部分方法：使用不多，了解即可；实现的方式是在一个部分类中定义一个没有方法体的方法，在另一个部分类中完成方法体的内容

参考类：OuterClass.cs; LambdaClass.cs; Course.cs

### C# Console类

控制台常用方法

- Write：向控制台输出内容后不换行
- WriteLine：向控制台输出内容后换行
- Read：从控制台上读取一个字符
- ReadLine：从控制台上读取一行字符

格式化输出内容：占位符的使用，{索引号}的形式，第一个输出项是{0}， 第二个是{1}，以此类推

```
Console.Write("{0} 同学在 {1} 学习", name, school);
```

参考类：Program.cs; 已经注释，在主函数中使用

### C# Math类

Math 保存了一些和数学相关的计算，提供了一些方法

| 方法    | 描述                                          |
| ------- | --------------------------------------------- |
| E       | 欧拉(Euler) 常数，自然对数的底（大约为2.718） |
| PI      | 一个圆的周长与其直径的比值（大约为3.14159）   |
| Abs     | 取绝对值                                      |
| Ceiling | 返回大于或等于指定的双精度浮点数的最小整数值  |
| Floor   | 返回小于或等于指定的双精度浮点数的最大整数值  |
| Equals  | 返回指定的对象实例是否相等                    |
| Max     | 返回两个数中较大数的值                        |
| Min     | 返回两个数中较小数的值                        |
| Sqrt    | 返回指定数字的平方根                          |
| Round   | 返回四舍五入后的值                            |

参考类：Program.cs; 在主函数中输出

### C# Random类

Random类是一个产生伪随机数字的类；由触发时刻的系统时间作为种子，产生的随机数
也是经过一些算法计算，有一定的规律，并非真正意义上的随机数，所以称伪随机数；

| 方法                              | 描述                                                  |
| --------------------------------- | ----------------------------------------------------- |
| Next()                            | 每次产生一个不同的随机正整数                          |
| Next(int max Value)               | 产生一个比 max Value 小的正整数                       |
| Next(int min Value,int max Value) | 产生一个 minValue~maxValue 的正整数，但不包含maxValue |
| NextDouble()                      | 产生一个0.0~1.0的浮点数                               |
| NextBytes(byte[] buffer)          | 用随机数填充指定字节数的数组                          |

参考类：Program.cs; 在主函数中输出

### C# DateTime类

使用 DateTime.Now 获得当前的日期和时间


| 方法                     | 描述                                     |
| ------------------------ | ---------------------------------------- |
| Date                     | 获取实例的日期部分                       |
| Day                      | 获取该实例所表示的日期是一个月的第几天   |
| DayOfWeek                | 获取该实例所表示的日期是一周的星期几     |
| DayOfYear                | 获取该实例所表示的日期是一年的第几天     |
| Add(Timespan value)      | 在指定的日期实例上添加时间间隔值 value   |
| AddDays(double value)    | 在指定的日期实例上添加指定天数 value     |
| AddHours(double value)   | 在指定的日期实例上添加指定的小时数 value |
| AddMinutes(double value) | 在指定的日期实例上添加指定的分钟数 value |
| AddSeconds(double value) | 在指定的日期实例上添加指定的秒数 value   |
| AddMonths(int value)     | 在指定的日期实例上添加指定的月份 value   |
| AddYears (int value)     | 在指定的日期实例上添加指定的年份 value   |

- Add 方法需要使用时间间隔类 TimeSpan 类做参数

参考类：Program.cs; 在主函数中输出

## C# 字符串

### C# 字符串及常用的方法

| 编号 | 属性或方法名 | 作用                                                                                                                          |
| ---- | ------------ | ----------------------------------------------------------------------------------------------------------------------------- |
| 1    | Length       | 获取字符串的长度，即字符串中字符的个数                                                                                        |
| 2    | IndexOf      | 返回整数，得到指定的字符串在原字符串中第一次出现的位置                                                                        |
| 3    | LastlndexOf  | 返回整数，得到指定的字符串在原字符串中最后一次出现的位置                                                                      |
| 4    | Starts With  | 返回布尔型的值，判断某个字符串是否以指定的字符串开头                                                                          |
| 5    | EndsWith     | 返回布尔型的值，判断某个字符串是否以指定的字符串结尾                                                                          |
| 6    | ToLower      | 返回一个新的字符串，将字符串中的大写字母转换成小写字母                                                                        |
| 7    | ToUpper      | 返回一个新的字符串，将字符串中的小写字母转换成大写字母                                                                        |
| 8    | Trim         | 返回一个新的字符串，不带任何参数时表示将原字符串中前后的空格删除。 参数为字符数组时表示将原字符串中含有的字符数组中的字符删除 |
| 9    | Remove       | 返回一个新的字符串，将字符串中指定位置的字符串移除                                                                            |
| 10   | TrimStart    | 返回一个新的字符串，将字符串中左侧的空格删除                                                                                  |
| 11   | TrimEnd      | 返回一个新的字符串，将字符串中右侧的空格删除                                                                                  |
| 12   | PadLeft      | 返回一个新的字符串，从字符串的左侧填充空格达到指定的字符串长度                                                                |
| 13   | PadRight     | 返回一个新的字符串，从字符串的右侧填充空格达到指定的字符串长度                                                                |
| 14   | Split        | 返回一个字符串类型的数组，根据指定的字符数组或者字符串数组中的字符 或字符串作为条件拆分字符串                                 |
| 15   | Replace      | 返回一个新的字符串，用于将指定字符串替换给原字符串中指定的字符串                                                              |
| 16   | Substring    | 返回一个新的字符串，用于截取指定的字符串                                                                                      |
| 17   | Insert       | 返回一个新的字符串，将一个字符串插入到另一个字符串中指定索引的位置                                                            |
| 18   | Concat       | 返回一个新的字符串，将多个字符串合并成一个字符串                                                                              |

### C# 获取字符串长度（string.Length）

- 字符串由多个字符组成
- 字符串下标最后一个字符是 (字符串.Length - 1)

```
字符串.Length
字符串[0]  字符串第一个字符
字符串[字符串.Length - 1]  字符串最后一个字符
```

参考类：Program.cs; 在主函数中输出

### C# 查找字符串中的字符（IndexOf 和 LastIndexOf）

查找特定字符或字符串在原字符串中的位置

- IndexOf：指定字符串在原字符串中第一次出现的位置
- LastIndexOf：指定字符串在原字符串中最后一次出现的位置
- 字符串的位置是从 0 开始的
- IndexOf 和 LastIndexOf，只要指定的字符串在查找的字符串中不存在，结果都为 -1
- 判断字符串是否仅含有一个指定的字符串，则需要将 IndexOf 和 LastlndexOf 方法一起使用，只要通过这两个方法得到的字符串出现的位置是同一个即可

参考类：Program.cs; 在主函数中输出

### C# 字符串替换（Replace）

字符串替换就是将原字符串中指定的字符串替换成新的字符串

参考类：Program.cs; 在主函数中输出

### C# 字符串截取函数（Substring）

在字符串中截取一部分字符串，比如手机号码前3位，邮箱用户名

- Substring(指定位置); //从字符串中的指定位置开始截取到字符串结束
- Substring(指定位置, 截取的字符的个数); //从字符串中的指定位置开始截取指定字符个数的字符

参考类：Program.cs; 在主函数中输出

### C# 字符串插入（Insert）

在原字符串的指定位置插入另一个字符串

参考类：Program.cs; 在主函数中输出

### C# 数据类型转换

C# 是一门强类型语言，对类型要求比较严格，但也可以进行数据类型转换

- 隐式类型转换：以安全的方式进行转换，不会导致数据丢失，如从小的整数类型转换为大的整数类型
- 显示类型转换：强制类型转换，需要强制转换运算符，可能会造成数据丢失

显示类型转换常用方法(不包含全部)：

| 方法       | 描述                                              |
| ---------- | ------------------------------------------------- |
| ToBoolean  | 如果可能的话，把类型转换为布尔型。                |
| ToByte     | 把类型转换为字节类型。                            |
| ToChar     | 如果可能的话，把类型转换为单个 Unicode 字符类型。 |
| ToDateTime | 把类型（整数或字符串类型）转换为 日期-时间 结构。 |
| ToDecimal  | 把浮点型或整数类型转换为十进制类型。              |
| ToDouble   | 把类型转换为双精度浮点型。                        |
| ToInt16    | 把类型转换为 16 位整数类型。                      |
| ToInt32    | 把类型转换为 32 位整数类型。                      |

### C# 隐式数据类型转换

隐式转换主要在整型，浮点型之间转换，将存储范围小的数据转换为存储范围大的数据

- 从 int 类型到 long,float,double,或 decimal 类型
- 从 byte 类型到 short,ushort,int,uint,long,ulong,float,double,或 decimal 类型

```
int aConvert = 10;
double bConvert = aConvert;
float cConvert = 1.2f;
bConvert = cConvert;
```

可以直接转换，不会提示，不需要任何方法；

参考类：Program.cs; 在主函数中输出

### C# 强制数据类型转换

- 强制类型转换主要将存储范围大的数据类型转换为存储范围小的，但数据类型需要兼容
- int -> float 可以
- float -> int 可以，但会造成数据精度丢失
- string -> int 无法进行强制类型转换

```
数据类型 变量名 = (数据类型)  变量名或值;
double dbl_num = 12345678910.456;
int k = (int) dbl_num ;//此处运用了强制转换
```

参考类：Program.cs; 在主函数中输出

### C# 字符串类型转换（Parse）

Parse 将字符串类型转换成任意类型

```
数据类型 变量 = 数据类型.Parse(字符串类型的值);
int num1 = int.Parse(Console.ReadLine());
double p_num2 = double.Parse("123.456");
```

- Parse 中必须放字符串

参考类：Program.cs; 在主函数中输出

### C# 数据类型转换（Convert）

- Convert 方法是数据类型转换中最灵活的方法，它能将任意数据类型的值转换成任意数据类型；
- 前提是不要超过指定数据类型的范围

```
数据类型  变量名 = convert.To数据类型(变量名);
integer = Convert.ToInt32(c_num1);
```

参考类：Program.cs; 在主函数中输出

### C# 装箱和拆箱（值类型和引用类型）

- 将值类型转换为引用类型的操作称为装箱
- 将引用类型转换成值类型称为拆箱

Object 类型，可以与任何允许的值类型互相转换

装箱：把值封装成对象，在托管堆中分配一个新对象；在栈中的数据值被转移到托管堆中
拆箱：存储在堆中对象上的值被转移回栈中；堆中未使用的对象将被回收

参考类：Program.cs; 在主函数中输出

### C# 正则表达式（Regex 类）

正则表达式的主要作用是验证字符串的值是否满足一定的规则

- 验证邮箱是否合法、身份证号码、或者用户名等
- 正则表达式是专门处理字符串的操作

正则表达式元字符：

| 字符 | 描述                       |
| ---- | -------------------------- |
| .    | 匹配除换行符以外的所有字符 |
| \w   | 匹配字母、数字、下画线     |
| \s   | 匹配空白符（空格）         |
| \d   | 匹配数字                   |
| \b   | 匹配表达式的开始或结束     |
| ^    | 匹配表达式的开始           |
| $    | 匹配表达式的结束           |

正则表达式中表示重复的字符：

| 字 符 | 描 述         |
| ----- | ------------- |
| *     | 0次或多次字符 |
| ?     | 0次或1次字符  |
| +     | 1次或多次字符 |
| {n}   | n次字符       |
| {n,M} | n到M次字符    |
| {n, } | n次以上字符   |

- "|" 分隔符表示多个正则表达式之间的或者关系
  - 就是在匹配某一个字符串时满足其中一个正则表达式即可。
  - 身份证正则表达式，第一代和第二代 \d{15}|\d{18}

- 正则表达式要用到 Regex类，在 System.Text.RegularExpressions 名称空间中
- 在 Regex 类中使用 IsMatch 方法判断所匹配的字符串是否满足正则表达式的要求

常用的正则表达式：

| 编号 | 正则表达式                 | 作用                                                               |
| ---- | -------------------------- |
| 1    | \d{15} or \d{18}           | 验证身份证号码（15位或18位）                                       |
| 2    | \d{3}-\d{8} or \d{4}-\d{7} | 验证国内的固定电话（区号有3位或4位，并在区号和电话号码之 间加上-） |
| 3    | ^[1-9]\d*$                 | 验证字符串中都是正整数                                             |
| 4    | ^-[1-9]\d*$                | 验证字符串中都是负整数                                             |
| 5    | ^-?[1-9]\d*$               | 验证字符串中是整数                                                 |
| 6    | ^[A-Za-z]+$                | 验证字符串中全是字母                                               |
| 7    | A[A-Za-z0-9]+$             | 验证字符串由数字和字母构成                                         |
| 8    | [\u4e00-\u9fa5]            | 匹配字符串中的中文                                                 |
| 9    | [^\x00-\xff]               | 匹配字符串中的双字节字符（包括汉字）                               |

参考类：Program.cs; 在主函数中输出

## C# 数组

### C# 数组简介

- 数组存放的是一组数，通过下标操作具体的数据
- 数组中存放的值都是同一数据类型
- 在 C# 中数组不一定是数字，也可以是其他数据类型
- 枚举类型定义某些列只能设置指定的值
- 结构体是一种特殊的类型，在结构体中允许定义字段，属性，方法等成员

### C# 一维数组

定义一维数组：

- 数据类型[] 数组名 = new 数据类型[长度];
  - 这种定义没有对数组中的数据初始化，系统会自动为其赋予初始值
  - 数据类型赋值为0，引用类型赋值为 null
- 数据类型[] 数组名 = {值1，值2，...};
  - 没有指定数组长度，那么值的个数就是数组长度
  - 值就是数组成员的赋值的值
- 数据类型[] 数组名 = new 数据类型[长度n]{值1,值2,...,值n};
  - 指定长度，并为全部数组成员赋值

参考类：Program.cs; 在主函数中输出

### C# 多维数组

- 多维数组: 常用的是二维数组
  - 数据类型[ , , ...]   数组名 = new  数据类型[m,n,...]  {{ , , ...},{ , , ...}};
  - double[,] points = { { 90, 80 }, { 100, 89 }, { 88.5, 86 } };
  - 使用 points.GetLength(维度) 方法获得多维数组中某一维度的长度
  - 数组元素：points[i,j];
- 锯齿形数组：就是数组中的数组
  - 数据类型[][]  数组名 = new 数据类型[数组长度][];
  - 数组名[0] = new 数据类型[数组长度];
  - int[][] arrays = new int[3][];
  - 使用 arrays.Length; 获得锯齿形数组含义几个数组
  - 使用 arrays[1].Length 获得锯齿形数组的第1个元素的长度
  - 定义锯齿型数组时必须要指定维度
  - 数组元素：arrays[i][j]

参考类：Program.cs; 在主函数中输出

### C# foreach循环用法

- foreach 循环用于列举集合中所有的元素
- 由关键字 in 隔开；in 右边是集合名，左边是变量名
  - 每一次循环会从右边集合中取一个放到左边的变量中
  - 变量名的数据类型必须和集合数据类型一致
  - 直到集合数据被访问一遍，之后为 false 退出循环
- foreach 常与数组一起使用
  - 直接使用变量名，省去使用数组下标的麻烦
  - foreach 语句仅能用于数组，字符串或集合类数据类型

```
foreach(数据类型  变量名  in  数组名)
{
    //语句块；
}
```

参考类：Program.cs; 在主函数中输出

### C# Split 将字符串拆分成数组

- Split 是按照指定字符串拆分原字符串，并返回拆分后的字符串数组
- string[] result = str.Split(condition, StringSplitOptions.None);
  - condition 是拆分条件，一个字符串数组，遇到这个字符就拆分成一个数组元素
  - StringSplitOptions.None 是拆分选项，表示遇到空字符串也作为一个数组元素
  - StringSplitOptions.RemoveEmptyEntries 标识遇到空字符串，跳过，不作为数组元素

参考类：Program.cs; 在主函数中输出

### 冒泡排序（Sort 方法）

冒泡排序，每一次交换就把大的数放到后面；

- System.Array 是所有数组的基类，其提供的属性和方法可以用到任何数组中

| 方法          | 描述                                                                                      |
| ------------- | ----------------------------------------------------------------------------------------- |
| Clear()       | 清空数组中的元素                                                                          |
| Sort()        | 冒泡排序，从小到大排序数组中的元素                                                        |
| Reverse()     | 将数组中的元素逆序排列                                                                    |
| IndexOf()     | 查找数组中是否含有某个元素，返回该元素第一次出现的位置，如果没有与之匹配的元素，则返回 -1 |
| LastIndexOf() | 查找数组中是否含有某个元素，返回该元素最后一次出现的位置                                  |

参考类：Program.cs; 在主函数中输出

### C# 枚举类型（enum）

- 枚举类型和结构体类型都是特殊的值类型
- 定义好的值会存放到栈中
- 枚举类型定义与类成员定义是一样的
  - 可以定义到类中
  - 也可以直接定义到命名空间中
  - 注意枚举类型不能定义到方法中
- 在枚举类型定义时，要保证枚举类型的唯一性

```
访问修饰符  enum  变量名 : 数据类型
{
    值l,
    值2,
}
```

- 访问修饰符：与类成员的一样，省略后，默认是 private
- 数据类型只能是整数类型：byte，short，int，long等
- 值1，值2：默认从 0 开始，后面的值递增1
  - 也可以直接赋值一个整数值，后面的值在这个值的基础之上递增
  - 枚举类型的值时字符串类型
- 在获取枚举类型中枚举值对应的整数值时，需要将枚举类型的字符串值，强制转换成整型

参考类：EnumTest.cs; Program.cs;

### C# 结构体类型（struct）

- 枚举类型和数组比较类似
- 结构体类型和类比较类似
- 结构体和枚举类型一样是值类型
  - 可以定义到类中
  - 也可以直接定义到命名空间中
  - 不能定义到方法中
- 在结构体中可以定义字段、属性、方法

```
访问修饰符  struct  结构体名称
{
    //结构体成员
}
```

- 访问修饰符: 通常是 public 或省略不写，省略不写为默认 private
- 结构体名称：和变量命名规则相同，
- 结构体成员
  - 包括字段、属性、方法、事件
  - 在结构体中也能编写构造器，但必须带参数，并且必须为结构体中的字段赋初值
  - 在调用结构体的成员时，能使用不带参数的构造器，与创建类的对象时类似

- 结构体和类的区别，这里不做详细比较，以后用到在学吧

参考类：Program.cs;

## C# 继承和派生

- 继承是面向对象语言中的重要特性之一
- 继承主要解决代码重用的问题
- C# 语言仅支持单重继承
- C# 也提供接口用于多重继承
- C# 所有的类都继承 Object 类； Object 类中的属性和方法，可以用于任何类

### C# 基类和派生类

- 基类：已有的类, 被继承的类
- 派生类：是新的类，继承的类
- 使用派生类继承基类，可以重用代码，节省时间
- 继承的思想：属于（IS-A）关系，动物 -> 哺乳动物 -> 狗
- 继承的特点：
  - 派生类是基类的扩展，派生类可以添加新成员，但不能删除继承的成员
  - 继承可以传递；C 继承 B，B 继承 A，所以 C 有 B 的成员同样也有 A 的成员
  - 构造函数和析构函数不能继承，其他成员可以继承；基类中的成员访问方式只能决定派生类能否访问它们
  - 派生类成员和继承类的成员同名，会覆盖继承类成员，并不会删除继承类成员，只是被覆盖
  - 类可以定义虚方法，虚属性，虚索引指示器，它们本身没有内容，但用于派生类的重载，展示多态性
  - 派生类只能有一个继承，但可以通过接口实现多重继承

### C# Object 类

- Object 类是 C# 中的根类，所有类都直接或间接继承 Object 类
  - 包括系统提供的标准类，或用户自行编写的类，都继承自 Object 类
- 一个类可以用 Extends 指明它的父类，否则编译器默认会继承 Object 类
- Object 类中的方法并不多，需要用户进行覆盖，以定义自己的功能
- Object 类中常用的4个方法：Equals，GetHashCode, GetType, ToString

### C# 判断两个对象是否相等（Equals）

Equals 方法主要用于比较两个对象是否相等，如果相等则返回 True，否则返回 False

```
Equals (object ol, object o2); //静态方法
Equals (object o); //非静态方法
```

- bool flag = Equals(stu1, stu2);
- stul.Equals(stu2);

参考类：Program.cs;

### C# 获取哈希码（GetHashCode）方法

GetHashCode 方法返回当前 System.Object 的哈希代码，每个对象的哈希值都是固定的

- 该方法不是静态的，不含有任何参数，需要使用实例来调用该方法
- 该方法是定义在 Object 中，所以，任何对象都可以直接调用该方法
- 不同实例的哈希值也不同，也可以通过比较对象的 hash 值判断对象是否相等

参考类：Program.cs;

### C# 获取对象 type 类型（GetType）

- GetType 获取当前实例的类型，返回值为 System.Type 类型
- GetType 是非静态的，不含参数，需要实例调用
- 也是在 Object 类中，可以被任何类调用
- 通常用来比较某些对象的类型是否一样

参考类：Program.cs;

### C# 返回对象实例的字符串（ToString）

- ToString 方法默认情况下返回类类型的限定名
- 因为是 Object 类，所以，可以重写 ToString，重写后，返回自定义的字符串
- 值类型的字符串表现形式是： 值 转换为 字符串
- 引用类型的字符串表现形式为： 对象的类型，和 GetType 返回结果一样

参考类：Program.cs;

### C# VS2015类图的使用

在开发软件时，在详细设计阶段会使用类图的形式来表示类

- 右击类文件，选择 “查看类图” 即打开 ClassDiagram.cd 拖动类到类图中，就可查看类的信息
- 如果类图中有继承，或接口等，也会标识出来

- 创建 Student 类和 Teacher 类，有很多共用的属性，显得代码冗余
- 所以可以创建一个 Person 类，包含共用属性,被 Student 和 Teacher 继承
- 继承使用： ":" 表示

```
访问修饰符  class  ClassA:ClassB
{
    //类成员
}
```

- 访问修饰符：包括public、internal。
- ClassA：称为子类、派生类，在子类中能直接使用 ClassB 中的成员。
- ClassB：称为父类、基类。
- 一个类只能有一个父类，但一个父类可以有多个子类

在类图中表示继承关系

- 箭头的三角形端指向父类
- 箭头的尾端指向子类

参考类：Person.cs; Student.cs; Teacher.cd; Program.cs; InheritanceDiagram.cd

### C# 调用父类成员方法 base

子类中的方法和父类中的方法同名，在调用的方法的时候只会调用到子类的方法

- 这种现象不是重载，是隐藏
  - 重载是方法名相同，参数不同
  - 隐藏是子类将父类的的方法同名，父类的方法不显，只能调用子类方法
- 在子类中如果需要调用父类的成员可以使用 base 关键字

```
base.父类成员
```

- 如果在子类的方法中使用 base 调用父类的方法，相当于把父类的方法复制到了子类方法中

用户在程序中使用 this 和 base

- this 关键字表示当前类的对象
- base 关键字表示父类中的对象

### C# virtual（虚拟）关键字详解

C# 默认类中的成员都是非虚拟的；如果定义虚拟的成员（字段，属性，方法），其目的是为了在继承该类之后，在子类中重写虚成员的内容；

- 虚方法就是为重写而生的
- virtual 关键字能修饰方法、属性、索引器、事件等，在父类中定义；
- 重载、隐藏、重写是不一样的几种情况

```
//修饰属性
public  virtual  数据类型  属性名{get; set; }

//修饰方法
访问修饰符  virtual  返回值类型方法名
{
    语句块；
}
```

注意：

- virtual 关键字不能修饰使用 static 修饰的成员
- virtual 可以放到访问修饰符前面，但习惯放到访问修饰符后面
- 子类继承父类，重写父类中的成员，使用关键字 override
- 重写：指子类和父类成员定义一致，仅在子类中增加 override 关键字修饰成员
  - 注意：方法定义不能改变，包括参数类型，返回值类型等

#### 方法隐藏和方法重写的区别

```
class Program
{
    static void Main(string[] args)
    {
        A a1 = new B();
        a1.Print();
        A a2 = new C();
        a2.Print();
    }
}
class A
{
    public virtual void Print()
    {
        Console.WriteLine("A");
    }
}
class B :A
{
    public new void Print()
    {
        Console.WriteLine("B");
    }
}
class C :A
{
    public override void Print()
    {
        Console.WriteLine("C");
    }
}

输出：
A
C
请按任意键继续...
```

- 因此方法隐藏相当于在子类中定义新方法，而方法重写则是重新定义父类中方法的内容。

```
// 父类强制转换为子类：
A a2=new C();
C c=(C) a2;
c.Print();

// 父类强制转换为子类：
A a1 = new B();
a1.Print();
A a2 = new C();
a2.Print();
```

## 知识积累

### C#中 ??  ?  ?:  ?. ?[ ] 问号

- 参考网址：https://www.cnblogs.com/youmingkuang/p/11459615.html

- 1、可空类型修饰符 ( ? )
  - 例如：int? 表示可空的整形，DateTime? 表示可为空的时间
  - int? firstX = null;
- 2、三元（运算符）表达式 ( ?: )
  - 例如：x?y:z 表示如果表达式 x 为 true，则返回y；如果 x 为 false，则返回 z
- 3、空合并运算符 ( ?? )
  - 例如：a??b 当 a 为 null 时则返回 b，a 不为 null 时则返回 a 本身
- 4、NULL 检查运算符 ( ?. )
  - 如果对象为 NULL，则不进行后面的获取成员的运算，直接返回 NULL
  - points?.FirstOrDefault(); points 不为空才调用 FirstOrDefault();
  - _pack?.Dispose();

```
if(_pack != NULL) _pack.Dispose();
```

### try...catch 异常处理

- 在执行C#代码时，可能会发生不同的错误：程序员的编码错误、错误输入导致的错误或其他不可预见的事情。
- 发生错误时，C#通常会停止并生成错误消息

- 参考网址：https://www.w3schools.cn/cs/cs_exceptions.asp


```
// 语法：
try
{
  //  要尝试的代码块
}
catch (Exception e)
{
  //  处理错误的代码块
}
```

例子：抛出异常，输出异常消息

```
// 数组越界，产生异常
try
{
  int[] myNumbers = {1, 2, 3};
  Console.WriteLine(myNumbers[10]);
}
catch (Exception e)
{
  Console.WriteLine(e.Message);
  Console.WriteLine("Something went wrong.");
}
```

finally 语句

- 例子：不管 try...catch 语句是否有异常，都会执行 finally 语句

```
try
{
  int[] myNumbers = {1, 2, 3};
  Console.WriteLine(myNumbers[10]);
}
catch (Exception e)
{
  Console.WriteLine("Something went wrong.");
}
finally
{
  Console.WriteLine("The 'try catch' is finished.");
}
// 输出:
// Something went wrong.
// The 'try catch' is finished.
```

throw 语句

- 抛出异常，自定义的错误；
- throw 语句与异常类exception class一起使用。
  - C# 中有许多可用的异常类：
  - ArithmeticException, FileNotFoundException,IndexOutOfRangeException,TimeOutException等

- 例子：数字小于范围，则抛出异常

```
static void checkAge(int age)
{
  if (age < 18)
  {
    throw new ArithmeticException("Access denied - You must be at least 18 years old.");
  }
  else
  {
    Console.WriteLine("Access granted - You are old enough!");
  }
}

static void Main(string[] args)
{
  checkAge(15);
  // 输出： System.ArithmeticException: 'Access denied - You must be at least 18 years old.'
  checkAge(20);
  // 输出： Access granted - You are old enough!
}
```

### C# 中的 IDisposable 模式用法详解

- 参考网址：https://www.jb51.net/article/54899.htm

托管资源和非托管资源

- C# 中有垃圾回收机制 GC (Garbage Collection)，可以回收类中占用的内存，但是，只可以清理托管资源；
- 托管资源：创建的数组，用户定义的类、接口、委托，object，字符串等。由 GC 负责回收
- 非托管资源：好比IO、网络链接、数据库链接、文件、窗口等等。须要开发人员手动释放
  - 当释放非托管资源的时候，需要实现接口 IDisposable 里面的 Dispose()方法


```
public interface IDisposable
{
  void Dispose();
}
public class DisposablClass : IDisposable
{
  //是否回收完毕
  bool _disposed;
  public void Dispose()
  {
    Dispose(true);
    GC.SuppressFinalize(this);
  }
  ~DisposableClass()
  {
    Dispose(false);
  }

  //这里的参数表示示是否需要释放那些实现IDisposable接口的托管对象
  protected virtual void Dispose(bool disposing)
  {
    if(_disposed) return; //如果已经被回收，就中断执行
    if(disposing)
    {
      //TODO:释放那些实现IDisposable接口的托管对象
      if (_port != null)
        {
            _port?.Dispose();
            _port = null;
        }
    }
    //TODO:释放非托管资源，设置对象为null
    _port?.Dispose();
    _disposed = true;
  }
}
```

## Learn_WPF_XAML

单独学习 XAML 界面内容；

- 参考网址：https://www.jb51.net/article/98384.htm

XAML：就是微软为构建应用程序界面而创建的一种描述性语言，也就是说，这东西是搞界面的

```
<Window x:Class='MyXaml.Window1'
 xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation'
 xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml'
 Title='MyXaml' Height='150' Width='300' >
 <Grid>
  <Grid.RowDefinitions>
  <RowDefinition Height='30'/>
  <RowDefinition Height='30'/>
  <RowDefinition Height='30'/>
  </Grid.RowDefinitions>
  <Grid.ColumnDefinitions>
  <ColumnDefinition Width='Auto'/>
  <ColumnDefinition Width='*'/>
  </Grid.ColumnDefinitions>
  <TextBlock Grid.Column='0' Grid.Row='0' FontWeight='Bold' Text='姓名：' Width='30'/>
  <TextBlock Grid.Column='0' Grid.Row='1' FontWeight='Bold' Width='30'>性别：</TextBlock>
  <TextBlock Grid.Column='0' Grid.Row='2' FontWeight='Bold' Width='30' Text='年龄'></TextBlock>
  <TextBox Grid.Column='1' Grid.Row='0' FontWeight='Bold' Width='100' />
  <TextBox Grid.Column='1' Grid.Row='1' FontWeight='Bold' Width='100'/>
  <TextBox Grid.Column='1' Grid.Row='2' FontWeight='Bold' Width='100'/>
 </Grid>
</Window>
```

- 启动的界面；在 App.xaml 中，程序启动后运行的界面
  - StartupUri='Window1.xaml'

XAML 语法概述

- Grid 控件；单元格，可以设置布局，有属性 row 和 column
  - 上述是一个 三行两列 的布局
- TextBlock 和 TextBox 控件；就是一些控件
  - 还有很多控件，比如 Button 等
  - 控件中的 Grid.Column='0' Grid.Row='1'；表示在 0 列 1 行
- WPF 中的布局有 5 种：Canvas、Grid、StackPanel、DockPanel和WrapPanel
  - 1、Canvas：绝对布局；和 WinForm 一致，都是以左上角为中心，按照上下距离左上角的坐标为标准的
    - 改变 button 的位置，就要给button控件设置：
    - Canvas.Left、 Canvas.Top、Canvas.Bottom 和Canvas.Right 这四个属性。
    - 常用于固定的界面，或要求不太高的界面
  - 2、Grid：网格布局；可以把窗体分为几行几列；每个网格当中以中心为基准
    - RowDefinition：只有 Height 属性，没有 Width
    - ColumnDefinition ：只有 Width 属性，没有 Height
    - Height/Width='*' 表示占据窗体剩下的所有高度/宽度
    - 如果都为 * 则表示平分窗体
    - 如果让窗体 3：1 将两个行定义分别设置为3* 和 *
  - 3、StackPanel：栈布局；从窗口中间部位，从顶部开始，从上到下排列控件；布局默认是竖向布局
    - 修改属性： Orientation='Horizontal'  改为横向布局
    - Orientation='Vertical'纵向布局，默认属性
  - 4、DockPanel：默认布局原则，从左中位置开始，控件依次排列，最后一个控件将剩余区域从中心填充
    - 设置属性：DockPanel.Dock="Bottom" 可以是 Top，Left，Right，Buttom
    - 从底部中间位置依次排列，最后一个控件在剩余区域中心填充
  - 5、WrapPanel：原则是从窗体左上角开始，多控件的自动换行; 默认的布局是横向
    - 横向：Orientation="Horizontal" 默认布局
    - 竖向：Orientation="Vertical" 左上角开始，向下顺序排列控件，到低自动换到下一列

```
<Canvas>
  <Button Name='btn1' Height='100' Width='100' Content='btn1' Margin='10'/>
  <Button Name='btn2' Height='100' Width='100' Content='btn2' Margin='10'/>
</Canvas>

<Grid>
  <Grid.RowDefinitions>
   <RowDefinition Height='*'/>
   <RowDefinition Height='*'/>
  </Grid.RowDefinitions>
  <Grid.ColumnDefinitions>
   <ColumnDefinition Width='*'/>
   <ColumnDefinition Width='*'/>
  </Grid.ColumnDefinitions>
  <Button Name='btn1' Height='40' Width='40' Content='btn1' />
  <Button Grid.Row='1' Grid.Column='1' Name='btn2' Height='40' Width='40' Content='btn2' />
</Grid>

<StackPanel Orientation='Horizontal'>
  <Button Name='btn1' Height='40' Width='40' Content='btn1' />
  <Button Name='btn2' Height='40' Width='40' Content='btn2' />
</StackPanel>

<DockPanel>
    <Button DockPanel.Dock="Bottom" Name="btn1" Height="40" Width="40" Content="btn1" />
    <Button DockPanel.Dock="Bottom" Height="40" Width="40" Content="btn2" />
    <Button Height="40" Width="40" Content="btn2" />
    <Button Height="40" Width="40" Content="btn2" />
    <Button Height="40" Width="40" Content="btn2" />
    <Button Height="40" Width="40" Content="btn2" />
 </DockPanel>
```

核心控件

- 上面讲述了 WPF 的布局，在布局里面需要添加控件，控件有很多
  - 第一类：用户输入控件：Button、RadioButton、ComboBox、TextBox、Label...
  - 第二类：窗口修饰控件：Menu、ToolBar、StatusBar、ToolTip、ProgressBar...
  - 第三类：媒体控件，支持音频/视频的重放和图像的显示：Image、MediaElement、SoundPlayerAction
- 控件的添加和触发事件，和 WinForm 有共同点，这里不做记录
  - WinForm 全面学习控件，WPF 用到哪个，查哪个

## C# 特性(Attribute)之 Flag 特性

参考网址：https://www.cnblogs.com/GreenLeaves/p/6752822.html

- 用 [Flags] 标识的枚举类型，作为位域（标识符）处理
- 当进行 | & 的操作时，记录的是两个位，而不是一个整型
- .Net 中的枚举一般有两种用法
  - (1)、表示唯一的元素序列,列入一周天里面的各天
  - (2)、表示多种的复合状态,这个时候一般需要为枚举加上[Flags]特性为标记
- 这种 [Flags] 的枚举，常用在权限、执行状态等场合，用 int 型保存整个状态

```
public enum Permission
{
    create = 1,
    read = 2,
    update = 4,
    delete = 8,
}
[Flags]
public enum Permission1
{
    create = 1,
    read = 2,
    update = 4,
    delete = 8,
}

Console.WriteLine(permission.ToString());  // 输出 15
Console.WriteLine((int)permission);  // 输出 15
Console.WriteLine(permission1.ToString());  // 输出 create, read, update, delete
Console.WriteLine((int)permission1);  // 输出 15
```

## C# 中异步编程 Async 和 Await 的用法

参考网址：https://www.cnblogs.com/webapi/p/15210123.html
参考网址：https://www.cnblogs.com/zhaoshujie/p/11192036.html

- 异步编程，即使用 Async 和 Await 关键字，可以让主 UI 不阻塞，同时重开一个进程
- 执行 Await 修饰的方法或等待 Await 修饰的变量完成；
- 异步方法的名称以“Async”后缀结尾
- Async 的返回类型可以有三种
  - 1、如果你的方法有操作数为 TResult 类型的返回语句，则为 Task<TResult>
  - 2、如果你的方法没有返回语句或具有没有操作数的返回语句，则为 Task
  - 3、如果你编写的是异步事件处理程序，则为 Void
- Async 方法通常包含至少一个 await 表达式；如果没有 Await 则和同步方法一样，顺序执行

![img](./img/2023-3-2_Async_await.jpg)

```
private async void button1_Click(object sender, EventArgs e)
{
    var t = Task.Run(() => {
        Thread.Sleep(5000);
        return "webapi";
    });
    textBox1.Text = await t;
}
```

Task.Run 用法; Task 启动的线程默认为线程池里的，启动后默认为后台线程

```
1、无参无返回值

Task.Run(Test);
public void Test()
{
    //...to...
}

2、无参有返回值

// 以string返回值为例,Task<string>中的<string>可省略
// task前面的var也可以直接写Task<string>,这里如果直接写的话不能将<string>省略
var task=Task.Run(Test);
string result=task.Result;
public string Test()
{
    //...todo...
    return "str";
}

3、有参无返回值

// 以string参数为例
string str="str...";
Task.Run(()=>Test(str));
public void Test(string str)
{
    //...todo...
}

4、有参有返回值

// 这里以参数为int,返回值string为例
int num = 10 ;
var task = Task.Run(() => Test(num));
string result = task.Result;
public string Test(int n)
{
    //...todo...
    return "str...";
}

例子：

/// <summary>
/// 添加操作日志
/// </summary>
/// <param name="caozuo"></param>
public void AddLog(string caozuo)
{
    ActionLog model = new ActionLog()
    {
        userID = LoginUser.id,
        username = LoginUser.username,
        name = LoginUser.name,
        times = System.DateTime.Now,
        caozuo = caozuo
    };
    Task.Run(() =>
    {
        new ActionLogBLL().Add(model);
    });
}

```

