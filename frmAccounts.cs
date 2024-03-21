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
    public partial class frmAccounts : Form
    {

        SqlConnection con;
        SqlCommand _cquery;
        SqlDataReader _cReader;

        
        public frmAccounts()
        {
            con = new SqlConnection(crud.connection);
            InitializeComponent();
        }

        private void frmAcc_btnClose_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void displayAccount()
        {
            dataGridView1.Rows.Clear();
            con.Open();
            _cquery = new SqlCommand("SELECT * FROM ACCOUNTS", con);
            _cReader = _cquery.ExecuteReader();

            while (_cReader.Read())
            {
                dataGridView1.Rows.Add(_cReader["AccID"].ToString(), _cReader["Fname"].ToString(), _cReader["Lname"].ToString(), _cReader["Email"].ToString());
            }

            con.Close();
            _cReader.Close();

        }
        private void frmAcc_btnCreateAcc_Click(object sender, EventArgs e)
        {
            frmCreateAccount newForm = new frmCreateAccount(this);
            newForm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
