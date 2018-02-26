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
}
