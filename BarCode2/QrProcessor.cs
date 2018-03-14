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

        //создание объекта qr кода из текущей коллекции контролов
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
        public void ListFillFromQrObject(ListBox listbox,TreeView tree,QrCodeData qr,Dictionary dict)
        {
            if(dict!=null)
            {
                listbox.Items.Clear();
                tree.Nodes.Clear();

                foreach(QrItem qritem in qr.ListQrItems)
                {
                    QrItemDictionary qrdi = new QrItemDictionary(qritem, dict.GetTypeDescription(qritem.Type));
                    qrdi.DataLen = qritem.Value.Length;
                    qrdi.ArrayItem = dict.GetValueArrayItemFromDictionary(qrdi.QrItem.Type, qrdi.QrItem.Value); 
                    listbox.Items.Add(qrdi);                    
                }
                if (qr.ListInPackets != null)
                {
                    foreach (QrCodeData inqr in qr.ListInPackets)
                    {
                        TreeNode node = new TreeNode(inqr.ToString());
                        List<string> qrItemDataStrs = this.IdentificateQrData(inqr, dict);
                        foreach (string qrs in qrItemDataStrs)
                        {
                            node.Nodes.Add(qrs);
                        }
                        node.Tag = inqr;
                        tree.Nodes.Add(node);
                    }
                }
            }
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
                        // qrPacketStr.Substring(qrPacketStr.IndexOf(d.TypeId), d.DataLen+d.TypeLen);

                        qrPacketStr = qrPacketStr.Remove(qrPacketStr.IndexOf(d.TypeId), d.DataLen + d.TypeLen);
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

        /// <summary>
        /// генерирует массив печати серии номеров к копированием по колонкам
        /// </summary>
        /// <param name="current"></param>
        /// <param name="dict"></param>
        /// <param name="ammount"></param>
        /// <returns></returns>
        public QrCodeData[] GenerateQrDataArrayForSerialPrint(QrCodeData current, Dictionary dict, int ammount)
        {
            if (current != null && dict != null)
            {
                QrCodeData[] qr_result_arr = null;

                QrCodeData qr_add = new QrCodeData(current);

                List<QrItemDictionary> changeItems = new List<QrItemDictionary>();
                List<int> qrItemIndexesList = new List<int>();

                foreach (DictionaryItem di in dict.DictionaryDataBase)
                {
                    for (int j = 0; j < current.ListQrItems.Count; j++)
                    {
                        if (current.ListQrItems[j].Type == di.TypeId && di.IsSerialDb)
                        {
                            QrItem qrAdd = new QrItem(current.ListQrItems[j].Type, current.ListQrItems[j].Value);
                            qrAdd.NoIncrimented = current.ListQrItems[j].NoIncrimented;
                            QrItemDictionary qr = new QrItemDictionary(qrAdd,di.DataLen);
                            changeItems.Add(qr);
                            qrItemIndexesList.Add(j);
                        }
                    }
                }

                if (changeItems.Count > 0)
                {

                    List<QrCodeData> qr_codes_list = new List<QrCodeData>();
                    for (int i = 0; i < ammount; i++)
                    {
                        for (int j =0; j<changeItems.Count;j++)
                        {


                            string str_format = "";
                            for (int v = 0; v < changeItems[j].DataLen; v++)
                            {
                                str_format += "0";
                            }
                            if(!changeItems[j].QrItem.NoIncrimented)
                            qr_add.ChangeQrItemInList(qrItemIndexesList[j], changeItems[j].QrItem.Type, (int.Parse(changeItems[j].QrItem.Value) + i).ToString(str_format));
                           
                        }
                        qr_codes_list.Add(new QrCodeData(qr_add));
                    }
                    qr_result_arr = qr_codes_list.ToArray();
                }
                   

                    return qr_result_arr;
            }
            else return null;
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
