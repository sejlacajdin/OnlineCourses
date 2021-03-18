using OnlineCourseApp.Model.Requests.Courses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OnlineCourseApp.WinUI.Courses
{
    public partial class frmCoursesDetails : Form
    {
        private int _courseId;
        private readonly APIService _serviceCourses = new APIService("courses");
        private readonly APIService _serviceCourseSection = new APIService("course-section");
        public frmCoursesDetails(int courseId)
        {
            InitializeComponent();
            _courseId = courseId;
        }

        private async void frmCoursesDetails_Load(object sender, EventArgs e)
        {
            var list = await _serviceCourseSection.Get<List<Model.CourseSections>>(null);
            comboBoxCategory.DataSource = list;
            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.ValueMember = "CourseSectionId";

            var course =await _serviceCourses.GetById<Model.Courses>(_courseId);
            textBoxTitle.Text = course.CourseName;
            comboBoxCategory.SelectedValue = course.CourseSectionId;
            textBoxDescription.Text = course.Notes;


        }

        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            CoursesInsertRequest request = new CoursesInsertRequest()
            {
                CourseName = textBoxTitle.Text,
                Notes = textBoxDescription.Text,
                ProfessorId =1,
                IsActive = true,
                CourseSectionId =(int)comboBoxCategory.SelectedValue,
                Picture = null,
                PictureThumb = null
            };
            await _serviceCourses.Update<Model.Courses>(_courseId, request);
            MessageBox.Show("Successfully updated course.");
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                await _serviceCourses.Delete<Model.Courses>(_courseId);

                frmIndex frm = (frmIndex)Application.OpenForms.Cast<Form>().Where(x => x.Name == "frmIndex").FirstOrDefault();
                frmCourses form = new frmCourses();
                if (frm != null) frm.openChildForm(form);

                MessageBox.Show("Successfully deleted course.");

            }
            else return;

        }
    }
}
