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
        AppConfig m_AppConfig;
        Dictionary m_DbDict;
        TcpModule m_tcpModule;
        QrProcessor m_QrProcessor;
        QrCodeData m_CurrentIdentificationQrCode;
        QrCodeData m_CurrentPrintQrCode;
        string m_ServerIP = "127.0.0.1";
        
        private List<char> QrPacket;

        public MainForm()
        {
           
            InitializeComponent();
            InitConfiguration();
            QrPacket = new List<char>();
            m_QrProcessor = new QrProcessor();
            m_tcpModule = new DataBase.TcpModule();
            m_tcpModule.Connected += Tcp_Connected;
            m_tcpModule.Receive += Tcp_Receive;
            m_DbDict = new Dictionary();
            m_DbDict.ReadFromIni();

            QrCodeData test = new QrCodeData();
            
            
        }
        /// <summary>
        /// инициализация конфигурации
        /// </summary>
        private void InitConfiguration()
        {
             m_AppConfig = (AppConfig)Functions.LoadConfig();
             if(m_AppConfig == null)
            {
                m_AppConfig = new AppConfig();
                SaveFormParametrs();
            }
            else
            {
                LoadFormParametrs();
                m_ServerIP = m_AppConfig.ServerIp;
            }

        }

        //применение параметров
        private void LoadFormParametrs()
        {
            this.Size = m_AppConfig.MainFormSize;
            if (m_AppConfig.MaximizedBox)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;

        }

        //сохранение параметров
        private void SaveFormParametrs()
        {
            m_AppConfig.MainFormSize = this.Size;
            if (this.WindowState == FormWindowState.Maximized)
                m_AppConfig.MaximizedBox = true;
            else
                m_AppConfig.MaximizedBox = false;
            Functions.SaveConfig(m_AppConfig);
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
      
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveFormParametrs();
        }


        #region работа с вкладкой "идентификация"

        private void CheckQrManualBtm_Click(object sender, EventArgs e)
        {
            qr_dataList.Items.Clear();
            m_CurrentIdentificationQrCode = m_QrProcessor.ParseQrPacket(CheckQrManualTxb.Text.ToCharArray(), m_DbDict);
            if (m_CurrentIdentificationQrCode != null)
            {
                qr_dataList.Items.AddRange(m_QrProcessor.IdentificateQrData(m_CurrentIdentificationQrCode, m_DbDict).ToArray());
                identificationTab.Invalidate();
                Console.Beep(500, 500);
            }
        }

        private void identificationTab_Paint(object sender, PaintEventArgs e)
        {
            if (m_CurrentIdentificationQrCode != null)
            {
                m_QrProcessor.DrawQrCode(m_CurrentIdentificationQrCode.GenerateQrCode(false), e.Graphics, 40, new Point(15, 10), QRCoder.QRCodeGenerator.ECCLevel.L);

            }
        }

        private void mainTabControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ОЖИДАНИЕ СЧИТЫВАНИЯ 
            if(mainTabControl.SelectedTab.Name== "identificationTab")
            {
                QrPacket.Add(e.KeyChar);
                QrCodeData tmpQr = m_QrProcessor.ParseQrPacket(QrPacket.ToArray(), m_DbDict);
                if (tmpQr!=null)
                {
                    m_CurrentIdentificationQrCode = tmpQr;
                    qr_dataList.Items.Clear();
                    qr_dataList.Items.AddRange(m_QrProcessor.IdentificateQrData(m_CurrentIdentificationQrCode, m_DbDict).ToArray());
                    identificationTab.Invalidate();
                    QrPacket.Clear();
                    Console.Beep(500, 500);
                }
            }
        }

        #endregion


        #region Работа с вкладкой "печать этикеток" 
        private void RefreshDictionary_Click(object sender, EventArgs e)
        {
            //запрос из сети
            TreeNode node;
            dictionaryTreeOnPrintTab.Nodes.Clear();
            foreach(DictionaryItem di in m_DbDict.DictionaryDataBase)
            {
                node = new TreeNode(di.DataDescr);
                node.Tag = di;
                if(di.KeyValues!=null)
                {
                    
                    foreach(ArrayItem ar in di.KeyValues)
                    {
                        TreeNode chNode = new TreeNode(ar.Value);
                        chNode.Tag = ar;
                        node.Nodes.Add(chNode);
                    }
                }
                dictionaryTreeOnPrintTab.Nodes.Add(node);
            }
           
        }
        private void saveqrFileBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Файл рисунка (*.jpg)|*.jpg";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                if (m_CurrentPrintQrCode != null)
                {
                    m_QrProcessor.SaveQrCode(m_CurrentPrintQrCode.GenerateQrCode(false),sf.FileName, QRCoder.QRCodeGenerator.ECCLevel.L);
                }
            }
        }
        private void DrawPrintQrcode(Graphics g) 
        {
            if (m_CurrentPrintQrCode != null)
            {
                m_QrProcessor.DrawQrCode(m_CurrentPrintQrCode.GenerateQrCode(false), g, QrSizetrackBar.Value, new Point(15, 15), QRCoder.QRCodeGenerator.ECCLevel.L);
            }
        }
        private void копироватьВБуферToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_CurrentPrintQrCode != null)
            {
                Clipboard.SetText(m_CurrentPrintQrCode.GenerateQrCode(false));
            }
        }
        private void printPanelBox_Paint(object sender, PaintEventArgs e)
        {
            DrawPrintQrcode(e.Graphics);
        }
        private void QrSizetrackBar_Scroll(object sender, EventArgs e)
        {
            QrSizeLbl.Text = QrSizetrackBar.Value.ToString();
            printPanelBox.Invalidate();
        }
        private void dictionaryTreeOnPrintTab_DoubleClick(object sender, EventArgs e)
        {
            if(dictionaryTreeOnPrintTab.SelectedNode!=null)
            {
                Type typeOfSelected = dictionaryTreeOnPrintTab.SelectedNode.Tag.GetType();
                QrItemDictionary qr = null;
                if(typeOfSelected == typeof(DictionaryItem))
                {
                    DictionaryItem di = (DictionaryItem)dictionaryTreeOnPrintTab.SelectedNode.Tag;
                    if (di.KeyValues != null)
                        return;

                   

                    AddEditQrCodeData qrDialog = new AddEditQrCodeData();
                    if (di.Is_date)
                    {
                        qrDialog.dateTimePicker.Enabled = true;
                        qrDialog.ValueTxb.Enabled = false;
                    }
                    qrDialog.groupBoxLabel.Text = di.DataDescr;
                    qrDialog.DictionaryItem = di;
                    if (qrDialog.ShowDialog() == DialogResult.OK)
                    {
                        if (qrDialog.dateTimePicker.Enabled)
                            qr = new QrItemDictionary(new QrItem(di.TypeId, qrDialog.dateTimePicker.Value.ToString("ddMMyy") ), di.DataDescr);
                        else
                            qr = new QrItemDictionary(new QrItem(di.TypeId, qrDialog.ValueTxb.Text), di.DataDescr);
                        currentQrCodeListBox.Items.Add(qr);
                        m_CurrentPrintQrCode = m_QrProcessor.CreateQrCodeFromList(currentQrCodeListBox.Items);
                        printPanelBox.Invalidate();
                    }

                }
                if(typeOfSelected == typeof(ArrayItem))
                {
                    ArrayItem ar = (ArrayItem)dictionaryTreeOnPrintTab.SelectedNode.Tag;
                    qr = new QrItemDictionary(new QrItem(ar.Type, ar.Key), m_DbDict.GetTypeDescription(ar.Type));
                    qr.ArrayItem = ar;
                    currentQrCodeListBox.Items.Add(qr);
                    m_CurrentPrintQrCode = m_QrProcessor.CreateQrCodeFromList(currentQrCodeListBox.Items);
                    printPanelBox.Invalidate();
                }
               // DictionaryItem di = (DictionaryItem)dictionaryTreeOnPrintTab.SelectedNode.Tag;
                
            }
        }



        #endregion


        #region работа с бд
        private void addDabaseBtn_Click(object sender, EventArgs e)
        {
            AddEditDataBase add = new AddEditDataBase();
            add.DictDb = m_DbDict;
            if(add.ShowDialog()== DialogResult.OK)
            {
                if (m_DbCollection == null)
                {
                    m_DbCollection = new DataBasesCollection();
                }
                    m_DbCollection.AddDataBase(new DataBase.DataBase(((DictionaryItem)add.typeDataCmbx.SelectedItem).TypeId, ((DictionaryItem)add.typeDataCmbx.SelectedItem).DataDescr, add.db_nameTxb.Text));
                    RefreshDbBtn_Click(null, null);


            }

            
        }

        private void RefreshDbBtn_Click(object sender, EventArgs e)
        {
            if (m_DbCollection != null)
            {
                DataBasesCollectionTree.Nodes.Clear();
               foreach (DataBase.DataBase d in m_DbCollection.DataBaseCollection)
                {
                    TreeNode node = new TreeNode(d.ToString());
                    node.Tag = d;
                    addNodeToTree(d, node);
                    DataBasesCollectionTree.Nodes.Add(node);
                }
            }
        }

        private void addNodeToTree(DataBase.DataBase d, TreeNode node)
        {
            if (d.DataBaseNode != null)
            {
                foreach (DataBase.DataBase dn in d.DataBaseNode.DataBaseCollection)
                {
                    TreeNode node1 = new TreeNode(dn.ToString());
                    node1.Tag = dn;
                    addNodeToTree(dn, node1);
                    node.Nodes.Add(node1);
                   
                }
            }
        }

        private void добавитьВложеннуюБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataBasesCollectionTree.SelectedNode != null)
            {
               if(m_DbCollection!=null)
                {
                    AddEditDataBase add = new AddEditDataBase();
                    add.DictDb = m_DbDict;
                    if (add.ShowDialog() == DialogResult.OK)
                    {
                        m_DbCollection.AddDataBaseToNode(new DataBase.DataBase(((DictionaryItem)add.typeDataCmbx.SelectedItem).TypeId, ((DictionaryItem)add.typeDataCmbx.SelectedItem).DataDescr, add.db_nameTxb.Text), ((DataBase.DataBase)DataBasesCollectionTree.SelectedNode.Tag).BaseUniqId);
                        RefreshDbBtn_Click(null, null);
                    }
                }
            }
        }




        #endregion

       
    }
}
