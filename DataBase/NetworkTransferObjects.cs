using System;
using System.Collections.Generic;

namespace DataBase
{
    [Serializable]
    public class NetworkTransferObjects
    {
        private Dictionary m_Dictionary;
        private DataBasesCollection m_DataBaseCollection;
        private DataBase m_DataBase;
        private QrCodeData m_QrCodeData;
        private QrCodeData[] m_QrCodeDataArray;
        private int m_DbIndex;
        private List<DataBaseItem> m_DataBaseItemsList;
        public Dictionary Dictionary
        {
            get
            {
                return m_Dictionary;
            }

            set
            {
                m_Dictionary = value;
            }
        }

        public DataBasesCollection DataBaseCollection
        {
            get
            {
                return m_DataBaseCollection;
            }

            set
            {
                m_DataBaseCollection = value;
            }
        }

        public DataBase DataBase
        {
            get
            {
                return m_DataBase;
            }

            set
            {
                m_DataBase = value;
            }
        }

        public QrCodeData QrCodeData
        {
            get
            {
                return m_QrCodeData;
            }

            set
            {
                m_QrCodeData = value;
            }
        }

        public QrCodeData[] QrCodeDataArray
        {
            get
            {
                return m_QrCodeDataArray;
            }

            set
            {
                m_QrCodeDataArray = value;
            }
        }

        public int DbIndex
        {
            get
            {
                return m_DbIndex;
            }

            set
            {
                m_DbIndex = value;
            }
        }

        public List<DataBaseItem> DataBaseItemsList
        {
            get
            {
                return m_DataBaseItemsList;
            }

            set
            {
                m_DataBaseItemsList = value;
            }
        }
    }
}