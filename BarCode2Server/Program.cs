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
             _tcpMod = new DataBase.TcpModule(true);
            _tcpMod.Receive += _tcpMod_Receive;
            _tcpMod.Accept += _tcpMod_Accept;
            _tcpMod.Connected += _tcpMod_Connected;
            _tcpMod.Disconnected += _tcpMod_Disconnected;
            _tcpMod.StartServer(15000);
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
            TcpModule tcp = (TcpModule)sender;
            if (e.SendInfo.ProtocolMsg == ProtocolOfExchange.CheckConnection )
            {
                tcp.SendData(null, ProtocolOfExchange.CheckConnectionOK);
            }
            if (e.SendInfo.ProtocolMsg == ProtocolOfExchange.AskDictionary)
            {
             
                Dictionary di = new Dictionary();
                di.ReadFromIni();
                NetworkTransferObjects obj = new NetworkTransferObjects();
                obj.Dictionary = di;
                tcp.SendData(obj, ProtocolOfExchange.AskDictionaryOk);
            }
            if (e.SendInfo.ProtocolMsg ==  ProtocolOfExchange.AskDbCollection)
            {

                NetworkTransferObjects obj = new NetworkTransferObjects();
                obj.DataBaseCollection = m_DbCollection;
                tcp.SendData(obj, ProtocolOfExchange.AskDbCollectionOk);
            }
            if (e.SendInfo.ProtocolMsg == ProtocolOfExchange.AddBase )
            {
                NetworkTransferObjects obj = new NetworkTransferObjects();
                DataBase.DataBase addDb = (DataBase.DataBase)e.NetDataObj.DataBase;
                if (addDb != null)
                {
                    if (m_DbCollection.AddDataBase(addDb))
                    {
                        Functions.SaveConfig(m_DbCollection, "DataBase.qrdb");

                        obj.DataBaseCollection = m_DbCollection;
                        tcp.SendData(obj,  ProtocolOfExchange.AddBaseOk);
                    }
                    else
                    {                      
                        tcp.SendData(null, ProtocolOfExchange.AddBaseFail );
                    }

                }
            }
            if (e.SendInfo.ProtocolMsg ==  ProtocolOfExchange.DelBase)
            {
                DataBase.DataBase addDb = (DataBase.DataBase)e.NetDataObj.DataBase;
                if (addDb != null)
                {

                    if (m_DbCollection.DeleteDataBase(addDb))
                    {
                        NetworkTransferObjects obj = new NetworkTransferObjects();
                        obj.DataBaseCollection = m_DbCollection;
                        Functions.SaveConfig(m_DbCollection, "DataBase.qrdb");                       
                        _tcpMod.SendData(obj,ProtocolOfExchange.DelBaseOk);
                    }
                }
            }
            //ADDQRITEMINBASE
            if (e.SendInfo.ProtocolMsg ==  ProtocolOfExchange.AddQrItemInBase )
            {
                QrCodeData qrcode = (QrCodeData)e.NetDataObj.QrCodeData;
                if (qrcode != null)
                {
                    if (m_DbCollection.AddQrCodeToDataBases(qrcode))
                    {
                        Functions.SaveConfig(m_DbCollection, "DataBase.qrdb");
                        NetworkTransferObjects obj = new NetworkTransferObjects();
                        obj.DataBaseCollection = m_DbCollection;

                        _tcpMod.SendData(obj, ProtocolOfExchange.AddQrItemInBaseOk);
                    }
                    else
                    {                      
                        tcp.SendData(null,  ProtocolOfExchange.AddQrItemInBaseFail);
                    }

                }
            }
            //ADDQRITEMSINBASE
            if (e.SendInfo.ProtocolMsg ==  ProtocolOfExchange.AddQrItemSInBase)
            {
                QrCodeData[] qrcode = (QrCodeData[])e.NetDataObj.QrCodeDataArray;
                if (qrcode != null)
                {
                    if (m_DbCollection.AddQrCodeSerialToDataBases(qrcode))
                    {
                        Functions.SaveConfig(m_DbCollection, "DataBase.qrdb");
                        NetworkTransferObjects obj = new NetworkTransferObjects();
                        obj.DataBaseCollection = m_DbCollection;
                        tcp.SendData(obj,  ProtocolOfExchange.AddQrItemSInBaseOk);
                    }
                    else
                    {
                      
                        tcp.SendData(null, ProtocolOfExchange.AddQrItemSInBaseFail);
                    }
                }
            }

            if (e.SendInfo.ProtocolMsg == ProtocolOfExchange.DelDbItems)
            {


                int db_index = e.NetDataObj.DbIndex;             
                if(db_index!=-1)
                {
                    if(m_DbCollection.DeleteItemsFromDb((List<DataBaseItem>)e.NetDataObj.DataBaseItemsList,db_index))
                    {
                        Functions.SaveConfig(m_DbCollection, "DataBase.qrdb");
                        NetworkTransferObjects obj = new NetworkTransferObjects();
                        obj.DataBaseCollection = m_DbCollection;

                        tcp.SendData(obj, ProtocolOfExchange.DelDbItemsOK);
                    }
                    else
                    {
                       

                        _tcpMod.SendData(null, ProtocolOfExchange.DelDbItemsFail);
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
