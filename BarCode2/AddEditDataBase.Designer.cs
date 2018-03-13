namespace BarCode2
{
    partial class AddEditDataBase
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.typeDataCmbx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.OkBtn = new System.Windows.Forms.Button();
            this.ProduktTypeCmb = new System.Windows.Forms.ComboBox();
            this.ProduktValueCmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ProduktValueCmb);
            this.groupBox1.Controls.Add(this.ProduktTypeCmb);
            this.groupBox1.Controls.Add(this.typeDataCmbx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cancelBtn);
            this.groupBox1.Controls.Add(this.OkBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные базы";
            // 
            // typeDataCmbx
            // 
            this.typeDataCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeDataCmbx.FormattingEnabled = true;
            this.typeDataCmbx.Location = new System.Drawing.Point(144, 122);
            this.typeDataCmbx.Name = "typeDataCmbx";
            this.typeDataCmbx.Size = new System.Drawing.Size(327, 21);
            this.typeDataCmbx.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Тип данных \r\nсерийного номера:";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(396, 173);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(306, 173);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 0;
            this.OkBtn.Text = "ОК";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // ProduktTypeCmb
            // 
            this.ProduktTypeCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProduktTypeCmb.FormattingEnabled = true;
            this.ProduktTypeCmb.Location = new System.Drawing.Point(144, 27);
            this.ProduktTypeCmb.Name = "ProduktTypeCmb";
            this.ProduktTypeCmb.Size = new System.Drawing.Size(327, 21);
            this.ProduktTypeCmb.TabIndex = 6;
            this.ProduktTypeCmb.SelectedIndexChanged += new System.EventHandler(this.ProduktTypeCmb_SelectedIndexChanged);
            // 
            // ProduktValueCmb
            // 
            this.ProduktValueCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProduktValueCmb.FormattingEnabled = true;
            this.ProduktValueCmb.Location = new System.Drawing.Point(144, 72);
            this.ProduktValueCmb.Name = "ProduktValueCmb";
            this.ProduktValueCmb.Size = new System.Drawing.Size(327, 21);
            this.ProduktValueCmb.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Тип записи \r\nнаименования изделия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Значение наименования\r\nизделия";
            // 
            // AddEditDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 237);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditDataBase";
            this.ShowIcon = false;
            this.Text = "AddEditDataBase";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button OkBtn;
        public System.Windows.Forms.ComboBox typeDataCmbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox ProduktValueCmb;
        public System.Windows.Forms.ComboBox ProduktTypeCmb;
    }
}