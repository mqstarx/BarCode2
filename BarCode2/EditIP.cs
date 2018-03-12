using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarCode2
{
    public partial class EditIP : Form
    {
        public EditIP()
        {
            InitializeComponent();
          
        }

        private void OK_Btn_Click(object sender, EventArgs e)
        {
          
            if (IpTxb.Text.Length > 0)
            {
                IPAddress ipAddress;
                if (IPAddress.TryParse(IpTxb.Text, out ipAddress))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неверный ip");
                }
               
            }
        }
    }
}
