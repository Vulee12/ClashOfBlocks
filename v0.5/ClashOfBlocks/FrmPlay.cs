using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ClashOfBlocks
{
    public partial class FrmPlay : Form
    {
        Teren teren = new Teren();
        Graphics g;
        public FrmPlay()
        {
            InitializeComponent();
            teren.Generisi();
            picBoxZv1.Hide();
            picBoxZv2.Hide();
            picBoxZv3.Hide();
            btnRetry.Hide();
            btnNext.Hide();

            RacunanjeCoinsa();

            RacunanjeLevela();
        }

        private static int Procenti = 0;
        
        private void RacunanjeLevela()
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
                lblNivo.Text = sqr.GetValue(8).ToString();
            }
            sqlconn.Close();
        }
        
        private void Level()
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "update [dbo].[UserRegistration] set Level+='" + 0.5 + "' where Uname='" + FrmLogin.Username + "'";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sqlcomm.ExecuteNonQuery();
            sqlconn.Close();
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

        public void IscrtajTeren()
        {
            g = pnlTeren.CreateGraphics();
            for (int i = 0; i < teren.Mapa.GetLength(0); i++)
            {
                for (int j = 0; j < teren.Mapa.GetLength(0); j++)
                {
                    switch (teren.Mapa[i, j])
                    {
                        case 0:
                            g.FillRectangle(Brushes.SaddleBrown, 1 + i * pnlTeren.Width / teren.Mapa.GetLength(0), 1 + j * pnlTeren.Height / teren.Mapa.GetLength(0), pnlTeren.Width / teren.Mapa.GetLength(0) - 2,
                                pnlTeren.Height / teren.Mapa.GetLength(0) - 2);
                            break;
                        case 1:
                            g.FillRectangle(Brushes.LightGray, 1 + i * pnlTeren.Width / teren.Mapa.GetLength(0), 1 + j * pnlTeren.Height / teren.Mapa.GetLength(0), pnlTeren.Width / teren.Mapa.GetLength(0) - 2,
                                pnlTeren.Height / teren.Mapa.GetLength(0) - 2);
                            break;
                        case 2:
                            g.FillRectangle(FrmIgra.b1, 1 + i * pnlTeren.Width / teren.Mapa.GetLength(0), 1 + j * pnlTeren.Height / teren.Mapa.GetLength(0), pnlTeren.Width / teren.Mapa.GetLength(0) - 2,
                               pnlTeren.Height / teren.Mapa.GetLength(0) - 2);
                            break;
                        case 3:
                            g.FillRectangle(FrmIgra.b2, 1 + i * pnlTeren.Width / teren.Mapa.GetLength(0), 1 + j * pnlTeren.Height / teren.Mapa.GetLength(0), pnlTeren.Width / teren.Mapa.GetLength(0) - 2,
                               pnlTeren.Height / teren.Mapa.GetLength(0) - 2);
                            break;
                    }
                }
            }
        }
        private void pnlTeren_Paint(object sender, PaintEventArgs e)
        {
            IscrtajTeren();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            int counter = 0;
            for (int i = 0; i < teren.Mapa.GetLength(0); i++)
            {
                for (int j = 0; j < teren.Mapa.GetLength(0); j++)
                {
                    if (teren.Mapa[i, j] == 2)
                        counter++;
                }
            }
            if (counter > 0)
            {
                timerSirenje.Start();
                btnStart.Hide();
            }

        }

        private void TimerSirenje_Tick(object sender, EventArgs e)
        {
            int counterEmpty = 0, counterPlayer = 0, counterEnemy = 0;
            for (int i = 0; i < teren.Mapa.GetLength(0); i++)
            {
                for (int j = 0; j < teren.Mapa.GetLength(0); j++)
                {
                    if (teren.Mapa[i, j] == 1)
                        counterEmpty++;
                    else if (teren.Mapa[i, j] == 2)
                        counterPlayer++;
                    else if (teren.Mapa[i, j] == 3)
                        counterEnemy++;
                }
            }
            if (counterEmpty > 0)
            {
                teren.Prosiri();
                IscrtajTeren();
            }
            else
            {
                timerSirenje.Stop();
                btnReset.Hide();
                lblProcenat.Show();
                lblStat.Show();
                int sum = counterEnemy + counterPlayer;
                int playerProcenat = Convert.ToInt32(((double)counterPlayer / sum) * 100);
                Procenti = playerProcenat;
                if (playerProcenat >= 50)
                {
                    picBoxZv1.Show();
                    if (playerProcenat >= 65)
                    {
                        picBoxZv2.Show();
                        if (playerProcenat >= 82)
                        {
                            picBoxZv3.Show();
                        }
                    }
                    btnRetry.Show();
                    btnNext.Show();
                    lblStat.Text = "Level uspesno predjen";
                    lblProcenat.Text = playerProcenat.ToString() + "%";
                }
                else
                {
                    lblStat.Text = "Niste presli ovaj level";
                    lblProcenat.Text = playerProcenat.ToString() + "%";
                    btnRetry.Show();
                }
            }

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            btnStart.Show();
            teren.Resetuj();
            timerSirenje.Stop();
            IscrtajTeren();
        }

        private void PnlTeren_MouseClick(object sender, MouseEventArgs e)
        {
            int counter = 0;
            for (int i = 0; i < teren.Mapa.GetLength(0); i++)
            {
                for (int j = 0; j < teren.Mapa.GetLength(0); j++)
                {
                    if (teren.Mapa[i, j] == 2)
                        counter++;
                }
            }
            if (counter > 0)
            {
                return;
            }
            for (int i = 0; i < teren.Mapa.GetLength(0); i++)
            {
                for (int j = 0; j < teren.Mapa.GetLength(0); j++)
                {
                    if (e.X - pnlTeren.Location.X > i * pnlTeren.Width / teren.Mapa.GetLength(0) && e.X - pnlTeren.Location.X < (i + 1) * pnlTeren.Width / teren.Mapa.GetLength(0))
                    {
                        if (e.Y - pnlTeren.Location.Y > j * pnlTeren.Width / teren.Mapa.GetLength(0) && e.Y - pnlTeren.Location.Y < (j + 1) * pnlTeren.Width / teren.Mapa.GetLength(0))
                        {
                            if (teren.Mapa[i, j] != 3 && teren.Mapa[i, j] != 0)
                                teren.Mapa[i, j] = 2;
                        }
                    }
                }
            }
            IscrtajTeren();
        }

        private void BtnRetry_Click(object sender, EventArgs e)
        {
            teren.Resetuj();
            timerSirenje.Stop();
            IscrtajTeren();
            btnRetry.Hide();
            lblProcenat.Hide();
            lblStat.Hide();
            lblProcenat.Text = "";
            lblStat.Text = "";
            lblProcenat.Show();
            lblStat.Show();
            btnReset.Show();
            picBoxZv1.Hide();
            picBoxZv2.Hide();
            picBoxZv3.Hide();
            btnNext.Hide();
            btnStart.Show();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            teren.Generisi();
            picBoxZv1.Hide();
            picBoxZv2.Hide();
            picBoxZv3.Hide();
            btnRetry.Hide();
            btnNext.Hide();
            lblProcenat.Hide();
            lblStat.Hide();
            btnReset.Show();
            btnStart.Show();
            g.Clear(Color.Black);
            IscrtajTeren();

            Level();
            RacunanjeLevela();

            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);

            if (Procenti >= 50 && Procenti < 65)
            {
                string sqlquery = "update [dbo].[UserRegistration] set Coins+='" + 25 + "' where Uname='" + FrmLogin.Username + "'";
                sqlconn.Open();
                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                sqlcomm.ExecuteNonQuery();
                sqlconn.Close();
            }
            if (Procenti >= 65 && Procenti < 82)
            {
                string sqlquery = "update [dbo].[UserRegistration] set Coins+='" + 50 + "' where Uname='" + FrmLogin.Username + "'";
                sqlconn.Open();
                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                sqlcomm.ExecuteNonQuery();
                sqlconn.Close();
            }
            if (Procenti >= 82)
            {
                string sqlquery = "update [dbo].[UserRegistration] set Coins+='" + 75 + "' where Uname='" + FrmLogin.Username + "'";
                sqlconn.Open();
                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                sqlcomm.ExecuteNonQuery();
                sqlconn.Close();
            }

            RacunanjeCoinsa();
        }
    }
}
