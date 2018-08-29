using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    class IniFile
    {
        string Path; //Имя файла.

        [DllImport("kernel32")] // Подключаем kernel32.dll и описываем его функцию WritePrivateProfilesString
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32")] // Еще раз подключаем kernel32.dll, а теперь описываем функцию GetPrivateProfileString
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        // С помощью конструктора записываем пусть до файла и его имя.
        public IniFile(string IniPath)
        {
            Path = new FileInfo(IniPath).FullName.ToString();
        }

        //Читаем ini-файл и возвращаем значение указного ключа из заданной секции.
        public string ReadINI(string Section, string Key)
        {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(Section, Key, "", RetVal, 255, Path);
            return RetVal.ToString();
        }
        //Записываем в ini-файл. Запись происходит в выбранную секцию в выбранный ключ.
        public void Write(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, Path);
        }

        //Удаляем ключ из выбранной секции.
        public void DeleteKey(string Key, string Section = null)
        {
            Write(Section, Key, null);
        }
        //Удаляем выбранную секцию
        public void DeleteSection(string Section = null)
        {
            Write(Section, null, null);
        }
        //Проверяем, есть ли такой ключ, в этой секции
        public bool KeyExists(string Key, string Section = null)
        {
            return ReadINI(Section, Key).Length > 0;
        }
    }
    public static class Functions
    {
        public static string ConvertEngl(string s)
        {
            s = s.Replace("А", "F");
            s = s.Replace("Б", "<");
            s = s.Replace("В", "D");
            s = s.Replace("Г", "U");
            s = s.Replace("Д", "L");
            s = s.Replace("Е", "T");
            s = s.Replace("Ё", "~");
            s = s.Replace("Ж", ";");
            s = s.Replace("З", "P");
            s = s.Replace("И", "B");
            s = s.Replace("Й", "Q");
            s = s.Replace("К", "R");
            s = s.Replace("Л", "K");
            s = s.Replace("М", "V");
            s = s.Replace("Н", "Y");
            s = s.Replace("О", "J");
            s = s.Replace("П", "G");
            s = s.Replace("Р", "H");
            s = s.Replace("С", "C");
            s = s.Replace("Т", "N");
            s = s.Replace("У", "E");
            s = s.Replace("Ф", "A");
            s = s.Replace("Х", "[");
            s = s.Replace("С", "C");
            s = s.Replace("Ч", "X");
            s = s.Replace("Ш", "I");
            s = s.Replace("Щ", "O");
            s = s.Replace("Ъ", "]");
            s = s.Replace("Ы", "S");
            s = s.Replace("Ь", "M");
            s = s.Replace("Я", "Z");
            s = s.Replace("а", "f");
            s = s.Replace("в", "d");
            s = s.Replace("г", "u");
            s = s.Replace("д", "l");
            s = s.Replace("е", "t");
            s = s.Replace("ё", "`");
            s = s.Replace("ж", ";");
            s = s.Replace("з", "p");
            s = s.Replace("и", "b");
            s = s.Replace("й", "q");
            s = s.Replace("к", "r");
            s = s.Replace("л", "k");
            s = s.Replace("м", "v");
            s = s.Replace("н", "y");
            s = s.Replace("о", "j");
            s = s.Replace("п", "g");
            s = s.Replace("р", "h");
            s = s.Replace("с", "c");
            s = s.Replace("т", "n");
            s = s.Replace("у", "e");
            s = s.Replace("ф", "a");
            s = s.Replace("ц", "w");
            s = s.Replace("ч", "x");
            s = s.Replace("ш", "i");
            s = s.Replace("щ", "o");
            s = s.Replace("ы", "s");
            s = s.Replace("ь", "m");
            s = s.Replace("я", "z");
             return s;
        }
        public static bool SaveConfig(object obj)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(Directory.GetCurrentDirectory() + @"\appconfig.qrcfg", FileMode.Create, FileAccess.Write, FileShare.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, obj);
                fs.Close();
                return true;
            }
            catch (Exception e)
            {
                if (fs != null)
                    fs.Close();
                return false;
            }
            finally
            {
                if (fs != null)
                    fs.Close();
            }


        }
        public static bool SaveConfig(object obj,string filename)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(Directory.GetCurrentDirectory() + @"\"+filename, FileMode.Create, FileAccess.Write, FileShare.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, obj);
                fs.Close();
                return true;
            }
            catch (Exception e)
            {
                if (fs != null)
                    fs.Close();
                return false;
            }
            finally
            {
                if (fs != null)
                    fs.Close();
            }


        }
        public static bool SaveConfigPath(object obj, string path)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, obj);
                fs.Close();
                return true;
            }
            catch (Exception e)
            {
                if (fs != null)
                    fs.Close();
                return false;
            }
            finally
            {
                if (fs != null)
                    fs.Close();
            }


        }
        public static object LoadConfig()
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(Directory.GetCurrentDirectory() + @"\appconfig.qrcfg", FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
                BinaryFormatter bf = new BinaryFormatter();
                object res = bf.Deserialize(fs);
                fs.Close();
                return res;
            }
            catch (Exception e)
            {
                if (fs != null)
                    fs.Close();
                return null;
            }
            finally
            {
                if (fs != null)
                    fs.Close();
            }


        }
        public static object LoadConfig(string filename)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(Directory.GetCurrentDirectory() + @"\"+ filename, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
                BinaryFormatter bf = new BinaryFormatter();
                object res = bf.Deserialize(fs);
                fs.Close();
                return res;
            }
            catch (Exception e)
            {
                if (fs != null)
                    fs.Close();
                return null;
            }
            finally
            {
                if (fs != null)
                    fs.Close();
            }


        }

        public static object LoadConfigPath(string path)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
                BinaryFormatter bf = new BinaryFormatter();
                object res = bf.Deserialize(fs);
                fs.Close();
                return res;
            }
            catch (Exception e)
            {
                if (fs != null)
                    fs.Close();
                return null;
            }
            finally
            {
                if (fs != null)
                    fs.Close();
            }


        }


    }

   


}
