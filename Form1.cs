using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using Newtonsoft.Json;

using System.Net.Http;
using System.Net.Http.Headers;

using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.IO;

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
        public void Login()
        {
            try
            {
                con.Open();
                com = new SqlCommand("SELECT * FROM ACCOUNTS WHERE Username = @username AND Password = @password", con);
                com.Parameters.AddWithValue("@username", textbox1.Text);
                com.Parameters.AddWithValue("@password", textbox2.Text);
                reader = com.ExecuteReader();

                if (reader.Read())
                {
                    frm_home newHome = new frm_home();
                    newHome._accID = reader["AccID"].ToString();

                    // Load user info including photo
                    if (!reader.IsDBNull(reader.GetOrdinal("PHOTO")))
                    {
                        long imgBinary = reader.GetBytes(reader.GetOrdinal("PHOTO"), 0, null, 0, 0);
                        byte[] byteImg = new byte[imgBinary + 1];
                        reader.GetBytes(reader.GetOrdinal("PHOTO"), 0, byteImg, 0, (int)imgBinary);

                        MemoryStream ms = new MemoryStream(byteImg);
                        Bitmap bitImageData = new Bitmap(ms);

                        newHome.round1.Image = bitImageData;
                    }
                    else
                    {
                        // Set a default image or handle the absence of an image as needed
                    }

                    newHome.lblUsername.Text = reader["Username"].ToString();
                    newHome.lblRole.Text = reader["Role"].ToString();

                    this.Hide();
                    newHome.Show();
                    newHome.navigation("dashboard");
                }
                else
                {
                    MessageBox.Show("Your Username or Password is Invalid", "eLIBRARY SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
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
            Login();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void kryptnLoginbtn_Click(object sender, EventArgs e)
        {
            Login();

        }

        


        private bool CheckInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://www.google.com"))
                    return true;
            }
            catch
            {
                return false;
            }
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRecoverAccount newRecover = new frmRecoverAccount();
            newRecover.ShowDialog();
        }
    }
}
