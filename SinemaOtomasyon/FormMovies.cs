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
    public partial class FormMovies : Form
    {
        bool isNew = false;
        FormEnterUrl dialog = new FormEnterUrl();
        String conString = "Data Source=BOSS;Initial Catalog=sinema;Integrated Security=True";
        public FormMovies()
        {
            InitializeComponent();
            GridLoad();
        }

        private void GridLoad()
        {
            movieGrid.Rows.Clear();
            movieGrid.ReadOnly = true; // sadece okunabilir olması yani veri düzenleme kapalı
            movieGrid.AllowUserToDeleteRows = false; // satırların silinmesi engelleniyor
            movieGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            movieGrid.ColumnCount = 3; //Kaç kolon olacağı belirleniyor…
            movieGrid.Columns[0].Name = "ID";//Kolonların adı belirleniyor
            movieGrid.Columns[1].Name = "Name";
            using (SqlConnection sqlConnection = new SqlConnection(conString))
            {
                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM movie_info", sqlConnection);
                sqlConnection.Open();
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                while (sqlReader.Read())
                {
                    movieGrid.Rows.Add(sqlReader["id"], sqlReader["name"], "Sil");
                }
                sqlReader.Close();
            }
        }
        private void DeleteData(int id)
        {
            try 
            {
                SqlConnection sqlConnection = new SqlConnection(conString);
                SqlCommand sqlCmd = new SqlCommand("DELETE FROM movie_info WHERE id="+id, sqlConnection);
                sqlConnection.Open();
                sqlCmd.ExecuteNonQuery();
                sqlConnection.Close();
                GridLoad();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LoadData(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(conString))
            {
                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM movie_info WHERE id="+id, sqlConnection);
                sqlConnection.Open();
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                if (sqlReader.Read())
                {
                    txtName.Text = sqlReader["name"].ToString();
                    txtDirector.Text = sqlReader["director"].ToString();
                    comboType.SelectedIndex = Convert.ToInt32(sqlReader["type"]);
                    pictureBox.Load(sqlReader["image_url"].ToString());
                    dialog.imgUrl = sqlReader["image_url"].ToString();
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                sqlReader.Close();
            }
        }

        private void movieGrid_SelectionChanged(object sender, EventArgs e)
        {
            isNew = false;
            LoadData(int.Parse(movieGrid.CurrentRow.Cells[0].Value.ToString()));
        }

        private void buttonImage_Click(object sender, EventArgs e)
        {
            dialog.ShowDialog();
            pictureBox.Load(dialog.imgUrl);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (isNew)
            {
                using (SqlConnection sqlConnection = new SqlConnection(conString))
                {
                    SqlCommand sqlCmd = new SqlCommand("INSERT INTO movie_info (name,director,type,image_url) VALUES ('" + txtName.Text + "','" + txtDirector.Text + "','" + comboType.SelectedIndex + "','" + dialog.imgUrl + "')", sqlConnection);
                    sqlConnection.Open();
                    sqlCmd.ExecuteNonQuery();
                    sqlConnection.Close();
                }
            }
            else
            {
                using (SqlConnection sqlConnection = new SqlConnection(conString))
                {
                    SqlCommand sqlCmd = new SqlCommand("UPDATE movie_info SET name = '" + txtName.Text + "',director = '" + txtDirector.Text + "',type = '" + comboType.SelectedIndex + "',image_url = '" + dialog.imgUrl + "' WHERE id = '" + int.Parse(movieGrid.CurrentRow.Cells[0].Value.ToString()) +"'", sqlConnection);
                    sqlConnection.Open();
                    sqlCmd.ExecuteNonQuery();
                    sqlConnection.Close();
                }
            }
            GridLoad();
            isNew = false;
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            isNew = true;
            txtName.Text = "";
            txtDirector.Text = "";
            comboType.SelectedIndex = 0;
            pictureBox.Image = null;
        }

        private void movieGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (movieGrid.RowCount > 0)
            {
                if (e.ColumnIndex == 2)
                {
                    int id = int.Parse(movieGrid.CurrentRow.Cells[0].Value.ToString());//the primary key for your table.
                    DeleteData(id);
                }
            }
        }
    }
}
