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
        static DataBasesCollection m_DbCollection;
        static void Main(string[] args)
        {
             _tcpMod = new DataBase.TcpModule();
            _tcpMod.Receive += _tcpMod_Receive;
            _tcpMod.Accept += _tcpMod_Accept;
            _tcpMod.Connected += _tcpMod_Connected;
            _tcpMod.Disconnected += _tcpMod_Disconnected;
            _tcpMod.StartServer();
            m_DbCollection = (DataBasesCollection)Functions.LoadConfig("DataBase.qrdb");
            if (m_DbCollection == null)
                m_DbCollection = new DataBasesCollection();




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
            
            if (e.sendInfo.message == "CHECKCONN")
            {
                // TcpModule tcp = (TcpModule)sender;
               

                _tcpMod.SendData(null, "CHECKCONNOK");
            }
            if (e.sendInfo.message == "ASKDICT")
            {
                // TcpModule tcp = (TcpModule)sender;
                Dictionary di = new Dictionary();
                di.ReadFromIni();
                TcpModule ccc = (TcpModule)sender;

                _tcpMod.SendData(di, "ASKDICTOK");
            }
            if (e.sendInfo.message == "ASKDBCOLLECTION")
            {
                TcpModule ccc = (TcpModule)sender;

                _tcpMod.SendData(m_DbCollection, "ASKDBCOLLECTIONOK");
            }
            if (e.sendInfo.message == "ADDBASE")
            {
                DataBase.DataBase addDb = (DataBase.DataBase)e.Object;
                if(addDb!=null)
                {
                    if (m_DbCollection.AddDataBase(addDb))
                    {
                        Functions.SaveConfig(m_DbCollection, "DataBase.qrdb");
                        TcpModule ccc = (TcpModule)sender;

                        _tcpMod.SendData(m_DbCollection, "ADDBASEOK");
                    }
                    
                }
            }
            if (e.sendInfo.message.Contains("ADDINBASE:"))
            {
                DataBase.DataBase addDb = (DataBase.DataBase)e.Object;
                string uid = e.sendInfo.message.Split(':')[1];
                if (addDb != null)
                {
                    if (m_DbCollection.AddDataBaseToNode(addDb,uid))
                    {
                        Functions.SaveConfig(m_DbCollection, "DataBase.qrdb");
                        TcpModule ccc = (TcpModule)sender;

                        _tcpMod.SendData(m_DbCollection, "ADDINBASEOK");
                    }

                }
            }
        }
        private static void _tcpMod_Accept(object sender)
        {
            Console.WriteLine("client accepted");
        }
    }
}
