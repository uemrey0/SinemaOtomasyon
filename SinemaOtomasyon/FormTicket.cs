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
using System.Collections;

namespace SinemaOtomasyon
{
    public partial class FormTicket : Form
    {
        String conString = "Data Source=BOSS;Initial Catalog=sinema;Integrated Security=True";
        public static ArrayList selectedChair = new ArrayList();
        public static ArrayList cancelChair = new ArrayList();
        public static ArrayList studentCount = new ArrayList();
        public static ArrayList adultCount = new ArrayList();
        public static object movie_id;
        public static object salon_id;
        public static object session_id;
        public static int toplam = 0;
        FormSell dialog = new FormSell();
        public FormTicket()
        {
            InitializeComponent();
            ComboMovieLoad();
        }

        private void ComboMovieLoad() // filmlerin database den alınarak comboya eklenmesi
        {
            using (SqlConnection sqlConnection = new SqlConnection(conString))
            {
                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM movie_info", sqlConnection);
                sqlConnection.Open();
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                while (sqlReader.Read())
                {
                    comboMovie.Items.Add(sqlReader["name"].ToString());
                }

                sqlReader.Close();
            }
            if (comboMovie.Items.Count == 1)
            {
                comboMovie.SelectedIndex = 0;
            }
        }
        private void DisableChair() // bütün koltukların kapatılması
        {
            for(int i = 1; i<37; i++)
            {
                this.Controls.Find("button" + i.ToString(), true)[0].Enabled = false;
                this.Controls.Find("button" + i.ToString(), true)[0].BackColor = SystemColors.Control;
            }
        }
        private void ChairLoad() // satılan koltukların yüklenmesi ve aktifleştirilmesi
        {
            for (int i = 1; i< 37; i++)
            {
                this.Controls.Find("button" + i.ToString(), true)[0].Enabled = true;
            }

            using (SqlConnection sqlConnection = new SqlConnection(conString))
            {
                
                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM chair_info WHERE movie_id = '"+movie_id+"' AND session_id = '"+session_id+"' AND theater_id = '"+salon_id+"'", sqlConnection);
                sqlConnection.Open();
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                while (sqlReader.Read())
                { 
                    string koltuk_No = sqlReader["chair_id"].ToString();
                    this.Controls.Find("button" + koltuk_No, true)[0].BackColor = Color.Red;
                }

                sqlReader.Close();
            }
        }

        public string ChairFind(int btnNo) // buton no > koltuk no dönüştüröe
        {
            string chairNo;
            if (btnNo < 7)
            {
                if (btnNo % 6 == 0)
                {
                    chairNo = "A6";
                }
                else
                {
                    chairNo = "A" + btnNo % 6;
                };
            }
            else if (btnNo < 13)
            {
                if (btnNo % 6 == 0)
                {
                    chairNo = "B6";
                }
                else
                {
                    chairNo = "B" + btnNo % 6;
                };
            }
            else if (btnNo < 17)
            {
                if (btnNo % 6 == 0)
                {
                    chairNo = "C6";
                }
                else
                {
                    chairNo = "C" + btnNo % 6;
                };
            }
            else if (btnNo < 25)
            {
                if (btnNo % 6 == 0)
                {
                    chairNo = "D6";
                }
                else
                {
                    chairNo = "D" + btnNo % 6;
                };
            }
            else if (btnNo < 31)
            {
                if (btnNo % 6 == 0)
                {
                    chairNo = "E6";
                }
                else
                {
                    chairNo = "E" + btnNo % 6;
                };
            }
            else
            {
                if (btnNo % 6 == 0)
                {
                    chairNo = "F6";
                }
                else
                {
                    chairNo = "F" + btnNo % 6;
                };
            }
            return chairNo;
        }

        private void comboMovie_SelectedIndexChanged(object sender, EventArgs e) // combo movie seçim event
        {
            DisableChair();
            comboSalon.Items.Clear();
            comboSession.Items.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(conString))
            {
                string selectedName = this.comboMovie.GetItemText(this.comboMovie.SelectedItem);
                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM movie_info WHERE name = '" + selectedName+"'", sqlConnection);
                sqlConnection.Open();
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                while (sqlReader.Read())
                {
                    movie_id = sqlReader["id"].ToString();
                }

                sqlReader.Close();
            }
            using (SqlConnection sqlConnection = new SqlConnection(conString))
            {

                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM session_info WHERE movie_id = "+movie_id, sqlConnection);
                sqlConnection.Open();
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                while (sqlReader.Read())
                {
                    comboSession.Items.Add(sqlReader["time"].ToString());
                }

                sqlReader.Close();
            }

            if (comboMovie.Items.Count == 1)
            {
                comboSession.SelectedIndex = 0;
            }
        }

