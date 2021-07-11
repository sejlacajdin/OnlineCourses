using OnlineCourseApp.Mobile.Views;
using OnlineCourseApp.Model;
using OnlineCourseApp.Model.Requests.CourseParticipants;
using OnlineCourseApp.Model.Requests.Courses;
using OnlineCourseApp.Model.Requests.Documents;
using OnlineCourseApp.Model.Requests.Videos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace OnlineCourseApp.Mobile.ViewModels
{
    public class CourseReviewViewModel : BaseViewModel
    {
        private readonly APIService _serviceCourses = new APIService("courses");
        private readonly APIService _serviceCourseParticipant = new APIService("course-participants");
        public ICommand clickCommand { get; set; }
        public CourseReviewViewModel()
        {
            InitCommand = new Command(async (courseId) => await Init((int)courseId));
            clickCommand = new Command(onClicked); // this will execute on the click of Click me button.
        }

        Courses _course = null;
        public Courses Course
        {
            get { return _course; }
            set
            {
                SetProperty(ref _course, value);
            }
        }

        string _comment = string.Empty;
        public string Comment
        {
            get { return _comment; }
            set
            {
                SetProperty(ref _comment, value);
            }
        }

        public ICommand InitCommand { get; set; }

        public async Task Init(int courseId)
        {
            Course = await _serviceCourses.GetById<Courses>(courseId);
        }

        public async void onClicked(object obj)
        {
            RattingBar b = (RattingBar)obj;

            var courseParticipants = await _serviceCourseParticipant.Get<List<CourseParticipants>>(new CourseParticipantsSearchRequest { CourseId = _course.CourseId, StudentId = APIService.UserId });
           
            var course = await _serviceCourses.GetById<Courses>(_course.CourseId);

            if(courseParticipants.Count > 0 && course != null)
            {
                _ = await _serviceCourseParticipant.Update<CourseParticipantsInsertRequest>(courseParticipants[0].CourseParticipantId, new CourseParticipantsInsertRequest
                {
                    CourseId = _course.CourseId,
                    Review = b.SelectedStarValue,
                    StudentId = APIService.UserId,
                    ParticipationDate = courseParticipants[0].ParticipationDate,
                    Comment = Comment
                });

                _ = await _serviceCourses.Update<CoursesInsertRequest>(_course.CourseId, new CoursesInsertRequest
                {
                    NumOfRatings = course.NumOfRatings == null? 1: course.NumOfRatings + 1,
                    Rating = course.Rating == null? b.SelectedStarValue :  course.Rating + b.SelectedStarValue,
                    CourseName = course.CourseName,
                    CourseSectionId = course.CourseSectionId,
                    IsActive = course.IsActive,
                    Notes = course.Notes,
                    Picture = course.Picture,
                    Price = course.Price,
                    ProfessorId = course.ProfessorId
                });
                await Application.Current.MainPage.DisplayAlert("Success", "Review is successfully added.", "OK");
                Application.Current.MainPage = new CourseDetailsPage(_course.CourseId);

            }
            //App.Current.MainPage.DisplayAlert("Selected Value is", b.SelectedStarValue.ToString(), "OK");
        }


        private string _selectedStar;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public string SelectedStar
        {
            get { return _selectedStar; }
            set { _selectedStar = value; NotifyPropertyChanged(); }
        }

    }
}
