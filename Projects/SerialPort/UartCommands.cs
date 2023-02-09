using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace SerialPortNameSpace
{
    class UartCommands
    {
        public void TestFun()
        {
            int temp = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("The temp is " + (temp + i));
            }
        }
    }
}
