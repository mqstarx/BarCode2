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
    public partial class QrCodeInfo : Form
    {
        public QrCodeInfo(List<string> qrData)
        {
            InitializeComponent();
            qrInfoListBox.Items.AddRange(qrData.ToArray());
        }
    }
}
