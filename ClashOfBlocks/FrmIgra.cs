using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClashOfBlocks
{
    public partial class FrmIgra : Form
    {
        public FrmIgra()
        {
            InitializeComponent();
            this.AcceptButton = btnPlay;
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            FrmPlay frm = new FrmPlay();
            frm.ShowDialog();
        }

        private void BtnShop_Click(object sender, EventArgs e)
        {
            FrmShop frm = new FrmShop();
            frm.ShowDialog();
        }
    }
}
