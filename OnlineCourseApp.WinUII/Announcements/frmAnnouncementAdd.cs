using OnlineCourseApp.Model.Requests.Announcements;
using OnlineCourseApp.Model.Requests.Courses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineCourseApp.WinUI.Announcements
{
    public partial class frmAnnouncementAdd : Form
    {
        private readonly APIService _serviceCourses = new APIService("courses");
        private readonly APIService _serviceCourseSection = new APIService("course-section");
        private readonly APIService _serviceCourseType = new APIService("course-type");
        private readonly APIService _serviceFilter = new APIService("announcement-filter-types");
        private readonly APIService _serviceAnnouncements = new APIService("announcements");
        private readonly APIService _serviceAnnouncementFilters = new APIService("announcement-filters");

        private int? _id = null;

        public frmAnnouncementAdd(int? id = null)
        {
            InitializeComponent();
            _id = id;

        }

        private async void frmAnnouncementAdd_Load(object sender, EventArgs e)
        {
            await LoadCourses();
            await LoadCourseSections();
            await LoadCourseTypes();
            await LoadFilters();
            lblAnnouncement.Text = _id == null ? "Add announcement" : "Edit announcement";

            if (_id.HasValue)
            {
                var announcement = await _serviceAnnouncements.GetById<Model.Announcements>(_id);
                var filter = await _serviceAnnouncementFilters.Get<List<Model.AnnouncementFilters>>(new AnnouncementFiltersSearchRequest { AnnouncementId = (int)_id});
                cmbFilter.SelectedValue = announcement.FilterTypeId;
                cmbCourses.SelectedValue = filter?.FirstOrDefault().CourseId != null ? filter.FirstOrDefault().CourseId : 0;
                cmbCourseSection.SelectedValue = filter?.FirstOrDefault().CourseSectionId != null? filter?.FirstOrDefault().CourseSectionId : 0;
                cmbCourseType.SelectedValue = filter?.FirstOrDefault().CourseTypeId != null? filter?.FirstOrDefault().CourseTypeId : 0;
                textTitle.Text = announcement.Title;
                txtBoxShortDesc.Text = announcement.ShortDescription;
                textBoxDescription.Text = announcement.Description;
            }
        }
        private async Task LoadCourses()
        {
            var list = await _serviceCourses.Get<List<Model.Courses>>(new CoursesSearchRequest { ProfessorId = APIService.UserId });

            BindingSource bs = new BindingSource();
            BindingList<Model.Courses> courses = new BindingList<Model.Courses>();
            courses.Add(new Model.Courses());

            foreach (var item in list)
                courses.Add(item);

            bs.DataSource = courses;

            cmbCourses.DataSource = bs;
            //cmbCourses.DataSource = list;
            cmbCourses.DisplayMember = "CourseName";
                cmbCourses.ValueMember = "CourseId";
     
        }
        private async Task LoadCourseSections()
        {
            var list = await _serviceCourseSection.Get<List<Model.CourseSections>>(null);

            BindingSource bs = new BindingSource();
            BindingList<Model.CourseSections> courseSections = new BindingList<Model.CourseSections>();
            courseSections.Add(new Model.CourseSections());

            foreach (var item in list)
                courseSections.Add(item);

            bs.DataSource = courseSections;

            cmbCourseSection.DataSource = bs;
            cmbCourseSection.DisplayMember = "Name";
            cmbCourseSection.ValueMember = "CourseSectionId";
        }
        private async Task LoadCourseTypes()
        {
            var list = await _serviceCourseType.Get<List<Model.CourseTypes>>(null);
            BindingSource bs = new BindingSource();
            BindingList<Model.CourseTypes> courseTypes = new BindingList<Model.CourseTypes>();
            courseTypes.Add(new Model.CourseTypes());

            foreach (var item in list)
                courseTypes.Add(item);

            bs.DataSource = courseTypes;

            cmbCourseType.DataSource = bs;
            cmbCourseType.DisplayMember = "Name";
            cmbCourseType.ValueMember = "CourseTypeId";
        }
        private async Task LoadFilters()
        {
            var list = await _serviceFilter.Get<List<Model.AnnouncementFilterTypes>>(null);
            cmbFilter.DataSource = list;
            cmbFilter.DisplayMember = "Name";
            cmbFilter.ValueMember = "AnnouncementFilterTypeId";
        }

        private void textTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textTitle.Text))
            {
                errorProvider.SetError(textTitle, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
                errorProvider.SetError(textTitle, null);
        }

        private void textBoxDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxDescription.Text))
            {
                errorProvider.SetError(textBoxDescription, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
                errorProvider.SetError(textBoxDescription, null);
        }

        private async void buttonAddAnnouncement_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;
            AnnouncementsInsertRequest request = new AnnouncementsInsertRequest
            {
                Title = textTitle.Text,
                ShortDescription = txtBoxShortDesc.Text,
                Description = textBoxDescription.Text,
                FilterTypeId = (int)cmbFilter.SelectedValue,
               
                AnnouncementOwnerId = APIService.UserId,
                PostOwner = APIService.Username
            };

            Model.Announcements annoncementResponse;
            if (_id.HasValue)
                 annoncementResponse = await _serviceAnnouncements.Update<Model.Announcements>(_id,request);       
            else
                 annoncementResponse = await _serviceAnnouncements.Insert<Model.Announcements>(request);

            AnnouncementFiltersInsertRequest requestFilter = new AnnouncementFiltersInsertRequest
            {
                AnnouncementId = annoncementResponse.AnnouncementId,
                CourseId = (int)cmbCourses.SelectedValue,
                CourseSectionId = (int)cmbCourseSection.SelectedValue,
                CourseTypeId = (int)cmbCourseType.SelectedValue,
            };

            if (_id.HasValue)
            {
                await _serviceAnnouncementFilters.Update<Model.AnnouncementFilters>(_id, requestFilter);
                MessageBox.Show("Successfully updated announcement.");

            }
            else
            {
                await _serviceAnnouncementFilters.Insert<Model.AnnouncementFilters>(requestFilter);
                MessageBox.Show("Successfully added new announcement.");
            }

                this.Close();
                frmIndex frm = (frmIndex)Application.OpenForms.Cast<Form>().Where(x => x.Name == "frmIndex").FirstOrDefault();
                if (frm != null) frm.openChildForm(new frmAnnouncements());
        }
    }
}
