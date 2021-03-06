﻿namespace BarCode2
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStripBar = new System.Windows.Forms.StatusStrip();
            this.connectionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.identificationTab = new System.Windows.Forms.TabPage();
            this.copyQrInBuffer = new System.Windows.Forms.Button();
            this.CheckQrManualBtm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckQrManualTxb = new System.Windows.Forms.TextBox();
            this.qr_dataList = new System.Windows.Forms.ListBox();
            this.PrintPageTab = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.auto_operation_statusPanel = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.autoModeQrInPacketCount = new System.Windows.Forms.NumericUpDown();
            this.autoModeCxb = new System.Windows.Forms.CheckBox();
            this.addToBaseBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.LeftOffsetNumeric = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.UpOffsetNumeric = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SerialPrintingSerialRadioBtn = new System.Windows.Forms.RadioButton();
            this.SerialCopyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.OncePrintingRadioBtn = new System.Windows.Forms.RadioButton();
            this.CopyOfPagesRadioBtn = new System.Windows.Forms.RadioButton();
            this.SerialPrintingRadioBtn = new System.Windows.Forms.RadioButton();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.SizeBeetweenColumnsLbl = new System.Windows.Forms.Label();
            this.PaperWidthLbl = new System.Windows.Forms.Label();
            this.ColumnsCountLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SizeBeetweenQrTrack = new System.Windows.Forms.TrackBar();
            this.QrPrintColumsTrack = new System.Windows.Forms.TrackBar();
            this.AddInPacketTreeView = new System.Windows.Forms.TreeView();
            this.contextMenuStripAddInTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.вставитьТекстИзБуффераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QrSizeLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.QrSizetrackBar = new System.Windows.Forms.TrackBar();
            this.printPanelBox = new System.Windows.Forms.GroupBox();
            this.contextMenuStripPrintPanel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.копироватьВБуферToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьРисунокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentQrCodeListBox = new System.Windows.Forms.ListBox();
            this.contextMenuStripQrCodeListBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.поднятьВверхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.опуститьВнизToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.снятьВыделениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.notIncrementedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LastVaqlueFromBdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.вставитьИзБуффераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.openQrSession = new System.Windows.Forms.ToolStripMenuItem();
            this.saveQrMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshDictionary = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dictionaryTreeOnPrintTab = new System.Windows.Forms.TreeView();
            this.DataBasePageTab = new System.Windows.Forms.TabPage();
            this.deleteBaseBtn = new System.Windows.Forms.Button();
            this.DataBaseCollectionListBox = new System.Windows.Forms.ListBox();
            this.RefreshDbBtn = new System.Windows.Forms.Button();
            this.addDabaseBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DataBasItemCollectionListBox = new System.Windows.Forms.ListBox();
            this.contextMenuDataitemListBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopyQrToBufferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteDbItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimeOutTimer = new System.Windows.Forms.Timer(this.components);
            this.statusStripBar.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.identificationTab.SuspendLayout();
            this.PrintPageTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoModeQrInPacketCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftOffsetNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpOffsetNumeric)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SerialCopyNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeBeetweenQrTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QrPrintColumsTrack)).BeginInit();
            this.contextMenuStripAddInTree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QrSizetrackBar)).BeginInit();
            this.contextMenuStripPrintPanel.SuspendLayout();
            this.contextMenuStripQrCodeListBox.SuspendLayout();
            this.DataBasePageTab.SuspendLayout();
            this.contextMenuDataitemListBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripBar
            // 
            this.statusStripBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStripBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionStatusLabel});
            this.statusStripBar.Location = new System.Drawing.Point(0, 727);
            this.statusStripBar.Name = "statusStripBar";
            this.statusStripBar.Padding = new System.Windows.Forms.Padding(2, 0, 12, 0);
            this.statusStripBar.Size = new System.Drawing.Size(1277, 25);
            this.statusStripBar.TabIndex = 0;
            this.statusStripBar.Text = "statusStrip1";
            // 
            // connectionStatusLabel
            // 
            this.connectionStatusLabel.BackColor = System.Drawing.Color.Red;
            this.connectionStatusLabel.DoubleClickEnabled = true;
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            this.connectionStatusLabel.Size = new System.Drawing.Size(179, 20);
            this.connectionStatusLabel.Text = "Соединение с сервером";
            this.connectionStatusLabel.DoubleClick += new System.EventHandler(this.connectionStatusLabel_DoubleClick);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabControl.Controls.Add(this.identificationTab);
            this.mainTabControl.Controls.Add(this.PrintPageTab);
            this.mainTabControl.Controls.Add(this.DataBasePageTab);
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1272, 709);
            this.mainTabControl.TabIndex = 1;
            this.mainTabControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mainTabControl_KeyPress);
            // 
            // identificationTab
            // 
            this.identificationTab.Controls.Add(this.copyQrInBuffer);
            this.identificationTab.Controls.Add(this.CheckQrManualBtm);
            this.identificationTab.Controls.Add(this.label1);
            this.identificationTab.Controls.Add(this.CheckQrManualTxb);
            this.identificationTab.Controls.Add(this.qr_dataList);
            this.identificationTab.Location = new System.Drawing.Point(4, 25);
            this.identificationTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.identificationTab.Name = "identificationTab";
            this.identificationTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.identificationTab.Size = new System.Drawing.Size(1264, 680);
            this.identificationTab.TabIndex = 0;
            this.identificationTab.Text = "Идентификация";
            this.identificationTab.UseVisualStyleBackColor = true;
            this.identificationTab.Paint += new System.Windows.Forms.PaintEventHandler(this.identificationTab_Paint);
            // 
            // copyQrInBuffer
            // 
            this.copyQrInBuffer.Location = new System.Drawing.Point(7, 240);
            this.copyQrInBuffer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.copyQrInBuffer.Name = "copyQrInBuffer";
            this.copyQrInBuffer.Size = new System.Drawing.Size(215, 29);
            this.copyQrInBuffer.TabIndex = 4;
            this.copyQrInBuffer.Text = "Копировать в буффер";
            this.copyQrInBuffer.UseVisualStyleBackColor = true;
            this.copyQrInBuffer.Click += new System.EventHandler(this.copyQrInBuffer_Click);
            // 
            // CheckQrManualBtm
            // 
            this.CheckQrManualBtm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CheckQrManualBtm.Location = new System.Drawing.Point(12, 623);
            this.CheckQrManualBtm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckQrManualBtm.Name = "CheckQrManualBtm";
            this.CheckQrManualBtm.Size = new System.Drawing.Size(215, 29);
            this.CheckQrManualBtm.TabIndex = 3;
            this.CheckQrManualBtm.Text = "Проверить ";
            this.CheckQrManualBtm.UseVisualStyleBackColor = true;
            this.CheckQrManualBtm.Click += new System.EventHandler(this.CheckQrManualBtm_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ввод  QR вручную";
            // 
            // CheckQrManualTxb
            // 
            this.CheckQrManualTxb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CheckQrManualTxb.Location = new System.Drawing.Point(12, 293);
            this.CheckQrManualTxb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckQrManualTxb.Multiline = true;
            this.CheckQrManualTxb.Name = "CheckQrManualTxb";
            this.CheckQrManualTxb.Size = new System.Drawing.Size(214, 321);
            this.CheckQrManualTxb.TabIndex = 1;
            this.CheckQrManualTxb.Text = "FFX014N000001D120386FXX";
            // 
            // qr_dataList
            // 
            this.qr_dataList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.qr_dataList.FormattingEnabled = true;
            this.qr_dataList.ItemHeight = 16;
            this.qr_dataList.Location = new System.Drawing.Point(233, 12);
            this.qr_dataList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.qr_dataList.Name = "qr_dataList";
            this.qr_dataList.Size = new System.Drawing.Size(1359, 628);
            this.qr_dataList.TabIndex = 0;
            // 
            // PrintPageTab
            // 
            this.PrintPageTab.Controls.Add(this.label10);
            this.PrintPageTab.Controls.Add(this.groupBox2);
            this.PrintPageTab.Controls.Add(this.addToBaseBtn);
            this.PrintPageTab.Controls.Add(this.label9);
            this.PrintPageTab.Controls.Add(this.LeftOffsetNumeric);
            this.PrintPageTab.Controls.Add(this.label8);
            this.PrintPageTab.Controls.Add(this.UpOffsetNumeric);
            this.PrintPageTab.Controls.Add(this.groupBox1);
            this.PrintPageTab.Controls.Add(this.PrintBtn);
            this.PrintPageTab.Controls.Add(this.SizeBeetweenColumnsLbl);
            this.PrintPageTab.Controls.Add(this.PaperWidthLbl);
            this.PrintPageTab.Controls.Add(this.ColumnsCountLbl);
            this.PrintPageTab.Controls.Add(this.label7);
            this.PrintPageTab.Controls.Add(this.label6);
            this.PrintPageTab.Controls.Add(this.label5);
            this.PrintPageTab.Controls.Add(this.SizeBeetweenQrTrack);
            this.PrintPageTab.Controls.Add(this.QrPrintColumsTrack);
            this.PrintPageTab.Controls.Add(this.AddInPacketTreeView);
            this.PrintPageTab.Controls.Add(this.QrSizeLbl);
            this.PrintPageTab.Controls.Add(this.label4);
            this.PrintPageTab.Controls.Add(this.QrSizetrackBar);
            this.PrintPageTab.Controls.Add(this.printPanelBox);
            this.PrintPageTab.Controls.Add(this.currentQrCodeListBox);
            this.PrintPageTab.Controls.Add(this.RefreshDictionary);
            this.PrintPageTab.Controls.Add(this.label2);
            this.PrintPageTab.Controls.Add(this.dictionaryTreeOnPrintTab);
            this.PrintPageTab.Location = new System.Drawing.Point(4, 25);
            this.PrintPageTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PrintPageTab.Name = "PrintPageTab";
            this.PrintPageTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PrintPageTab.Size = new System.Drawing.Size(1264, 680);
            this.PrintPageTab.TabIndex = 1;
            this.PrintPageTab.Text = "Печать этикеток";
            this.PrintPageTab.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(345, 386);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Входящие Qr-пакеты";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.auto_operation_statusPanel);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.autoModeQrInPacketCount);
            this.groupBox2.Controls.Add(this.autoModeCxb);
            this.groupBox2.Location = new System.Drawing.Point(10, 386);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(327, 278);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Автоматический режим";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(298, 17);
            this.label13.TabIndex = 31;
            this.label13.Text = "Статус выполнение предыдущей операции:";
            // 
            // auto_operation_statusPanel
            // 
            this.auto_operation_statusPanel.BackColor = System.Drawing.Color.Red;
            this.auto_operation_statusPanel.Location = new System.Drawing.Point(298, 136);
            this.auto_operation_statusPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.auto_operation_statusPanel.Name = "auto_operation_statusPanel";
            this.auto_operation_statusPanel.Size = new System.Drawing.Size(18, 27);
            this.auto_operation_statusPanel.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(218, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 34);
            this.label12.TabIndex = 29;
            this.label12.Text = "сканирования\r\nQr-пакета";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 34);
            this.label11.TabIndex = 28;
            this.label11.Text = "Совершать действие\r\nпосле";
            // 
            // autoModeQrInPacketCount
            // 
            this.autoModeQrInPacketCount.Location = new System.Drawing.Point(155, 76);
            this.autoModeQrInPacketCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.autoModeQrInPacketCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.autoModeQrInPacketCount.Name = "autoModeQrInPacketCount";
            this.autoModeQrInPacketCount.Size = new System.Drawing.Size(57, 22);
            this.autoModeQrInPacketCount.TabIndex = 27;
            this.autoModeQrInPacketCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // autoModeCxb
            // 
            this.autoModeCxb.AutoSize = true;
            this.autoModeCxb.Location = new System.Drawing.Point(7, 24);
            this.autoModeCxb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.autoModeCxb.Name = "autoModeCxb";
            this.autoModeCxb.Size = new System.Drawing.Size(94, 21);
            this.autoModeCxb.TabIndex = 0;
            this.autoModeCxb.Text = "Включить";
            this.autoModeCxb.UseVisualStyleBackColor = true;
            // 
            // addToBaseBtn
            // 
            this.addToBaseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addToBaseBtn.Location = new System.Drawing.Point(1020, 638);
            this.addToBaseBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addToBaseBtn.Name = "addToBaseBtn";
            this.addToBaseBtn.Size = new System.Drawing.Size(132, 29);
            this.addToBaseBtn.TabIndex = 25;
            this.addToBaseBtn.Text = "Добавить в базу";
            this.addToBaseBtn.UseVisualStyleBackColor = true;
            this.addToBaseBtn.Click += new System.EventHandler(this.addToBaseBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1062, 445);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Смещение слева";
            // 
            // LeftOffsetNumeric
            // 
            this.LeftOffsetNumeric.Location = new System.Drawing.Point(1185, 442);
            this.LeftOffsetNumeric.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LeftOffsetNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LeftOffsetNumeric.Name = "LeftOffsetNumeric";
            this.LeftOffsetNumeric.Size = new System.Drawing.Size(57, 22);
            this.LeftOffsetNumeric.TabIndex = 23;
            this.LeftOffsetNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(862, 445);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Смещение от верха";
            // 
            // UpOffsetNumeric
            // 
            this.UpOffsetNumeric.Location = new System.Drawing.Point(1000, 442);
            this.UpOffsetNumeric.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UpOffsetNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpOffsetNumeric.Name = "UpOffsetNumeric";
            this.UpOffsetNumeric.Size = new System.Drawing.Size(57, 22);
            this.UpOffsetNumeric.TabIndex = 21;
            this.UpOffsetNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.SerialPrintingSerialRadioBtn);
            this.groupBox1.Controls.Add(this.SerialCopyNumericUpDown);
            this.groupBox1.Controls.Add(this.OncePrintingRadioBtn);
            this.groupBox1.Controls.Add(this.CopyOfPagesRadioBtn);
            this.groupBox1.Controls.Add(this.SerialPrintingRadioBtn);
            this.groupBox1.Location = new System.Drawing.Point(660, 465);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(597, 162);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки серии";
            // 
            // SerialPrintingSerialRadioBtn
            // 
            this.SerialPrintingSerialRadioBtn.AutoSize = true;
            this.SerialPrintingSerialRadioBtn.Location = new System.Drawing.Point(5, 88);
            this.SerialPrintingSerialRadioBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SerialPrintingSerialRadioBtn.Name = "SerialPrintingSerialRadioBtn";
            this.SerialPrintingSerialRadioBtn.Size = new System.Drawing.Size(256, 21);
            this.SerialPrintingSerialRadioBtn.TabIndex = 4;
            this.SerialPrintingSerialRadioBtn.Text = "Серия номеров(последовательно)";
            this.SerialPrintingSerialRadioBtn.UseVisualStyleBackColor = true;
            this.SerialPrintingSerialRadioBtn.CheckedChanged += new System.EventHandler(this.SerialPrintingSerialRadioBtn_CheckedChanged);
            // 
            // SerialCopyNumericUpDown
            // 
            this.SerialCopyNumericUpDown.Enabled = false;
            this.SerialCopyNumericUpDown.Location = new System.Drawing.Point(277, 88);
            this.SerialCopyNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SerialCopyNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.SerialCopyNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SerialCopyNumericUpDown.Name = "SerialCopyNumericUpDown";
            this.SerialCopyNumericUpDown.Size = new System.Drawing.Size(102, 22);
            this.SerialCopyNumericUpDown.TabIndex = 3;
            this.SerialCopyNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // OncePrintingRadioBtn
            // 
            this.OncePrintingRadioBtn.AutoSize = true;
            this.OncePrintingRadioBtn.Checked = true;
            this.OncePrintingRadioBtn.Location = new System.Drawing.Point(5, 24);
            this.OncePrintingRadioBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OncePrintingRadioBtn.Name = "OncePrintingRadioBtn";
            this.OncePrintingRadioBtn.Size = new System.Drawing.Size(127, 21);
            this.OncePrintingRadioBtn.TabIndex = 2;
            this.OncePrintingRadioBtn.TabStop = true;
            this.OncePrintingRadioBtn.Text = "Одна этикетка";
            this.OncePrintingRadioBtn.UseVisualStyleBackColor = true;
            this.OncePrintingRadioBtn.CheckedChanged += new System.EventHandler(this.OncePrintingRadioBtn_CheckedChanged);
            // 
            // CopyOfPagesRadioBtn
            // 
            this.CopyOfPagesRadioBtn.AutoSize = true;
            this.CopyOfPagesRadioBtn.Location = new System.Drawing.Point(5, 118);
            this.CopyOfPagesRadioBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CopyOfPagesRadioBtn.Name = "CopyOfPagesRadioBtn";
            this.CopyOfPagesRadioBtn.Size = new System.Drawing.Size(133, 21);
            this.CopyOfPagesRadioBtn.TabIndex = 1;
            this.CopyOfPagesRadioBtn.Text = "Копии этикеток";
            this.CopyOfPagesRadioBtn.UseVisualStyleBackColor = true;
            // 
            // SerialPrintingRadioBtn
            // 
            this.SerialPrintingRadioBtn.AutoSize = true;
            this.SerialPrintingRadioBtn.Location = new System.Drawing.Point(5, 57);
            this.SerialPrintingRadioBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SerialPrintingRadioBtn.Name = "SerialPrintingRadioBtn";
            this.SerialPrintingRadioBtn.Size = new System.Drawing.Size(130, 21);
            this.SerialPrintingRadioBtn.TabIndex = 0;
            this.SerialPrintingRadioBtn.Text = "Серия номеров";
            this.SerialPrintingRadioBtn.UseVisualStyleBackColor = true;
            this.SerialPrintingRadioBtn.CheckedChanged += new System.EventHandler(this.SerialPrintingRadioBtn_CheckedChanged);
            // 
            // PrintBtn
            // 
            this.PrintBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintBtn.Location = new System.Drawing.Point(1158, 638);
            this.PrintBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(93, 29);
            this.PrintBtn.TabIndex = 19;
            this.PrintBtn.Text = "Печать";
            this.PrintBtn.UseVisualStyleBackColor = true;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // SizeBeetweenColumnsLbl
            // 
            this.SizeBeetweenColumnsLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SizeBeetweenColumnsLbl.AutoSize = true;
            this.SizeBeetweenColumnsLbl.Location = new System.Drawing.Point(1212, 386);
            this.SizeBeetweenColumnsLbl.Name = "SizeBeetweenColumnsLbl";
            this.SizeBeetweenColumnsLbl.Size = new System.Drawing.Size(16, 17);
            this.SizeBeetweenColumnsLbl.TabIndex = 18;
            this.SizeBeetweenColumnsLbl.Text = "0";
            // 
            // PaperWidthLbl
            // 
            this.PaperWidthLbl.AutoSize = true;
            this.PaperWidthLbl.Location = new System.Drawing.Point(817, 445);
            this.PaperWidthLbl.Name = "PaperWidthLbl";
            this.PaperWidthLbl.Size = new System.Drawing.Size(16, 17);
            this.PaperWidthLbl.TabIndex = 17;
            this.PaperWidthLbl.Text = "0";
            // 
            // ColumnsCountLbl
            // 
            this.ColumnsCountLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ColumnsCountLbl.AutoSize = true;
            this.ColumnsCountLbl.Location = new System.Drawing.Point(1212, 317);
            this.ColumnsCountLbl.Name = "ColumnsCountLbl";
            this.ColumnsCountLbl.Size = new System.Drawing.Size(16, 17);
            this.ColumnsCountLbl.TabIndex = 16;
            this.ColumnsCountLbl.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(653, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 51);
            this.label7.TabIndex = 15;
            this.label7.Text = "Расстояние\r\nмежду\r\nкононками";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(653, 445);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ширина бумаги (мм):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(653, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 34);
            this.label5.TabIndex = 13;
            this.label5.Text = "Кол-во\r\nколонок";
            // 
            // SizeBeetweenQrTrack
            // 
            this.SizeBeetweenQrTrack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SizeBeetweenQrTrack.Location = new System.Drawing.Point(747, 371);
            this.SizeBeetweenQrTrack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SizeBeetweenQrTrack.Maximum = 20;
            this.SizeBeetweenQrTrack.Minimum = 1;
            this.SizeBeetweenQrTrack.Name = "SizeBeetweenQrTrack";
            this.SizeBeetweenQrTrack.Size = new System.Drawing.Size(457, 56);
            this.SizeBeetweenQrTrack.TabIndex = 12;
            this.SizeBeetweenQrTrack.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.SizeBeetweenQrTrack.Value = 1;
            this.SizeBeetweenQrTrack.Scroll += new System.EventHandler(this.SizeBeetweenQrTrack_Scroll);
            // 
            // QrPrintColumsTrack
            // 
            this.QrPrintColumsTrack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QrPrintColumsTrack.Location = new System.Drawing.Point(747, 305);
            this.QrPrintColumsTrack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QrPrintColumsTrack.Maximum = 5;
            this.QrPrintColumsTrack.Minimum = 1;
            this.QrPrintColumsTrack.Name = "QrPrintColumsTrack";
            this.QrPrintColumsTrack.Size = new System.Drawing.Size(457, 56);
            this.QrPrintColumsTrack.TabIndex = 10;
            this.QrPrintColumsTrack.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.QrPrintColumsTrack.Value = 1;
            this.QrPrintColumsTrack.Scroll += new System.EventHandler(this.QrPrintColumsTrack_Scroll);
            // 
            // AddInPacketTreeView
            // 
            this.AddInPacketTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddInPacketTreeView.ContextMenuStrip = this.contextMenuStripAddInTree;
            this.AddInPacketTreeView.Location = new System.Drawing.Point(343, 410);
            this.AddInPacketTreeView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddInPacketTreeView.Name = "AddInPacketTreeView";
            this.AddInPacketTreeView.Size = new System.Drawing.Size(301, 252);
            this.AddInPacketTreeView.TabIndex = 9;
            // 
            // contextMenuStripAddInTree
            // 
            this.contextMenuStripAddInTree.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStripAddInTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem1,
            this.toolStripSeparator2,
            this.вставитьТекстИзБуффераToolStripMenuItem});
            this.contextMenuStripAddInTree.Name = "contextMenuStripAddInTree";
            this.contextMenuStripAddInTree.Size = new System.Drawing.Size(219, 58);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(218, 24);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.удалитьToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(215, 6);
            // 
            // вставитьТекстИзБуффераToolStripMenuItem
            // 
            this.вставитьТекстИзБуффераToolStripMenuItem.Name = "вставитьТекстИзБуффераToolStripMenuItem";
            this.вставитьТекстИзБуффераToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.вставитьТекстИзБуффераToolStripMenuItem.Text = "Вставить из  буфера";
            this.вставитьТекстИзБуффераToolStripMenuItem.Click += new System.EventHandler(this.вставитьТекстИзБуффераToolStripMenuItem_Click);
            // 
            // QrSizeLbl
            // 
            this.QrSizeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.QrSizeLbl.AutoSize = true;
            this.QrSizeLbl.Location = new System.Drawing.Point(1212, 257);
            this.QrSizeLbl.Name = "QrSizeLbl";
            this.QrSizeLbl.Size = new System.Drawing.Size(16, 17);
            this.QrSizeLbl.TabIndex = 8;
            this.QrSizeLbl.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(653, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 51);
            this.label4.TabIndex = 7;
            this.label4.Text = "Размер\r\nQR-кода\r\nв мм";
            // 
            // QrSizetrackBar
            // 
            this.QrSizetrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QrSizetrackBar.Location = new System.Drawing.Point(747, 240);
            this.QrSizetrackBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QrSizetrackBar.Maximum = 40;
            this.QrSizetrackBar.Minimum = 1;
            this.QrSizetrackBar.Name = "QrSizetrackBar";
            this.QrSizetrackBar.Size = new System.Drawing.Size(457, 56);
            this.QrSizetrackBar.TabIndex = 6;
            this.QrSizetrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.QrSizetrackBar.Value = 1;
            this.QrSizetrackBar.Scroll += new System.EventHandler(this.QrSizetrackBar_Scroll);
            // 
            // printPanelBox
            // 
            this.printPanelBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printPanelBox.ContextMenuStrip = this.contextMenuStripPrintPanel;
            this.printPanelBox.Location = new System.Drawing.Point(657, 7);
            this.printPanelBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.printPanelBox.Name = "printPanelBox";
            this.printPanelBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.printPanelBox.Size = new System.Drawing.Size(597, 224);
            this.printPanelBox.TabIndex = 4;
            this.printPanelBox.TabStop = false;
            this.printPanelBox.Text = "Настройка печати";
            this.printPanelBox.Paint += new System.Windows.Forms.PaintEventHandler(this.printPanelBox_Paint);
            // 
            // contextMenuStripPrintPanel
            // 
            this.contextMenuStripPrintPanel.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStripPrintPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьВБуферToolStripMenuItem,
            this.сохранитьРисунокToolStripMenuItem});
            this.contextMenuStripPrintPanel.Name = "contextMenuStripPrintPanel";
            this.contextMenuStripPrintPanel.Size = new System.Drawing.Size(222, 52);
            // 
            // копироватьВБуферToolStripMenuItem
            // 
            this.копироватьВБуферToolStripMenuItem.Name = "копироватьВБуферToolStripMenuItem";
            this.копироватьВБуферToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.копироватьВБуферToolStripMenuItem.Text = "Копировать в буфер";
            this.копироватьВБуферToolStripMenuItem.Click += new System.EventHandler(this.копироватьВБуферToolStripMenuItem_Click);
            // 
            // сохранитьРисунокToolStripMenuItem
            // 
            this.сохранитьРисунокToolStripMenuItem.Name = "сохранитьРисунокToolStripMenuItem";
            this.сохранитьРисунокToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.сохранитьРисунокToolStripMenuItem.Text = "Сохранить рисунок";
            this.сохранитьРисунокToolStripMenuItem.Click += new System.EventHandler(this.сохранитьРисунокToolStripMenuItem_Click);
            // 
            // currentQrCodeListBox
            // 
            this.currentQrCodeListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.currentQrCodeListBox.ContextMenuStrip = this.contextMenuStripQrCodeListBox;
            this.currentQrCodeListBox.FormattingEnabled = true;
            this.currentQrCodeListBox.ItemHeight = 16;
            this.currentQrCodeListBox.Location = new System.Drawing.Point(343, 12);
            this.currentQrCodeListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.currentQrCodeListBox.Name = "currentQrCodeListBox";
            this.currentQrCodeListBox.Size = new System.Drawing.Size(301, 340);
            this.currentQrCodeListBox.TabIndex = 3;
            // 
            // contextMenuStripQrCodeListBox
            // 
            this.contextMenuStripQrCodeListBox.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStripQrCodeListBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поднятьВверхToolStripMenuItem,
            this.опуститьВнизToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.удалитьВсеToolStripMenuItem,
            this.снятьВыделениеToolStripMenuItem,
            this.toolStripSeparator1,
            this.notIncrementedMenuItem,
            this.LastVaqlueFromBdToolStripMenuItem,
            this.toolStripSeparator4,
            this.вставитьИзБуффераToolStripMenuItem,
            this.toolStripSeparator5,
            this.openQrSession,
            this.saveQrMenuItem});
            this.contextMenuStripQrCodeListBox.Name = "contextMenuStripQrCodeListBox";
            this.contextMenuStripQrCodeListBox.Size = new System.Drawing.Size(316, 262);
            this.contextMenuStripQrCodeListBox.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripQrCodeListBox_Opening);
            // 
            // поднятьВверхToolStripMenuItem
            // 
            this.поднятьВверхToolStripMenuItem.Name = "поднятьВверхToolStripMenuItem";
            this.поднятьВверхToolStripMenuItem.Size = new System.Drawing.Size(315, 24);
            this.поднятьВверхToolStripMenuItem.Text = "Поднять вверх";
            this.поднятьВверхToolStripMenuItem.Click += new System.EventHandler(this.поднятьВверхToolStripMenuItem_Click);
            // 
            // опуститьВнизToolStripMenuItem
            // 
            this.опуститьВнизToolStripMenuItem.Name = "опуститьВнизToolStripMenuItem";
            this.опуститьВнизToolStripMenuItem.Size = new System.Drawing.Size(315, 24);
            this.опуститьВнизToolStripMenuItem.Text = "Опустить вниз";
            this.опуститьВнизToolStripMenuItem.Click += new System.EventHandler(this.опуститьВнизToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(315, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // удалитьВсеToolStripMenuItem
            // 
            this.удалитьВсеToolStripMenuItem.Name = "удалитьВсеToolStripMenuItem";
            this.удалитьВсеToolStripMenuItem.Size = new System.Drawing.Size(315, 24);
            this.удалитьВсеToolStripMenuItem.Text = "Удалить все";
            this.удалитьВсеToolStripMenuItem.Click += new System.EventHandler(this.удалитьВсеToolStripMenuItem_Click);
            // 
            // снятьВыделениеToolStripMenuItem
            // 
            this.снятьВыделениеToolStripMenuItem.Name = "снятьВыделениеToolStripMenuItem";
            this.снятьВыделениеToolStripMenuItem.Size = new System.Drawing.Size(315, 24);
            this.снятьВыделениеToolStripMenuItem.Text = "Снять выделение";
            this.снятьВыделениеToolStripMenuItem.Click += new System.EventHandler(this.снятьВыделениеToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(312, 6);
            // 
            // notIncrementedMenuItem
            // 
            this.notIncrementedMenuItem.CheckOnClick = true;
            this.notIncrementedMenuItem.Enabled = false;
            this.notIncrementedMenuItem.Name = "notIncrementedMenuItem";
            this.notIncrementedMenuItem.Size = new System.Drawing.Size(315, 24);
            this.notIncrementedMenuItem.Text = "Не инкриментировать";
            this.notIncrementedMenuItem.Click += new System.EventHandler(this.notIncrementedMenuItem_Click);
            // 
            // LastVaqlueFromBdToolStripMenuItem
            // 
            this.LastVaqlueFromBdToolStripMenuItem.Enabled = false;
            this.LastVaqlueFromBdToolStripMenuItem.Name = "LastVaqlueFromBdToolStripMenuItem";
            this.LastVaqlueFromBdToolStripMenuItem.Size = new System.Drawing.Size(315, 24);
            this.LastVaqlueFromBdToolStripMenuItem.Text = "Последнее значение из базы +1";
            this.LastVaqlueFromBdToolStripMenuItem.Click += new System.EventHandler(this.LastVaqlueFromBdToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(312, 6);
            // 
            // вставитьИзБуффераToolStripMenuItem
            // 
            this.вставитьИзБуффераToolStripMenuItem.Name = "вставитьИзБуффераToolStripMenuItem";
            this.вставитьИзБуффераToolStripMenuItem.Size = new System.Drawing.Size(315, 24);
            this.вставитьИзБуффераToolStripMenuItem.Text = "Вставить из буфера";
            this.вставитьИзБуффераToolStripMenuItem.Click += new System.EventHandler(this.вставитьИзБуффераToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(312, 6);
            // 
            // openQrSession
            // 
            this.openQrSession.Name = "openQrSession";
            this.openQrSession.Size = new System.Drawing.Size(315, 24);
            this.openQrSession.Text = "Загрузить QR-Код из файла";
            this.openQrSession.Click += new System.EventHandler(this.openQrSession_Click);
            // 
            // saveQrMenuItem
            // 
            this.saveQrMenuItem.Name = "saveQrMenuItem";
            this.saveQrMenuItem.Size = new System.Drawing.Size(315, 24);
            this.saveQrMenuItem.Text = "Сохранить текущий Qr-код в файл";
            this.saveQrMenuItem.Click += new System.EventHandler(this.saveQrMenuItem_Click);
            // 
            // RefreshDictionary
            // 
            this.RefreshDictionary.Location = new System.Drawing.Point(217, 9);
            this.RefreshDictionary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RefreshDictionary.Name = "RefreshDictionary";
            this.RefreshDictionary.Size = new System.Drawing.Size(118, 29);
            this.RefreshDictionary.TabIndex = 2;
            this.RefreshDictionary.Text = "Обновить";
            this.RefreshDictionary.UseVisualStyleBackColor = true;
            this.RefreshDictionary.Click += new System.EventHandler(this.RefreshDictionary_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Справочник:";
            // 
            // dictionaryTreeOnPrintTab
            // 
            this.dictionaryTreeOnPrintTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dictionaryTreeOnPrintTab.Location = new System.Drawing.Point(10, 46);
            this.dictionaryTreeOnPrintTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dictionaryTreeOnPrintTab.Name = "dictionaryTreeOnPrintTab";
            this.dictionaryTreeOnPrintTab.Size = new System.Drawing.Size(326, 321);
            this.dictionaryTreeOnPrintTab.TabIndex = 0;
            this.dictionaryTreeOnPrintTab.DoubleClick += new System.EventHandler(this.dictionaryTreeOnPrintTab_DoubleClick);
            // 
            // DataBasePageTab
            // 
            this.DataBasePageTab.Controls.Add(this.deleteBaseBtn);
            this.DataBasePageTab.Controls.Add(this.DataBaseCollectionListBox);
            this.DataBasePageTab.Controls.Add(this.RefreshDbBtn);
            this.DataBasePageTab.Controls.Add(this.addDabaseBtn);
            this.DataBasePageTab.Controls.Add(this.label3);
            this.DataBasePageTab.Controls.Add(this.DataBasItemCollectionListBox);
            this.DataBasePageTab.Location = new System.Drawing.Point(4, 25);
            this.DataBasePageTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataBasePageTab.Name = "DataBasePageTab";
            this.DataBasePageTab.Size = new System.Drawing.Size(1264, 680);
            this.DataBasePageTab.TabIndex = 2;
            this.DataBasePageTab.Text = "БазаДанных";
            this.DataBasePageTab.UseVisualStyleBackColor = true;
            // 
            // deleteBaseBtn
            // 
            this.deleteBaseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteBaseBtn.Enabled = false;
            this.deleteBaseBtn.Location = new System.Drawing.Point(215, 642);
            this.deleteBaseBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteBaseBtn.Name = "deleteBaseBtn";
            this.deleteBaseBtn.Size = new System.Drawing.Size(182, 29);
            this.deleteBaseBtn.TabIndex = 5;
            this.deleteBaseBtn.Text = "Удалить базу";
            this.deleteBaseBtn.UseVisualStyleBackColor = true;
            this.deleteBaseBtn.Click += new System.EventHandler(this.deleteBaseBtn_Click);
            // 
            // DataBaseCollectionListBox
            // 
            this.DataBaseCollectionListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DataBaseCollectionListBox.FormattingEnabled = true;
            this.DataBaseCollectionListBox.HorizontalScrollbar = true;
            this.DataBaseCollectionListBox.ItemHeight = 16;
            this.DataBaseCollectionListBox.Location = new System.Drawing.Point(12, 48);
            this.DataBaseCollectionListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataBaseCollectionListBox.Name = "DataBaseCollectionListBox";
            this.DataBaseCollectionListBox.Size = new System.Drawing.Size(816, 580);
            this.DataBaseCollectionListBox.TabIndex = 4;
            this.DataBaseCollectionListBox.SelectedIndexChanged += new System.EventHandler(this.DataBaseCollectionListBox_SelectedIndexChanged);
            // 
            // RefreshDbBtn
            // 
            this.RefreshDbBtn.Location = new System.Drawing.Point(143, 12);
            this.RefreshDbBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RefreshDbBtn.Name = "RefreshDbBtn";
            this.RefreshDbBtn.Size = new System.Drawing.Size(82, 29);
            this.RefreshDbBtn.TabIndex = 3;
            this.RefreshDbBtn.Text = "Обновить";
            this.RefreshDbBtn.UseVisualStyleBackColor = true;
            this.RefreshDbBtn.Click += new System.EventHandler(this.RefreshDbBtn_Click);
            // 
            // addDabaseBtn
            // 
            this.addDabaseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addDabaseBtn.Location = new System.Drawing.Point(12, 642);
            this.addDabaseBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addDabaseBtn.Name = "addDabaseBtn";
            this.addDabaseBtn.Size = new System.Drawing.Size(197, 29);
            this.addDabaseBtn.TabIndex = 2;
            this.addDabaseBtn.Text = "Добавить базу";
            this.addDabaseBtn.UseVisualStyleBackColor = true;
            this.addDabaseBtn.Click += new System.EventHandler(this.addDabaseBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Список баз данных:";
            // 
            // DataBasItemCollectionListBox
            // 
            this.DataBasItemCollectionListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DataBasItemCollectionListBox.ContextMenuStrip = this.contextMenuDataitemListBox;
            this.DataBasItemCollectionListBox.FormattingEnabled = true;
            this.DataBasItemCollectionListBox.ItemHeight = 16;
            this.DataBasItemCollectionListBox.Location = new System.Drawing.Point(835, 48);
            this.DataBasItemCollectionListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataBasItemCollectionListBox.Name = "DataBasItemCollectionListBox";
            this.DataBasItemCollectionListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.DataBasItemCollectionListBox.Size = new System.Drawing.Size(222, 580);
            this.DataBasItemCollectionListBox.TabIndex = 0;
            this.DataBasItemCollectionListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DataBasItemCollectionListBox_MouseDoubleClick);
            // 
            // contextMenuDataitemListBox
            // 
            this.contextMenuDataitemListBox.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuDataitemListBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyQrToBufferToolStripMenuItem,
            this.toolStripSeparator3,
            this.DeleteDbItem});
            this.contextMenuDataitemListBox.Name = "contextMenuDataBaseTree";
            this.contextMenuDataitemListBox.Size = new System.Drawing.Size(232, 58);
            // 
            // CopyQrToBufferToolStripMenuItem
            // 
            this.CopyQrToBufferToolStripMenuItem.Name = "CopyQrToBufferToolStripMenuItem";
            this.CopyQrToBufferToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.CopyQrToBufferToolStripMenuItem.Text = "Копировать в буффер";
            this.CopyQrToBufferToolStripMenuItem.Click += new System.EventHandler(this.CopyQrToBufferToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(228, 6);
            // 
            // DeleteDbItem
            // 
            this.DeleteDbItem.Enabled = false;
            this.DeleteDbItem.Name = "DeleteDbItem";
            this.DeleteDbItem.Size = new System.Drawing.Size(231, 24);
            this.DeleteDbItem.Text = "Удалить";
            this.DeleteDbItem.Click += new System.EventHandler(this.DeleteDbItem_Click);
            // 
            // TimeOutTimer
            // 
            this.TimeOutTimer.Interval = 2000;
            this.TimeOutTimer.Tick += new System.EventHandler(this.TimeOutTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1277, 752);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.statusStripBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1291, 782);
            this.Name = "MainForm";
            this.Text = "QR кодер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.statusStripBar.ResumeLayout(false);
            this.statusStripBar.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.identificationTab.ResumeLayout(false);
            this.identificationTab.PerformLayout();
            this.PrintPageTab.ResumeLayout(false);
            this.PrintPageTab.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoModeQrInPacketCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftOffsetNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpOffsetNumeric)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SerialCopyNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeBeetweenQrTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QrPrintColumsTrack)).EndInit();
            this.contextMenuStripAddInTree.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QrSizetrackBar)).EndInit();
            this.contextMenuStripPrintPanel.ResumeLayout(false);
            this.contextMenuStripQrCodeListBox.ResumeLayout(false);
            this.DataBasePageTab.ResumeLayout(false);
            this.DataBasePageTab.PerformLayout();
            this.contextMenuDataitemListBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripBar;
        private System.Windows.Forms.ToolStripStatusLabel connectionStatusLabel;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage identificationTab;
        private System.Windows.Forms.TabPage PrintPageTab;
        private System.Windows.Forms.ListBox qr_dataList;
        private System.Windows.Forms.Button CheckQrManualBtm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CheckQrManualTxb;
        private System.Windows.Forms.TreeView dictionaryTreeOnPrintTab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RefreshDictionary;
        private System.Windows.Forms.TabPage DataBasePageTab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox DataBasItemCollectionListBox;
        private System.Windows.Forms.Button addDabaseBtn;
        private System.Windows.Forms.Button RefreshDbBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuDataitemListBox;
        private System.Windows.Forms.ToolStripMenuItem CopyQrToBufferToolStripMenuItem;
        private System.Windows.Forms.GroupBox printPanelBox;
        private System.Windows.Forms.ListBox currentQrCodeListBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPrintPanel;
        private System.Windows.Forms.ToolStripMenuItem копироватьВБуферToolStripMenuItem;
        private System.Windows.Forms.Label QrSizeLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar QrSizetrackBar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripQrCodeListBox;
        private System.Windows.Forms.ToolStripMenuItem поднятьВверхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem опуститьВнизToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem снятьВыделениеToolStripMenuItem;
        private System.Windows.Forms.TreeView AddInPacketTreeView;
        private System.Windows.Forms.ToolStripMenuItem сохранитьРисунокToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAddInTree;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.TrackBar QrPrintColumsTrack;
        private System.Windows.Forms.TrackBar SizeBeetweenQrTrack;
        private System.Windows.Forms.Label SizeBeetweenColumnsLbl;
        private System.Windows.Forms.Label PaperWidthLbl;
        private System.Windows.Forms.Label ColumnsCountLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton OncePrintingRadioBtn;
        private System.Windows.Forms.RadioButton CopyOfPagesRadioBtn;
        private System.Windows.Forms.RadioButton SerialPrintingRadioBtn;
        private System.Windows.Forms.NumericUpDown SerialCopyNumericUpDown;
        private System.Windows.Forms.RadioButton SerialPrintingSerialRadioBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown UpOffsetNumeric;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown LeftOffsetNumeric;
        private System.Windows.Forms.Timer TimeOutTimer;
        private System.Windows.Forms.ListBox DataBaseCollectionListBox;
        private System.Windows.Forms.Button deleteBaseBtn;
        private System.Windows.Forms.Button addToBaseBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem notIncrementedMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LastVaqlueFromBdToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem вставитьТекстИзБуффераToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem DeleteDbItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button copyQrInBuffer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem вставитьИзБуффераToolStripMenuItem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown autoModeQrInPacketCount;
        private System.Windows.Forms.CheckBox autoModeCxb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel auto_operation_statusPanel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem openQrSession;
        private System.Windows.Forms.ToolStripMenuItem saveQrMenuItem;
    }
}

