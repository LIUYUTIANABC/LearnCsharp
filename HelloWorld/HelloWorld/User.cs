using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class User
    {
        // 构造函数
        public User(string name, string password, string tel)
        {
            this.Name = name;
            this.Password = password;
            this.Tel = tel;
        }

        // 析构函数
        ~User()
        {
            Console.WriteLine("调用了User的析构方法");
        }

        public string Name { get; set; }
        public string Password { get; set; }
        public string Tel { get; set; }

        public void PrintMsg()
        {
            Console.WriteLine("用户名：" + this.Name);
            Console.WriteLine("密  码：" + this.Password);
            Console.WriteLine("手机号：" + this.Tel);
        }
    }
}
