using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarCode2
{
    [Serializable]
    public class AppConfig
    {
        private Size m_MainFormSize;
        private bool m_MaximizedBox;
        private string m_ServerIp;
        public AppConfig()
        { }

        public Size MainFormSize
        {
            get
            {
                return m_MainFormSize;
            }

            set
            {
                m_MainFormSize = value;
            }
        }

        public bool MaximizedBox
        {
            get
            {
                return m_MaximizedBox;
            }

            set
            {
                m_MaximizedBox = value;
            }
        }

        public string ServerIp
        {
            get
            {
                if (m_ServerIp == null)
                    return "127.0.0.1";
                else
                    return m_ServerIp;
            }

            set
            {
                m_ServerIp = value;
            }
        }
    }
}
