using DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarCode2
{
    public partial class AddEditQrCodeData : Form
    {
        private DictionaryItem m_DictionaryItem;

        public DictionaryItem DictionaryItem
        {
            get
            {
                return m_DictionaryItem;
            }

            set
            {
                m_DictionaryItem = value;
                ValueTxb.MaxLength = m_DictionaryItem.DataLen;
            }
        }

        public AddEditQrCodeData()
        {
            InitializeComponent();
           
        }

       

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if(ValueTxb.Text.Length>0 && ValueTxb.Text.Length==m_DictionaryItem.DataLen)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            if(dateTimePicker.Enabled && dateTimePicker.Value!=null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
