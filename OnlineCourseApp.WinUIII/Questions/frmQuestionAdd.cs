using OnlineCourseApp.Model.Requests.Choices;
using OnlineCourseApp.Model.Requests.Questions;
using OnlineCourseApp.WinUI.Tests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineCourseApp.WinUI.Questions
{
    public partial class frmQuestionAdd : Form
    {
        private readonly APIService _serviceQuestionCategories = new APIService("question-category");
        private readonly APIService _serviceQuestionTypes = new APIService("question-type");
        private readonly APIService _serviceQuestion = new APIService("questions");
        private readonly APIService _serviceChoices = new APIService("choices");
        private int? _id = null;
        private Model.Questions _questions = null;
        private int _examId;

        public frmQuestionAdd(int examId,int? id = null)
        {
            InitializeComponent();
            _id = id;
            _examId = examId;
        }

        private async Task LoadQuestionCategories()
        {
            var list = await _serviceQuestionCategories.Get<List<Model.QuestionCategories>>(null);
            cmbQuestionCategory.DataSource = list;
            cmbQuestionCategory.DisplayMember = "CategoryName";
            cmbQuestionCategory.ValueMember = "QuestionCategoryId";
        }

        private async Task LoadQuestionTypes()
        {
            var list = await _serviceQuestionTypes.Get<List<Model.QuestionTypes>>(null);
            cmbQuestionType.DataSource = list;
            cmbQuestionType.DisplayMember = "TypeName";
            cmbQuestionType.ValueMember = "QuestionTypeId";
        }

        private async void frmQuestionAdd_Load(object sender, EventArgs e)
        {
            await LoadQuestionCategories();
            await LoadQuestionTypes();
            labelQuestion.Text = _id == null ? "Add question" : "Edit question";

            if (_id.HasValue)
            {
                _questions = await _serviceQuestion.GetById<Model.Questions>(_id);
                cmbQuestionCategory.SelectedValue = _questions.QuestionCategoryId;

                cmbQuestionType.SelectedIndexChanged -= this.cmbQuestionType_SelectionChangeCommitted;
                cmbQuestionType.SelectedValue = _questions.QuestionTypeId;
                cmbQuestionType.SelectedIndexChanged += this.cmbQuestionType_SelectionChangeCommitted;

                txtPoints.Value = (decimal)_questions.Points;
                textBoxQuestion.Text = _questions.Text;
                checkBoxActive.CheckedChanged -= this.checkBoxActive_CheckedChanged;
                checkBoxActive.CheckState = _questions.IsActive ? CheckState.Checked : CheckState.Unchecked;
                checkBoxActive.CheckedChanged += this.checkBoxActive_CheckedChanged;

            }
        }

        QuestionsInsertRequest request = new QuestionsInsertRequest();
        private async void btnAddQuestion_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;
            var questions = await _serviceQuestion.Get<List<Model.Questions>>(new QuestionsSearchRequest { ExamId = (int)_examId });
            var questionCount = questions.Count();
     
            request.QuestionCategoryId = (int)cmbQuestionCategory.SelectedValue;
            request.QuestionTypeId = (int)cmbQuestionType.SelectedValue;
            request.ExamId = _examId;
            request.Points = (double)txtPoints.Value;
            request.Text = textBoxQuestion.Text;
            request.QuestionNumber = ++questionCount;


            if (_id.HasValue)
            {
                await _serviceQuestion.Update<Model.Questions>(_id, request);
                MessageBox.Show("Successfully updated question.");
            }
            else
            {
                await _serviceQuestion.Insert<Model.Questions>(request);
                MessageBox.Show("Successfully added new question.");
            }
                this.Close();
                frmIndex frm = (frmIndex)Application.OpenForms.Cast<Form>().Where(x => x.Name == "frmIndex").FirstOrDefault();
                if (frm != null) frm.openChildForm(new frmExamAdd(_examId));
        }

        private async void checkBoxActive_CheckedChanged(object sender, EventArgs e)
        {
            var choices = await _serviceChoices.Get<List<Model.Choices>>(new ChoicesSearchRequest { QuestionId = (int)_id });

            if (checkBoxActive.Checked)
            {
                if (choices.Count <= 0)
                {
                    MessageBox.Show("You need to have at least one answer.");
                    checkBoxActive.CheckState = CheckState.Unchecked;
                    request.IsActive = false;
                }
                else
                    request.IsActive = true;
            }
                else
                    request.IsActive = false;
            }

        private void txtPoints_Validating(object sender, CancelEventArgs e)
        {
            if (txtPoints.Value <=0)
            {
                errorProvider.SetError(txtPoints, "Value need to be more than 0");
                e.Cancel = true;
            }
            else
                errorProvider.SetError(txtPoints, null);
        }

        private void textBoxQuestion_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxQuestion.Text))
            {
                errorProvider.SetError(textBoxQuestion, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
                errorProvider.SetError(textBoxQuestion, null);
        }

        private async void cmbQuestionType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var choices = await _serviceChoices.Get<List<Model.Choices>>(new ChoicesSearchRequest { QuestionId = (int)_id });
                if (choices.Count != 0 && (int)cmbQuestionType.SelectedValue != _questions.QuestionTypeId)
                {
                    cmbQuestionType.SelectedValue = _questions.QuestionTypeId;
                    MessageBox.Show("You can't change type of question. There are choices.");
                    return;
                }

            }
        }
    }
}
