using OnlineCourseApp.Model.Requests.Choices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OnlineCourseApp.WinUI.Choices
{
    public partial class frmChoiceAdd : Form
    {
        private readonly APIService _serviceChoices = new APIService("choices");
        private readonly APIService _serviceQuestions = new APIService("questions");
        private int? _questionId = null;
        private int? _id = null;
        public frmChoiceAdd(int? questionId = null, int? id = null)
        {
            InitializeComponent();
            _questionId = questionId;
            _id = id;
        }

        ChoicesInsertRequest request = new ChoicesInsertRequest();

        private async void btnSaveChoice_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;

            if (request.IsCorrect == null)
                request.IsCorrect = false;

            request.QuestionId = (int)_questionId;
            request.Text = textBoxChoice.Text;
            request.Percentage = (double)txtPercentage.Value;

            if (_id.HasValue)
            {
                await _serviceChoices.Update<Model.Choices>(_id, request);
                MessageBox.Show("Successfully updated choice.");
            }
            else
            {
                await _serviceChoices.Insert<Model.Choices>(request);
                MessageBox.Show("Successfully added new choice.");
            }
                this.Close();
                Form fc = Application.OpenForms["frmChoices"];

                if (fc != null)
                    fc.Close();

                frmChoices frm = new frmChoices((int)_questionId);
                frm.ShowDialog();
        }

        private async void checkBoxActive_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBoxActive.Checked)
            {
            var question =await _serviceQuestions.GetById<Model.Questions>(_questionId);
            var choices = await _serviceChoices.Get<List<Model.Choices>>(new ChoicesSearchRequest { QuestionId = (int)_questionId });

            if(question.QuestionTypeId == 2 && choices.Any(c => c.IsCorrect == true))
            {
                MessageBox.Show("Type of question is MCSA and there is already correct answer.");
                return;
            }

                    request.IsCorrect = true;
            }            
            else
                request.IsCorrect = false;
        }

        private async void frmChoiceAdd_Load(object sender, EventArgs e)
        {
            lblChoice.Text = _id == null ? "Add choice" : "Edit choice";

            if (_id.HasValue)
            {
                var choice = await _serviceChoices.GetById<Model.Choices>(_id);
                textBoxChoice.Text = choice.Text;
                txtPercentage.Value = (decimal)choice.Percentage;
                checkBoxActive.CheckedChanged -= this.checkBoxActive_CheckedChanged;
                checkBoxActive.CheckState = (bool)choice.IsCorrect ? CheckState.Checked : CheckState.Unchecked;      
                checkBoxActive.CheckedChanged += this.checkBoxActive_CheckedChanged;
            }
        }

        private void textBoxChoice_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxChoice.Text))
            {
                errorProvider.SetError(textBoxChoice, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
                errorProvider.SetError(textBoxChoice, null);
        }

        private void txtPercentage_Validating(object sender, CancelEventArgs e)
        {
            if (txtPercentage.Value <=0)
            {
                errorProvider.SetError(txtPercentage, "Value need to be more than 0.");
                e.Cancel = true;
            }
            else
                errorProvider.SetError(txtPercentage, null);
        }
    }
}
