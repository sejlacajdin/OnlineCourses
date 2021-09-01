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

namespace OnlineCourseApp.WinUI.Courses
{
    public partial class frmCoursesAdd : Form
    {
        private readonly APIService _serviceCourses = new APIService("courses");
        private readonly APIService _serviceCourseSection = new APIService("course-section");
        public frmCoursesAdd()
        {
            InitializeComponent();
        }

        private async void buttonAddCourse_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;

            var request = new CoursesInsertRequest()
            {
                CourseName = textTitle.Text,
                Notes = textBoxDescription.Text,
                IsActive = true,
                CourseSectionId = (int) comboBoxCategory.SelectedValue,
                ProfessorId = APIService.UserId,
                Price = Double.Parse(txtPrice.Text),
                Picture = null,
                PictureThumb = null
            };
             await _serviceCourses.Insert<Model.Courses>(request);
            this.Close();
            MessageBox.Show("Successfully added new course.");
            frmIndex frm = (frmIndex)Application.OpenForms.Cast<Form>().Where(x => x.Name == "frmIndex").FirstOrDefault();
            if(frm != null) frm.openChildForm(new frmCourses());

        }

        private async void frmCoursesDetails_Load(object sender, EventArgs e)
        {
             await LoadCourseSections();
        }

        private async Task LoadCourseSections()
        {
            var list = await _serviceCourseSection.Get<List<Model.CourseSections>>(null);
            comboBoxCategory.DataSource = list;
            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.ValueMember = "CourseSectionId";
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

        private void comboBoxCategory_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxCategory.SelectedIndex == -1)
            {
                errorProvider.SetError(comboBoxCategory, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
                errorProvider.SetError(comboBoxCategory, null);
        }
    }
}
