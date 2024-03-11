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
    public partial class books : Form
    {
        SqlConnection con;
        SqlCommand com;
        SqlDataReader readData;
        public books()
        {
            con = new SqlConnection(crud.connection);
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            frm_addBooks newAdd = new frm_addBooks(this);
            newAdd.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void loadBooks()
        {
            try
            {
                dataGridView1.Rows.Clear();
                con.Open();
                com = new SqlCommand("SELECT * FROM BOOKS", con);
                readData = com.ExecuteReader();
                while (readData.Read())
                {
                    dataGridView1.Rows.Add(readData["ASESSION_NUM"].ToString(), readData["TITLE"].ToString(), readData["PUBLICATION"].ToString(), readData["AUTHOR"].ToString(), DateTime.Parse(readData["RELEASE_DATE"].ToString()).ToShortDateString(), readData["SUBJECT_AREA"].ToString(), readData["PAGES"].ToString(), readData["DDC_NUM"].ToString());
                }
                con.Close();
                readData.Close();
            }catch(Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "PNS eLibrary [ ERROR ]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
