using OnlineCourseApp.Mobile.ViewModels;
using OnlineCourseApp.Model;
using OnlineCourseApp.Model.Requests.CourseParticipants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OnlineCourseApp.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CoursesPage : ContentPage
    {

        private readonly APIService _serviceCourses = new APIService("courses");
        private readonly APIService _serviceCourseParticipant = new APIService("course-participants");
        private CoursesViewModel model = null;

        public CoursesPage()
        {
            InitializeComponent();
            BindingContext = model = new CoursesViewModel();
        }

        protected override  async void OnAppearing()
        {
            base.OnAppearing();
           await model.Init();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            object courseId = ((Button)sender).BindingContext as object;

            var courseParticipants = await _serviceCourseParticipant.Get<List<CourseParticipants>>(new CourseParticipantsSearchRequest { CourseId = (int)courseId, StudentId = APIService.UserId });
            if (courseParticipants.Count != 0)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "You have already applied for this course.", "OK");
                
            }
            else
            {
            var course = await _serviceCourses.GetById<Courses>(courseId);
            if (course.Price == null)
            {
                CourseParticipantsInsertRequest req = new CourseParticipantsInsertRequest
                {
                    CourseId = (int)courseId,
                    StudentId = APIService.UserId,
                    Comment = "",
                    Review = 0,
                    ParticipationDate = DateTime.Now
                };

                await _serviceCourseParticipant.Insert<CourseParticipants>(req);

                await Application.Current.MainPage.DisplayAlert("Info", "You have successfuly buy course!", "OK");
                await model.Init();
                }
            else
                await Navigation.PushAsync(new PaymentPage(courseId));

            }

        }
    }
}