using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase;

namespace BarCode2Server
{
    class Program
    {
        static TcpModule _tcpMod;
        static void Main(string[] args)
        {
             _tcpMod = new DataBase.TcpModule();
            _tcpMod.Receive += _tcpMod_Receive;
            _tcpMod.Accept += _tcpMod_Accept;
            _tcpMod.Connected += _tcpMod_Connected;
            _tcpMod.Disconnected += _tcpMod_Disconnected;
            _tcpMod.StartServer();
            Console.Read();
        }

        private static void _tcpMod_Disconnected(object sender, string result)
        {
            Console.WriteLine(result);
        }

        private static void _tcpMod_Connected(object sender, string result)
        {
            //Console.WriteLine("Data Recieved");
            Console.WriteLine(result);
            
            // throw new NotImplementedException();
        }

        private static void _tcpMod_Receive(object sender, DataBase.ReceiveEventArgs e)
        {
            if (e.sendInfo.message == "ASKDICT")
            {
                // TcpModule tcp = (TcpModule)sender;
                Dictionary di = new Dictionary();
                di.ReadFromIni();
                _tcpMod.SendData(di, "ASKDICTOK");
            }
            
        }

        private static void _tcpMod_Accept(object sender)
        {
            Console.WriteLine("client accepted");
        }
    }
}
