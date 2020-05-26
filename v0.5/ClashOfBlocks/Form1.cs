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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
            txtBoxName.MaxLength = 16;
            txtBoxPass.MaxLength = 16;
        }
        public static string Username = "";
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            FrmRegister frm = new FrmRegister();
            if (frm.ShowDialog() != DialogResult.OK)
                return;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select * from [dbo].[UserRegistration] where Uname=@Uname and Upass=@Upass";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.Parameters.AddWithValue("@Uname", txtBoxName.Text);
            sqlcomm.Parameters.AddWithValue("@Upass", txtBoxPass.Text);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sqlcomm.ExecuteNonQuery();
            if (dt.Rows.Count > 0)
            {
                Username = txtBoxName.Text;
                FrmIgra frm = new FrmIgra();
                frm.ShowDialog();
                this.Close();
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
