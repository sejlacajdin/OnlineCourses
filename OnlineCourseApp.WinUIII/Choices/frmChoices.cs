﻿using OnlineCourseApp.Model;
using OnlineCourseApp.Model.Requests.Choices;
using OnlineCourseApp.Model.Requests.Questions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OnlineCourseApp.WinUI.Choices
{
    public partial class frmChoices : Form
    {
        private readonly APIService _serviceChoices = new APIService("choices");
        private readonly APIService _serviceQuestions = new APIService("questions");
        private readonly APIService _serviceExamAnsweredQuestions = new APIService("exam-answers");
        private int? _questionId = null;
        public frmChoices(int? questionId = null)
        {
            InitializeComponent();
            _questionId = questionId;
        }

        private void btnAddChoice_Click(object sender, EventArgs e)
        {
            frmChoiceAdd frm = new frmChoiceAdd(_questionId);
            frm.ShowDialog();
        }

        private async void frmChoices_Load(object sender, EventArgs e)
        {
            var choices = await _serviceChoices.Get<List<Model.Choices>>(new ChoicesSearchRequest { QuestionId = (int)_questionId });
            dgvChoices.AutoGenerateColumns = false;
            if (choices != null)
                dgvChoices.DataSource = choices;
        }

        private async void dgvChoices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvChoices.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "Confirm", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    var id = dgvChoices.SelectedRows[0].Cells[0].Value;
                    var choiceExist = await _serviceExamAnsweredQuestions.Get<double>(new ExamAnsweredQuestionsSearchRequest { QuestionId = (int)_questionId, ChoiceId = (int)id });

                    if(choiceExist == -1)
                    await _serviceChoices.Delete<Model.Choices>(id);
                    else
                    {
                        MessageBox.Show("You can't delete this choice. There are results of exam.");
                        return;
                    }

                    var search = new ChoicesSearchRequest()
                    {
                        QuestionId = (int)_questionId
                    };
                    var choices = await _serviceChoices.Get<List<Model.Choices>>(search);
                    dgvChoices.AutoGenerateColumns = false;

                    dgvChoices.DataSource = choices;
                    
                    if (choices.Count == 0)
                    {
                        var question = await _serviceQuestions.GetById<Model.Questions>(_questionId);
                        var request = new QuestionsInsertRequest
                        {
                            ExamId = question.ExamId,
                            IsActive = false,
                            Points = question.Points,
                            QuestionCategoryId = question.QuestionCategoryId,
                            QuestionNumber = question.QuestionNumber,
                            QuestionTypeId = question.QuestionTypeId,
                            Text = question.Text
                        };

                        await _serviceQuestions.Update<Model.Questions>(_questionId, request);
                    }

                    MessageBox.Show("Successfully deleted choice.");

                }
                else return;
            }
            else if (e.ColumnIndex == dgvChoices.Columns["Update"].Index && e.RowIndex >= 0)
            {
                var id = dgvChoices.SelectedRows[0].Cells[0].Value;
                frmChoiceAdd form = new frmChoiceAdd(_questionId,int.Parse(id.ToString()));
                form.ShowDialog();
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var _txtSearch = txtSearch.Text;

            var search = new ChoicesSearchRequest()
            {
                QuestionId = (int)_questionId,
                Text = _txtSearch
            };

            var result = await _serviceChoices.Get<List<Model.Choices>>(search);

            if (result != null)
                dgvChoices.DataSource = result;
        }
    }
}
