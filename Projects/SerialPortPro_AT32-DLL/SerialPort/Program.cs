using System;
using System.IO;
using System.IO.Ports;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Text;
using System.Diagnostics;
using DGevolt.Product;
using myDll;

namespace SerialPortNameSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            myDll.Class1 myd = new myDll.Class1();
            int aa = myd.Add(3 , 4);
            Console.WriteLine("调用 myDll 方法: " + aa);

            Console.WriteLine("-------- 调试 DGevolt.Product.AT32V1 --------");
            string? comport = "COM18";
            using DGevolt.Product.AT32V1 device = new AT32V1(comport);
            if(device.QueryHello())
            {
                Console.WriteLine("QueryHello: Pass");
            }
            else
            {
                Console.WriteLine("QueryHello: Fail");
            }

            Thread.Sleep(1000);

            ushort addr= 0x0000;
            byte data = 0x00;

            Console.WriteLine("Please input the address: ");
            addr = Convert.ToUInt16(Console.ReadLine());

            Console.WriteLine("Please input the data: ");
            data = Convert.ToByte(Console.ReadLine());

            Console.WriteLine($"Read the EEROM address: 0x{addr:X4}");
            var readData = device.EepromRead(addr);
            if (readData.valid)
            {
                Console.Write($"Read the EEROM data ： 0x{readData.payload[0]:X2}");
            }
            else
            {
                Console.WriteLine("Read EEROM error!!");
            }
            Console.WriteLine();

            Console.WriteLine($"Write the EEPROM address：0x{addr:X2} data：0x{data:X2} ");
            device.EepromWrite(addr,data);

            Thread.Sleep(1000);

            Console.WriteLine($"Read the EEROM address：0x{addr:X4}");
            readData = device.EepromRead(addr);
            if (readData.valid)
            {
                Console.Write($"Read the EEROM data： 0x{readData.payload[0]:X2}");
            }
            else
            {
                Console.WriteLine("Read EEROM error!!");
            }

            Console.WriteLine();
            Console.WriteLine("---- END ----");
        }
    }
}
