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
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand com;
        SqlDataReader reader;
        public Form1()
        {
            splashScreen newScreen = new splashScreen();
            newScreen.Dispose();
            InitializeComponent();
            con = new SqlConnection(crud.connection);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         public void login()
        {
            con.Open();
            com = new SqlCommand("SELECT * FROM ACCOUNTS WHERE Username = @username and Password = @password", con);
            com.Parameters.AddWithValue("@username", textBox1.Text);
            com.Parameters.AddWithValue("@password", textBox2.Text);
            reader = com.ExecuteReader();
            reader.Read();

            if (reader.HasRows)
            {
                frm_home newHome = new frm_home();
                this.Hide();
                newHome.Show();
            }
            else
            {
                MessageBox.Show("Your Username or Password is Invalid","eLIBRARY SYSTEM",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            reader.Close();
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            login();
        }
    }
}
