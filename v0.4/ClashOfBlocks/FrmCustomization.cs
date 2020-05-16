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
    public partial class FrmCustomization : Form
    { 
        public FrmCustomization()
        {
            InitializeComponent();
            lblPack.Text = FrmIgra.Info;
        }

        private void BtnPack1_Click(object sender, EventArgs e)
        {
            FrmIgra.b1 = Brushes.Blue;
            FrmIgra.b2 = Brushes.DarkOrange;
            lblPack.Text = "Standardni pack";
            FrmIgra.Info = "Standardni pack";
        }

        private void BtnPack2_Click(object sender, EventArgs e)
        {
            FrmIgra.b1 = Brushes.Green;
            FrmIgra.b2 = Brushes.Red;
            lblPack.Text = "Pack 1";
            FrmIgra.Info = "Pack 1";
        }

        private void BtnPack3_Click(object sender, EventArgs e)
        {
            FrmIgra.b1 = Brushes.Purple;
            FrmIgra.b2 = Brushes.Yellow;
            lblPack.Text = "Pack 2";
            FrmIgra.Info = "Pack 2";
        }
    }
}
