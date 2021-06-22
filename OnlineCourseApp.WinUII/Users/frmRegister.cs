using OnlineCourseApp.Model.Requests.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace OnlineCourseApp.WinUI.Users
{
    public partial class frmRegister : Form
    {
        private readonly APIService _serviceUsers = new APIService("users");

        public frmRegister()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmUsersRegister_Load(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtPassword.PasswordChar = '*';
            txtConfirmPassword.Text = "";
            txtConfirmPassword.PasswordChar = '*';
        }

        private async void buttonAddCourse_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;
            var request = new UsersInsertRequest()
            {
                FirstName = txtFirstname.Text,
                LastName = txtLastname.Text,
                Username = txtUsername.Text,
                Email = txtEmail.Text,
                Phone = txtPhone.Text,
                Password = txtPassword.Text,
                PasswordConfirmation = txtConfirmPassword.Text,
                Role = "Professor",
                Status = true
            };

            await _serviceUsers.Register<Model.Users>(request);
            this.Close();
            MessageBox.Show("Successfully registered.");
            frmLogin _frmLogin = new frmLogin();
            _frmLogin.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }

        private void textFirstname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstname.Text))
            {
                errorProvider.SetError(txtFirstname, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
                errorProvider.SetError(txtFirstname, null);
        }

        private void txtLastname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastname.Text))
            {
                errorProvider.SetError(txtLastname, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
                errorProvider.SetError(txtLastname, null);
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider.SetError(txtUsername, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
                errorProvider.SetError(txtUsername, null);
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            Regex reg = new Regex(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$", RegexOptions.IgnoreCase);

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (!reg.IsMatch(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, Properties.Resources.Validation_EmailFormat);
                e.Cancel = true;
            } 
            else
                errorProvider.SetError(txtEmail, null);
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (txtPhone.Text.Length < 9)
            {
                errorProvider.SetError(txtPhone, "Phone number must be minimum 9 digits");
                e.Cancel = true;
            }
            else
                errorProvider.SetError(txtPhone, null);
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider.SetError(txtPassword, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (txtPassword.Text.Length< 8 )
            {
                errorProvider.SetError(txtPassword, "Minimum length is 8 characters");
                e.Cancel = true;
            }
            else if(!Regex.Match(txtPassword.Text, "^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])|(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^a-zA-Z0-9])|(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])|(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{8,}$").Success)
            {
                errorProvider.SetError(txtPassword, "Passwords must contain at 3 of 4 of the following: upper case (A-Z), lower case (a-z), number (0-9) and special character (e.g. !@#$%^&*)");
                e.Cancel = true;
            }
            else
                errorProvider.SetError(txtPassword, null);
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                errorProvider.SetError(txtConfirmPassword, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (txtConfirmPassword.Text != txtPassword.Text)
            {
                errorProvider.SetError(txtConfirmPassword, "Passwords don't match.");
                e.Cancel = true;
            }
            else
                errorProvider.SetError(txtConfirmPassword, null);
        }
    }
}
