using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OnlineCourseApp.WinUI.Announcements
{
    public partial class frmAnnouncementDetails : Form
    {
        private int? _id = null;
        private readonly APIService _serviceAnnouncements = new APIService("announcements");

        public frmAnnouncementDetails(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmAnnouncementDetails_Load(object sender, EventArgs e)
        {
            if (!_id.HasValue)
                return;
            
            var announcement = await _serviceAnnouncements.GetById<Model.Announcements>(_id);

            lblTitle.Text = announcement.Title;
            lblPostOwner.Text = announcement.PostOwner;
            tbxShortDescription.Text = announcement.ShortDescription;
            tbxDescription.Text = announcement.Description;
        }

    }
}
