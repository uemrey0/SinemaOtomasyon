using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyon
{
    public partial class FormSplash : Form
    {
        public FormSplash()
        {
            InitializeComponent();
        }
        //Form ile hareket ettirme
        bool move;
        int mvX, mvY;

        private void FormSplash_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mvX = e.X;
            mvY = e.Y;
        }

        private void FormSplash_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mvX, MousePosition.Y - mvY);
            }
        }

        private void FormSplash_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
    }
    
    
    
}
