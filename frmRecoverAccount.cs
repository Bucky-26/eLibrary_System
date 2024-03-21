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
    public partial class frmRecoverAccount : Form
    {
        string _cOTP;
        int remainingSeconds = 60; // Initial remaining time in seconds
        System.Windows.Forms.Timer timer;
        SqlConnection _cConnection;
        SqlCommand _cCommand;
        SqlDataReader _cDataReader;

        public frmRecoverAccount()
        {
            _cConnection = new SqlConnection(crud.connection);
            InitializeComponent();
        }
        public async void CheckCreds()
        {

            try
            {
                _cConnection.Open();
                _cCommand = new SqlCommand("SELECT * FROM ACCOUNTS WHERE Email = @mail OR Username = @user",_cConnection);
                _cCommand.Parameters.AddWithValue("@mail",txtEmailcontainer.Text);
                _cCommand.Parameters.AddWithValue("@user", txtEmailcontainer.Text);
                _cDataReader = _cCommand.ExecuteReader();
                _cDataReader.Read();
                if (_cDataReader.HasRows)
                {
                    kryptonButton3.Enabled = false;
                    EmailService emailService = new EmailService();
                    string otp = await emailService.SendEmail(_cDataReader["Email"].ToString());
                    _cOTP = otp;

                    remainingSeconds = 60;
                    timer = new System.Windows.Forms.Timer();
                    timer.Interval = 2000;
                    timer.Tick += Timer_Tick;
                    timer.Start();
                }
                else
                {

                }
                _cConnection.Close();
                _cDataReader.Close();
            }
            catch (Exception ex)
            {
                _cConnection.Close();
                MessageBox.Show(ex.Message,"eLibrary System [ ERROR ]",MessageBoxButtons.OK,MessageBoxIcon.Error);
           
            
            }

        }
        private async void kryptonButton3_Click(object sender, EventArgs e)
        {
            CheckCreds();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            remainingSeconds--;
            if (remainingSeconds > 0)
            {
                kryptonButton3.Text = $"Resend OTP ({remainingSeconds}s)";
            }
            else
            {
                timer.Stop();
                kryptonButton3.Enabled = true; 
                kryptonButton3.Text = "Resend OTP";
            }
        }
        public void ChangePassword()
        {
            try
            {
                _cConnection.Open();
                _cCommand = new SqlCommand("UPDATE ACCOUNTS SET Password = @Password WHERE Username = @Username OR Email = @Email", _cConnection);
                _cCommand.Parameters.AddWithValue("@Email", txtEmailcontainer.Text);
                _cCommand.Parameters.AddWithValue("@Username", txtEmailcontainer.Text);
                _cCommand.Parameters.AddWithValue("@Password", txtnewPassword.Text);
                
                int rowsAffected = _cCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Your password has been updated successfully", "eLibrary System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose(); 
                }
                else
                {
                    MessageBox.Show("Failed to update password", "eLibrary System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "eLibrary System [ ERROR ]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _cConnection.Close();
            }
        }

        public void CheckCorrectPassword()
        {
            if(txtConfirmNewPassword.Text == txtnewPassword.Text)
            {
                ChangePassword();
            }
        }
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (txtOTP.Text == _cOTP)
            {

                CheckCorrectPassword();

            }
            else
            {
                MessageBox.Show("Invalid OTP", "eLibrary System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void kryptonLabel3_Paint(object sender, PaintEventArgs e)
        {
            this.Close();
            Form1 newForm = new Form1();
        }
    }
}
