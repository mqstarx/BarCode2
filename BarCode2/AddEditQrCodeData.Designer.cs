namespace BarCode2
{
    partial class AddEditQrCodeData
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
            this.groupBoxLabel = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ValueTxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.OkBtn = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBoxLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLabel
            // 
            this.groupBoxLabel.Controls.Add(this.dateTimePicker);
            this.groupBoxLabel.Controls.Add(this.label2);
            this.groupBoxLabel.Controls.Add(this.ValueTxb);
            this.groupBoxLabel.Controls.Add(this.label1);
            this.groupBoxLabel.Controls.Add(this.cancelBtn);
            this.groupBoxLabel.Controls.Add(this.OkBtn);
            this.groupBoxLabel.Location = new System.Drawing.Point(12, 12);
            this.groupBoxLabel.Name = "groupBoxLabel";
            this.groupBoxLabel.Size = new System.Drawing.Size(378, 160);
            this.groupBoxLabel.TabIndex = 0;
            this.groupBoxLabel.TabStop = false;
            this.groupBoxLabel.Text = "Ввод значения :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дата:";
            // 
            // ValueTxb
            // 
            this.ValueTxb.Location = new System.Drawing.Point(77, 42);
            this.ValueTxb.Name = "ValueTxb";
            this.ValueTxb.Size = new System.Drawing.Size(284, 20);
            this.ValueTxb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Значение:";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(297, 131);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(191, 131);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 0;
            this.OkBtn.Text = "ОК";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Location = new System.Drawing.Point(77, 87);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(284, 20);
            this.dateTimePicker.TabIndex = 5;
            // 
            // AddEditQrCodeData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 180);
            this.Controls.Add(this.groupBoxLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditQrCodeData";
            this.ShowIcon = false;
            this.Text = "Вввести/Изменить значение";
            this.groupBoxLabel.ResumeLayout(false);
            this.groupBoxLabel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button OkBtn;
        public System.Windows.Forms.TextBox ValueTxb;
        public System.Windows.Forms.DateTimePicker dateTimePicker;
        public System.Windows.Forms.GroupBox groupBoxLabel;
    }
}