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
                if (d.TypeDbProdukt.Type == newDb.TypeDbProdukt.Type && d.TypeOfDataSerial==newDb.TypeOfDataSerial && d.TypeDbProdukt.Key==newDb.TypeDbProdukt.Key)
                    return false;
            }
            m_DataBasesCollection.Add(newDb);
            return true;

        }
        public bool DeleteDataBase(DataBase newDb)
        {
            foreach (DataBase d in m_DataBasesCollection)
            {
                if (d.TypeDbProdukt.Type == newDb.TypeDbProdukt.Type && d.TypeOfDataSerial == newDb.TypeOfDataSerial && d.TypeDbProdukt.Key == newDb.TypeDbProdukt.Key)
                {
                    m_DataBasesCollection.Remove(d);
                    return true;
                }
            }
           
            return false;

        }


        public bool IsQrItemInBase(QrItem qrItem)
        {
            foreach(DataBase db in m_DataBasesCollection)
            {
                foreach(DataBaseItem di in db.DataBaseItems)
                {
                    if (di.QrItem.Type == qrItem.Type && di.QrItem.Value == qrItem.Value)
                        return true;
                }
               
            }
            return false;
        }
      

        public bool IsHaveDbWithQrParametrs(QrCodeData qrCode)
        {
            bool produkt_param = false;
            bool serial_param = false;
            foreach (DataBase db in m_DataBasesCollection)
            {
               
                foreach(QrItem qr in qrCode.ListQrItems)
                {
                    if (qr.Type == db.TypeOfDataSerial)
                        serial_param = true;

                    if (qr.Type == db.TypeDbProdukt.Type && qr.Value == db.TypeDbProdukt.Key)
                        produkt_param = true;
                }

            }
            if (produkt_param && serial_param)
                return true;
            else
                return false;

        }

        //возвращает индексы баз данных в которые необходимо добавить qr-код
        private int[] DbIndexesForQrDataSave(QrCodeData qrCode)
        {
            List<int> indexes = new List<int>();

            for(int i=0;i<m_DataBasesCollection.Count;i++)
            {
                bool produkt_param = false;
                bool serial_param = false;
                foreach (QrItem qr in qrCode.ListQrItems)
                {
                    if (qr.Type == m_DataBasesCollection[i].TypeOfDataSerial)
                        serial_param = true;

                    if (qr.Type == m_DataBasesCollection[i].TypeDbProdukt.Type && qr.Value == m_DataBasesCollection[i].TypeDbProdukt.Key)
                        produkt_param = true;
                }
                if (produkt_param && serial_param)
                    indexes.Add(i);
            }
            return indexes.ToArray();

        }
        //можно ли добавить данный qr-код в базы с этими индексами
        private bool is_can_to_Add(int[] db_indexes,QrCodeData qrCode)
        {
            if (db_indexes.Length > 0)
            {
                int sucsess_counter = 0;

                for (int i = 0; i < db_indexes.Length; i++)
                {
                    foreach (QrItem qr in qrCode.ListQrItems)
                     {
                        if(qr.Type==m_DataBasesCollection[db_indexes[i]].TypeOfDataSerial)
                        {
                            if (!m_DataBasesCollection[db_indexes[i]].IsItemContain(qr))
                                sucsess_counter++;
                        }
                    }
                }
                if (sucsess_counter == db_indexes.Length)
                    return true;
                else
                    return false;
            }
            return false;
        }
        public bool AddQrCodeToDataBases(QrCodeData qrCode)
        {
            int[] db_indexes = DbIndexesForQrDataSave(qrCode);
            if(is_can_to_Add(db_indexes,qrCode))
            {
                for (int i = 0; i < db_indexes.Length; i++)
                {
                    foreach (QrItem qr in qrCode.ListQrItems)
                    {
                        if (qr.Type == m_DataBasesCollection[db_indexes[i]].TypeOfDataSerial)
                        {
                            m_DataBasesCollection[db_indexes[i]].AddItemInBase(qr, qrCode);
                        }
                    }
                }
                return true;
            }
            return false;
        }
        public bool AddQrCodeSerialToDataBases(QrCodeData[] qrCodes)
        {

            if (qrCodes != null)
            {
                //проверяем можно ли добавить все qr-коды
                for (int i = 0; i < qrCodes.Length; i++)
                {
                    int[] db_indexes = DbIndexesForQrDataSave(qrCodes[i]);
                    if (!is_can_to_Add(db_indexes, qrCodes[i]))
                        return false;
                }
                //добавляем qr-коды
                for (int i = 0; i < qrCodes.Length; i++)
                {
                    int[] db_indexes = DbIndexesForQrDataSave(qrCodes[i]);
                    for (int j = 0; j < db_indexes.Length; j++)
                    {
                        foreach (QrItem qr in qrCodes[i].ListQrItems)
                        {
                            if (qr.Type == m_DataBasesCollection[db_indexes[j]].TypeOfDataSerial)
                            {
                                m_DataBasesCollection[db_indexes[j]].AddItemInBase(qr, qrCodes[i]);
                            }
                        }
                    }
                }
                return true;
            }
            return false;
           
        }

    }





    [Serializable]
    public class DataBase
    {
        private string m_TypeOfDataSerial;
        private string m_TypeSerialDescr;
        private string m_TypeDbProduktDescr;
        private List<DataBaseItem> m_DataBaseItems;


        private ArrayItem m_TypeDbProdukt;
        private DateTime m_CreationDate;
       
        //из справочника
        public string TypeOfDataSerial
        {
            get
            {
                return m_TypeOfDataSerial;
            }

            set
            {
                m_TypeOfDataSerial = value;
            }
        }

        public List<DataBaseItem> DataBaseItems
        {
            get
            {
                return m_DataBaseItems;
            }
           

        }

        

        public string TypeSerialDescr
        {
            get
            {
                return m_TypeSerialDescr;
            }

            set
            {
                m_TypeSerialDescr = value;
            }
        }

        

      

        /// <summary>
        /// поле для определения к какому изделию принадлежит база
        /// </summary>
        public ArrayItem TypeDbProdukt
        {
            get
            {
                return m_TypeDbProdukt;
            }

            set
            {
                m_TypeDbProdukt = value;
            }
        }

        public string TypeDbProduktDescr
        {
            get
            {
                return m_TypeDbProduktDescr;
            }

            set
            {
                m_TypeDbProduktDescr = value;
            }
        }

        /// <summary>
        /// Конструкор
        /// </summary>
        /// <param name="typeofdata">Тип данных(напр N-серийный номер)</param>
        /// <param name="typedescr">Описание типа</param>
        /// <param name="strname">Имя базы данных</param>
        ///  <param name="typedbdescr">Описание типа наименования изделия</param>
        /// <param name="ar">Тип данных наименование изделия(например [Z] - 001 - Плата трубки </param>
        public DataBase(string typeofdata,string typedescr,string typedbdescr,ArrayItem ar)
        {
            m_TypeOfDataSerial = typeofdata;
           
            m_DataBaseItems = new List<DataBaseItem>();
            m_TypeDbProduktDescr = typedbdescr;
            m_TypeDbProdukt = ar;
            m_TypeSerialDescr = typedescr;

            m_CreationDate = DateTime.Now;
        }
        public override string ToString()
        {
            return m_TypeDbProduktDescr+": "+m_TypeDbProdukt.Value + " (Тип: "+ m_TypeSerialDescr + "[" + m_TypeOfDataSerial + "]" + " Дата создания:" + m_CreationDate.ToString("dd.MM.yyyy") + ")";
        }
        
        /// <summary>
        /// добавляет qr итем в базу
        /// </summary>
        /// <param name="qr"></param>
        /// <param name="qrData"></param>
        /// <returns></returns>
        public bool AddItemInBase(QrItem qr,QrCodeData qrData)
        {
            if (qr.Type != m_TypeOfDataSerial)
                return false;
            else
            {
                foreach(DataBaseItem dbi in m_DataBaseItems)
                {
                    if (dbi.QrItem.Value == qr.Value)
                        return false;
                }
                m_DataBaseItems.Add(new DataBaseItem(qr,qrData.GenerateQrCode(false)));
                return true;
            }
        }
        public bool IsItemContain(QrItem qr)
        {
            foreach (DataBaseItem dbi in m_DataBaseItems)
            {
                if (dbi.QrItem.Value == qr.Value)
                    return true;
            }
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
        public override string ToString()
        {
            return m_QrItem.Value;
        }
    }
    /// <summary>
    /// класс содержащий в себе список qr итем для попытки добавления в базу
    /// </summary>
    [Serializable]
    public class AddDataBaseItem
    {
        private List<QrItem> m_QrItems;
        private string m_qrCode;
        public AddDataBaseItem(List<QrItem> qr,string qrCode)
        {
            m_QrItems = qr;
            m_qrCode = qrCode;
        }

        public string QrCode
        {
            get
            {
                return QrCode;
            }

            set
            {
                QrCode = value;
            }
        }

        public List<QrItem> QrItems
        {
            get
            {
                return m_QrItems;
            }

            set
            {
                m_QrItems = value;
            }
        }
    }

}
