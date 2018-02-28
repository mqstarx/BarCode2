namespace BarCode2
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
            this.statusStripBar = new System.Windows.Forms.StatusStrip();
            this.connectionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.identificationTab = new System.Windows.Forms.TabPage();
            this.CheckQrManualBtm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckQrManualTxb = new System.Windows.Forms.TextBox();
            this.qr_dataList = new System.Windows.Forms.ListBox();
            this.PrintPageTab = new System.Windows.Forms.TabPage();
            this.RefreshDictionary = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dictionaryTreeOnPrintTab = new System.Windows.Forms.TreeView();
            this.DataBasePageTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.DataBaseCollectionListBox = new System.Windows.Forms.ListBox();
            this.addDabaseBtn = new System.Windows.Forms.Button();
            this.RefreshDbBtn = new System.Windows.Forms.Button();
            this.NewDataBaseNameTxb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStripBar.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.identificationTab.SuspendLayout();
            this.PrintPageTab.SuspendLayout();
            this.DataBasePageTab.SuspendLayout();
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
            // RefreshDictionary
            // 
            this.RefreshDictionary.Location = new System.Drawing.Point(85, 7);
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
            this.dictionaryTreeOnPrintTab.Size = new System.Drawing.Size(172, 446);
            this.dictionaryTreeOnPrintTab.TabIndex = 0;
            // 
            // DataBasePageTab
            // 
            this.DataBasePageTab.Controls.Add(this.label4);
            this.DataBasePageTab.Controls.Add(this.NewDataBaseNameTxb);
            this.DataBasePageTab.Controls.Add(this.RefreshDbBtn);
            this.DataBasePageTab.Controls.Add(this.addDabaseBtn);
            this.DataBasePageTab.Controls.Add(this.label3);
            this.DataBasePageTab.Controls.Add(this.DataBaseCollectionListBox);
            this.DataBasePageTab.Location = new System.Drawing.Point(4, 22);
            this.DataBasePageTab.Name = "DataBasePageTab";
            this.DataBasePageTab.Size = new System.Drawing.Size(943, 488);
            this.DataBasePageTab.TabIndex = 2;
            this.DataBasePageTab.Text = "БазаДанных";
            this.DataBasePageTab.UseVisualStyleBackColor = true;
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
            // DataBaseCollectionListBox
            // 
            this.DataBaseCollectionListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DataBaseCollectionListBox.FormattingEnabled = true;
            this.DataBaseCollectionListBox.Location = new System.Drawing.Point(8, 35);
            this.DataBaseCollectionListBox.Name = "DataBaseCollectionListBox";
            this.DataBaseCollectionListBox.Size = new System.Drawing.Size(172, 381);
            this.DataBaseCollectionListBox.TabIndex = 0;
            // 
            // addDabaseBtn
            // 
            this.addDabaseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addDabaseBtn.Location = new System.Drawing.Point(8, 453);
            this.addDabaseBtn.Name = "addDabaseBtn";
            this.addDabaseBtn.Size = new System.Drawing.Size(172, 23);
            this.addDabaseBtn.TabIndex = 2;
            this.addDabaseBtn.Text = "Добавить базу";
            this.addDabaseBtn.UseVisualStyleBackColor = true;
            this.addDabaseBtn.Click += new System.EventHandler(this.addDabaseBtn_Click);
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
            // NewDataBaseNameTxb
            // 
            this.NewDataBaseNameTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewDataBaseNameTxb.Location = new System.Drawing.Point(75, 427);
            this.NewDataBaseNameTxb.Name = "NewDataBaseNameTxb";
            this.NewDataBaseNameTxb.Size = new System.Drawing.Size(105, 20);
            this.NewDataBaseNameTxb.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Имя базы:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 536);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.statusStripBar);
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
            this.DataBasePageTab.ResumeLayout(false);
            this.DataBasePageTab.PerformLayout();
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
        private System.Windows.Forms.ListBox DataBaseCollectionListBox;
        private System.Windows.Forms.Button addDabaseBtn;
        private System.Windows.Forms.Button RefreshDbBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NewDataBaseNameTxb;
    }
}

