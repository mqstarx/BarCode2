using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase;
using System.Text.RegularExpressions;

namespace BarCode2
{
    public class QrProcessor
    {
        QRCoder.QRCode qrCode;
        QRCoder.QRCodeGenerator qgen;
        Bitmap bitmap;
        public QrProcessor()
        {
            qgen = new QRCoder.QRCodeGenerator();
        }
        /// <summary>
        /// Рисует QR код
        /// </summary>
        /// <param name="data">данный</param>
        /// <param name="g">объект графики</param>
        /// <param name="z">размер квадрата</param>
        /// <param name="p">координаты левого верхнего угла</param>
        ///  <param name="err_cor">уровень коррекции ошибок</param>
        public void DrawQrCode(string data, Graphics g, int z, Point p, QRCoder.QRCodeGenerator.ECCLevel err_cor)
        {
            QRCoder.QRCodeData qr_data = qgen.CreateQrCode(data, err_cor);
            qrCode = new QRCoder.QRCode(qr_data);
            bitmap = qrCode.GetGraphic(z,Color.Black,Color.White,false);
            g.DrawImage(bitmap, p.X, p.Y, z, z);

        }
        public void SaveQrCode(string data, string filename, QRCoder.QRCodeGenerator.ECCLevel err_cor)
        {
            QRCoder.QRCodeData qr_data = qgen.CreateQrCode(data, err_cor);
            qrCode = new QRCoder.QRCode(qr_data);
            bitmap = qrCode.GetGraphic(25);
            bitmap.Save(filename);

        }

        /// <summary>
        /// убирает заголовки и возвращает чистые данные 
        /// </summary>
        /// <param name="qrPacketStr">входная строка</param>
        /// <param name="packet_flag_start">флаг начала пакета</param>
        /// <param name="packet_flag_end">флаг конца пакета</param>
        /// <param name="numSymbolsofLenCounter">колличество знаков длины пакета</param>
        /// <returns></returns>
        public string FindPacketData(string qrPacketStr, string packet_flag_start, string packet_flag_end,int numSymbolsofLenCounter )
        {
            if (IsPacketExist(qrPacketStr,packet_flag_start,packet_flag_end,numSymbolsofLenCounter))
            {
                int _beginPacketIndex = qrPacketStr.IndexOf(packet_flag_start) + packet_flag_start.Length+ numSymbolsofLenCounter;
                int _packetLen = int.Parse(qrPacketStr.Substring(qrPacketStr.IndexOf(packet_flag_start) + packet_flag_start.Length, numSymbolsofLenCounter));
                if (_packetLen > qrPacketStr.Length -packet_flag_start.Length+numSymbolsofLenCounter+packet_flag_end.Length)
                    return null;

                return  qrPacketStr.Substring(_beginPacketIndex, _packetLen);
            }
            return null;
        }

        private bool IsPacketExist(string qrPacketStr, string packet_flag_start, string packet_flag_end, int numSymbolsofLenCounter)
        {
            if (qrPacketStr.IndexOf(packet_flag_start) != -1 && qrPacketStr.IndexOf(packet_flag_end) != -1 && Regex.Match(qrPacketStr, packet_flag_start + @"\d{3}(.*)" + packet_flag_end).Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Возвращает объект класса Qr -кода. В случае ошибки чтения null
        /// </summary>
        /// <param name="QrPacket"></param>
        /// <returns></returns>
        public QrCodeData ParseQrPacket(char[] QrPacket,Dictionary dict)
        {
            //преобразуем массив символов в строку
            string qrPacketStr = new string(QrPacket.ToArray());
            QrCodeData _qrResult =null;
            qrPacketStr = FindPacketData(qrPacketStr, "FFX", "FXX", 3);
            //проверка наличия пакета
            if (qrPacketStr!=null)
            {

                _qrResult = new QrCodeData();

                if(IsPacketExist(qrPacketStr,"FFY","FYY",3)) // проверка на наличие входящих пакетов
                {

                    List<string> _inPacketArray = new List<string>();
                    string _tmpStr = qrPacketStr;
                    while(IsPacketExist(_tmpStr,"FFY","FYY",3))
                    {
                        _inPacketArray.Add(FindPacketData(_tmpStr, "FFY", "FYY", 3));
                        _tmpStr = _tmpStr.Substring(_tmpStr.IndexOf("FYY")+3);
                    }
                   
                    if(_inPacketArray.Count>0)
                    {
                       //добавляем входные пакеты
                        foreach (string s in _inPacketArray)
                        {
                            QrCodeData _inQrData = new QrCodeData();
                            QrItem[] _qrItem = DictionarySearch(dict, s);
                            if (_qrItem != null)
                                _inQrData.AddQritem(_qrItem);
                            if (_inQrData.ListQrItems.Count > 0)
                                _qrResult.AddQrInPacket(_inQrData);
                        }
                        
                    }


                    // получаем данные основного пакета
                    qrPacketStr = qrPacketStr.Substring(0, qrPacketStr.IndexOf("FFY"));

                }

                 //прогоняем через справочник
                    QrItem[] _qrItemArr = DictionarySearch(dict, qrPacketStr);
                    if (_qrItemArr != null)
                        _qrResult.AddQritem(_qrItemArr);





                    if (_qrResult.ListQrItems.Count == 0)
                    {
                        _qrResult = null;
                    }
              


            }
            return _qrResult;
        }

        private  QrItem[]  DictionarySearch(Dictionary dict, string qrPacketStr)
        {
            List<QrItem> _qrList = new List<QrItem>();
            foreach (DictionaryItem d in dict.DictionaryDataBase)
            {
                if (qrPacketStr.IndexOf(d.TypeId) != -1)
                {
                    if (qrPacketStr.Length - qrPacketStr.IndexOf(d.TypeId) > d.DataLen) // если остаток пакета больше заявленной длинны
                    {
                        string pac_data = qrPacketStr.Substring(qrPacketStr.IndexOf(d.TypeId) + d.TypeLen, d.DataLen); //вычленяем данные записываем в класс
                                                                                                                    
                        _qrList.Add(new QrItem(d.TypeId, pac_data));

                    }
                }
            }
            if (_qrList.Count > 0)
                return _qrList.ToArray();
            else
                return null;
        }

       


    }
}
