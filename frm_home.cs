using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
namespace eLibrary_System
{
    public partial class frm_home : Form
    {


        SqlConnection _cConnect;
        SqlCommand _cCommand;
        SqlDataReader _cReader;
        public frm_home()
        {
            InitializeComponent();
        }
        private string _AccID;

        public string _accID
        {
            get { return _AccID; }
            set { _AccID = value; }
        }


        


        public void navigation(string nav)
        {
            if (pnl_body.Controls.Count > 0)
            {
                pnl_body.Controls[0].Dispose();
                pnl_body.Controls.Clear();
            }
            switch (nav)
            {
                case "dashboard":
                    frmDashboard newDashboard = new frmDashboard();
                    newDashboard.TopLevel = false;
                    newDashboard.BringToFront();
                    this.pnl_body.Controls.Add(newDashboard);
                    newDashboard.Show();
                    break;
                case "books":
                    books newBooks = new books();
                    newBooks.TopLevel = false;
                    newBooks.BringToFront();
                    newBooks.DisplayBooks();
                    newBooks.dsplayddc("");
                    this.pnl_body.Controls.Add(newBooks);
                    newBooks.Show();


                    break;
                case "boroowBooks":

                    frm_borrowBooks newBorrow = new frm_borrowBooks();
                    newBorrow.TopLevel = false;
                    newBorrow.BringToFront();
                    newBorrow.LoadIssuedBooks();
                    this.pnl_body.Controls.Add(newBorrow);
                    newBorrow.Show();
                    break;
                case "return":

                    frmReturn newReturn = new frmReturn();
                    newReturn.TopLevel = false;
                    newReturn.BringToFront();
                   newReturn.DisplayReturn();
                  newReturn.ReturnedBooks();
                    this.pnl_body.Controls.Add(newReturn);
                    newReturn.Show();
                    break;
                case "overDUE":

                    break;
                case "members":

                    frm_members newMember = new frm_members();
                    newMember.TopLevel = false;
                    newMember.BringToFront();
                    this.pnl_body.Controls.Add(newMember);
                    newMember.loadMembers();
                    newMember.Show();
                    break;

                case "accounts":
                    frmAccounts newForm = new frmAccounts();
                    newForm.TopLevel = false;
                    newForm.BringToFront();
                    this.pnl_body.Controls.Add(newForm);
                    newForm.displayAccount();
                    newForm.Show();
                    break;



            }
        }
        private void frm_home_Resize(object sender, EventArgs e)
        {
          this.Height =  Screen.PrimaryScreen.Bounds.Height- 45  ;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Top = 0;
            this.Left = 0;
        }

        private void frm_home_Load(object sender, EventArgs e)
        {


        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            navigation("members");

          
                }

        private void button4_Click(object sender, EventArgs e)
        {
            navigation("boroowBooks");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            navigation("dashboard");
        }

        private void pnl_body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            navigation("accounts");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            profile f = new profile();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            navigation("return");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 newLogin = new Form1();
            this.Close();
            newLogin.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            navigation("books");
        }
    }
}
