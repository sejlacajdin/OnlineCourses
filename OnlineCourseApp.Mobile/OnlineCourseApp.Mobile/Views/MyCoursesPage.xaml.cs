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
    public partial class MyCoursesPage : ContentPage
    {
        private MyCoursesViewModel model = null;
        public MyCoursesPage()
        {
            InitializeComponent();
            BindingContext = model = new MyCoursesViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            object courseId = ((Button)sender).BindingContext as object;
        }
    }
}