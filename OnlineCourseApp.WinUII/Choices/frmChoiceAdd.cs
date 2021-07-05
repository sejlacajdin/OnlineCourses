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

        private void checkBoxActive_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxActive.Checked)                
                    request.IsCorrect = true;
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
                checkBoxActive.CheckState = (bool)choice.IsCorrect ? CheckState.Checked : CheckState.Unchecked;
            }
        }
    }
}
