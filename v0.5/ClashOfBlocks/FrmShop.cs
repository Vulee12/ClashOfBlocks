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
    public partial class FrmShop : Form
    {
        public FrmShop()
        {
            InitializeComponent();
            lblPack.Text = FrmIgra.Info;

            RacunanjeCoinsa();

            if(Kupljeno1())
            {
                btnBuy1.Hide();
                lblPrice1.Hide();
            }

            if(Kupljeno2())
            {
                btnBuy2.Hide();
                lblPrice2.Hide();
            }
        }
        private bool Kupljeno1()
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select * from [dbo].[UserRegistration] where Uname='" + FrmLogin.Username + "' and Pack1='" + "Kupljeno" + "'";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sqlcomm.ExecuteNonQuery();
            sqlconn.Close();
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool Kupljeno2()
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select * from [dbo].[UserRegistration] where Uname='" + FrmLogin.Username + "' and Pack2='" + "Kupljeno" + "'";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sqlcomm.ExecuteNonQuery();
            sqlconn.Close();
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void RacunanjeCoinsa()
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select * from [dbo].[UserRegistration] where Uname=@Uname";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.Parameters.AddWithValue("@Uname", FrmLogin.Username);
            SqlDataReader sqr = sqlcomm.ExecuteReader();
            while (sqr.Read())
            {
                lblCoins.Text = sqr.GetValue(5).ToString();
            }
            sqlconn.Close();
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
            if(Kupljeno1())
            {
                FrmIgra.b1 = Brushes.Green;
                FrmIgra.b2 = Brushes.Red;
                lblPack.Text = "Pack 1";
                FrmIgra.Info = "Pack 1";
            }
            else
            {
                MessageBox.Show("Ovaj pack nije kupljen");
            }
        }

        private void BtnPack3_Click(object sender, EventArgs e)
        {
            if(Kupljeno2())
            {
                FrmIgra.b1 = Brushes.Purple;
                FrmIgra.b2 = Brushes.Yellow;
                lblPack.Text = "Pack 2";
                FrmIgra.Info = "Pack 2";
            }
            else
            {
                MessageBox.Show("Ovaj pack nije kupljen");
            }
        }


        private void BtnBuy1_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select * from [dbo].[UserRegistration] where Uname='" + FrmLogin.Username + "' and Coins >='" + 1500 + "'";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sqlcomm.ExecuteNonQuery();
            if (dt.Rows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Da li ste sigurni da zelite da kupite ovaj pack?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                else if (dr == DialogResult.OK)
                {
                    string mainconn1 = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                    SqlConnection sqlconn1 = new SqlConnection(mainconn1);
                    string sqlquery1 = "update [dbo].[UserRegistration] set Coins-='" + 1500 + "', Pack1='" + "Kupljeno" + "' where Uname='" + FrmLogin.Username + "'";
                    sqlconn1.Open();
                    SqlCommand sqlcomm1 = new SqlCommand(sqlquery1, sqlconn1);
                    SqlDataAdapter sda1 = new SqlDataAdapter(sqlcomm1);
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);
                    sqlcomm.ExecuteNonQuery();
                    sqlconn1.Close();
                    RacunanjeCoinsa();
                    btnBuy1.Hide();
                    lblPrice1.Hide();
                }
            }
            else
            {
                MessageBox.Show("Nemate dovoljno para");
            }
            sqlconn.Close();
        }

        private void BtnBuy2_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select * from [dbo].[UserRegistration] where Uname='" + FrmLogin.Username + "' and Coins >='" + 3000 + "'";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sqlcomm.ExecuteNonQuery();
            if (dt.Rows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Da li ste sigurni da zelite da kupite ovaj pack?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                else if (dr == DialogResult.OK)
                {
                    string mainconn1 = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                    SqlConnection sqlconn1 = new SqlConnection(mainconn1);
                    string sqlquery1 = "update [dbo].[UserRegistration] set Coins-='" + 3000 + "', Pack2='" + "Kupljeno" + "' where Uname='" + FrmLogin.Username + "'";
                    sqlconn1.Open();
                    SqlCommand sqlcomm1 = new SqlCommand(sqlquery1, sqlconn1);
                    SqlDataAdapter sda1 = new SqlDataAdapter(sqlcomm1);
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);
                    sqlcomm.ExecuteNonQuery();
                    sqlconn1.Close();
                    RacunanjeCoinsa();
                    btnBuy2.Hide();
                    lblPrice2.Hide();
                }
            }
            else
            {
                MessageBox.Show("Nemate dovoljno para");
            }
            sqlconn.Close();
        }
    }
}
