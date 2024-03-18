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
using System.IO;
namespace eLibrary_System
{
    public partial class memb3rs : Form
    {
        SqlConnection con;
        SqlCommand com;
        SqlDataReader rd;
        
        public memb3rs()
        {
            con = new SqlConnection(crud.connection);
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files (*.png)|*.png|(*.jpg)|*.jpg";
            openFileDialog1.ShowDialog();
            round1.Image = Image.FromFile(openFileDialog1.FileName);
        }
        public void addMembers()
        {
            try
            {
                // Check if any required fields are empty
                if (string.IsNullOrEmpty(txtLCnumber.Text) ||
                    string.IsNullOrEmpty(txtlcnum.Text) ||
                    string.IsNullOrEmpty(txtfname.Text) ||
                    string.IsNullOrEmpty(cmboxGender.Text) ||
                    string.IsNullOrEmpty(txtaddress.Text) ||
                    string.IsNullOrEmpty(txtcnum.Text) ||
                    string.IsNullOrEmpty(txtgl.Text) ||
                    string.IsNullOrEmpty(txtsec.Text) ||
                    string.IsNullOrEmpty(txtadviser.Text))
                {
                    MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit method if any required field is empty
                }

                MemoryStream save_img = new MemoryStream();
                if (round1.Image != null)
                {
                    round1.Image.Save(save_img, System.Drawing.Imaging.ImageFormat.Jpeg);
                }

                con.Open();
                com = new SqlCommand("INSERT INTO MEMBERS (LC_Num, LRN_Num, NAME, DATE_OF_BIRTH, GENDER, ADDRESS, CONTACT_NUMBER, GRADE_LEVEL, Section, ADVISER, PHOTO) VALUES(@LC_Num, @LRN_Num, @NAME, @DATE_OF_BIRTH, @GENDER, @ADDRESS, @CONTACT_NUM, @GRADE_LEVEL, @Section, @ADVISER, @PHOTO)", con);

                // Set parameters after validation checks
                com.Parameters.AddWithValue("@LC_Num", txtLCnumber.Text);
                com.Parameters.AddWithValue("@LRN_Num", txtlcnum.Text);
                com.Parameters.AddWithValue("@NAME", txtfname.Text);
                com.Parameters.AddWithValue("@DATE_OF_BIRTH", dateTimePicker1.Value);
                com.Parameters.AddWithValue("@GENDER", cmboxGender.Text);
                com.Parameters.AddWithValue("@ADDRESS", txtaddress.Text);
                com.Parameters.AddWithValue("@CONTACT_NUM", txtcnum.Text);
                com.Parameters.AddWithValue("@GRADE_LEVEL", txtgl.Text);
                com.Parameters.AddWithValue("@Section", txtsec.Text);
                com.Parameters.AddWithValue("@ADVISER", txtadviser.Text);

                if (round1.Image != null)
                {
                    ImageConverter converter = new ImageConverter();
                    byte[] photoBytes = (byte[])converter.ConvertTo(round1.Image, typeof(byte[]));
                    com.Parameters.AddWithValue("@PHOTO", photoBytes);
                }
                else
                {
                    com.Parameters.AddWithValue("@PHOTO", DBNull.Value);
                }

                com.ExecuteNonQuery();
                MessageBox.Show("Member added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addMembers();
        }
    }
}
