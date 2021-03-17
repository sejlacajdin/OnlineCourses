﻿using OnlineCourseApp.Model.Requests.Courses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OnlineCourseApp.WinUI.Courses
{
    public partial class frmCoursesDetails : Form
    {
        private readonly APIService _serviceCourses = new APIService("courses");
        private readonly APIService _serviceCourseSection = new APIService("course-section");
        public frmCoursesDetails()
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
                ProfessorId = 1, /*need to be changed*/
                Picture = null,
                PictureThumb = null
            };
             await _serviceCourses.Insert<Model.Courses>(request);
            this.Close();
            MessageBox.Show("Successfully added new course.");
        }

        private async void frmCoursesDetails_Load(object sender, EventArgs e)
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
                errorProvider.SetError(textTitle, null);
        }
    }
}
