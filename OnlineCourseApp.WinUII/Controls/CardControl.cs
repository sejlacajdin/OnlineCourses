using OnlineCourseApp.WinUI.Courses;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OnlineCourseApp.WinUI.Controls
{
    public partial class CardControl : UserControl
    {
        public CardViewModel ViewModel { get; set; }

        public CardControl()
        {
            InitializeComponent();
        }
        public CardControl(CardViewModel viewModel)
        {
            ViewModel = viewModel;
            InitializeComponent();
        }

        public void DataBind()
        {
            SuspendLayout();

            courseName.Text = ViewModel.courseName;
            courseSection.Text = ViewModel.courseSection;
            notes.Text = ViewModel.notes;
            courseId.Text = ViewModel.courseId.ToString();
            pictureBox.Image = ViewModel.picture;

            ResumeLayout();
        }
        private void CardControl_Click(object sender, EventArgs e)
        {
            frmIndex frm =(frmIndex) Application.OpenForms.Cast<Form>().Where(x => x.Name == "frmIndex").FirstOrDefault();
            frmCoursesDetails form = new frmCoursesDetails(int.Parse(courseId.Text));
            if (frm != null) frm.openChildForm(form);
            else form.Show();
        }
    }

    public class CardsViewModel
    {
        public ObservableCollection<CardViewModel> Cards { get; set; }
    }

    public class CardViewModel
    {
        public int courseId { get; set; }
        public string courseName { get; set; }
        public string courseSection { get; set; }
        public string notes { get; set; }
        public Image picture { get; set; }
    }
}
