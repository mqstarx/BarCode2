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
        public void AddQritem(QrItem qr)
        {
            m_ListQrItems.Add(qr);
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
        /// Генерирует строку из данных класса
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
    }
}
