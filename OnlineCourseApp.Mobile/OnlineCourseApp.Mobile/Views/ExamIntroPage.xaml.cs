using OnlineCourseApp.Mobile.ViewModels;
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
    public partial class ExamIntroPage : ContentPage
    {
        private ExamViewModel model = null;
        private int _courseId = 0;
        public ExamIntroPage(int courseId)
        {
            InitializeComponent();
            BindingContext = model = new ExamViewModel();
            _courseId = (int)courseId;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            model.InitCommand.Execute(_courseId);
        }

    }
}