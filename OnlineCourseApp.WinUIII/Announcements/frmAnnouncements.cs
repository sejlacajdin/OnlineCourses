using OnlineCourseApp.Model.Requests.Announcements;
using OnlineCourseApp.Model.Requests.Courses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineCourseApp.WinUI.Announcements
{
    public partial class frmAnnouncements : Form
    {
        private readonly APIService _serviceAnnouncements = new APIService("announcements");
        private readonly APIService _serviceAnnouncementFilters = new APIService("announcement-filters");
        private readonly APIService _serviceCourses = new APIService("courses");
        private readonly APIService _serviceCourseSection = new APIService("course-section");
        private readonly APIService _serviceCourseType = new APIService("course-type");


        public frmAnnouncements()
        {
            InitializeComponent();
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


        private void button1_Click(object sender, EventArgs e)
        {
            frmAnnouncementAdd frm = new frmAnnouncementAdd();
            frm.ShowDialog();
        }

        private async void frmAnnouncements_Load(object sender, EventArgs e)
        {
            await LoadCourses();
            await LoadCourseSections();
            await LoadCourseTypes();

            var myAnnouncements = await _serviceAnnouncements.Get<List<Model.Announcements>>(new AnnouncementsSearchRequest { AnnouncementOwnerId = APIService.UserId });
            var announcements = await _serviceAnnouncements.Get<List<Model.Announcements>>(new AnnouncementsSearchRequest { FilterTypeId = new List<int>(2) { 1, 2 } });

            dgvMyAnnouncements.AutoGenerateColumns = false;
            dgvAnnouncements.AutoGenerateColumns = false;

            dgvMyAnnouncements.DataSource = myAnnouncements;
            dgvAnnouncements.DataSource = announcements;
        }

        private async void dgvAnnouncements_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvMyAnnouncements.Columns["Delete"].Index && e.RowIndex >= 0)
            {

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "Confirm", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    var id = dgvMyAnnouncements.SelectedRows[0].Cells[0].Value;

                    await _serviceAnnouncementFilters.Delete<Model.AnnouncementFilters>(id);
                    await _serviceAnnouncements.Delete<Model.Announcements>(id);

                    var myAnnouncements = await _serviceAnnouncements.Get<List<Model.Announcements>>(new AnnouncementsSearchRequest {AnnouncementOwnerId = APIService.UserId });
                    dgvMyAnnouncements.AutoGenerateColumns = false;

                    dgvMyAnnouncements.DataSource = myAnnouncements;

                    MessageBox.Show("Successfully deleted announcement.");


                }
                else return;
            }
            else if (e.ColumnIndex == dgvMyAnnouncements.Columns["Update"].Index && e.RowIndex >= 0)
            {
                var id = dgvMyAnnouncements.SelectedRows[0].Cells[0].Value;
                frmAnnouncementAdd form = new frmAnnouncementAdd(int.Parse(id.ToString()));
                form.ShowDialog();
            }
        }

        private void dgvAnnouncements_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvAnnouncements.Columns["Details"].Index && e.RowIndex >= 0)
            {
                var id = dgvMyAnnouncements.SelectedRows[0].Cells[0].Value;
                frmAnnouncementDetails form = new frmAnnouncementDetails(int.Parse(id.ToString()));
                form.ShowDialog();
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var _txtSearch = txtSearch.Text;

            var myAnnouncements = await _serviceAnnouncements.Get<List<Model.Announcements>>(new AnnouncementsSearchRequest { Title = _txtSearch, AnnouncementOwnerId = APIService.UserId });
            var announcements = await _serviceAnnouncements.Get<List<Model.Announcements>>(new AnnouncementsSearchRequest { Title = _txtSearch,  FilterTypeId = new List<int>(2) { 1, 2 } });

            dgvMyAnnouncements.DataSource = myAnnouncements;
            dgvAnnouncements.DataSource = announcements;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            AnnouncementFiltersSearchRequest request = new AnnouncementFiltersSearchRequest
            {
                CourseId = (int)cmbCourses.SelectedValue,
                CourseSectionId = (int)cmbCourseSection.SelectedValue,
                CourseTypeId = (int)cmbCourseType.SelectedValue
            };

            var announcements = await _serviceAnnouncementFilters.Get<List<Model.AnnouncementFilters>>(request);
            List<Model.Announcements> myList = new List<Model.Announcements>();
            List<Model.Announcements> list = new List<Model.Announcements>();

            foreach (var item in announcements)
            {
                var ann = await _serviceAnnouncements.GetById<Model.Announcements>(item.AnnouncementId);
                if (ann.AnnouncementOwnerId == APIService.UserId)
                    myList.Add(ann);
                else if (ann.FilterTypeId == 1 || ann.FilterTypeId == 2)
                    list.Add(ann);
            }

            dgvMyAnnouncements.DataSource = myList;
            dgvAnnouncements.DataSource = list;
        }
    }
}