        private void comboSession_SelectedIndexChanged(object sender, EventArgs e) //combo session seçim event
        {
            DisableChair();
            comboSalon.Items.Clear();
            string selectedTime = this.comboSession.GetItemText(this.comboSession.SelectedItem);
            using (SqlConnection sqlConnection = new SqlConnection(conString))
            {

                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM session_info WHERE  movie_id = '" + movie_id + "' AND time = CAST('" + selectedTime + "' as TIME)", sqlConnection);
                sqlConnection.Open();
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                while (sqlReader.Read())
                {
                    session_id = sqlReader["id"].ToString();
                }

                sqlReader.Close();
            }
            using (SqlConnection sqlConnection = new SqlConnection(conString))
            {
                
                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM session_info WHERE  movie_id = '" + movie_id + "' AND time = CAST('"+selectedTime+"' as TIME)", sqlConnection);
                sqlConnection.Open();
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                while (sqlReader.Read())
                {
                    salon_id = sqlReader["salon_id"].ToString();
                }

                sqlReader.Close();
            }
            using (SqlConnection sqlConnection = new SqlConnection(conString))
            {

                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM theater_info WHERE id = '" + salon_id.ToString() +"'", sqlConnection);
                sqlConnection.Open();
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                while (sqlReader.Read())
                {
                    comboSalon.Items.Add(sqlReader["name"].ToString());
                }

                sqlReader.Close();
            }
            if(comboSalon.Items.Count == 1)
            {
                comboSalon.SelectedIndex = 0;
            }
        }

        private void comboSalon_SelectedIndexChanged(object sender, EventArgs e) // salon combo seçim event
        {
            ChairLoad();
        }

        private void buttonChair_click(object sender, EventArgs e) // koltuk butonları click event
        {
            if (((Button)sender).BackColor == SystemColors.Control) // control

            {
                int btnNo = Convert.ToInt32(((Button)sender).Name.Remove(0, 6));
                dialog.ShowDialog();
                if (dialog.isStudent)
                {
                    studentCount.Add(((Button)sender).Name);
                    lblStudent.Text = studentCount.Count.ToString();
                    lblTop.Text = studentCount.Count*23
                }
                else
                {
                    adultCount.Add(((Button)sender).Name);
                    lblAdult.Text = adultCount.Count.ToString();
                }
                if (cancelChair.Count == 0 && !selectedChair.Contains(((Button)sender).Name))

                {
                    ((Button)sender).BackColor = Color.Green;
                    selectedChair.Add(((Button)sender).Name);
                }
            }

            else if (((Button)sender).BackColor == Color.Green) // yeşil

            {
                int btnNo = Convert.ToInt32(((Button)sender).Name.Remove(0, 6));
                if (studentCount.Contains(((Button)sender).Name))
                {
                    studentCount.Remove(((Button)sender).Name);
                    lblStudent.Text = studentCount.Count.ToString();
                }
                else
                {
                    adultCount.Remove(((Button)sender).Name);
                    lblAdult.Text = adultCount.Count.ToString();

                }
                ((Button)sender).BackColor = SystemColors.Control;

                if (selectedChair.Contains(((Button)sender).Name))

                {

                    selectedChair.Remove(((Button)sender).Name);

                }
            }
            else if (((Button)sender).BackColor == Color.Orange)// turuncu
            {
                
                int btnNo = Convert.ToInt32(((Button)sender).Name.Remove(0, 6));
                if (cancelChair.Contains(btnNo))
                {
                    ((Button)sender).BackColor = Color.Red;
                    cancelChair.Remove(btnNo);
                }
            }
            else // kırmızı
            {   
                int btnNo = Convert.ToInt32(((Button)sender).Name.Remove(0, 6));
                if (!cancelChair.Contains(btnNo) && selectedChair.Count == 0)
                {
                    ((Button)sender).BackColor = Color.Orange;
                    cancelChair.Add(btnNo);
                }
            }
            //hangi button aktif olacak
            if (selectedChair.Count != 0 && selectedChair != null)
            {
                buttonSell.Enabled = true;
            }
            else
            {
                buttonSell.Enabled = false;
            }
            if (cancelChair.Count != 0 && cancelChair != null)
            {
                buttonCancel.Enabled = true;
            }else
            {
                buttonCancel.Enabled = false;
            }
        }

        private void buttonSell_Click(object sender, EventArgs e) //satiş butonu click event
        {
            if(selectedChair != null && selectedChair.Count != 0)
            {
                foreach (var item in selectedChair)
                {
                    string btnName = item.ToString();
                    int btnNo = Convert.ToInt32(btnName.Remove(0, 6));
                    try
                    {
                        SqlConnection sqlConnection = new SqlConnection(conString);
                        SqlCommand sqlCmd = new SqlCommand("INSERT INTO chair_info (movie_id,session_id,theater_id,chair_id) VALUES ('"+movie_id+"','"+session_id+"','"+salon_id+"','"+btnNo+"')", sqlConnection);
                        sqlConnection.Open();
                        sqlCmd.ExecuteNonQuery();
                        sqlConnection.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                DisableChair();
                comboMovie.SelectedItem = null;
                selectedChair.Clear();
                buttonSell.Enabled = false;
            }
            else
            {
                MessageBox.Show("En az bir koltuk seçmeniz gerekmektedir!");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e) //iptal butonu click event
        {
            if(cancelChair != null && cancelChair.Count != 0)
            {
                foreach (var item in cancelChair)
                {
                    DialogResult dialogResult = MessageBox.Show(ChairFind(Convert.ToInt32(item)) + " Koltuk numarasını iptal etmek istediğinize emin misiniz?", "İptal?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            SqlConnection sqlConnection = new SqlConnection(conString);
                            SqlCommand sqlCmd = new SqlCommand("DELETE FROM chair_info WHERE movie_id = '" + movie_id + "' AND session_id = '" + session_id + "' AND theater_id = '" + salon_id + "' AND chair_id = '" + Convert.ToInt32(item) + "'", sqlConnection);
                            sqlConnection.Open();
                            sqlCmd.ExecuteNonQuery();
                            sqlConnection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
                DisableChair();
                cancelChair.Clear();
                buttonCancel.Enabled = false;
            }
        }
    }
}
