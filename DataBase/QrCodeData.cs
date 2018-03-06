using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    /// <summary>
    /// класс определяющий один сформированный qr_код
    /// </summary>
   [Serializable]
    public class QrCodeData
    {
        private List<QrItem> m_ListQrItems;
        private List<QrCodeData> m_ListInPackets;

        public List<QrItem> ListQrItems
        {
            get
            {
                return m_ListQrItems;
            }
        }

        /// <summary>
        /// вложения(входящие пакеты)
        /// </summary>
        public List<QrCodeData> ListInPackets
        {
            get
            {
                return m_ListInPackets;
            }

            
        }
        public QrCodeData()
        {
            m_ListQrItems = new List<QrItem>();
            m_ListInPackets = null;
        }
        /// <summary>
        /// Копирует объект в аргументе
        /// </summary>
        /// <param name="qr"></param>
        public QrCodeData(QrCodeData qr)
        {
            QrItem[] arr = new QrItem[qr.m_ListQrItems.Count];
            qr.ListQrItems.CopyTo(arr);
            m_ListQrItems = new List<QrItem>();
            m_ListQrItems.AddRange(arr);

            if (qr.ListInPackets != null)
            {
                if (qr.ListInPackets.Count > 0)
                {
                    QrCodeData[] arr_qr = new QrCodeData[qr.ListInPackets.Count];
                    qr.ListInPackets.CopyTo(arr_qr);

                    m_ListInPackets = new List<QrCodeData>();
                    m_ListInPackets.AddRange(arr_qr);
                }
            }
        }
        public void ChangeQrItemInList(int index,string type,string val)
        {
            m_ListQrItems[index] = new QrItem(type, val);
        }
        public void AddQritem(QrItem qr)
        {
            m_ListQrItems.Add(qr);
        }
        public void AddQritem(QrItem[] qr)
        {
            m_ListQrItems.AddRange(qr);
        }
        public void AddQrInPacket(QrCodeData qr)
        {
            if (m_ListInPackets == null)
            {
                m_ListInPackets = new List<QrCodeData>();
                m_ListInPackets.Add(qr);
            }
            else
            {
                m_ListInPackets.Add(qr);
            }
        }
        /// <summary>
        /// Генерирует строку(пакет) из данных класса
        /// </summary>
        /// <param name="header">Тип заголовка (false -FFX[заголовок основного пакета];true FFY[заголовок вложенного пакета]) </param>
        /// <returns></returns>
        public string GenerateQrCode(bool header)
        {
            string packet_data = "";
            for (int i = 0; i < m_ListQrItems.Count; i++)
            {
                if(!String.IsNullOrEmpty(m_ListQrItems[i].Type)&&!String.IsNullOrEmpty((m_ListQrItems[i].Value)))
                    packet_data += m_ListQrItems[i].Type + m_ListQrItems[i].Value;
            }
            //добавление входящих пакетов
            if (m_ListInPackets != null && !header)
            {
                for (int j = 0; j < m_ListInPackets.Count; j++)
                {
                   
                        packet_data += m_ListInPackets[j].GenerateQrCode(true);
                }
            }
            if(!header)
                 return "FFX" + packet_data.Length.ToString("000") + packet_data + "FXX";
            else
                return "FFY" + packet_data.Length.ToString("000") + packet_data + "FYY";
        }

        public override string ToString()
        {
            return "Qr-Код: " + m_ListQrItems.Count.ToString(); 
        }
    }
}
