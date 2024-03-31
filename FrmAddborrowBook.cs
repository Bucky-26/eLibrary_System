using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eLibrary_System
{

    public partial class FrmAddborrowBook : Form
    {
        frm_borrowBooks newDisplay;
        public FrmAddborrowBook(frm_borrowBooks newDisplay)
        {
            InitializeComponent();
            this.newDisplay = newDisplay;
        }
        // ALL DATABASE FUNCTION GO HERE -DEV ISOY

        public void IssueBookNow()
        {
            try
            {
                IssueBookInfo newIssue = new IssueBookInfo()
                {
                    assesion_number = txtbookAssesion.Text,
                    card_number = txtstuLcNum.Text,
                    DateIssue = dtdateb.Value,
                    DueDate = dtdueDate.Value,
                    Status = "BORROWED",
                    Remarks = "NOT RETURN"
                };

                IssueBookInfo issueManager = new IssueBookInfo();
                issueManager.IssueBook(newIssue);
                MessageBox.Show("Book successfully issued to the student.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PNS eLMS [ERROR]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        //end
        private void CLOSE_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmAddborrowBook_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtbookAssesion.Text == "" || txtstuLcNum.Text == "")
            {
                MessageBox.Show("Please fill all filled", "PNS eLMS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                IssueBookNow();

                newDisplay.LoadIssuedBooks();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBookList newList = new frmBookList(this);
            newList.ShowDialog();
        }

        private void txtStuBlock_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmStudentList newList = new frmStudentList(this);
            newList.LoadStudent();
            newList.Show();
        }

        private void dtdueDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime DueDate = dtdueDate.Value;
            DateTime _today = DateTime.Today;

            if (DueDate < _today)
            {
                MessageBox.Show("Due date cannot be set to a past date. Setting due date to tomorrow.", "Invalid Due Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                dtdueDate.Value = DateTime.Today.AddDays(1);
            }
        }
    }
}