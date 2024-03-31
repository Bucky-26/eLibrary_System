using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eLibrary_System
{
    public partial class frmRecoverAccount : Form
    {
        string _cOTP;
        int remainingSeconds = 60; 
        Timer timer;
        SqlConnection _cConnection;
        SqlCommand _cCommand;
        string _mail;
        SqlDataReader _cDataReader;
        EmailService _emailService;

        public frmRecoverAccount()
        {
            _cConnection = new SqlConnection(crud.connection);
            _emailService = new EmailService();
            InitializeComponent();
        }

        public async void CheckCreds()
        {
            try
            {
                _cConnection.Open();
                _cCommand = new SqlCommand("SELECT * FROM ACCOUNTS WHERE Email = @mail OR Username = @user", _cConnection);
                _cCommand.Parameters.AddWithValue("@mail", txtEmailcontainer.Text);
                _cCommand.Parameters.AddWithValue("@user", txtEmailcontainer.Text);
                _cDataReader = _cCommand.ExecuteReader();
                if (_cDataReader.Read())
                {
                    kryptonButton3.Enabled = false;
                    string otp = await _emailService.SendEmail(_cDataReader["Email"].ToString());
                    _cOTP = otp;
                    _mail = _cDataReader["Email"].ToString();

                    remainingSeconds = 60;
                    timer = new Timer();
                    timer.Interval = 1000;
                    timer.Tick += Timer_Tick;
                    timer.Start();
                }
                else
                {
                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _cDataReader?.Close();
                _cConnection?.Close();
            }
        }

        private async void kryptonButton3_Click(object sender, EventArgs e)
        {
            CheckCreds();
        }

        private async void kryptonButton1_Click(object sender, EventArgs e)
        {
            string enteredOTP = txtOTP.Text;
            string email = _mail;

            if (!string.IsNullOrEmpty(enteredOTP) && !string.IsNullOrEmpty(email))
            {
                bool isValidOTP = await _emailService.ValidateOTP(email, enteredOTP);
                if (isValidOTP)
                {
                    await ChangePassword();
                }
                else
                {
                    MessageBox.Show("Invalid OTP", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter OTP and Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task ChangePassword()
        {
            try
            {
                _cConnection.Open();
                _cCommand = new SqlCommand("UPDATE ACCOUNTS SET Password = @Password WHERE Username = @Username OR Email = @Email", _cConnection);
                _cCommand.Parameters.AddWithValue("@Email", _mail); 
                _cCommand.Parameters.AddWithValue("@Username", txtEmailcontainer.Text);
                _cCommand.Parameters.AddWithValue("@Password", txtnewPassword.Text);

                int rowsAffected = _cCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Your password has been updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Failed to update password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _cConnection.Close();
            }
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

        private void kryptonLabel3_Paint(object sender, PaintEventArgs e)
        {
            this.Close();
           
        }
    }
}
