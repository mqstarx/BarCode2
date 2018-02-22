using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
  [Serializable]
    public class SerialItem
    {
        private List<int> m_Test;
        private List<string> m_Stest;
        public List<int> Test
        {
            get
            {
                return m_Test;
            }

            set
            {
                m_Test = value;
            }
        }

        public List<string> Stest
        {
            get
            {
                return m_Stest;
            }

            set
            {
                m_Stest = value;
            }
        }

        public SerialItem() {
            m_Test = new List<int>();
            m_Stest = new List<string>();
        }
    }
}
