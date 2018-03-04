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
    public partial class AddEditDataBase : Form
    {
        private Dictionary m_DictDb;
        public AddEditDataBase()
        {
            InitializeComponent();
        }

        public Dictionary DictDb
        {            
            set
            {
                m_DictDb = value;
                foreach(DictionaryItem di in m_DictDb.DictionaryDataBase)
                {
                    //если значение вводимое и не является датой
                    if (di.KeyValues == null && !di.Is_date && di.IsSerialDb)
                        typeDataCmbx.Items.Add(di);
                }
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if(db_nameTxb.Text.Length>0 && typeDataCmbx.SelectedIndex!=-1)
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
