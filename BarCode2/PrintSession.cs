using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase;

namespace BarCode2
{
    /// <summary>
    /// Класс для сохранения параметров сессии печати
    /// </summary>
    [Serializable]
    public class PrintSession
    {
        private int m_QrCodeSize;
        private int m_CollumnsCount;
        private int m_SizeBeetweenCollumns;
        private int m_DX;
        private int m_DY;
        private int m_SerialCopy;
        private int m_CheckedBox;
        private DataBase.QrCodeData m_CurrentQrCode;

        public int QrCodeSize
        {
            get
            {
                return m_QrCodeSize;
            }

            set
            {
                m_QrCodeSize = value;
            }
        }

        public int CollumnsCount
        {
            get
            {
                return m_CollumnsCount;
            }

            set
            {
                m_CollumnsCount = value;
            }
        }

        public int SizeBeetweenCollumns
        {
            get
            {
                return m_SizeBeetweenCollumns;
            }

            set
            {
                m_SizeBeetweenCollumns = value;
            }
        }

        public int DX
        {
            get
            {
                return m_DX;
            }

            set
            {
                m_DX = value;
            }
        }

        public int DY
        {
            get
            {
                return m_DY;
            }

            set
            {
                m_DY = value;
            }
        }

        public int SerialCopy
        {
            get
            {
                return m_SerialCopy;
            }

            set
            {
                m_SerialCopy = value;
            }
        }

        public int CheckedBox
        {
            get
            {
                return m_CheckedBox;
            }

            set
            {
                m_CheckedBox = value;
            }
        }

        public QrCodeData CurrentQrCode
        {
            get
            {
                return m_CurrentQrCode;
            }

            set
            {
                m_CurrentQrCode = value;
            }
        }

        public PrintSession() { }
    }
}
