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
    public partial class FrmRegister : Form
    {
        private Account acc = new Account("", "");

        public Account Acc
        {
            get
            {
                return acc;
            }
            set
            {
                acc = value;
            }
        }
        public FrmRegister()
        {
            InitializeComponent();
            this.AcceptButton = btnRegister;
            txtBoxPass.PasswordChar = '*';
            txtBoxPassRpt.PasswordChar = '*';
            txtBoxName.MaxLength = 16;
            txtBoxPass.MaxLength = 16;
            txtBoxPassRpt.MaxLength = 16;
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if(txtBoxName.TextLength >= 4 && txtBoxPass.TextLength >= 4 && txtBoxPassRpt.TextLength >= 4)
            {
                if (txtBoxPass.Text == txtBoxPassRpt.Text)
                {
                    DialogResult dr = MessageBox.Show("Da li ste sigurni da zelite da napravite akaunt sa parametrima: " + txtBoxName.Text + " / " + txtBoxPass.Text + "?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.Cancel)
                    {
                        txtBoxName.Select();
                        return;
                    }
                    else if (dr == DialogResult.OK)
                    {
                        this.DialogResult = DialogResult.OK;
                        acc.Username = txtBoxName.Text;
                        acc.Password = txtBoxPass.Text;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Sifre se ne podudaraju", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxPassRpt.Select();
                }
            }
            else
            {
                MessageBox.Show("Ime i sifra moraju imati 4 ili vise karaktera", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (txtBoxName.TextLength < 4)
                {
                    txtBoxName.Select();
                }
                else if (txtBoxPass.TextLength < 4)
                {
                    txtBoxPass.Select();
                }
            }
        }
    }
}
