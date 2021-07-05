using OnlineCourseApp.Model.Requests.Exams;
using OnlineCourseApp.Model.Requests.Questions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OnlineCourseApp.WinUI.Tests
{
    public partial class frmExam : Form
    {
        private readonly APIService _serviceExams = new APIService("exams");
        private readonly APIService _serviceQuestions = new APIService("questions");

        public frmExam()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmIndex frm = (frmIndex)Application.OpenForms.Cast<Form>().Where(x => x.Name == "frmIndex").FirstOrDefault();
            frmExamAdd form = new frmExamAdd();
            if (frm != null) frm.openChildForm(form);
            else form.Show();
        }

        private async void frmExam_Load(object sender, EventArgs e)
        {
            var exams = await _serviceExams.Get<List<Model.Exams>>(new ExamsSearchRequest { ExamOwnerId = APIService.UserId});
            dgvTests.AutoGenerateColumns = false;

            if (exams != null)
                dgvTests.DataSource = exams;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var _txtSearch = txtSearch.Text;

            var search = new ExamsSearchRequest()
            {
                Title = _txtSearch,
                ExamOwnerId = APIService.UserId
            };

            var result = await _serviceExams.Get<List<Model.Exams>>(search);

            if (result != null)
                dgvTests.DataSource = result;
        }

       

        private async void dgvTests_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvTests.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "Confirm", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    var id = dgvTests.SelectedRows[0].Cells[0].Value;
                    var questions = await _serviceQuestions.Get<List<Model.Questions>>(new QuestionsSearchRequest {ExamId = (int)id });

                    if(questions.Count > 0)
                    {
                        MessageBox.Show("You can't delete this exam. There are questions.");
                        return;
                    }

                    await _serviceExams.Delete<Model.Exams>(id);

                    var search = new ExamsSearchRequest()
                    {
                        ExamOwnerId = APIService.UserId
                    };
                    var exams = await _serviceExams.Get<List<Model.Exams>>(search);
                    dgvTests.AutoGenerateColumns = false;

                    if (exams != null)
                        dgvTests.DataSource = exams;

                    MessageBox.Show("Successfully deleted test.");

                }
                else return;
            }
            else if (e.ColumnIndex == dgvTests.Columns["Update"].Index && e.RowIndex >= 0)
            {
                var id = dgvTests.SelectedRows[0].Cells[0].Value;
                frmIndex frm = (frmIndex)Application.OpenForms.Cast<Form>().Where(x => x.Name == "frmIndex").FirstOrDefault();
                frmExamAdd form = new frmExamAdd(int.Parse(id.ToString()));
                if (frm != null) frm.openChildForm(form);
                else form.Show();
            }
        }
    }
}
