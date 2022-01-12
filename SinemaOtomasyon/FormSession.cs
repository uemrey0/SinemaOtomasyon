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
    public partial class FormSession : Form
    {
        bool isNew = true;
        String conString = Connection.connString;
        public FormSession()
        {
            InitializeComponent();
            ComboLoad();
        }

        private void GridLoad()
        {
            sessionGrid.Rows.Clear();
            sessionGrid.ReadOnly = true; // sadece okunabilir olması yani veri düzenleme kapalı
            sessionGrid.AllowUserToDeleteRows = false; // satırların silinmesi engelleniyor
            sessionGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            sessionGrid.ColumnCount = 4; //Kaç kolon olacağı belirleniyor…
            sessionGrid.Columns[0].Name = "ID"; //Kolonların adı belirleniyor
            sessionGrid.Columns[1].Name = "Time";
            sessionGrid.Columns[2].Name = "Salon ID";
            string[] parcalar = comboMovie.SelectedItem.ToString().Split('-');
            using (SqlConnection sqlConnection = new SqlConnection(conString))
            {
                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM session_info WHERE movie_id=" + parcalar[0], sqlConnection);
                sqlConnection.Open();
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                while (sqlReader.Read())
                {
                    sessionGrid.Rows.Add(sqlReader["id"], sqlReader["time"], sqlReader["salon_id"], "Sil");
                }
                sqlReader.Close();
            }
        }

        private void DeleteData(int id)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(conString);
                SqlCommand sqlCmd = new SqlCommand("DELETE FROM session_info WHERE id=" + id, sqlConnection);
                sqlConnection.Open();
                sqlCmd.ExecuteNonQuery();
                sqlConnection.Close();
                GridLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ComboLoad() // filmlerin database den alınarak comboya eklenmesi
        {
            using (SqlConnection sqlConnection = new SqlConnection(conString))
            {
                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM movie_info", sqlConnection);
                sqlConnection.Open();
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                while (sqlReader.Read())
                {
                    comboMovie.Items.Add(sqlReader["id"] + "-" + sqlReader["name"]);
                }

                sqlReader.Close();
            }
            using (SqlConnection sqlConnection = new SqlConnection(conString))
            {
                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM theater_info", sqlConnection);
                sqlConnection.Open();
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                while (sqlReader.Read())
                {
                    comboTheater.Items.Add(sqlReader["id"] + "-" + sqlReader["name"]);
                }

                sqlReader.Close();
            }
        }

        private void comboMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridLoad();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string[] parcalarMovie = comboMovie.SelectedItem.ToString().Split('-');
            string[] parcalarTheater = comboTheater.SelectedItem.ToString().Split('-');
            if (isNew)
            {
                using (SqlConnection sqlConnection = new SqlConnection(conString))
                {
                    SqlCommand sqlCmd = new SqlCommand("INSERT INTO session_info (movie_id, time, salon_id) VALUES ('" + parcalarMovie[0] +"', '" +timePicker.Text +"', '" +parcalarTheater[0]+"')", sqlConnection);
                    sqlConnection.Open();
                    sqlCmd.ExecuteNonQuery();
                    sqlConnection.Close();
                }
            }
            GridLoad();
        }

        private void sessionGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (sessionGrid.RowCount > 0)
            {
                if (e.ColumnIndex == 3)
                {
                    int id = int.Parse(sessionGrid.CurrentRow.Cells[0].Value.ToString());//the primary key for your table.
                    DeleteData(id);
                }
            }
        }
    }
}
