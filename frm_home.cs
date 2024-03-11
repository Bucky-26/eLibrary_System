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
    public partial class frm_home : Form
    {
        public frm_home()
        {
            InitializeComponent();
        }

        private void frm_home_Resize(object sender, EventArgs e)
        {
          this.Height =  Screen.PrimaryScreen.Bounds.Height - 40;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Top = 0;
            this.Left = 0;
            MessageBox.Show(this.Height.ToString() + this.Width.ToString());
        }

        private void frm_home_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            books newBooks = new books();
            newBooks.TopLevel = false;
            newBooks.BringToFront();
            this.pnl_body.Controls.Add(newBooks);
            newBooks.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            frm_members newMember = new frm_members();
            newMember.TopLevel = false;
            newMember.BringToFront();
            this.pnl_body.Controls.Add(newMember);
            newMember.Show();
                }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_borrowBooks newBorrow = new frm_borrowBooks();
            newBorrow.TopLevel = false;
            newBorrow.BringToFront();
            this.pnl_body.Controls.Add(newBorrow);
            newBorrow.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDashboard newDashboard = new frmDashboard();
            newDashboard.TopLevel = false;
            newDashboard.BringToFront();
            this.pnl_body.Controls.Add(newDashboard);
            newDashboard.Show();
        }
    }
}
