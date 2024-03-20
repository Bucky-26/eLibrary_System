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







        public void updateStudentRecord(string lcnumber)
        {
            try
            {
                con.Open();
                com = new SqlCommand("SELECT * FROM MEMBERS WHERE LC_Num = @LC_Num", con);
                com.Parameters.AddWithValue("@LC_Num", lcnumber);
                read = com.ExecuteReader();

                if (read.HasRows)
                {
                    read.Read();
                    long imgBinary = read.GetBytes(read.GetOrdinal("PHOTO"), 0, null, 0, 0);
                    byte[] byteImg = new byte[imgBinary + 1];
                    read.GetBytes(read.GetOrdinal("PHOTO"), 0, byteImg, 0, (int)imgBinary);

                    MemoryStream ms = new MemoryStream(byteImg);
                    Bitmap bitImageData = new Bitmap(ms);

                    memb3rs newForm = new memb3rs(this);
                    newForm.txtLCnumber.Text = read["LC_Num"].ToString();
                    newForm.txtlcnum.Text = read["LRN_Num"].ToString();
                    newForm.txtfname.Text = read["NAME"].ToString();
                    newForm.dateTimePicker1.Value = Convert.ToDateTime(read["DATE_OF_BIRTH"]);
                    newForm.cmboxGender.Text = read["GENDER"].ToString();
                    newForm.txtaddress.Text = read["ADDRESS"].ToString();
                    newForm.txtcnum.Text = read["CONTACT_NUMBER"].ToString();
                    newForm.txtgl.Text = read["GRADE_LEVEL"].ToString();
                    newForm.txtsec.Text = read["Section"].ToString();
                    newForm.txtadviser.Text = read["ADVISER"].ToString();
                    newForm.imgboxStudent.Image = bitImageData;
                    newForm.btnUpdate.Enabled = true;
                    newForm.btnAdd.Enabled = false;
                    newForm.ShowDialog();

                    con.Close();
                    read.Close();
                }
                else
                {
                    con.Close();
                    read.Close();
                    MessageBox.Show("No records found for LC_Num: " + lcnumber);
                }
            }
            catch (Exception ex)
            {
                con.Close();
                read?.Close();
                MessageBox.Show(ex.Message);
            }
        }



        public void loadMembers()
        {
         
                con.Open();
                dgviewStudents.Rows.Clear();
                com = new SqlCommand("Select * from MEMBERS", con);
                read = com.ExecuteReader();

                while (read.Read())
                {
                    dgviewStudents.Rows.Add(read[0].ToString(), read[1].ToString(), read[2].ToString(), read[5].ToString(), read[6].ToString(), read[7].ToString(), read[8].ToString());
                }

                read.Close();
                con.Close();
            
           
         

            }
        private void button1_Click(object sender, EventArgs e)
        {
            memb3rs newForm = new memb3rs(this);
            newForm.ShowDialog();
        }

        private void dgviewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void dgviewStudents_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
                string col_name = dgviewStudents.Columns[e.ColumnIndex].Name;
                switch (col_name)
                {
                    case "edit":
                        MessageBox.Show(dgviewStudents.Rows[e.RowIndex].Cells[0].Value.ToString());
                        updateStudentRecord(dgviewStudents.Rows[e.RowIndex].Cells[0].Value.ToString());
                        break;
                    default:
                        break;
                }
            
        }

    }
}
