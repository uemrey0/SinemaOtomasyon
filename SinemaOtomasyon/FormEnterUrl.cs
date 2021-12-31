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
    public partial class FormEnterUrl : Form
    {
        public string imgUrl;
        
        public FormEnterUrl()
        {
            InitializeComponent();
            textBox1.Text = imgUrl;
        }
        
        private void buttonURL_Click(object sender, EventArgs e)
        {
            imgUrl = textBox1.Text;
            textBox1.Text = "";
            this.Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            this.Hide();
        }
    }
}
