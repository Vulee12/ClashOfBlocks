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
    public partial class FrmLogin : Form
    {
        public List<Account> akaunti = new List<Account>();
        public FrmLogin()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
            txtBoxPass.PasswordChar = '*';
            txtBoxName.MaxLength = 16;
            txtBoxPass.MaxLength = 16;
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            FrmRegister frm = new FrmRegister();
            if (frm.ShowDialog() != DialogResult.OK)
                return;
            akaunti.Add(new Account(frm.Acc.Username, frm.Acc.Password));
        }
        private bool Provera()
        {
            if (akaunti.Exists(x => x.Username == txtBoxName.Text && x.Password == txtBoxPass.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(Provera())
            {
                FrmIgra frm = new FrmIgra();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Greska pri unosu!", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (txtBoxName.Text == null || txtBoxName.Text == "")
                {
                    txtBoxName.Select();
                }
                else if (txtBoxPass.Text == null || txtBoxPass.Text == "")
                {
                    txtBoxPass.Select();
                }
                else
                {
                    txtBoxPass.Select();
                }
            }
        }
    }
}
