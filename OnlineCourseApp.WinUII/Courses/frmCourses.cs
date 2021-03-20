using OnlineCourseApp.Model.Requests.Courses;
using OnlineCourseApp.WinUI.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineCourseApp.WinUI.Courses
{
    public partial class frmCourses : Form
    {
        private readonly APIService _serviceCourses = new APIService("courses");
        private readonly APIService _serviceCourseSection = new APIService("course-section");

        public frmCourses()
        {
            InitializeComponent();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            frmCoursesAdd frm = new frmCoursesAdd();
            frm.ShowDialog();
        }

        private async void frmCourses_Load(object sender, EventArgs e)
        {
            var courses = await _serviceCourses.Get<List<Model.Courses>>(null);
            cardsPanel1.ViewModel = await LoadSomeData(courses);
            cardsPanel1.DataBind();
        }

        private async Task<CardsViewModel> LoadSomeData(List<Model.Courses> courses)
        {
            ObservableCollection<CardViewModel> cards = new ObservableCollection<CardViewModel>();
            
            foreach (var item in courses)
            {
                var section = await _serviceCourseSection.GetById<Model.CourseSections>(item.CourseSectionId);
                CardViewModel course = new CardViewModel()
                {
                    courseId = item.CourseId,
                    courseName = item.CourseName,
                    courseSection = section.Name,
                    notes = item.Notes
                };
                if (item.Picture != null && item.Picture.Length > 0)
                    course.picture = Image.FromStream(new MemoryStream(item.Picture));

                cards.Add(course);
            }
        
            CardsViewModel VM = new CardsViewModel()
            {
                Cards = cards
            };
            return VM;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var _txtSearch = txtSearch.Text;

            var search = new CoursesSearchRequest()
            {
                CourseName = _txtSearch
            };

            var result = await _serviceCourses.Get<List<Model.Courses>>(search);

            cardsPanel1.ViewModel = await LoadSomeData(result);
            cardsPanel1.DataBind();
        }
    }
}
