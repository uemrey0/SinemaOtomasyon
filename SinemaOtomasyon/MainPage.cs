using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace SinemaOtomasyon
{
    public partial class MainPage : Form
    {
        private IconButton currentButton;
        private Panel leftBorderButton;
        private Form currnetChildForm;

        public MainPage()
        {
            
            InitializeComponent();
            leftBorderButton = new Panel();
            leftBorderButton.Size = new Size(7, 50);
            pnlMenu.Controls.Add(leftBorderButton);
            OpenChildForm(new FormHome());
            btnHome_Click(btnHome, new EventArgs());
            
        }
        public void StartSplash()
        {
            Application.Run(new FormSplash());
        }
        private void ActicateButton(object senderBtn)
        {
            if(senderBtn != null)
            {
                DisableButton();
                currentButton = (IconButton)senderBtn;
                currentButton.BackColor = Color.FromArgb(232, 246, 239);
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;
                //left border button
                leftBorderButton.BackColor = Color.FromArgb(235, 149, 132);
                leftBorderButton.Location = new Point(0, currentButton.Location.Y);
                leftBorderButton.Visible = true;
                leftBorderButton.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentButton.IconChar;
            }
        }

        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(184, 223, 216);
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }

        public void OpenChildForm(Form childForm)
        {
            if(currnetChildForm != null)
            {
                currnetChildForm.Close();
            }
            currnetChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlDesktop.Controls.Add(childForm);
            pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
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
                this.SetDesktopLocation(MousePosition.X - mvX, MousePosition.Y - mvY);
            }
        }

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActicateButton(sender);
            OpenChildForm(new FormHome());
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            ActicateButton(sender);
            OpenChildForm(new FormTicket());
        }

        private void btnMovie_Click(object sender, EventArgs e)
        {
            ActicateButton(sender);
            OpenChildForm(new FormMovies());
        }

        private void pictureLogo_Click(object sender, EventArgs e)
        {
            DisableButton();
            leftBorderButton.Visible = false;
            OpenChildForm(new FormHome());
            iconCurrentChildForm.IconChar = IconChar.HandPointRight;
        }
    }
}
