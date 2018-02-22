using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarCode2Server
{
    class Program
    {
        
        static void Main(string[] args)
        {
            DataBase.TcpModule _tcpMod = new DataBase.TcpModule();
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
            DataBase.SerialItem si = (DataBase.SerialItem)e.Object;
            Console.WriteLine("Data Recieved: " + si.Stest.Count );
        }

        private static void _tcpMod_Accept(object sender)
        {
            Console.WriteLine("client accepted");
        }
    }
}
