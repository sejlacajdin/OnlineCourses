using Flurl.Http;
using OnlineCourseApp.Model.Requests.Courses;
using OnlineCourseApp.Model.Requests.Exams;
using OnlineCourseApp.Model.Requests.Questions;
using OnlineCourseApp.WinUI.Choices;
using OnlineCourseApp.WinUI.Questions;
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
        private readonly APIService _serviceQuestions = new APIService("questions");
        private int? _id = null;
        public frmExamAdd(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmTestAdd_Load(object sender, EventArgs e)
        {
            await LoadCourses();
            await LoadQuestions();
            lblTest.Text = _id ==null? "Add Test" : "Edit test";

            if (_id.HasValue)
            {
                var exam = await _serviceExams.GetById<Model.Exams>(_id);
                txtTitle.Text = exam.Title;
                comboBoxCourses.SelectedValue = exam.CourseId;
                textBoxInstructions.Text = exam.Instructions;
                dateTimePicker1.Value = DateTime.Parse(exam.TimeLimit);
                checkBoxActive.CheckState = exam.IsActive ? CheckState.Checked : CheckState.Unchecked;
            }
        }

        private async Task LoadCourses()
        {
            var list = await _serviceCourses.Get<List<Model.Courses>>(new CoursesSearchRequest { ProfessorId = APIService.UserId });
                if(list != null)
            {
                comboBoxCourses.DataSource = list;
                comboBoxCourses.DisplayMember = "CourseName";
                comboBoxCourses.ValueMember = "CourseId";
            }
        }
        private async Task LoadQuestions()
        {
            if (_id == null)
                return;

            var questions = await _serviceQuestions.Get<List<Model.Questions>>(new QuestionsSearchRequest { ExamId = (int)_id});
            dgvQuestions.AutoGenerateColumns = false;

            if (questions != null)
                dgvQuestions.DataSource = questions;
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

            if (_id.HasValue)
            {
                await _serviceExams.Update<Model.Exams>(_id,request);
                 MessageBox.Show("Successfully updated test.");
            }
            else
            {
                await _serviceExams.Insert<Model.Exams>(request);
                MessageBox.Show("Successfully added new test.");
                this.Close();
                frmIndex frm = (frmIndex)Application.OpenForms.Cast<Form>().Where(x => x.Name == "frmIndex").FirstOrDefault();
                if (frm != null) frm.openChildForm(new frmExam());
            }
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

        private async void checkBoxActive_CheckedChanged(object sender, EventArgs e)
        {
                var question = await _serviceQuestions.Get<List<Model.Questions>>(_id);

            if (checkBoxActive.Checked)
            {
                if(question.Count <= 0)
                {
                    MessageBox.Show("You need to have at least one question.");
                    checkBoxActive.CheckState = CheckState.Unchecked;
                    request.IsActive = false;
                }else
                     request.IsActive = true;
            }
            else
                    request.IsActive = false;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (_id == null)
            {
                MessageBox.Show("You have to add exam first");
                return;
            }
            frmQuestionAdd frm = new frmQuestionAdd((int)_id, null);
            frm.ShowDialog();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var _txtSearch = txtSearch.Text;

            var search = new QuestionsSearchRequest()
            {
                ExamId = (int)_id,
                Question = _txtSearch
            };

            var result = await _serviceQuestions.Get<List<Model.Questions>>(search);

            if (result != null)
                dgvQuestions.DataSource = result;
        }

        private async void dgvQuestions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvQuestions.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "Confirm", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    var id = dgvQuestions.SelectedRows[0].Cells[0].Value;
                    await _serviceQuestions.Delete<Model.Questions>(id);

                    var search = new QuestionsSearchRequest()
                    {
                        ExamId = (int)_id
                    };
                    var questions = await _serviceQuestions.Get<List<Model.Questions>>(search);
                    dgvQuestions.AutoGenerateColumns = false;

                    if (questions != null)
                        dgvQuestions.DataSource = questions;

                    MessageBox.Show("Successfully deleted question.");

                }
                else return;
            }
            else if (e.ColumnIndex == dgvQuestions.Columns["Update"].Index && e.RowIndex >= 0)
            {
                var id = dgvQuestions.SelectedRows[0].Cells[0].Value;
                frmQuestionAdd form = new frmQuestionAdd((int)_id,int.Parse(id.ToString()));
                form.ShowDialog();
            }
            else if (e.ColumnIndex == dgvQuestions.Columns["Answer"].Index && e.RowIndex >= 0)
            {
                frmChoices frm = new frmChoices();
                frm.ShowDialog();
            }
        }
    }
}
