using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eLibrary_System
{
    public partial class frm_borrowBooks : Form
    {
        public frm_borrowBooks()
        {
            InitializeComponent();
        }
        // All Data Related Function


        public void LoadIssuedBooks()
        {
            try
            {
                dataGridView2.Rows.Clear();
                var newBorrow = IssueBookInfo.DisplayIssuedBooks(txtsearchqry.Text);
                foreach(var item in newBorrow)
                {
                    dataGridView2.Rows.Add(item.Id,item.assesion_number, item.title, item.card_number, item.studentName, item.GLevel, item.DateIssue, item.DueDate, item.Status);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "PNS eLMS [ERROR]",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        public void DeleteRec(int paramss)
        {
            var newInfo1 = new IssueBookInfo()
            {
                Id= paramss
            };
            IssueBookInfo deletRec = new IssueBookInfo();
            deletRec.DeleteIssue(newInfo1);
        }
        //end here
        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmAddborrowBook newFrom = new FrmAddborrowBook(this);
            DateTime currentDate = DateTime.Today;
            newFrom.dtdueDate.Value = currentDate.AddDays(1);
            newFrom.ShowDialog();
        }

        public void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView2.Columns[e.ColumnIndex].Name;
            if (colName == "delete")
            {
                if (dataGridView2.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    int idToDelete = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value);

                    DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        DeleteRec(idToDelete);

                        MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadIssuedBooks();

                    }
                }
                else
                {
                    MessageBox.Show("Invalid ID value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtsearchqry_Click(object sender, EventArgs e)
        {

        }

        private void txtsearchqry_TextChanged(object sender, EventArgs e)
        {
            LoadIssuedBooks();
        }
    }
}
