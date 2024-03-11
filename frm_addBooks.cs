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
    public partial class frm_addBooks : Form
    {
        SqlConnection con;
        SqlCommand com;
        books newBooks;
        public frm_addBooks(books newBooks)
        {
            con = new SqlConnection(crud.connection);
            InitializeComponent();
            this.newBooks = newBooks;
        }
        private void ClearTextBoxes()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
        }

        public void AddBooks(string ASESSION_NUM, string title, string author, DateTime releaseDate, string ddc_num, string publication, string subarea, int pages, string location)
        {
            try
            {
                con.Open();
                string sql = @"INSERT INTO BOOKS (ASESSION_NUM, TITLE, AUTHOR, RELEASE_DATE, DDC_NUM, PUBLICATION, SUBJECT_AREA, PAGES, LOCATION)
                       VALUES (@ASESSION_NUM, @TITLE, @AUTHOR, @RELEASE_DATE, @DDC_NUM, @PUBLICATION, @SUBAREA, @PAGES, @LOCATION)";

                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@ASESSION_NUM", ASESSION_NUM);
                com.Parameters.AddWithValue("@TITLE", title);
                com.Parameters.AddWithValue("@AUTHOR", author);
                com.Parameters.AddWithValue("@RELEASE_DATE", releaseDate);
                com.Parameters.AddWithValue("@DDC_NUM", ddc_num);
                com.Parameters.AddWithValue("@PUBLICATION", publication);
                com.Parameters.AddWithValue("@SUBAREA", subarea);
                com.Parameters.AddWithValue("@PAGES", pages);
                com.Parameters.AddWithValue("@LOCATION", location);
                com.ExecuteNonQuery();
                MessageBox.Show("Books has been added to database successfully", "PNS eLibrary [SYSTEM]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                newBooks.loadBooks();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PNS eLibrary [SYSTEM]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pageNum;
            if (int.TryParse(txtPageNum.Text, out pageNum))
            {
                string title = string.IsNullOrEmpty(txtTitle.Text) ? "Unknown" : txtTitle.Text;
                string author = string.IsNullOrEmpty(txtAuthor.Text) ? "Unknown" : txtAuthor.Text;
                string ddcNum = string.IsNullOrEmpty(txtddcNo.Text) ? "Unknown" : txtddcNo.Text;
                string publication = string.IsNullOrEmpty(txtPub.Text) ? "Unknown" : txtPub.Text;
                string subArea = string.IsNullOrEmpty(txtSubArea.Text) ? "Unknown" : txtSubArea.Text;

                AddBooks(txtAssesion.Text, title, author, dtrD.Value, ddcNum, publication, subArea, pageNum, "N/A");
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Please enter a valid number for the page count.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
