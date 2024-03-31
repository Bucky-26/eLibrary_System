using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;

namespace eLibrary_System
{
    public partial class frmReturn : Form
    {
        DateTime DueDate;
        DateTime DateReturn = DateTime.Today;
        int TotalDaysLate;
        int bID;
        string Remarks;
        public frmReturn()
        {
            InitializeComponent();
        }

        public void DisplayReturn()
        {
            try
            {
                dataGridView1.Rows.Clear();
                var newBorrow = IssueBookInfo.DisplayIssuedBooks(kryptonTextBox2.Text);
                foreach (var item in newBorrow)
                {
                    dataGridView1.Rows.Add(item.Id, item.assesion_number, item.title, item.card_number, item.studentName, item.GLevel, item.DateIssue.ToShortDateString(), item.DueDate.ToShortDateString(), item.Status);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PNS eLMS [ERROR]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ReturnedBooks()
        {
            try
            {
                dataGridView2.Rows.Clear();
                var newBorrow = IssueBookInfo.DisplayIssuedBooks(kryptonTextBox1.Text);
                foreach (var item in newBorrow)
                {
                    dataGridView2.Rows.Add(item.Id, item.assesion_number, item.title, item.card_number, item.studentName, item.GLevel, item.DateIssue.ToShortDateString(), item.DueDate.ToShortDateString(), item.Remarks);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PNS eLMS [ERROR]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CalculateDaysLate()
        {
            TimeSpan timeDifference = DateTime.Today - DueDate;
            TotalDaysLate = Math.Max(0, timeDifference.Days); 
            if(TotalDaysLate >= 1)
            {
                Remarks = "OverDue";
            }
            else
            {
                Remarks = "On-Time";
            }
        }
        public void returnBooks(int id)
        {
            try
            {
                var returnnow = new IssueBookInfo()
                {
                    DateReturn = DateReturn,
                    Status = "Returned",
                    DaysLate = TotalDaysLate,
                    Remarks = Remarks,

                    Id= id
                };
                IssueBookInfo info = new IssueBookInfo();
                info.returnIssue(returnnow);
                MessageBox.Show("The Issued book has been return", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PNS eLMS [ERROR]", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void kryptonTextBox2_TextChanged(object sender, EventArgs e)
        {
            DisplayReturn();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int idToDelete = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                bID = idToDelete;
                kryptonButton1.Enabled = true;
                DueDate = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
                CalculateDaysLate(); 
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (TotalDaysLate >= 1)
            {
                MessageBox.Show($"The book is returned {TotalDaysLate} day(s) late.", "PNS eLMS [SYSTEM]", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The book is returned on time.", "PNS eLMS [SYSTEM]", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            returnBooks(bID);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {
            ReturnedBooks();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int idToDelete = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                bID = idToDelete;
                kryptonButton1.Enabled = true;
                DueDate = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
                CalculateDaysLate();
            }
        }
    }
}