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
namespace eLibrary_System
{
    public partial class books : Form
    {
        SqlConnection con;
        SqlCommand com;
        SqlDataReader readData;
        public books()
        {
            con = new SqlConnection(crud.connection);
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            frm_addBooks newAdd = new frm_addBooks(this);
            newAdd.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void loadBooks()
        {
            try
            {
                dgviewBook.Rows.Clear();
                con.Open();
                com = new SqlCommand(@"SELECT * FROM BOOKS WHERE ASESSION_NUM LIKE @ASESSION_NUM OR  TITLE LIKE @TITLE OR PUBLICATION LIKE @PUBLICATION OR AUTHOR LIKE @AUTHOR ", con);
                com.Parameters.AddWithValue("@ASESSION_NUM", $"%{txtSearchBooks.Text}%");
                com.Parameters.AddWithValue("@TITLE", $"%{txtSearchBooks.Text}%");
                com.Parameters.AddWithValue("@PUBLICATION", $"%{txtSearchBooks.Text}%");
                com.Parameters.AddWithValue("@AUTHOR", $"%{txtSearchBooks.Text}%");

                readData = com.ExecuteReader();
                while (readData.Read())
                {
                    dgviewBook.Rows.Add(readData["ASESSION_NUM"].ToString(), readData["TITLE"].ToString(), readData["PUBLICATION"].ToString(), readData["AUTHOR"].ToString(), DateTime.Parse(readData["RELEASE_DATE"].ToString()).ToShortDateString(), readData["SUBJECT_AREA"].ToString(), readData["PAGES"].ToString(), readData["DDC_NUM"].ToString());
                }
                con.Close();
                readData.Close();
            }catch(Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "PNS eLibrary [ ERROR ]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        public void editBooks(string assesion)
        {
            try
            {
                con.Open();
                com = new SqlCommand("SELECT * FROM BOOKS WHERE ASESSION_NUM=@ASSESION", con);
                com.Parameters.AddWithValue("@ASSESION", assesion);
                readData = com.ExecuteReader();

                if (readData.Read())
                {
                    frm_addBooks newUpdate = new frm_addBooks(this);
                    newUpdate.txtAssesion.Text = readData["ASESSION_NUM"].ToString();
                    newUpdate.txtTitle.Text = readData["TITLE"].ToString();
                    newUpdate.txtAuthor.Text = readData["AUTHOR"].ToString();
                    newUpdate.dtrD.Value = Convert.ToDateTime(readData["RELEASE_DATE"]);
                    newUpdate.txtPub.Text = readData["PUBLICATION"].ToString();
                    newUpdate.txtSubArea.Text = readData["SUBJECT_AREA"].ToString();
                    newUpdate.txtPageNum.Text = readData["PAGES"].ToString();
                    newUpdate.txtddcNo.Text = readData["DDC_NUM"].ToString();
                    newUpdate.btnUpdate.Enabled = true;
                    newUpdate.button1.Enabled = false;
                    newUpdate.txtAssesion.ReadOnly = true;
                    readData.Close();
                    con.Close();

                    newUpdate.ShowDialog();
                }
                else
                {
                    readData.Close();
                    con.Close();
                    MessageBox.Show("Book not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void DeleteBook(string asession)
        {
            try
            {
                con.Open();
                com = new SqlCommand("DELETE FROM BOOKS WHERE ASESSION_NUM=@ASSESION", con);
                com.Parameters.AddWithValue("@ASSESION", asession);
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Book record deleted successfully.", "eLibrary System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadBooks();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void dgviewBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string col_name = dgviewBook.Columns[e.ColumnIndex].Name;
            
            switch (col_name)
            {
                case "edit":
                    editBooks(dgviewBook.Rows[e.RowIndex].Cells[0].Value.ToString());
                    break;
                case "delete":
                    DialogResult deleteQ = MessageBox.Show("Do you want to Delete this book?","eLibrary System!",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if(deleteQ == DialogResult.Yes)
                    {
                        DeleteBook(dgviewBook.Rows[e.RowIndex].Cells[0].Value.ToString());
                    }
                    break;
            }
        }

        private void txtSearchBooks_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchBooks_TextChanged(object sender, EventArgs e)
        {
            loadBooks();
        }
    }
}
