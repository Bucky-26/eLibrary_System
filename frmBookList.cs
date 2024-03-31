
using System;
using System.Diagnostics.Contracts;
using System.Windows.Forms;

namespace eLibrary_System
{
    public partial class frmBookList : Form
    {
        FrmAddborrowBook newb;
        public frmBookList(FrmAddborrowBook newb)
        {
            InitializeComponent();
            this.newb = newb;
        }

        private void frmBookList_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void kryptonLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadBooks()
        {
            try
            {
                dgviewBook.Rows.Clear();
                string searchQuery = txtSearchBooks.Text;
                var booksList = BookInfo.GetBooks(searchQuery);

                foreach (var book in booksList)
                {
                    dgviewBook.Rows.Add(book.SessionNumber, book.Title, book.Author, book.DdcNumber);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PNS eLibrary [ ERROR ]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearchBooks_TextChanged(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void dgviewBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string colName = dgviewBook.Columns[e.ColumnIndex].Name;
                if (colName == "select")
                {

                    newb.txtbookAssesion.Text = dgviewBook.Rows[e.RowIndex].Cells[0].Value.ToString();
                    newb.txtbookTitle.Text = dgviewBook.Rows[e.RowIndex].Cells[1].Value.ToString();
                    newb.txtBookDDC.Text = dgviewBook.Rows[e.RowIndex].Cells[3].Value.ToString();

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PNS eLibrary [ ERROR ]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void kryptonLabel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void kryptonLabel1_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
