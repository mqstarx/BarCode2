using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarCode2
{
    public partial class Form1 : Form
    {
        DataBase.SerialItem si;
        DataBase.TcpModule tcp;
        public Form1()
        {
            InitializeComponent();
             si = new DataBase.SerialItem();
           // for (int i = 0; i < 2; i++)
          //  { si.Stest.Add("qweqweqweqweqweqweqweqwe"); si.Test.Add(i * 78); }
            tcp = new DataBase.TcpModule();
            tcp.Connected += Tcp_Connected;
            
           
            
        }

        private void Tcp_Connected(object sender, string result)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5000000; i++)
            { si.Stest.Add("qweqweqweqweqweqweqweqwe"); si.Test.Add(i * 78); }
            tcp.SendData(si);
            tcp.DisconnectClient();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tcp.ConnectClient("192.168.100.13");
        }
    }
}
