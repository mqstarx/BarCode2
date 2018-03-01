using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    [Serializable]
    public class DataBasesCollection
    {
        private List<DataBase> m_DataBasesCollection;
        

        public List<DataBase> DataBaseCollection
        {
            get
            {
                return m_DataBasesCollection;
            }
            
        }

       

        public DataBasesCollection()
        {
          
            m_DataBasesCollection = new List<DataBase>();
        }
        public bool AddDataBase(DataBase newDb)
        {
            foreach(DataBase d in m_DataBasesCollection)
            {
                if (d.Equals(newDb))
                    return false;
            }
            m_DataBasesCollection.Add(newDb);
            return true;

        }
        public bool AddDataBaseToNode(DataBase newDb,string dbId)
        {
            foreach (DataBase d in m_DataBasesCollection)
            {
                if(d.BaseUniqId==dbId)
                {
                    if (d.DataBaseNode == null)
                        d.DataBaseNode = new DataBasesCollection();
                    d.DataBaseNode.AddDataBase(newDb);
                    return true;
                }
               
                    DataBase dbNode = SearchDbNodeInDb(d, dbId);
                if(dbNode!=null)
                {
                    if (dbNode.DataBaseNode == null)
                        dbNode.DataBaseNode = new DataBasesCollection();
                    dbNode.DataBaseNode.AddDataBase(newDb);
                    return true;
                }

               
            }
            m_DataBasesCollection.Add(newDb);
            return true;

        }
        /// <summary>
        /// поиск 
        /// </summary>
        /// <param name="db">База данных в ветке которой ведется поиск</param>
        /// <param name="id">Уникальный ид базы</param>
        /// <returns>Возвращает найденную базу</returns>
        private DataBase SearchDbNodeInDb(DataBase db,string id)
        {
            if(db.DataBaseNode!=null)
            {
                foreach(DataBase d in db.DataBaseNode.DataBaseCollection)
                {
                    if (d.BaseUniqId == id)
                        return d;
                    DataBase dbNode = SearchDbNodeInDb(d, id);
                    if (dbNode != null)
                        return dbNode;

                }
                return null;
            }
            return null;
                
        }

        public bool IsQrItemInBase(QrItem qrItem, DataBasesCollection dbCollection)
        {
            foreach(DataBase db in dbCollection.DataBaseCollection)
            {
                foreach(DataBaseItem di in db.DataBaseItems)
                {
                    if (di.QrItem.Type == qrItem.Type && di.QrItem.Value == qrItem.Value)
                        return true;
                }
                if(db.DataBaseNode!=null)
                {
                    return IsQrItemInBase(qrItem, db.DataBaseNode);
                }
            }
            return false;
        }

    }
    [Serializable]
    public class DataBase
    {
        private string m_TypeOfData;
        private string m_TypeDescr;
        private List<DataBaseItem> m_DataBaseItems;
        private DataBasesCollection m_DataBaseNode;
        private DateTime m_CreationDate;
        private string m_DataBaseName;
        private string m_BaseUniqId;

        //из справочника
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
            set
            {
                 m_DataBaseItems =value;
            }

        }

        public DataBasesCollection DataBaseNode
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

        public string TypeDescr
        {
            get
            {
                return m_TypeDescr;
            }

            set
            {
                m_TypeDescr = value;
            }
        }

        public string BaseUniqId
        {
            get
            {
                return m_BaseUniqId;
            }

           
        }

        public string DataBaseName
        {
            get
            {
                return m_DataBaseName;
            }

           
        }

        public DataBase(string typeofdata,string typedescr,string strname)
        {
            m_TypeOfData = typeofdata;
            m_CreationDate = DateTime.Now;
            m_DataBaseItems = new List<DataBaseItem>();
            m_DataBaseNode = null;
            m_DataBaseName = strname;
            m_TypeDescr = typedescr;
            Random rnd = new Random((int)m_CreationDate.Ticks+DataBaseName.GetHashCode());
            m_BaseUniqId = rnd.Next().ToString();
        }
        public override string ToString()
        {
            return DataBaseName + " (Тип: "+ m_TypeDescr + "[" + m_TypeOfData + "]" + " Дата создания:" + m_CreationDate.ToString("dd.MM.yyyy") + ")";
        }
        public override bool Equals(object obj)
        {
            DataBase _db = (DataBase)obj;
            if (_db.BaseUniqId == m_BaseUniqId && _db.DataBaseName ==m_DataBaseName)
                return true;
            else
                return false;
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
