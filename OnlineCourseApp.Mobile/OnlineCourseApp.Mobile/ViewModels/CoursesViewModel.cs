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
    public class CoursesViewModel : BaseViewModel
    {
        private readonly APIService _serviceCourses = new APIService("courses");
        private readonly APIService _serviceCourseSection = new APIService("course-section");
        private readonly APIService _serviceCourseParticipant = new APIService("course-participants");

        public CoursesViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<Courses> Courses { get; set; } = new ObservableCollection<Courses>();
        public ObservableCollection<CourseSections> CourseSections { get; set; } = new ObservableCollection<CourseSections>();

        CourseSections _selectedCourseSection = null;
        public CourseSections SelectedCourseSection
        {
            get { return _selectedCourseSection; }
            set { 
                SetProperty(ref _selectedCourseSection, value);
                if (value != null)
                    InitCommand.Execute(null);
            }
        }

        public ICommand InitCommand { get; set; }


        public async Task Init()
        {
            if(CourseSections.Count == 0)
            {
            var courseSections = await _serviceCourseSection.Get<List<CourseSections>>(null);
                CourseSections.Add(new CourseSections { CourseSectionId =0, Name="All"});
            foreach (var section in courseSections)
                CourseSections.Add(section);
            }

            CoursesSearchRequest search = new CoursesSearchRequest { 
                IsActive = true
            };
            if (SelectedCourseSection != null)
                search.CourseSectionId = SelectedCourseSection.CourseSectionId;
            else
                search.CourseSectionId = 0;

            var coursePax = await _serviceCourseParticipant.Get<List<CourseParticipants>>(new CourseParticipantsSearchRequest { StudentId = APIService.UserId });
            var courses = await _serviceCourses.Get<IEnumerable<Courses>>(search);
            Courses.Clear();

            foreach (var course in courses)
            {
                if (course.Picture.Length == 0)
                    course.Picture = null;
                course.Price = course.Price != null ? course.Price : 0.00;

                if (course.Rating != null)
                    course.FinalRating = (float)course.Rating / course.NumOfRatings;
                else
                    course.FinalRating = 0;

                if (!coursePax.Exists(x => x.CourseId == course.CourseId))
                    Courses.Add(course);
            }
        }
    }
}
