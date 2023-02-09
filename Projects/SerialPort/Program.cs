using System;
using System.IO;
using System.IO.Ports;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Text;

namespace SerialPortNameSpace
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("-------- 调试串口 --------");

            SerialPortTest port = new SerialPortTest();
            port.Send();
            port.Close();

            Program pro = new Program();
            TestFun();
            Console.ReadLine();
        }
        static void TestFun()
        {
            int temp = 0xFF;
            Console.WriteLine("Main fun: " + temp);
        }
    }

    public class SerialPortTest
    {
        SerialPort port;
        public SerialPortTest()
        {
            port = new SerialPort("COM18");
            port.BaudRate = 9600;
            try
            {
                port.Open();
                Reaceieve();
            }
            catch (System.Exception)
            {
                Console.WriteLine("Failed to open serial port !!!");
            }
        }

        private void Reaceieve()
        {
            port.DataReceived += port_DataReaceved;
        }

        void port_DataReaceved(object sender, SerialDataReceivedEventArgs e)
        {
            string strReceive = string.Empty;
            if(port != null)
            {
                int n = port.BytesToRead;
                byte[] byteReceive = new byte[n];
                port.Read(byteReceive, 0, n);
                strReceive = Encoding.UTF8.GetString(byteReceive);
                Console.WriteLine("接收到：" + strReceive);
            }
        }

        public void Send()
        {
            Console.WriteLine("请输入字符串");
            string? strRead = Console.ReadLine();
            while(strRead != "q")
            {
                strRead = strRead?.Trim();
                // if(!strRead.Equals(""))
                if(strRead != null)
                {
                    port.WriteLine(strRead);
                }
                Console.WriteLine("请输入字符串");
                strRead = Console.ReadLine();
            }
        }

        public void Close()
        {
            if (port != null && port.IsOpen)
            {
                port.Close();
                port.Dispose();
            }
        }
    }

}

