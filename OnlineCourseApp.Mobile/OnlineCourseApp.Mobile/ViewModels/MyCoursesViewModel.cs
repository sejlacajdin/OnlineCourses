using OnlineCourseApp.Mobile.Views;
using OnlineCourseApp.Model;
using OnlineCourseApp.Model.Requests.CourseParticipants;
using OnlineCourseApp.Model.Requests.Courses;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace OnlineCourseApp.Mobile.ViewModels
{
    public class MyCoursesViewModel : BaseViewModel
    {
        private readonly APIService _serviceCourses = new APIService("courses");
        private readonly APIService _serviceCourseParticipant = new APIService("course-participants");

        public MyCoursesViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<Courses> Courses { get; set; } = new ObservableCollection<Courses>();

        public ICommand InitCommand { get; set; }


        public async Task Init()
        {
            var courseParticipant = await _serviceCourseParticipant.Get<List<CourseParticipants>>(new CourseParticipantsSearchRequest { StudentId = APIService.UserId });

            var courses = await _serviceCourses.Get<IEnumerable<Courses>>(new CoursesSearchRequest { IsActive = true });
            Courses.Clear();

            foreach (var course in courses)
            {
                if (course.Picture.Length == 0)
                    course.Picture = null;

                if (courseParticipant.Exists(x => x.CourseId == course.CourseId))
                    Courses.Add(course);
            }
        }
    }
}