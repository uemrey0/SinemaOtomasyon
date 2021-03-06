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

namespace SinemaOtomasyon
{
    public partial class Form1 : Form
    {
        //Sql connection global vars
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        String conString = Connection.connString;

        //debug mod on
        public static bool debug = false;
        public Form1()
        {
            InitializeComponent();
            if (debug)
            {
                lblDebug.Visible = true;
            }
        }
        
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Fast login for debug mode
            if (debug)
            {
                this.Hide();
                MainPage newForm = new MainPage();
                newForm.Show();
                return;
            }
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (username != "" && password != "")
            {
                con = new SqlConnection(conString);
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM user_info WHERE username = '" + username + "' AND password = '" + password + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    this.Hide();
                    MainPage newForm = new MainPage();
                    newForm.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şidre hatalı", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Boş alan bırakmayınız", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, new EventArgs());
            }

        }

        //Kontrol butonları
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        //Panel ile hareket ettirme
        bool move;
        int mvX, mvY;
        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mvX = e.X;
            mvY = e.Y;
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X-mvX, MousePosition.Y-mvY);
            }
        }

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
    }
}
