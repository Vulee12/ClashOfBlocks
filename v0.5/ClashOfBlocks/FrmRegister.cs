﻿using System;
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
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
            txtBoxName.MaxLength = 16;
            txtBoxPass.MaxLength = 16;
            txtBoxRePass.MaxLength = 16;
            txtBoxEmail.MaxLength = 50;
            lblCoins.Hide();
            lblNKupljeno.Hide();
            lblNivo.Hide();
        }

        private void TxtBoxName_Leave(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select * from [dbo].[UserRegistration] where Uname='" + txtBoxName.Text + "'";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sqlcomm.ExecuteNonQuery();

            System.Text.RegularExpressions.Regex rName = new System.Text.RegularExpressions.Regex(@"^([a-zA-Z0-9]*)$");
            if (txtBoxName.TextLength < 4)
            {
                MessageBox.Show("Ime mora imati minimum 4 karaktera");
                txtBoxName.Focus();
                return;
            }
            else if (!rName.IsMatch(txtBoxName.Text))
            {
                MessageBox.Show("Ime nije validno");
                txtBoxName.Focus();
                return;
            }
            else if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Uneti username vec postoji");
                txtBoxName.Focus();
                return;
            }
        }

        private void TxtBoxPass_Leave(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex rPass = new System.Text.RegularExpressions.Regex(@"^([a-zA-Z0-9]*)$");
            if (txtBoxPass.TextLength < 4)
            {
                MessageBox.Show("Sifra mora imati minimum 4 karaktera");
                txtBoxPass.Focus();
                return;
            }
            else if (!rPass.IsMatch(txtBoxPass.Text))
            {
                MessageBox.Show("Sifra nije validna");
                txtBoxPass.Focus();
                return;
            }
        }

        private void TxtBoxRePass_Leave(object sender, EventArgs e)
        {
            if (txtBoxPass.Text != txtBoxRePass.Text)
            {
                MessageBox.Show("Sifre se ne podudaraju");
                txtBoxRePass.Focus();
                return;
            }
        }

        private void TxtBoxEmail_Leave(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select * from [dbo].[UserRegistration] where Email='" + txtBoxEmail.Text + "'";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sqlcomm.ExecuteNonQuery();

            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (!rEmail.IsMatch(txtBoxEmail.Text))
            {
                MessageBox.Show("Email nije validan");
                txtBoxEmail.Focus();
                return;
            }
            else if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Uneti Email vec postoji");
                txtBoxEmail.Focus();
                return;
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (txtBoxName.TextLength < 4 || txtBoxPass.TextLength < 4 || txtBoxPass.Text != txtBoxRePass.Text || txtBoxEmail.Text == "")
            {
                MessageBox.Show("Greska pri registrovanju");
                txtBoxName.Focus();
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show("Da li ste sigurni da zelite da napravite akaunt", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Cancel)
                {
                    txtBoxName.Select();
                    return;
                }
                else if (dr == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                    SqlConnection sqlconn = new SqlConnection(mainconn);
                    string sqlquery = "insert into [dbo].[UserRegistration] values (@Uname, @Upass, @Urepass, @Email, @Coins, @Pack1, @Pack2, @Level)";
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                    sqlcomm.Parameters.AddWithValue("@Uname", txtBoxName.Text);
                    sqlcomm.Parameters.AddWithValue("@Upass", txtBoxPass.Text);
                    sqlcomm.Parameters.AddWithValue("@Urepass", txtBoxRePass.Text);
                    sqlcomm.Parameters.AddWithValue("@Email", txtBoxEmail.Text);
                    sqlcomm.Parameters.AddWithValue("@Coins", Convert.ToInt32(lblCoins.Text));
                    sqlcomm.Parameters.AddWithValue("@Pack1", lblNKupljeno.Text);
                    sqlcomm.Parameters.AddWithValue("@Pack2", lblNKupljeno.Text);
                    sqlcomm.Parameters.AddWithValue("@Level", Convert.ToInt32(lblNivo.Text));
                    sqlcomm.ExecuteNonQuery();
                    sqlconn.Close();
                    this.Close();
                }
            }
        }
    }
}
