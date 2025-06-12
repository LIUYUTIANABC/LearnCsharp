using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Form
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Form1 form = new Form1();
            Console.WriteLine("Input String ");
            form.str = Console.ReadLine();
            form.ShowDialog();

            Class1 cls = new Class1("Liu");
            Console.WriteLine(cls.Name);

            form.Show();
            Console.WriteLine("HelloWorld");
            Console.ReadLine();
        }
    }
}
