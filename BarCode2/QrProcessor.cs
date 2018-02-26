using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase;

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
        private void DrawQrCode(string data, Graphics g, int z, Point p, QRCoder.QRCodeGenerator.ECCLevel err_cor)
        {
            QRCoder.QRCodeData qr_data = qgen.CreateQrCode(data, err_cor);
            qrCode = new QRCoder.QRCode(qr_data);
            bitmap = qrCode.GetGraphic(25);
            g.DrawImage(bitmap, p.X, p.Y, z, z);

        }
        private void SaveQrCode(string data, string filename, QRCoder.QRCodeGenerator.ECCLevel err_cor)
        {
            QRCoder.QRCodeData qr_data = qgen.CreateQrCode(data, err_cor);
            qrCode = new QRCoder.QRCode(qr_data);
            bitmap = qrCode.GetGraphic(25);
            bitmap.Save(filename);

        }
        /*     private QrCodeData ParseQrPacket(List<char> QrPacket)
             {
                 string res = "";
                 foreach (char c in QrPacket)
                 {
                     res += c;
                 }
                 QrCodeData _qrResult;
                 //проверка наличия пакета
                 if (res.IndexOf("FFX") != -1 && res.IndexOf("FXX") != -1 && res.Length > 9)
                 {
                     _qrResult = new QrCodeData();


                    //получаем строку без заголовка
                     string _packetWithoutHeader = res.Substring(res.IndexOf("FFX") + 6, int.Parse(res.Substring(res.IndexOf("FFX") + 3, 3)));

                     string t_packet = datapacket;
                     List<string> in_pac = new List<string>();

                     // парсинг входящих пакетов в состав основного пакета

                     while (t_packet.IndexOf("FFY") != -1 && t_packet.IndexOf("FYY") != -1)
                     {
                         in_pac.Add(t_packet.Substring(t_packet.IndexOf("FFY") + 6, int.Parse(res.Substring(res.IndexOf("FFY") + 3, 3))));
                         t_packet = t_packet.Substring(t_packet.IndexOf("FYY") + 3, t_packet.Length - t_packet.IndexOf("FYY") - 3);
                     }
                     if (in_pac.Count == 0)
                     {
                         foreach (PacketDataType p in DbList)
                         {
                             if (datapacket.IndexOf(p.TypeId) != -1)
                             {
                                 string d = datapacket.Substring(datapacket.IndexOf(p.TypeId) + 1, p.DataLen);
                                 if (p.KeyValue.Count > 0)
                                 {
                                     foreach (KeyValuePair<string, string> kv in p.KeyValue)
                                     {
                                         if (kv.Key == d)
                                             list_ident_data.Items.Add(p.DataDescr + ": " + kv.Value);
                                     }
                                 }
                                 else
                                 {
                                     list_ident_data.Items.Add(p.DataDescr + ": " + d);
                                 }

                             }
                         }
                         QrPacket.Clear();
                     }
                     else
                     {
                         string main_packet = datapacket.Substring(0, datapacket.IndexOf("FFY"));
                         foreach (PacketDataType p in DbList)
                         {
                             if (main_packet.IndexOf(p.TypeId) != -1)
                             {
                                 string d = main_packet.Substring(main_packet.IndexOf(p.TypeId) + 1, p.DataLen);
                                 if (p.KeyValue.Count > 0)
                                 {
                                     foreach (KeyValuePair<string, string> kv in p.KeyValue)
                                     {
                                         if (kv.Key == d)
                                             list_ident_data.Items.Add(p.DataDescr + ": " + kv.Value);
                                     }
                                 }
                                 else
                                 {
                                     list_ident_data.Items.Add(p.DataDescr + ": " + d);
                                 }

                             }
                         }
                         foreach (string s in in_pac)
                         {

                             foreach (PacketDataType p in DbList)
                             {
                                 if (s.IndexOf(p.TypeId) != -1)
                                 {
                                     string d = s.Substring(s.IndexOf(p.TypeId) + 1, p.DataLen);
                                     if (p.KeyValue.Count > 0)
                                     {
                                         foreach (KeyValuePair<string, string> kv in p.KeyValue)
                                         {
                                             if (kv.Key == d)
                                                 list_ident_data.Items.Add(p.DataDescr + ": " + kv.Value);
                                         }
                                     }
                                     else
                                     {
                                         list_ident_data.Items.Add(p.DataDescr + ": " + d);
                                     }

                                 }
                             }
                         }

                         QrPacket.Clear();
                     }

                 }
             }
         */
    }
}
