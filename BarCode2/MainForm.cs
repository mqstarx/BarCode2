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
using System.Drawing.Printing;

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
        QrCodeData[] m_SerialQrDataArray;
        private List<char> QrPacket;
        PrintSession m_PrintSession;
        private int cur_page_packet_counter;

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
            InitConfiguration();

        }

        #region Работа с конфигурацией приложения
        /// <summary>
        /// инициализация конфигурации
        /// </summary>
        private void InitConfiguration()
        {
             m_AppConfig = (AppConfig)Functions.LoadConfig();
            m_PrintSession = (PrintSession)Functions.LoadConfig("printsession.qrc");
            if (m_PrintSession != null)
                LoadPrintSession();
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

        //загрузка параметров сессии
        private void LoadPrintSession()
        {
            m_CurrentPrintQrCode = m_PrintSession.CurrentQrCode;
            QrPrintColumsTrack.Value = m_PrintSession.CollumnsCount;
            QrSizetrackBar.Value = m_PrintSession.QrCodeSize;
            SizeBeetweenQrTrack.Value = m_PrintSession.SizeBeetweenCollumns;
            SerialCopyNumericUpDown.Value = m_PrintSession.SerialCopy;
            LeftOffsetNumeric.Value = m_PrintSession.DX;
            UpOffsetNumeric.Value = m_PrintSession.DY;
            if (m_PrintSession.CheckedBox == 0)
                OncePrintingRadioBtn.Checked = true;
            if (m_PrintSession.CheckedBox == 1)
                SerialPrintingRadioBtn.Checked = true;

            if (m_PrintSession.CheckedBox == 2)
                SerialPrintingSerialRadioBtn.Checked = true;

            if (m_PrintSession.CheckedBox == 3)
                CopyOfPagesRadioBtn.Checked = true;

            m_QrProcessor.ListFillFromQrObject(currentQrCodeListBox, AddInPacketTreeView, m_CurrentPrintQrCode, m_DbDict);
            printPanelBox.Invalidate();

        }

        //сохранение параметров формы
        private void SaveFormParametrs()
        {
            m_AppConfig.MainFormSize = this.Size;
            if (this.WindowState == FormWindowState.Maximized)
                m_AppConfig.MaximizedBox = true;
            else
                m_AppConfig.MaximizedBox = false;
            Functions.SaveConfig(m_AppConfig);
        }

        //сохранение параметров сессии
        private void SavePrintSession()
        {
            m_PrintSession = new PrintSession();

            m_PrintSession.CurrentQrCode = m_CurrentPrintQrCode;
            m_PrintSession.CollumnsCount = QrPrintColumsTrack.Value;
            m_PrintSession.QrCodeSize = QrSizetrackBar.Value;
            m_PrintSession.SizeBeetweenCollumns = SizeBeetweenQrTrack.Value;
            m_PrintSession.SerialCopy = (int)SerialCopyNumericUpDown.Value;
            m_PrintSession.DX = (int)LeftOffsetNumeric.Value;
            m_PrintSession.DY = (int)UpOffsetNumeric.Value;
            if (OncePrintingRadioBtn.Checked)
                m_PrintSession.CheckedBox = 0;
            if (SerialPrintingRadioBtn.Checked)
                m_PrintSession.CheckedBox = 1;
            if (SerialPrintingSerialRadioBtn.Checked)
                m_PrintSession.CheckedBox = 2;
            if (CopyOfPagesRadioBtn.Checked)
                m_PrintSession.CheckedBox = 3;

            Functions.SaveConfig(m_PrintSession,"printsession.qrc");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveFormParametrs();
            SavePrintSession();
        }
        #endregion

        #region Работа с сетью
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
        #endregion
        
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
            if (mainTabControl.SelectedTab.Name == "identificationTab")
            {
                QrPacket.Add(e.KeyChar);
                QrCodeData tmpQr = m_QrProcessor.ParseQrPacket(QrPacket.ToArray(), m_DbDict);
                if (tmpQr != null)
                {
                    m_CurrentIdentificationQrCode = tmpQr;
                    qr_dataList.Items.Clear();
                    qr_dataList.Items.AddRange(m_QrProcessor.IdentificateQrData(m_CurrentIdentificationQrCode, m_DbDict).ToArray());
                    identificationTab.Invalidate();
                    QrPacket.Clear();
                    Console.Beep(500, 500);
                }
            }
            //PrintPageTab
            if (mainTabControl.SelectedTab.Name == "PrintPageTab")
            {
                QrPacket.Add(e.KeyChar);
                QrCodeData tmpQr = m_QrProcessor.ParseQrPacket(QrPacket.ToArray(), m_DbDict);
                if (tmpQr != null)
                {
                   
                    TreeNode node = new TreeNode(tmpQr.ToString());
                    List<string> qrItemDataStrs = m_QrProcessor.IdentificateQrData(tmpQr, m_DbDict);
                    foreach(string qr in qrItemDataStrs)
                    {
                        node.Nodes.Add(qr);
                    }
                    node.Tag = tmpQr;
                    AddInPacketTreeView.Nodes.Add(node);

                   
                    QrPacket.Clear();
                    m_CurrentPrintQrCode = m_QrProcessor.CreateQrCodeFromList(currentQrCodeListBox.Items, AddInPacketTreeView.Nodes);
                    printPanelBox.Invalidate();
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
       
        private void DrawPrintQrcode(Graphics g,int x,int y) 
        {
            if (m_CurrentPrintQrCode != null)
            {
                float h = ((QrSizetrackBar.Value) * (float)3.779527559055);
                float z = ((SizeBeetweenQrTrack.Value) * (float)3.779527559055);
                float dy = y * (float)3.779527559055;
                float dx = x * (float)3.779527559055;
                for (int i = 0; i < QrPrintColumsTrack.Value; i++)
                {
                    m_QrProcessor.DrawQrCode(m_CurrentPrintQrCode.GenerateQrCode(false), g, QrSizetrackBar.Value, new PointF(dx+(i*(h+z)), dy), QRCoder.QRCodeGenerator.ECCLevel.L);
                }
            }
        }
        /// <summary>
        /// Функция печати серии номеров
        /// </summary>
        /// <param name="g"></param>
        /// <param name="x">начальная точка х</param>
        /// <param name="y">начальная точка у</param>
        /// <param name="printingQr">печатаемый в данный момент код</param>
       
        private void DrawPrintQrcodeSerial(Graphics g, int x, int y,QrCodeData printingQr)
        {
            if (printingQr != null)
            {
                float h = ((QrSizetrackBar.Value) * (float)3.779527559055);
                float z = ((SizeBeetweenQrTrack.Value) * (float)3.779527559055);
                float dy = y * (float)3.779527559055;
                float dx = x * (float)3.779527559055;
                for (int i = 0; i < QrPrintColumsTrack.Value; i++)
                {
                    m_QrProcessor.DrawQrCode(printingQr.GenerateQrCode(false), g, QrSizetrackBar.Value, new PointF(dx + (i * (h + z)), dy), QRCoder.QRCodeGenerator.ECCLevel.L);
                }
            }
        }
        //в случае если многоколонок печатать номера последовательно
        private void DrawPrintQrcodeSerial(Graphics g, int x, int y, QrCodeData[] printingQr)
        {
            if (printingQr != null && QrPrintColumsTrack.Value==printingQr.Length)
            {
                float h = ((QrSizetrackBar.Value) * (float)3.779527559055);
                float z = ((SizeBeetweenQrTrack.Value) * (float)3.779527559055);
                float dy = y * (float)3.779527559055;
                float dx = x * (float)3.779527559055;
                for (int i = 0; i < QrPrintColumsTrack.Value; i++)
                {
                    if(printingQr[i]!=null)
                    m_QrProcessor.DrawQrCode(printingQr[i].GenerateQrCode(false), g, QrSizetrackBar.Value, new PointF(dx + (i * (h + z)), dy), QRCoder.QRCodeGenerator.ECCLevel.L);
                }
            }
        }
        private void DrawPrintPaper(Graphics g)
        {
            float h = ((QrSizetrackBar.Value) * (float)3.779527559055);
            float w = (((QrPrintColumsTrack.Value* QrSizetrackBar.Value) + ((QrPrintColumsTrack.Value-1)*SizeBeetweenQrTrack.Value)) * (float)3.779527559055);
            PaperWidthLbl.Text = (((QrPrintColumsTrack.Value * QrSizetrackBar.Value) + ((QrPrintColumsTrack.Value - 1) * SizeBeetweenQrTrack.Value))).ToString();
            g.DrawRectangle(new Pen(new SolidBrush(Color.DarkSlateBlue)), 13, 13,w+4, h+4);
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
            DrawPrintPaper(e.Graphics);
            DrawPrintQrcode(e.Graphics,4,4);
        }
        private void сохранитьРисунокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Файл рисунка (*.jpg)|*.jpg";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                if (m_CurrentPrintQrCode != null)
                {
                    m_QrProcessor.SaveQrCode(m_CurrentPrintQrCode.GenerateQrCode(false), sf.FileName, QRCoder.QRCodeGenerator.ECCLevel.L);
                }
            }
        }
        private void QrSizetrackBar_Scroll(object sender, EventArgs e)
        {
            QrSizeLbl.Text = QrSizetrackBar.Value.ToString();
            printPanelBox.Invalidate();
        }
    
        private void QrPrintColumsTrack_Scroll(object sender, EventArgs e)
        {
            ColumnsCountLbl.Text = QrPrintColumsTrack.Value.ToString();
            printPanelBox.Invalidate();

        }
        private void SizeBeetweenQrTrack_Scroll(object sender, EventArgs e)
        {
            SizeBeetweenColumnsLbl.Text = SizeBeetweenQrTrack.Value.ToString();
            printPanelBox.Invalidate();
        }
        private void снятьВыделениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentQrCodeListBox.SelectedIndex = -1;
        }
        private void OncePrintingRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (OncePrintingRadioBtn.Checked)
                SerialCopyNumericUpDown.Enabled = false;
            else
                SerialCopyNumericUpDown.Enabled = true;
        }
        private void поднятьВверхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentQrCodeListBox.SelectedIndex != -1 && currentQrCodeListBox.SelectedIndex > 0)
            {
                QrItemDictionary qr_tmp = ((QrItemDictionary)currentQrCodeListBox.SelectedItem);
                QrItemDictionary qr_tmp0 = ((QrItemDictionary)currentQrCodeListBox.Items[currentQrCodeListBox.SelectedIndex - 1]);

                currentQrCodeListBox.Items[currentQrCodeListBox.SelectedIndex] = qr_tmp0;
                currentQrCodeListBox.Items[currentQrCodeListBox.SelectedIndex - 1] = qr_tmp;
                m_CurrentPrintQrCode = m_QrProcessor.CreateQrCodeFromList(currentQrCodeListBox.Items,AddInPacketTreeView.Nodes);
                printPanelBox.Invalidate();

            }
        }
        private void опуститьВнизToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentQrCodeListBox.SelectedIndex != -1 && currentQrCodeListBox.SelectedIndex < currentQrCodeListBox.Items.Count - 1)
            {
                QrItemDictionary qr_tmp = ((QrItemDictionary)currentQrCodeListBox.SelectedItem);
                QrItemDictionary qr_tmp0 = ((QrItemDictionary)currentQrCodeListBox.Items[currentQrCodeListBox.SelectedIndex + 1]);

                currentQrCodeListBox.Items[currentQrCodeListBox.SelectedIndex] = qr_tmp0;
                currentQrCodeListBox.Items[currentQrCodeListBox.SelectedIndex + 1] = qr_tmp;
                m_CurrentPrintQrCode = m_QrProcessor.CreateQrCodeFromList(currentQrCodeListBox.Items, AddInPacketTreeView.Nodes);
                printPanelBox.Invalidate();

            }
           
        }
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(currentQrCodeListBox.SelectedIndex != -1)
            {
                currentQrCodeListBox.Items.RemoveAt(currentQrCodeListBox.SelectedIndex);
                m_CurrentPrintQrCode = m_QrProcessor.CreateQrCodeFromList(currentQrCodeListBox.Items, AddInPacketTreeView.Nodes);
                printPanelBox.Invalidate();
            }
        }
        private void удалитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentQrCodeListBox.Items.Clear();
            m_CurrentPrintQrCode = m_QrProcessor.CreateQrCodeFromList(currentQrCodeListBox.Items, AddInPacketTreeView.Nodes);
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
                        if (currentQrCodeListBox.SelectedItem != null)
                            currentQrCodeListBox.Items[currentQrCodeListBox.SelectedIndex] = qr;
                        else
                            currentQrCodeListBox.Items.Add(qr);
                        m_CurrentPrintQrCode = m_QrProcessor.CreateQrCodeFromList(currentQrCodeListBox.Items, AddInPacketTreeView.Nodes);
                        printPanelBox.Invalidate();
                    }

                }
                if(typeOfSelected == typeof(ArrayItem))
                {
                    ArrayItem ar = (ArrayItem)dictionaryTreeOnPrintTab.SelectedNode.Tag;
                    qr = new QrItemDictionary(new QrItem(ar.Type, ar.Key), m_DbDict.GetTypeDescription(ar.Type));
                    qr.ArrayItem = ar;
                    if (currentQrCodeListBox.SelectedItem != null)                    
                        currentQrCodeListBox.Items[currentQrCodeListBox.SelectedIndex] = qr;                    
                    else                    
                        currentQrCodeListBox.Items.Add(qr);                    
                    m_CurrentPrintQrCode = m_QrProcessor.CreateQrCodeFromList(currentQrCodeListBox.Items, AddInPacketTreeView.Nodes);
                    printPanelBox.Invalidate();
                }
               // DictionaryItem di = (DictionaryItem)dictionaryTreeOnPrintTab.SelectedNode.Tag;
                
            }
        }
        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (AddInPacketTreeView.SelectedNode != null)
            {
                if(AddInPacketTreeView.SelectedNode.Tag!=null)
                {
                    AddInPacketTreeView.Nodes.RemoveAt(AddInPacketTreeView.SelectedNode.Index);
                    m_CurrentPrintQrCode = m_QrProcessor.CreateQrCodeFromList(currentQrCodeListBox.Items, AddInPacketTreeView.Nodes);
                    printPanelBox.Invalidate();
                }
            }
        }


        private void PrintBtn_Click(object sender, EventArgs e)
        {
            if(OncePrintingRadioBtn.Checked)
            {
                PrintDocument printDocument = new PrintDocument();
                float h = ((float)(QrSizetrackBar.Value+UpOffsetNumeric.Value) * (float)3.779527559055);
                float w = (((QrPrintColumsTrack.Value * QrSizetrackBar.Value) + ((QrPrintColumsTrack.Value - 1) * SizeBeetweenQrTrack.Value)) * (float)3.779527559055);
               // printDocument.DefaultPageSettings.PaperSize = new PaperSize("Other", (int)w+4, (int)h+4);
               
                printDocument.PrintPage += PrintDocument_PrintPage;
                cur_page_packet_counter = 0;
                printDocument.Print();
            }
            if(CopyOfPagesRadioBtn.Checked)
            {
                PrintDocument printDocument = new PrintDocument();
                float h = ((QrSizetrackBar.Value) * (float)3.779527559055);
                float w = (((QrPrintColumsTrack.Value * QrSizetrackBar.Value) + ((QrPrintColumsTrack.Value - 1) * SizeBeetweenQrTrack.Value)) * (float)3.779527559055);
              //  printDocument.DefaultPageSettings.PaperSize = new PaperSize("Other", (int)w + 4, (int)h + 4);
                printDocument.PrintPage += PrintDocument_PrintPageCopy;
                cur_page_packet_counter = 0;
                printDocument.Print();
            }
            if(SerialPrintingRadioBtn.Checked)
            {
                m_SerialQrDataArray = m_QrProcessor.GenerateQrDataArrayForSerialPrint(m_CurrentPrintQrCode, m_DbDict, (int)SerialCopyNumericUpDown.Value);
                if (m_SerialQrDataArray != null)
                {
                    PrintDocument printDocument = new PrintDocument();
                    float h = ((QrSizetrackBar.Value) * (float)3.779527559055);
                    float w = (((QrPrintColumsTrack.Value * QrSizetrackBar.Value) + ((QrPrintColumsTrack.Value - 1) * SizeBeetweenQrTrack.Value)) * (float)3.779527559055);
                   // printDocument.DefaultPageSettings.PaperSize = new PaperSize("Other", (int)w + 4, (int)h + 4);
                    printDocument.PrintPage += PrintDocument_PrintPageSerial;
                    cur_page_packet_counter = 0;
                    printDocument.Print();
                }
            }
            if(SerialPrintingSerialRadioBtn.Checked)
            {
                m_SerialQrDataArray = m_QrProcessor.GenerateQrDataArrayForSerialPrint(m_CurrentPrintQrCode, m_DbDict, (int)SerialCopyNumericUpDown.Value);
                if (m_SerialQrDataArray != null)
                {
                    PrintDocument printDocument = new PrintDocument();
                    float h = ((QrSizetrackBar.Value) * (float)3.779527559055);
                    float w = (((QrPrintColumsTrack.Value * QrSizetrackBar.Value) + ((QrPrintColumsTrack.Value - 1) * SizeBeetweenQrTrack.Value)) * (float)3.779527559055);
                    // printDocument.DefaultPageSettings.PaperSize = new PaperSize("Other", (int)w + 4, (int)h + 4);
                    printDocument.PrintPage += PrintDocument_PrintPageSerialSerial;
                    cur_page_packet_counter = 0;
                    printDocument.Print();
                }
            }

        }

        private void PrintDocument_PrintPageSerialSerial(object sender, PrintPageEventArgs e)
        {
            int pages_count = (int)SerialCopyNumericUpDown.Value / (int)QrPrintColumsTrack.Value;
            if (SerialCopyNumericUpDown.Value % QrPrintColumsTrack.Value != 0)
                pages_count += 1;

                QrCodeData[] m_tmpQrrArr = new QrCodeData[QrPrintColumsTrack.Value];
                if (m_SerialQrDataArray.Length - cur_page_packet_counter * QrPrintColumsTrack.Value < QrPrintColumsTrack.Value)
                    Array.Copy(m_SerialQrDataArray, cur_page_packet_counter* QrPrintColumsTrack.Value, m_tmpQrrArr, 0, m_SerialQrDataArray.Length - cur_page_packet_counter * QrPrintColumsTrack.Value);
                else
                    Array.Copy(m_SerialQrDataArray, cur_page_packet_counter * QrPrintColumsTrack.Value, m_tmpQrrArr, 0, QrPrintColumsTrack.Value);
                DrawPrintQrcodeSerial(e.Graphics, (int)LeftOffsetNumeric.Value, (int)UpOffsetNumeric.Value, m_tmpQrrArr);

            if ((cur_page_packet_counter < pages_count-1) && (SerialCopyNumericUpDown.Value > QrPrintColumsTrack.Value))
                e.HasMorePages = true;

            cur_page_packet_counter++;

             
        }

        private void PrintDocument_PrintPageSerial(object sender, PrintPageEventArgs e)
        {
            if (cur_page_packet_counter >= SerialCopyNumericUpDown.Value)
            {
                e.HasMorePages = false;

                return;
            }
            else
            {
                if (cur_page_packet_counter != SerialCopyNumericUpDown.Value - 1)
                    e.HasMorePages = true;

                DrawPrintQrcodeSerial(e.Graphics, (int)LeftOffsetNumeric.Value, (int)UpOffsetNumeric.Value, m_SerialQrDataArray[cur_page_packet_counter]);

                cur_page_packet_counter++;

                if (e.HasMorePages == false)
                    cur_page_packet_counter = 0;
            }
        }

        private void PrintDocument_PrintPageCopy(object sender, PrintPageEventArgs e)
        {
            if (cur_page_packet_counter >= SerialCopyNumericUpDown.Value)
            {
                e.HasMorePages = false;

                return;
            }
            else
            {
                if (cur_page_packet_counter != SerialCopyNumericUpDown.Value - 1)
                    e.HasMorePages = true;
 
                DrawPrintQrcode(e.Graphics, (int)LeftOffsetNumeric.Value, (int)UpOffsetNumeric.Value);

                cur_page_packet_counter++;

                if (e.HasMorePages == false)
                    cur_page_packet_counter = 0;
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            DrawPrintQrcode(e.Graphics, (int)LeftOffsetNumeric.Value, (int)UpOffsetNumeric.Value);
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
