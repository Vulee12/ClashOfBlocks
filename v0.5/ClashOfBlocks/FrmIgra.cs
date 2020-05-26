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
        public static Brush b1 = Brushes.Blue;
        public static Brush b2 = Brushes.DarkOrange;
        public static string Info = "Standardni pack";
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

        private void PicBoxSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.ShowDialog();
        }

        private void FrmIgra_Load(object sender, EventArgs e)
        {
            this.Text = "Dobrodosli nazad " + FrmLogin.Username;
        }

        private void BtnShop_Click(object sender, EventArgs e)
        {
            FrmShop frm = new FrmShop();
            frm.ShowDialog();
        }
    }
}
