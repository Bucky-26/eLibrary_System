using System;
using System.Windows.Forms;

namespace eLibrary_System
{
    public partial class frmBookList : Form
    {
        public frmBookList()
        {
            InitializeComponent();
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
                    dgviewBook.Rows.Add(book.SessionNumber, book.Title, book.Publication, book.Author,
                                        book.ReleaseDate.ToShortDateString(), book.SubjectArea, book.DdcNumber);
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
