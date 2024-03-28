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
        frm_members newMembers;
        public memb3rs(frm_members newMembers)
        {
            this.imgboxStudent = new eLibrary_System.round();

            con = new SqlConnection(crud.connection);
            InitializeComponent();
            this.newMembers = newMembers;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void ClearTextBoxes()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                
            }
            imgboxStudent.Image = null;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files (*.png)|*.png|(*.jpg)|*.jpg";
            openFileDialog1.ShowDialog();
            imgboxStudent.Image = Image.FromFile(openFileDialog1.FileName);
        }
        public void addMembers()
        {
            try
            {
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
                    return;
                }

                // Check if an image is selected
                if (imgboxStudent.Image == null)
                {
                    MessageBox.Show("Please select an image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Convert the image to byte array
                byte[] photoBytes;
                using (MemoryStream ms = new MemoryStream())
                {
                    imgboxStudent.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    photoBytes = ms.ToArray();
                }

                membersInfo newwMember = new membersInfo()
                {
                    LC_Num = txtLCnumber.Text,
                    LRN_Num = txtlcnum.Text,
                    NAME = txtfname.Text,
                    DATE_OF_BIRTH = dateTimePicker1.Value,
                    GENDER = cmboxGender.Text,
                    ADDRESS = txtaddress.Text,
                    CONTACT_NUMBER = txtcnum.Text,
                    Section = txtsec.Text,
                    ADVISER = txtadviser.Text,
                    GRADE_LEVEL = txtgl.Text
                };

                MembersData membersData = new MembersData();
                membersData.NewMembers(newwMember, photoBytes); // Pass the photo byte array

                MessageBox.Show("Member added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        public void UpdateMembers()
        {
            try
            {
                con.Open();

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
                }
                else
                {
                    MemoryStream save_img = new MemoryStream();
                    if (imgboxStudent.Image != null)
                    {
                        imgboxStudent.Image.Save(save_img, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }

                    com = new SqlCommand(@"UPDATE MEMBERS  SET LRN_Num=@LRN_Num, NAME=@NAME, DATE_OF_BIRTH=@DATE_OF_BIRTH, GENDER=@GENDER, ADDRESS=@ADDRESS, CONTACT_NUMBER=@CONTACT_NUMBER, GRADE_LEVEL=@GRADE_LEVEL, Section=@Section, ADVISER=ADVISER, PHOTO=@PHOTO
                    WHERE LC_Num= @LC_Num ", con);

                    com.Parameters.AddWithValue("@LC_Num", txtLCnumber.Text);
                    com.Parameters.AddWithValue("@LRN_Num", txtlcnum.Text);
                    com.Parameters.AddWithValue("@NAME", txtfname.Text);
                    com.Parameters.AddWithValue("@DATE_OF_BIRTH", dateTimePicker1.Value);
                    com.Parameters.AddWithValue("@GENDER", cmboxGender.Text);
                    com.Parameters.AddWithValue("@ADDRESS", txtaddress.Text);
                    com.Parameters.AddWithValue("@CONTACT_NUMBER", txtcnum.Text);
                    com.Parameters.AddWithValue("@GRADE_LEVEL", txtgl.Text);
                    com.Parameters.AddWithValue("@Section", txtsec.Text);
                    com.Parameters.AddWithValue("@ADVISER", txtadviser.Text);

                    if (imgboxStudent.Image != null)
                    {
                        ImageConverter converter = new ImageConverter();
                        byte[] photoBytes = (byte[])converter.ConvertTo(imgboxStudent.Image, typeof(byte[]));
                        com.Parameters.AddWithValue("@PHOTO", photoBytes);
                    }
                    else
                    {
                        com.Parameters.AddWithValue("@PHOTO", DBNull.Value);
                    }

                    com.ExecuteNonQuery();
                    con.Close();
                    ClearTextBoxes();

                    MessageBox.Show("Student Info updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 


                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addMembers();
        }

        private void memb3rs_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateMembers();
            newMembers.loadMembers();
            this.Dispose();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
    }
}
