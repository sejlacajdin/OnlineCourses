using OnlineCourseApp.Mobile.ViewModels;
using OnlineCourseApp.Mobile.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace OnlineCourseApp.Mobile
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(CoursesPage), typeof(CoursesPage));
            Routing.RegisterRoute(nameof(MyCoursesPage), typeof(MyCoursesPage));
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
