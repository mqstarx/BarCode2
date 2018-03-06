using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    /// <summary>
    /// Класс реализующий полный справочник
    /// </summary>
    [Serializable]
    public class Dictionary
    {
        private List<DictionaryItem> m_DictionaryDataBase;

        public List<DictionaryItem> DictionaryDataBase
        {
            get
            {
                return m_DictionaryDataBase;
            }
        }

        public Dictionary()
        {
            m_DictionaryDataBase = new List<DictionaryItem>();
        }
       
        public void ReadFromIni()
        {
            try
            {
                IniFile ini = new IniFile(Directory.GetCurrentDirectory() + @"\conf.ini");
                string datatypes = ini.ReadINI("main", "datatypes");
                string[] datatypesarray = datatypes.Split(';');
                for (int i = 0; i < datatypesarray.Length; i++)
                {
                    bool is_date = false;
                    if (ini.KeyExists("is_date", datatypesarray[i]) && ini.ReadINI(datatypesarray[i], "is_date") == "true")
                        is_date = true;
                    bool is_serialDb = false;
                    if (ini.KeyExists("is_db_serial", datatypesarray[i]) && ini.ReadINI(datatypesarray[i], "is_db_serial") == "true")
                        is_serialDb = true;
                    int sort_index = 0;
                    if ((ini.KeyExists("sort_index", datatypesarray[i])))
                       sort_index = int.Parse( ini.ReadINI(datatypesarray[i], "sort_index"));
                    DictionaryItem di = new DictionaryItem(datatypesarray[i], int.Parse(ini.ReadINI(datatypesarray[i], "len")), ini.ReadINI(datatypesarray[i], "name"),is_date,is_serialDb,null,sort_index);
                    if (ini.KeyExists("array", datatypesarray[i]))
                    {
                        di.KeyValues = new List<ArrayItem>();
                        string[] arrayvalues = ini.ReadINI(datatypesarray[i], "array").Split(';');
                        for (int j = 0; j < arrayvalues.Length; j++)
                        {
                            di.KeyValues.Add(new ArrayItem(arrayvalues[j].Split(':')[0], arrayvalues[j].Split(':')[1],di.TypeId));
                        }
                    }
                    m_DictionaryDataBase.Add(di);
                    
                }
                Sort();
            }
            catch (Exception e )
            {
                Console.WriteLine(e.Message);
            }
        }
       
        public void Sort()
        {
            m_DictionaryDataBase.Sort(SortingDiItems);
        }

        private int SortingDiItems(DictionaryItem x, DictionaryItem y)
        {
            
            if (x.SortIndex > y.SortIndex)
                return 1;
            else if (x.SortIndex < y.SortIndex)
                return -1;
            else
                return 0;
        }

        public string GetTypeDescription(string type)
        {
            foreach(DictionaryItem di in m_DictionaryDataBase)
            {
                if(di.TypeId == type)
                {
                    return di.DataDescr;
                }
            }
            return "Тип данных отсутствует в справочнике";
        }

        public ArrayItem GetValueArrayItemFromDictionary(string type,string key)
        {
            ArrayItem ar = null;
            foreach(DictionaryItem di in m_DictionaryDataBase)
            {
                if(di.TypeId == type)
                {
                    if(di.KeyValues!=null)
                    {
                        foreach(ArrayItem a in di.KeyValues)
                        {
                            if (a.Key == key)
                            {
                                ar = a;
                                break;
                            }
                           
                        }
                    }
                }
            }
            return ar;
        }
    }

    /// <summary>
    /// Класс определяющий одну запись справочника
    /// </summary>
    [Serializable]
    public class DictionaryItem
    {
        string m_typeId;
        int m_typeLen;
        int m_dataLen;
        string m_dataDescr;
        bool m_is_date;
        int m_sortIndex;
        bool m_IsSerialDb;
        List<ArrayItem> m_keyValues;

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="typeid"></param>
        /// <param name="datalen"></param>
        /// <param name="datadescr"></param>
        /// <param name="isdate"></param>
        /// <param name="array_item"></param>
        public DictionaryItem(string typeid,int datalen, string datadescr,bool isdate,bool is_serialdb,ArrayItem[] array_item,int sort_index)
        {
            m_typeId = typeid;
            m_dataLen = datalen;
            m_dataDescr = datadescr;
            if(isdate )
            {
                if (m_dataLen != 6) // если длинна данных указана другая, то игнорируем флаг
                    isdate = false; 
            }
            m_is_date = isdate;
            m_IsSerialDb = is_serialdb;

            if (array_item == null)
                m_keyValues = null;
            else
            {
                m_keyValues = new List<ArrayItem>();
                m_keyValues.AddRange(array_item);
            }
            m_typeLen = m_typeId.Length;
            m_sortIndex = sort_index;
        }

        /// <summary>
        ///тип записи справочника
        /// </summary>
        public string TypeId
        {
            get
            {
                return m_typeId;
            }

        }

        /// <summary>
        /// длинна данных в справочнике
        /// </summary>
        public int DataLen
        {
            get
            {
                return m_dataLen;
            }

        }

        /// <summary>
        /// описание типа данных
        /// </summary>
        public string DataDescr
        {
            get
            {
                return m_dataDescr;
            }

            set
            {
                m_dataDescr = value;
            }
        }

        /// <summary>
        /// массив значений для типа данных(если null значит вводимое значение)
        /// </summary>
        public List<ArrayItem> KeyValues
        {
            get
            {
                return m_keyValues;
            }

            set
            {
                m_keyValues = value;
            }
        }

        /// <summary>
        /// длинна типа таднных (например [D] - длина 1 , [DF] - длина 2)
        /// </summary>
        public int TypeLen
        {
            get
            {
                return m_typeLen;
            }

        }

        /// <summary>
        /// является ли запись датой (для создание подходящих контролов)
        /// </summary>
        public bool Is_date
        {
            get
            {
                return m_is_date;
            }

        }

        public int SortIndex
        {
            get
            {
                return m_sortIndex;
            }

            set
            {
                m_sortIndex = value;
            }
        }

        public bool IsSerialDb
        {
            get
            {
                return m_IsSerialDb;
            }

           
        }

        public override string ToString()
        {
            return m_dataDescr + " (" + m_typeId + ")";
        }
    }
    /// <summary>
    /// 
    /// 
    /// класс определяющий ключ значение
    /// </summary>
    [Serializable]
    public class ArrayItem
    {
        private string m_Key;
        private string m_Value;
        private string m_Type;

        public ArrayItem(string key, string val,string type)
        {
            m_Key = key;
            m_Value = val;
            m_Type = type;
        }


        public string Key
        {
            get
            {
                return m_Key;
            }

            set
            {
                m_Key = value;
            }
        }

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

        public override string ToString()
        {
            return m_Key + ":" + m_Value;
        }
    }

}
