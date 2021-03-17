using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Flurl.Http;
using OnlineCourseApp.Model.Requests;
using OnlineCourseApp.Model.Requests.Users;

namespace OnlineCourseApp.WinUI.Users
{
    public partial class frmUsers : Form
    {
        private readonly APIService _apiService = new APIService("users"); 
        public frmUsers()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var v = txtPretraga.Text?.Split(' ');

            var search = new UsersSearchRequest()
            {
                FirstName = txtPretraga.Text?.Split(' ')[0],
                LastName = txtPretraga.Text?.Split(' ').Length > 1 ? txtPretraga.Text?.Split(' ')[1] : null
            };

            var result = await _apiService.Get<List<Model.Users>>(search);

            dgvUsers.DataSource = result;
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {

        }
    }
}
