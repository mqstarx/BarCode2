namespace BarCode2
{
    partial class QrCodeInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.qrInfoListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // qrInfoListBox
            // 
            this.qrInfoListBox.FormattingEnabled = true;
            this.qrInfoListBox.Location = new System.Drawing.Point(1, 1);
            this.qrInfoListBox.Name = "qrInfoListBox";
            this.qrInfoListBox.Size = new System.Drawing.Size(960, 563);
            this.qrInfoListBox.TabIndex = 0;
            // 
            // QrCodeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 566);
            this.Controls.Add(this.qrInfoListBox);
            this.MinimizeBox = false;
            this.Name = "QrCodeInfo";
            this.ShowIcon = false;
            this.Text = "Данный Qr-кода для записи";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox qrInfoListBox;
    }
}