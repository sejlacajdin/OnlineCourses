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
        APIService _service = new APIService("courses");
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
                await _service.Get<dynamic>(null);

                frmIndex frm = new frmIndex();
                frm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Autentikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
