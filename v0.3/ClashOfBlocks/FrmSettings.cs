using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ClashOfBlocks
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
            lblOPass.Hide();
            txtBoxOPass.Hide();
            lblNPass.Hide();
            txtBoxNPass.Hide();
            lblRePass.Hide();
            txtBoxRePass.Hide();
            btnOk.Hide();
        }

        private void BtnPassChng_Click(object sender, EventArgs e)
        {
            lblOPass.Show();
            txtBoxOPass.Show();
            lblNPass.Show();
            txtBoxNPass.Show();
            lblRePass.Show();
            txtBoxRePass.Show();
            btnOk.Show();
            txtBoxOPass.Select();
        }

        private void TxtBoxOPass_Leave(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select * from [dbo].[UserRegistration] where Uname='" + FrmLogin.Username + "' and Upass='" + txtBoxOPass.Text + "'";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sqlcomm.ExecuteNonQuery();
            if (!(dt.Rows.Count > 0))
            {
                MessageBox.Show("Uneta stara sifra je netacna", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxOPass.Focus();
            }
            sqlconn.Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "update [dbo].[UserRegistration] set Upass='"+ txtBoxNPass.Text +"', Urepass = '"+ txtBoxRePass.Text + "' where Uname='" + FrmLogin.Username + "'";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sqlcomm.ExecuteNonQuery();
            MessageBox.Show("Vasa sifra je promenjena");
            sqlconn.Close();
            this.Close();
        }

        private void TxtBoxNPass_Leave(object sender, EventArgs e)
        {
            if (txtBoxNPass.TextLength < 4)
            {
                MessageBox.Show("Sifra mora imati minimum 4 karaktera");
                txtBoxNPass.Focus();
                return;
            }
        }

        private void TxtBoxRePass_Leave(object sender, EventArgs e)
        {
            if (txtBoxNPass.Text != txtBoxRePass.Text)
            {
                MessageBox.Show("Sifre se ne podudaraju");
                txtBoxRePass.Focus();
                return;
            }
        }
    }
}
