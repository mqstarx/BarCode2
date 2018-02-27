using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    [Serializable]
    class DataBasesCollection
    {
        private List<DataBase> m_DataBasesCollection;
        private string m_DataBaseName;

        public List<DataBase> DataBaseCollection
        {
            get
            {
                return m_DataBasesCollection;
            }
            
        }

        public string DataBaseName
        {
            get
            {
                return m_DataBaseName;
            }

           
        }

        public DataBasesCollection(string name)
        {
            m_DataBaseName = name;
            m_DataBasesCollection = new List<DataBase>();
        }
    }
    [Serializable]
    public class DataBase
    {
        private string m_TypeOfData;
        private List<DataBaseItem> m_DataBaseItems;
        private DataBase m_DataBaseNode;
        private DateTime m_CreationDate;

        public string TypeOfData
        {
            get
            {
                return m_TypeOfData;
            }

            set
            {
                m_TypeOfData = value;
            }
        }

        public List<DataBaseItem> DataBaseItems
        {
            get
            {
                return m_DataBaseItems;
            }

          
        }

        public DataBase DataBaseNode
        {
            get
            {
                return m_DataBaseNode;
            }

            set
            {
                m_DataBaseNode = value;
            }
        }
        public DataBase(string typeofdata)
        {
            m_TypeOfData = typeofdata;
            m_CreationDate = DateTime.Now;
            m_DataBaseItems = new List<DataBaseItem>();
            m_DataBaseNode = null;

        }
    }
    [Serializable]
    public class DataBaseItem
    {
        private QrItem m_QrItem;
        private string m_QrCode;
        private DateTime m_CreationDate;

        public QrItem QrItem
        {
            get
            {
                return m_QrItem;
            }

            set
            {
                m_QrItem = value;
            }
        }

        public string QrCode
        {
            get
            {
                return m_QrCode;
            }

            set
            {
                m_QrCode = value;
            }
        }
        public DataBaseItem(QrItem q, string qr)
        {
            m_QrItem = q;
            m_QrCode = qr;
            m_CreationDate = DateTime.Now;
        }
    }

}
