using OnlineCourseApp.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OnlineCourseApp.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReviewPage : ContentPage
    {
        private int _courseId = 0;
        private CourseReviewViewModel model = null;

        public ReviewPage(object courseId)
        {
            InitializeComponent();
            BindingContext = model = new CourseReviewViewModel();
      
            _courseId = (int)courseId;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            model.InitCommand.Execute(_courseId);
        }
    }
}