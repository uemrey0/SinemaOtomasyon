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
    public partial class FormTheaters : Form
    {
        bool isNew = false;
        String conString = Connection.connString;
        public FormTheaters()
        {
            InitializeComponent();
            GridLoad();
        }
        private void GridLoad()
        {
            theaterGrid.Rows.Clear();
            theaterGrid.ReadOnly = true; // sadece okunabilir olması yani veri düzenleme kapalı
            theaterGrid.AllowUserToDeleteRows = false; // satırların silinmesi engelleniyor
            theaterGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            theaterGrid.ColumnCount = 3; //Kaç kolon olacağı belirleniyor…
            theaterGrid.Columns[0].Name = "ID"; //Kolonların adı belirleniyor
            theaterGrid.Columns[1].Name = "Name";
            using (SqlConnection sqlConnection = new SqlConnection(conString))
            {
                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM theater_info", sqlConnection);
                sqlConnection.Open();
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                while (sqlReader.Read())
                {
                    theaterGrid.Rows.Add(sqlReader["id"], sqlReader["name"], "Sil");
                }
                sqlReader.Close();
            }
        }
        private void DeleteData(int id)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(conString);
                SqlCommand sqlCmd = new SqlCommand("DELETE FROM theater_info WHERE id=" + id, sqlConnection);
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

        private void LoadData(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(conString))
            {
                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM theater_info WHERE id=" + id, sqlConnection);
                sqlConnection.Open();
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                if (sqlReader.Read())
                {
                    txtName.Text = sqlReader["name"].ToString();
                }
                sqlReader.Close();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (isNew)
            {
                using (SqlConnection sqlConnection = new SqlConnection(conString))
                {
                    SqlCommand sqlCmd = new SqlCommand("INSERT INTO theater_info (name) VALUES ('"+txtName.Text+"')", sqlConnection);
                    sqlConnection.Open();
                    sqlCmd.ExecuteNonQuery();
                    sqlConnection.Close();
                }
            }
            else
            {
                using (SqlConnection sqlConnection = new SqlConnection(conString))
                {
                    SqlCommand sqlCmd = new SqlCommand("UPDATE theater_info SET name = '" + txtName.Text + "' WHERE id = '" + int.Parse(theaterGrid.CurrentRow.Cells[0].Value.ToString()) + "'", sqlConnection);
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
        }

        private void theaterGrid_SelectionChanged(object sender, EventArgs e)
        {
            isNew = false;
            LoadData(int.Parse(theaterGrid.CurrentRow.Cells[0].Value.ToString()));
        }

        private void theaterGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (theaterGrid.RowCount > 0)
            {
                if (e.ColumnIndex == 2)
                {
                    int id = int.Parse(theaterGrid.CurrentRow.Cells[0].Value.ToString());//the primary key for your table.
                    DeleteData(id);
                }
            }
        }
    }
}
