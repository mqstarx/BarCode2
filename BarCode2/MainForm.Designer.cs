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
            this.CheckQrManualBtm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckQrManualTxb = new System.Windows.Forms.TextBox();
            this.qr_dataList = new System.Windows.Forms.ListBox();
            this.PrintPageTab = new System.Windows.Forms.TabPage();
            this.AddInPacketTreeView = new System.Windows.Forms.TreeView();
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
            this.RefreshDictionary = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dictionaryTreeOnPrintTab = new System.Windows.Forms.TreeView();
            this.DataBasePageTab = new System.Windows.Forms.TabPage();
            this.DataBasesCollectionTree = new System.Windows.Forms.TreeView();
            this.contextMenuDataBaseTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьВложеннуюБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshDbBtn = new System.Windows.Forms.Button();
            this.addDabaseBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DataBasItemCollectionListBox = new System.Windows.Forms.ListBox();
            this.contextMenuStripAddInTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.QrPrintColumsTrack = new System.Windows.Forms.TrackBar();
            this.PaperWightTrack = new System.Windows.Forms.TrackBar();
            this.SizeBeetweenQrTrack = new System.Windows.Forms.TrackBar();
            this.statusStripBar.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.identificationTab.SuspendLayout();
            this.PrintPageTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QrSizetrackBar)).BeginInit();
            this.contextMenuStripPrintPanel.SuspendLayout();
            this.contextMenuStripQrCodeListBox.SuspendLayout();
            this.DataBasePageTab.SuspendLayout();
            this.contextMenuDataBaseTree.SuspendLayout();
            this.contextMenuStripAddInTree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QrPrintColumsTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaperWightTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeBeetweenQrTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStripBar
            // 
            this.statusStripBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStripBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionStatusLabel});
            this.statusStripBar.Location = new System.Drawing.Point(0, 514);
            this.statusStripBar.Name = "statusStripBar";
            this.statusStripBar.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStripBar.Size = new System.Drawing.Size(951, 22);
            this.statusStripBar.TabIndex = 0;
            this.statusStripBar.Text = "statusStrip1";
            // 
            // connectionStatusLabel
            // 
            this.connectionStatusLabel.BackColor = System.Drawing.Color.Red;
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            this.connectionStatusLabel.Size = new System.Drawing.Size(140, 17);
            this.connectionStatusLabel.Text = "Соединение с сервером";
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
            this.mainTabControl.Size = new System.Drawing.Size(951, 514);
            this.mainTabControl.TabIndex = 1;
            this.mainTabControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mainTabControl_KeyPress);
            // 
            // identificationTab
            // 
            this.identificationTab.Controls.Add(this.CheckQrManualBtm);
            this.identificationTab.Controls.Add(this.label1);
            this.identificationTab.Controls.Add(this.CheckQrManualTxb);
            this.identificationTab.Controls.Add(this.qr_dataList);
            this.identificationTab.Location = new System.Drawing.Point(4, 22);
            this.identificationTab.Name = "identificationTab";
            this.identificationTab.Padding = new System.Windows.Forms.Padding(3);
            this.identificationTab.Size = new System.Drawing.Size(943, 488);
            this.identificationTab.TabIndex = 0;
            this.identificationTab.Text = "Идентификация";
            this.identificationTab.UseVisualStyleBackColor = true;
            this.identificationTab.Paint += new System.Windows.Forms.PaintEventHandler(this.identificationTab_Paint);
            // 
            // CheckQrManualBtm
            // 
            this.CheckQrManualBtm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CheckQrManualBtm.Location = new System.Drawing.Point(9, 459);
            this.CheckQrManualBtm.Name = "CheckQrManualBtm";
            this.CheckQrManualBtm.Size = new System.Drawing.Size(172, 23);
            this.CheckQrManualBtm.TabIndex = 3;
            this.CheckQrManualBtm.Text = "Проверить ";
            this.CheckQrManualBtm.UseVisualStyleBackColor = true;
            this.CheckQrManualBtm.Click += new System.EventHandler(this.CheckQrManualBtm_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ввод  QR вручную";
            // 
            // CheckQrManualTxb
            // 
            this.CheckQrManualTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CheckQrManualTxb.Location = new System.Drawing.Point(9, 181);
            this.CheckQrManualTxb.Multiline = true;
            this.CheckQrManualTxb.Name = "CheckQrManualTxb";
            this.CheckQrManualTxb.Size = new System.Drawing.Size(172, 272);
            this.CheckQrManualTxb.TabIndex = 1;
            this.CheckQrManualTxb.Text = "FFX014N000001D120386FXX";
            // 
            // qr_dataList
            // 
            this.qr_dataList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.qr_dataList.FormattingEnabled = true;
            this.qr_dataList.Location = new System.Drawing.Point(187, 10);
            this.qr_dataList.Name = "qr_dataList";
            this.qr_dataList.Size = new System.Drawing.Size(748, 472);
            this.qr_dataList.TabIndex = 0;
            // 
            // PrintPageTab
            // 
            this.PrintPageTab.Controls.Add(this.SizeBeetweenQrTrack);
            this.PrintPageTab.Controls.Add(this.PaperWightTrack);
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
            this.PrintPageTab.Location = new System.Drawing.Point(4, 22);
            this.PrintPageTab.Name = "PrintPageTab";
            this.PrintPageTab.Padding = new System.Windows.Forms.Padding(3);
            this.PrintPageTab.Size = new System.Drawing.Size(943, 488);
            this.PrintPageTab.TabIndex = 1;
            this.PrintPageTab.Text = "Печать этикеток";
            this.PrintPageTab.UseVisualStyleBackColor = true;
            // 
            // AddInPacketTreeView
            // 
            this.AddInPacketTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddInPacketTreeView.ContextMenuStrip = this.contextMenuStripAddInTree;
            this.AddInPacketTreeView.Location = new System.Drawing.Point(275, 280);
            this.AddInPacketTreeView.Name = "AddInPacketTreeView";
            this.AddInPacketTreeView.Size = new System.Drawing.Size(242, 199);
            this.AddInPacketTreeView.TabIndex = 9;
            // 
            // QrSizeLbl
            // 
            this.QrSizeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.QrSizeLbl.AutoSize = true;
            this.QrSizeLbl.Location = new System.Drawing.Point(901, 239);
            this.QrSizeLbl.Name = "QrSizeLbl";
            this.QrSizeLbl.Size = new System.Drawing.Size(13, 13);
            this.QrSizeLbl.TabIndex = 8;
            this.QrSizeLbl.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(523, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 39);
            this.label4.TabIndex = 7;
            this.label4.Text = "Размер\r\nQR-кода\r\nв мм";
            // 
            // QrSizetrackBar
            // 
            this.QrSizetrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QrSizetrackBar.Location = new System.Drawing.Point(579, 223);
            this.QrSizetrackBar.Maximum = 40;
            this.QrSizetrackBar.Minimum = 1;
            this.QrSizetrackBar.Name = "QrSizetrackBar";
            this.QrSizetrackBar.Size = new System.Drawing.Size(304, 45);
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
            this.printPanelBox.Location = new System.Drawing.Point(524, 36);
            this.printPanelBox.Name = "printPanelBox";
            this.printPanelBox.Size = new System.Drawing.Size(411, 175);
            this.printPanelBox.TabIndex = 4;
            this.printPanelBox.TabStop = false;
            this.printPanelBox.Text = "Настройка печати";
            this.printPanelBox.Paint += new System.Windows.Forms.PaintEventHandler(this.printPanelBox_Paint);
            // 
            // contextMenuStripPrintPanel
            // 
            this.contextMenuStripPrintPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьВБуферToolStripMenuItem,
            this.сохранитьРисунокToolStripMenuItem});
            this.contextMenuStripPrintPanel.Name = "contextMenuStripPrintPanel";
            this.contextMenuStripPrintPanel.Size = new System.Drawing.Size(187, 48);
            // 
            // копироватьВБуферToolStripMenuItem
            // 
            this.копироватьВБуферToolStripMenuItem.Name = "копироватьВБуферToolStripMenuItem";
            this.копироватьВБуферToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.копироватьВБуферToolStripMenuItem.Text = "Копировать в буфер";
            this.копироватьВБуферToolStripMenuItem.Click += new System.EventHandler(this.копироватьВБуферToolStripMenuItem_Click);
            // 
            // сохранитьРисунокToolStripMenuItem
            // 
            this.сохранитьРисунокToolStripMenuItem.Name = "сохранитьРисунокToolStripMenuItem";
            this.сохранитьРисунокToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.сохранитьРисунокToolStripMenuItem.Text = "Сохранить рисунок";
            this.сохранитьРисунокToolStripMenuItem.Click += new System.EventHandler(this.сохранитьРисунокToolStripMenuItem_Click);
            // 
            // currentQrCodeListBox
            // 
            this.currentQrCodeListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.currentQrCodeListBox.ContextMenuStrip = this.contextMenuStripQrCodeListBox;
            this.currentQrCodeListBox.FormattingEnabled = true;
            this.currentQrCodeListBox.Location = new System.Drawing.Point(275, 36);
            this.currentQrCodeListBox.Name = "currentQrCodeListBox";
            this.currentQrCodeListBox.Size = new System.Drawing.Size(242, 238);
            this.currentQrCodeListBox.TabIndex = 3;
            // 
            // contextMenuStripQrCodeListBox
            // 
            this.contextMenuStripQrCodeListBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поднятьВверхToolStripMenuItem,
            this.опуститьВнизToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.удалитьВсеToolStripMenuItem,
            this.снятьВыделениеToolStripMenuItem});
            this.contextMenuStripQrCodeListBox.Name = "contextMenuStripQrCodeListBox";
            this.contextMenuStripQrCodeListBox.Size = new System.Drawing.Size(170, 114);
            // 
            // поднятьВверхToolStripMenuItem
            // 
            this.поднятьВверхToolStripMenuItem.Name = "поднятьВверхToolStripMenuItem";
            this.поднятьВверхToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.поднятьВверхToolStripMenuItem.Text = "Поднять вверх";
            this.поднятьВверхToolStripMenuItem.Click += new System.EventHandler(this.поднятьВверхToolStripMenuItem_Click);
            // 
            // опуститьВнизToolStripMenuItem
            // 
            this.опуститьВнизToolStripMenuItem.Name = "опуститьВнизToolStripMenuItem";
            this.опуститьВнизToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.опуститьВнизToolStripMenuItem.Text = "Опустить вниз";
            this.опуститьВнизToolStripMenuItem.Click += new System.EventHandler(this.опуститьВнизToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // удалитьВсеToolStripMenuItem
            // 
            this.удалитьВсеToolStripMenuItem.Name = "удалитьВсеToolStripMenuItem";
            this.удалитьВсеToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.удалитьВсеToolStripMenuItem.Text = "Удалить все";
            this.удалитьВсеToolStripMenuItem.Click += new System.EventHandler(this.удалитьВсеToolStripMenuItem_Click);
            // 
            // снятьВыделениеToolStripMenuItem
            // 
            this.снятьВыделениеToolStripMenuItem.Name = "снятьВыделениеToolStripMenuItem";
            this.снятьВыделениеToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.снятьВыделениеToolStripMenuItem.Text = "Снять выделение";
            this.снятьВыделениеToolStripMenuItem.Click += new System.EventHandler(this.снятьВыделениеToolStripMenuItem_Click);
            // 
            // RefreshDictionary
            // 
            this.RefreshDictionary.Location = new System.Drawing.Point(174, 7);
            this.RefreshDictionary.Name = "RefreshDictionary";
            this.RefreshDictionary.Size = new System.Drawing.Size(95, 23);
            this.RefreshDictionary.TabIndex = 2;
            this.RefreshDictionary.Text = "Обновить";
            this.RefreshDictionary.UseVisualStyleBackColor = true;
            this.RefreshDictionary.Click += new System.EventHandler(this.RefreshDictionary_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Справочник:";
            // 
            // dictionaryTreeOnPrintTab
            // 
            this.dictionaryTreeOnPrintTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dictionaryTreeOnPrintTab.Location = new System.Drawing.Point(8, 36);
            this.dictionaryTreeOnPrintTab.Name = "dictionaryTreeOnPrintTab";
            this.dictionaryTreeOnPrintTab.Size = new System.Drawing.Size(261, 443);
            this.dictionaryTreeOnPrintTab.TabIndex = 0;
            this.dictionaryTreeOnPrintTab.DoubleClick += new System.EventHandler(this.dictionaryTreeOnPrintTab_DoubleClick);
            // 
            // DataBasePageTab
            // 
            this.DataBasePageTab.Controls.Add(this.DataBasesCollectionTree);
            this.DataBasePageTab.Controls.Add(this.RefreshDbBtn);
            this.DataBasePageTab.Controls.Add(this.addDabaseBtn);
            this.DataBasePageTab.Controls.Add(this.label3);
            this.DataBasePageTab.Controls.Add(this.DataBasItemCollectionListBox);
            this.DataBasePageTab.Location = new System.Drawing.Point(4, 22);
            this.DataBasePageTab.Name = "DataBasePageTab";
            this.DataBasePageTab.Size = new System.Drawing.Size(943, 488);
            this.DataBasePageTab.TabIndex = 2;
            this.DataBasePageTab.Text = "БазаДанных";
            this.DataBasePageTab.UseVisualStyleBackColor = true;
            // 
            // DataBasesCollectionTree
            // 
            this.DataBasesCollectionTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DataBasesCollectionTree.ContextMenuStrip = this.contextMenuDataBaseTree;
            this.DataBasesCollectionTree.Location = new System.Drawing.Point(23, 52);
            this.DataBasesCollectionTree.Name = "DataBasesCollectionTree";
            this.DataBasesCollectionTree.Size = new System.Drawing.Size(448, 404);
            this.DataBasesCollectionTree.TabIndex = 4;
            // 
            // contextMenuDataBaseTree
            // 
            this.contextMenuDataBaseTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьВложеннуюБДToolStripMenuItem});
            this.contextMenuDataBaseTree.Name = "contextMenuDataBaseTree";
            this.contextMenuDataBaseTree.Size = new System.Drawing.Size(213, 26);
            // 
            // добавитьВложеннуюБДToolStripMenuItem
            // 
            this.добавитьВложеннуюБДToolStripMenuItem.Name = "добавитьВложеннуюБДToolStripMenuItem";
            this.добавитьВложеннуюБДToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.добавитьВложеннуюБДToolStripMenuItem.Text = "Добавить вложенную БД";
            this.добавитьВложеннуюБДToolStripMenuItem.Click += new System.EventHandler(this.добавитьВложеннуюБДToolStripMenuItem_Click);
            // 
            // RefreshDbBtn
            // 
            this.RefreshDbBtn.Location = new System.Drawing.Point(115, 9);
            this.RefreshDbBtn.Name = "RefreshDbBtn";
            this.RefreshDbBtn.Size = new System.Drawing.Size(65, 23);
            this.RefreshDbBtn.TabIndex = 3;
            this.RefreshDbBtn.Text = "Обновить";
            this.RefreshDbBtn.UseVisualStyleBackColor = true;
            this.RefreshDbBtn.Click += new System.EventHandler(this.RefreshDbBtn_Click);
            // 
            // addDabaseBtn
            // 
            this.addDabaseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addDabaseBtn.Location = new System.Drawing.Point(8, 462);
            this.addDabaseBtn.Name = "addDabaseBtn";
            this.addDabaseBtn.Size = new System.Drawing.Size(261, 23);
            this.addDabaseBtn.TabIndex = 2;
            this.addDabaseBtn.Text = "Добавить базу";
            this.addDabaseBtn.UseVisualStyleBackColor = true;
            this.addDabaseBtn.Click += new System.EventHandler(this.addDabaseBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Список баз данных:";
            // 
            // DataBasItemCollectionListBox
            // 
            this.DataBasItemCollectionListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DataBasItemCollectionListBox.FormattingEnabled = true;
            this.DataBasItemCollectionListBox.Location = new System.Drawing.Point(477, 52);
            this.DataBasItemCollectionListBox.Name = "DataBasItemCollectionListBox";
            this.DataBasItemCollectionListBox.Size = new System.Drawing.Size(179, 407);
            this.DataBasItemCollectionListBox.TabIndex = 0;
            // 
            // contextMenuStripAddInTree
            // 
            this.contextMenuStripAddInTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem1});
            this.contextMenuStripAddInTree.Name = "contextMenuStripAddInTree";
            this.contextMenuStripAddInTree.Size = new System.Drawing.Size(119, 26);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.удалитьToolStripMenuItem1_Click);
            // 
            // QrPrintColumsTrack
            // 
            this.QrPrintColumsTrack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QrPrintColumsTrack.Location = new System.Drawing.Point(579, 274);
            this.QrPrintColumsTrack.Maximum = 5;
            this.QrPrintColumsTrack.Minimum = 1;
            this.QrPrintColumsTrack.Name = "QrPrintColumsTrack";
            this.QrPrintColumsTrack.Size = new System.Drawing.Size(304, 45);
            this.QrPrintColumsTrack.TabIndex = 10;
            this.QrPrintColumsTrack.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.QrPrintColumsTrack.Value = 1;
            this.QrPrintColumsTrack.Scroll += new System.EventHandler(this.QrPrintColumsTrack_Scroll);
            // 
            // PaperWightTrack
            // 
            this.PaperWightTrack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PaperWightTrack.Location = new System.Drawing.Point(579, 325);
            this.PaperWightTrack.Maximum = 100;
            this.PaperWightTrack.Minimum = 1;
            this.PaperWightTrack.Name = "PaperWightTrack";
            this.PaperWightTrack.Size = new System.Drawing.Size(304, 45);
            this.PaperWightTrack.TabIndex = 11;
            this.PaperWightTrack.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.PaperWightTrack.Value = 1;
            this.PaperWightTrack.Scroll += new System.EventHandler(this.PaperWightTrack_Scroll);
            // 
            // SizeBeetweenQrTrack
            // 
            this.SizeBeetweenQrTrack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SizeBeetweenQrTrack.Location = new System.Drawing.Point(579, 376);
            this.SizeBeetweenQrTrack.Maximum = 100;
            this.SizeBeetweenQrTrack.Minimum = 1;
            this.SizeBeetweenQrTrack.Name = "SizeBeetweenQrTrack";
            this.SizeBeetweenQrTrack.Size = new System.Drawing.Size(304, 45);
            this.SizeBeetweenQrTrack.TabIndex = 12;
            this.SizeBeetweenQrTrack.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.SizeBeetweenQrTrack.Value = 1;
            this.SizeBeetweenQrTrack.Scroll += new System.EventHandler(this.SizeBeetweenQrTrack_Scroll);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 536);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.statusStripBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(960, 570);
            this.Name = "MainForm";
            this.Text = "QR кодер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.statusStripBar.ResumeLayout(false);
            this.statusStripBar.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.identificationTab.ResumeLayout(false);
            this.identificationTab.PerformLayout();
            this.PrintPageTab.ResumeLayout(false);
            this.PrintPageTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QrSizetrackBar)).EndInit();
            this.contextMenuStripPrintPanel.ResumeLayout(false);
            this.contextMenuStripQrCodeListBox.ResumeLayout(false);
            this.DataBasePageTab.ResumeLayout(false);
            this.DataBasePageTab.PerformLayout();
            this.contextMenuDataBaseTree.ResumeLayout(false);
            this.contextMenuStripAddInTree.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QrPrintColumsTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaperWightTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeBeetweenQrTrack)).EndInit();
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
        private System.Windows.Forms.TreeView DataBasesCollectionTree;
        private System.Windows.Forms.ContextMenuStrip contextMenuDataBaseTree;
        private System.Windows.Forms.ToolStripMenuItem добавитьВложеннуюБДToolStripMenuItem;
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
        private System.Windows.Forms.TrackBar PaperWightTrack;
        private System.Windows.Forms.TrackBar SizeBeetweenQrTrack;
    }
}

