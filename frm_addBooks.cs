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
            button1.Enabled = true;
            btnUpdate.Enabled = false;
        }

        public void AddBooks(string ASESSION_NUM, string title, string author, DateTime releaseDate, string ddc_num, string publication, string subarea, int pages, string location)
        {
            try
            {
                BookInfo newData = new BookInfo()
                {
                    SessionNumber = ASESSION_NUM,
                    Title = title,
                    Author = author,
                    ReleaseDate = releaseDate,
                    DdcNumber = ddc_num,
                    Publication = publication,
                    SubjectArea = subarea,
                    Pages = pages,
                    location = location
                };

                BookInfo.InsertNew(newData);

                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PNS eLibrary [SYSTEM]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void UpdateBooks(string ASESSION_NUM, string title, string author, DateTime releaseDate, string ddc_num, string publication, string subarea, int pages, string location)
        {
            try
            {
                con.Open();
                string sql = @"UPDATE BOOKS SET TITLE=@TITLE, AUTHOR=@AUTHOR, RELEASE_DATE=@RELEASE_DATE, DDC_NUM=@DDC_NUM, PUBLICATION=@PUBLICATION, SUBJECT_AREA=@SUBJECT_AREA, PAGES=@PAGES, LOCATION=@LOCATION
    WHERE ASESSION_NUM=@ASESSION_NUM";

                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@ASESSION_NUM", ASESSION_NUM);

                com.Parameters.AddWithValue("@TITLE", title);
                com.Parameters.AddWithValue("@AUTHOR", author);
                com.Parameters.AddWithValue("@RELEASE_DATE", releaseDate);
                com.Parameters.AddWithValue("@DDC_NUM", ddc_num);
                com.Parameters.AddWithValue("@PUBLICATION", publication);
                com.Parameters.AddWithValue("@SUBJECT_AREA", subarea);
                com.Parameters.AddWithValue("@PAGES", pages);
                com.Parameters.AddWithValue("@LOCATION", location);
                com.ExecuteNonQuery();
                MessageBox.Show("Books has been Updated on the database successfully", "PNS eLibrary [SYSTEM]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                newBooks.loadBooks();
                con.Close();
                ClearTextBoxes();
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
        
        private void frm_addBooks_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int pageNum;
            if (int.TryParse(txtPageNum.Text, out pageNum))
            {
                string title = string.IsNullOrEmpty(txtTitle.Text) ? "Unknown" : txtTitle.Text;
                string author = string.IsNullOrEmpty(txtAuthor.Text) ? "Unknown" : txtAuthor.Text;
                string ddcNum = string.IsNullOrEmpty(txtddcNo.Text) ? "Unknown" : txtddcNo.Text;
                string publication = string.IsNullOrEmpty(txtPub.Text) ? "Unknown" : txtPub.Text;
                string subArea = string.IsNullOrEmpty(txtSubArea.Text) ? "Unknown" : txtSubArea.Text;

                UpdateBooks(txtAssesion.Text, title, author, dtrD.Value, ddcNum, publication, subArea, pageNum, "N/A");
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Please enter a valid number for the page count.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
