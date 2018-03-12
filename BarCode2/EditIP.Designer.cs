namespace BarCode2
{
    partial class EditIP
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
            this.IpTxb = new System.Windows.Forms.MaskedTextBox();
            this.OK_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IpTxb
            // 
            this.IpTxb.Location = new System.Drawing.Point(12, 12);
            this.IpTxb.Name = "IpTxb";
            this.IpTxb.Size = new System.Drawing.Size(113, 20);
            this.IpTxb.TabIndex = 0;
            // 
            // OK_Btn
            // 
            this.OK_Btn.Location = new System.Drawing.Point(50, 38);
            this.OK_Btn.Name = "OK_Btn";
            this.OK_Btn.Size = new System.Drawing.Size(75, 23);
            this.OK_Btn.TabIndex = 1;
            this.OK_Btn.Text = "OK";
            this.OK_Btn.UseVisualStyleBackColor = true;
            this.OK_Btn.Click += new System.EventHandler(this.OK_Btn_Click);
            // 
            // EditIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(137, 62);
            this.Controls.Add(this.OK_Btn);
            this.Controls.Add(this.IpTxb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditIP";
            this.ShowIcon = false;
            this.Text = "IP адрес сервера";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OK_Btn;
        public System.Windows.Forms.MaskedTextBox IpTxb;
    }
}