using OnlineCourseApp.Model.Requests.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OnlineCourseApp.WinUI.Users
{
    public partial class frmLogin : Form
    {
        private readonly APIService _service = new APIService("users/login");
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            frmRegister frm = new frmRegister();
            frm.ShowDialog();
        }

        private void txtUsernameEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsernameEmail.Text))
            {
                errorProvider.SetError(txtUsernameEmail, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtPassword.PasswordChar = '*';
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider.SetError(txtPassword, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
        }

        private async void buttonAddCourse_Click(object sender, EventArgs e)
        {
            try
            {
                APIService.Username = txtUsernameEmail.Text;
                APIService.Password = txtPassword.Text;
               
                var user = await _service.Get<Model.Users>(new UserLoginRequest { Username = txtUsernameEmail.Text, Password = txtPassword.Text } );

                bool isProfessor = false;
                foreach (var item in user.UserRoles)
                {
                    if (item.Role.Name == "Professor")
                        isProfessor = true;
                };

                if (isProfessor)
                {
                    APIService.UserId = user.UserId;
                    this.Hide();
                    frmIndex frm = new frmIndex();
                    frm.Show();
                }
                else
                    MessageBox.Show("You need to have professor account.", "Permission", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong username or pasword. Try again.", "Autentikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
