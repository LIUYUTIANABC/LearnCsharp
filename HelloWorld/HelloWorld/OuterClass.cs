using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public partial class Course
    {
        private int id;
        private string name;
        private double point;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Point { get => point; set => point = value; }
    }
    class OuterClass
    {
        public class InnerClass
        {
            private string cardId;
            private string password;

            public string CardId { get => cardId; set => cardId = value; }
            public string Password { get => password; set => password = value; }
            public void PrintMsg()
            {
                Console.WriteLine("卡号：" + CardId);
                Console.WriteLine("密码：" + Password);
            }
            public static void Diaplay() => Console.WriteLine("内部类， Lambda");
        }
    }
}
