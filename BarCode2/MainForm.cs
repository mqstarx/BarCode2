using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBase;

namespace BarCode2
{
    public partial class MainForm : Form
    {
        SerialItem si;
        Dictionary m_DbDict;
        DataBase.TcpModule tcp;
        public MainForm()
        {
            InitializeComponent();
             si = new DataBase.SerialItem();
           // for (int i = 0; i < 2; i++)
          //  { si.Stest.Add("qweqweqweqweqweqweqweqwe"); si.Test.Add(i * 78); }
            tcp = new DataBase.TcpModule();
            tcp.Connected += Tcp_Connected;
            tcp.Receive += Tcp_Receive;
            
           
            
        }

        private void Tcp_Receive(object sender, ReceiveEventArgs e)
        {
            if(e.sendInfo.message == "ASKDICTOK")
            {
                m_DbDict = (Dictionary)e.Object;
            }
        }

        private void Tcp_Connected(object sender, string result)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  for (int i = 0; i < 500; i++)
            // { si.Stest.Add("qweqweqweqweqweqweqweqwe"); si.Test.Add(i * 78); }
            // tcp.SendData(si);
            // tcp.DisconnectClient();
            tcp.SendData(null, "ASKDICT");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tcp.ConnectClient("127.0.0.1");
        }
    }
}
