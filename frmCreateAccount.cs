using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace eLibrary_System
{
    public partial class frmCreateAccount : Form
    {
        SqlConnection con;
        SqlCommand com;
        SqlDataReader reader;


        public frmCreateAccount()
        {
            InitializeComponent();
            con = new SqlConnection(crud.connection);
        }

        public void CreateAccount()
        {
            try
            {
                con.Open();
                com = new SqlCommand(@"INSERT INTO ACCOUNTS (Fname,Lname,Email,Role,Username,Password) VALUES (@Fname,@Lname,@Email,@Role,@Username,@Password)", con);
                com.Parameters.AddWithValue("@Fname", txtName.Text);
                com.Parameters.AddWithValue("@Lname", txtLastName.Text);
                com.Parameters.AddWithValue("@Email", txtEmail.Text);
                com.Parameters.AddWithValue("@Role", cmboxRole.Text);
                com.Parameters.AddWithValue("@Username", UtxtUsername.Text);
                com.Parameters.AddWithValue("@Password", txtConfirmPassword.Text);
                com.ExecuteNonQuery();
                MessageBox.Show("Account created successfully", "eLibrary System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error creating account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                com = new SqlCommand("SELECT * FROM ACCOUNTS WHERE Username = @Username OR Email = @Email", con);
                com.Parameters.AddWithValue("@Username", UtxtUsername.Text);
                com.Parameters.AddWithValue("@Email", txtEmail.Text);
                reader = com.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Username or Email is already in use", "eLibrary System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    con.Close();
                    reader.Close();
                    CreateAccount();
                }
            }
            catch (Exception ex)
            {
                con.Close();

                MessageBox.Show("Error checking username/email: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
