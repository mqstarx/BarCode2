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
                    if (di.KeyValues != null && !di.Is_date && di.IsDbProduct)
                        ProduktTypeCmb.Items.Add(di);
                }
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if( typeDataCmbx.SelectedIndex!=-1 && ProduktTypeCmb.SelectedIndex!=-1 && ProduktValueCmb.SelectedIndex!=-1)
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

        private void ProduktTypeCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ProduktTypeCmb.SelectedIndex!=-1)
            {
                DictionaryItem di =(DictionaryItem)ProduktTypeCmb.SelectedItem;
                if (di.KeyValues != null)
                {
                    foreach (ArrayItem ar in di.KeyValues)
                    {
                        ProduktValueCmb.Items.Add(ar);
                    }
                }
            }
        }
    }
}
