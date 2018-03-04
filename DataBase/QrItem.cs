using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    /// <summary>
    /// класс хранящий значение данных в qr пакете 
    /// </summary>
  [Serializable]
    public class QrItem
    {
         private string m_Value;
        private string m_Type;
        private DateTime m_CreationDate;
        /// <summary>
        /// значение, занесенное пользователем(данные введенные в поле либо Key из справочника
        /// </summary>
        public string Value
        {
            get
            {
                return m_Value;
            }

            set
            {
                m_Value = value;
            }
        }

        public string Type
        {
            get
            {
                return m_Type;
            }

            set
            {
                m_Type = value;
            }
        }

        public DateTime CreationDate
        {
            get
            {
                return m_CreationDate;
            }

           
        }

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="_type">тип записи из справочника</param>
        /// <param name="_data">значение, занесенное пользователем(данные введенные в поле либо Key из справочника</param>
        public QrItem(string _type,string _data)
        {
             m_Type = _type;
             m_Value =_data;
            m_CreationDate = DateTime.Now;
        }
    }

    /// <summary>
    /// Класс для идентификации типа QrItem по справочнику
    /// </summary>
    public class QrItemDictionary
    {
        private QrItem m_QrItem;
        private string m_DictionaryTypeDescription;
        private ArrayItem m_ArrayItem;
        /// <summary>
        /// Объект qr кода
        /// </summary>
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

        /// <summary>
        /// описание типа из справочника
        /// </summary>
        public string DictionaryTypeDescription
        {
            get
            {
                return m_DictionaryTypeDescription;
            }

            set
            {
                m_DictionaryTypeDescription = value;
            }
        }

        /// <summary>
        /// для определения расшифровки  значения 
        /// </summary>
        public ArrayItem ArrayItem
        {
            get
            {
                return m_ArrayItem;
            }

            set
            {
                m_ArrayItem = value;
            }
        }

        public QrItemDictionary(QrItem q,string Descr)
        {
            m_QrItem = q;
            m_DictionaryTypeDescription = Descr;
        }
        public override string ToString()
        {
            if (m_ArrayItem == null)
                return m_DictionaryTypeDescription + ":" + m_QrItem.Value;
            else
                return m_DictionaryTypeDescription + ":" + m_ArrayItem.Value;
        }
       
    }

}
