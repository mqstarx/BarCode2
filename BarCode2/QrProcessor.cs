using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Windows.Forms;

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
        public void DrawQrCode(string data, Graphics g, int z, PointF p, QRCoder.QRCodeGenerator.ECCLevel err_cor)
        {
            QRCoder.QRCodeData qr_data = qgen.CreateQrCode(data, err_cor);
            qrCode = new QRCoder.QRCode(qr_data);
            bitmap = qrCode.GetGraphic(10,Color.Black,Color.White,false);
            float h = z * (float)3.779527559055;
            g.DrawImage(bitmap, p.X, p.Y, h,h);

        }
        public void SaveQrCode(string data, string filename, QRCoder.QRCodeGenerator.ECCLevel err_cor)
        {
            QRCoder.QRCodeData qr_data = qgen.CreateQrCode(data, err_cor);
            qrCode = new QRCoder.QRCode(qr_data);
            bitmap = qrCode.GetGraphic(100, Color.Black, Color.White, false);
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
            qrPacketStr = Functions.ConvertEngl(qrPacketStr);
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


        public QrCodeData CreateQrCodeFromList(ListBox.ObjectCollection arr,TreeNodeCollection nodes)
        {
            QrCodeData _result = new QrCodeData();
            foreach(QrItemDictionary qr in arr)
            {
                _result.AddQritem(qr.QrItem);
            }
            foreach(TreeNode trNode in nodes)
            {
                _result.AddQrInPacket((QrCodeData)trNode.Tag);
            }
            return _result;
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

       
        public List<string> IdentificateQrData(QrCodeData qr,Dictionary dict)
        {
            List<string> m_result = new List<string>();
            if (qr != null && dict != null)
            {
                if (qr.ListQrItems.Count > 0 && dict.DictionaryDataBase.Count > 0)
                {
                    foreach(QrItem q in qr.ListQrItems)
                    {
                        foreach(DictionaryItem d in dict.DictionaryDataBase)
                        {
                            if(q.Type == d.TypeId)
                            {
                                if (d.KeyValues == null)
                                {
                                    if(!d.Is_date)
                                        m_result.Add(d.DataDescr + ":" + q.Value);
                                    else
                                        m_result.Add(d.DataDescr + ":" + ParseDate(q.Value).ToString("dd:MM:yyyy"));
                                }
                                else
                                {
                                    foreach (ArrayItem ar in d.KeyValues)
                                    {
                                        if (ar.Key == q.Value)
                                        {
                                            m_result.Add(d.DataDescr + ":" + ar.Value);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if(qr.ListInPackets!=null )
                    {
                        if (qr.ListInPackets.Count > 0)
                        {
                           
                            foreach (QrCodeData qrIn in qr.ListInPackets)
                            {
                                m_result.Add("Входящий узел:");
                                foreach (QrItem q in qrIn.ListQrItems)
                                {
                                    foreach (DictionaryItem d in dict.DictionaryDataBase)
                                    {
                                        if (q.Type == d.TypeId)
                                        {
                                            if (d.KeyValues == null)
                                            {
                                                if (!d.Is_date)
                                                    m_result.Add(d.DataDescr + ":" + q.Value);
                                                else
                                                    m_result.Add(d.DataDescr + ":" + ParseDate(q.Value).ToString("dd:MM:yyyy"));
                                            }
                                            else
                                            {
                                                foreach (ArrayItem ar in d.KeyValues)
                                                {
                                                    if (ar.Key == q.Value)
                                                    {
                                                        m_result.Add(d.DataDescr + ":" + ar.Value);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else
                    return null;
            }
            else
                return null;

            return m_result;
        }

        private DateTime ParseDate(string s)
        {
            if (s.Length != 6)
                return DateTime.MaxValue;
            else
            {
                try
                {
                    int.Parse(s);
                    int year = int.Parse(s.Substring(4, 2));
                    if (year > 70)
                        year += 1900;
                    else
                        year += 2000;
                    DateTime d = new DateTime(year, int.Parse(s.Substring(2, 2)), int.Parse(s.Substring(0, 2)));
                    return d;
                    

                }
                catch { return DateTime.MaxValue; }
            }
        }
         
    }
}
