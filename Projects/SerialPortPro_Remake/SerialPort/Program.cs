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

namespace SerialPortNameSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] writeByte = new byte[4];

            writeByte[0] = 0x0B;
            writeByte[1] = 0x00;
            writeByte[2] = 0x00;
            writeByte[3] = 0x01;

            string quit = "y";

            Console.WriteLine("-------- 调试串口 --------");
            SerialPortTest uartPort = new SerialPortTest("COM18");

            // while (quit != "q")
            // {
            //     uartPort.Write(writeByte);
            //     quit = Console.ReadLine() ?? "y";
            //     // Thread.Sleep(1500);
            // }

            while (true)
            {
                uartPort.Read();
                Thread.Sleep(3000);
            }
        }
    }

    public class SerialPortTest
    {
        private const byte startByte = 0x55;
        private const byte endByte = 0xAA;
        private const int packetLength = 7;
        private SerialPort port;
        private readonly Stopwatch rateLimiter = Stopwatch.StartNew();

        private enum PacketLayout
        {
            Start = 0,
            Command,
            DataHigh,
            DataMid,
            DataLow,
            Checksum,
            EndByte
        }

        public SerialPortTest(string _uartPort)
        {
            port = new SerialPort(_uartPort);
            port.BaudRate = 9600;
            port.Parity = Parity.None;
            port.StopBits = StopBits.One;
            port.DataBits = 8;
            try
            {
                port.Open();
                // Reaceieve();
            }
            catch (System.Exception)
            {
                Close();
                Console.WriteLine("Failed to open serial port !!!");
            }
        }

        private byte CalculateCheckSum(byte[] _payload)
        {
            byte chk = 0;
            foreach (byte b in _payload)
            {
                chk = (byte) (chk ^ b);
            }
            return chk;
        }

        public void Write(byte[] _payload)
        {
            while (rateLimiter.ElapsedMilliseconds < 2)
            {
                // wait.
            }

            rateLimiter.Restart();
            port.DiscardInBuffer();
            port.DiscardOutBuffer();
            List<byte> packetToSend = new List<byte>();
            packetToSend.Add(startByte);
            packetToSend.AddRange(_payload);
            packetToSend.Add(CalculateCheckSum(_payload));
            packetToSend.Add(endByte);
            port.Write(packetToSend.ToArray(), 0, packetToSend.ToArray().Length);
        }

        public void Read()
        {
            List<byte> returnPacket = new List<byte>();
            Stopwatch sw = new Stopwatch();
            sw.Start();

            while (sw.ElapsedMilliseconds < 30)
            {
                if (port.BytesToRead > 0)
                {
                    returnPacket.Add((byte) port.ReadByte());
                    sw.Restart();
                }

                Thread.Sleep(5);
            }
            Console.Write("Read Data:   ");
            foreach (byte item in returnPacket)
            {
                Console.Write("    {0:X2}", item);
            }
            Console.WriteLine();
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
