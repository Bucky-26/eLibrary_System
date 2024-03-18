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
    public partial class frm_members : Form
    {
        SqlConnection con;
        SqlCommand com;
        SqlDataReader read;
        public frm_members()
        {
            con = new SqlConnection(crud.connection);
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void loadMembers()
        {
            try
            {
                con.Open();
                dataGridView1.Rows.Clear();
                com = new SqlCommand("Select * from MEMBERS", con);
                read = com.ExecuteReader();

                while (read.Read())
                {
                    dataGridView1.Rows.Add(read[0].ToString(), read[1].ToString(), read[2].ToString(), read[5].ToString(), read[6].ToString(), read[7].ToString(), read[8].ToString() );
                }

                read.Close();
                con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            memb3rs newForm = new memb3rs();
            newForm.ShowDialog();
        }

      
    }
}
