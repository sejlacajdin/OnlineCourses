using Flurl.Http;
using OnlineCourseApp.Model.Requests.Courses;
using OnlineCourseApp.Model.Requests.Exams;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineCourseApp.WinUI.Tests
{
    public partial class frmExamAdd : Form
    {
        private readonly APIService _serviceCourses = new APIService("courses");
        private readonly APIService _serviceExams = new APIService("exams");
        public frmExamAdd(int? id = null)
        {
            InitializeComponent();
        }

        private async void frmTestAdd_Load(object sender, EventArgs e)
        {
            await LoadCourses();
        }

        private async Task LoadCourses()
        {
            var list = await _serviceCourses.Get<List<Model.Courses>>(new CoursesSearchRequest { ProfessorId = APIService.UserId });
            comboBoxCourses.DataSource = list;
            comboBoxCourses.DisplayMember = "CourseName";
            comboBoxCourses.ValueMember = "CourseId";
        }

        ExamsInsertRequest request = new ExamsInsertRequest();
        private async void btnAddTest_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;

            request.Title = txtTitle.Text;
            request.Instructions = textBoxInstructions.Text;
            request.TimeLimit = new TimeSpan(0, dateTimePicker1.Value.Minute, dateTimePicker1.Value.Second).ToString();
            request.CourseId = (int)comboBoxCourses.SelectedValue;
            request.ExamOwnerId = APIService.UserId;

            await _serviceExams.Insert<Model.Exams>(request);
            this.Close();
            MessageBox.Show("Successfully added new test.");
            frmIndex frm = (frmIndex)Application.OpenForms.Cast<Form>().Where(x => x.Name == "frmIndex").FirstOrDefault();
            if (frm != null) frm.openChildForm(new frmExam());
        }

        private void comboBoxCourses_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxCourses.SelectedIndex == -1)
            {
                errorProvider1.SetError(comboBoxCourses, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(comboBoxCourses, null);
        }

        private void textBoxInstructions_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxInstructions.Text))
            {
                errorProvider1.SetError(textBoxInstructions, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(textBoxInstructions, null);
        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                errorProvider1.SetError(txtTitle, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(txtTitle, null);
        }

        private void checkBoxActive_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxActive.Checked)
                request.IsActive = true;
            else
                request.IsActive = false;
        }
    }
}
