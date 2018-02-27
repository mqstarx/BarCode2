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
        DataBasesCollection m_DbCollection;
        Dictionary m_DbDict;
        TcpModule m_tcpModule;
        QrProcessor m_QrProcessor;
        private List<char> QrPacket;

        public MainForm()
        {
            InitializeComponent();

            QrPacket = new List<char>();
            m_QrProcessor = new QrProcessor();
            m_tcpModule = new DataBase.TcpModule();
            m_tcpModule.Connected += Tcp_Connected;
            m_tcpModule.Receive += Tcp_Receive;
            m_DbDict = new Dictionary();
            m_DbDict.ReadFromIni();

            QrCodeData test = new QrCodeData();
            
            
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
           
            m_tcpModule.SendData(null, "ASKDICT");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            m_tcpModule.ConnectClient("127.0.0.1");
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            QrPacket.Add(e.KeyChar);
            QrCodeData test = m_QrProcessor.ParseQrPacket(QrPacket.ToArray(),m_DbDict);
            if(test!=null)
            {
                m_QrProcessor.DrawQrCode(test.GenerateQrCode(false), this.CreateGraphics(), 70, new Point(100, 100), QRCoder.QRCodeGenerator.ECCLevel.L);
                QrPacket.Clear();
            }
        }
    }
}
