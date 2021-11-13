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
        public Form1()
        {
            InitializeComponent();
        }
        
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        String conString = "Data Source=BOSS;Initial Catalog=sinema;Integrated Security=True";
        private void btnLogin_Click(object sender, EventArgs e)
        {
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
                    //Giriş başarılı
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
