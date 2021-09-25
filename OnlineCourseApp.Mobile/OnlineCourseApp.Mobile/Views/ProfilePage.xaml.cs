using OnlineCourseApp.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OnlineCourseApp.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        ProfileViewModel vm = null;
        public ProfilePage()
        {
            InitializeComponent();
            BindingContext = vm = new ProfileViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            vm.InitCommand.Execute(null);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(this.FirstName.Text, @"^[a-zA-Z]+$") && this.FirstName.Text.Length < 3)
            {
                FirstnameError.Text = "** Only alphabets are allowed and minimum 3 characters **";
                FirstnameError.IsVisible = true;
            }
            else
            {
                FirstnameError.Text = " ";
                FirstnameError.IsVisible = false;
            }

            if (!Regex.IsMatch(this.LastName.Text, @"^[a-zA-Z]+$") && this.LastName.Text.Length < 3)
            {
                LastnameError.Text = "** Only alphabets are allowed and minimum 3 characters **";
                LastnameError.IsVisible = true;
            }
            else
            {
                LastnameError.Text = " ";
                LastnameError.IsVisible = false;
            }

            if (this.Phone.Text.Length < 9)
            {
                PhoneError.Text = "** Phone number must be minimum 9 digits **";
                PhoneError.IsVisible = true;
            }
            else
            {
                PhoneError.Text = " ";
                PhoneError.IsVisible = false;
            }

            Regex reg = new Regex(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$", RegexOptions.IgnoreCase);

            if (!reg.IsMatch(Email.Text))
            {
                EmailError.Text = "** Valid format example example@example.com  **";
                EmailError.IsVisible = true;
            }
            else
            {
                EmailError.Text = "";
                EmailError.IsVisible = false;
            }

            if (this.Username.Text.Length < 3)
            {
                UsernameError.Text = "** Minimum 3 characters. **";
                UsernameError.IsVisible = true;
            }
            else
            {
                UsernameError.Text = "";
                UsernameError.IsVisible = false;
            }

            if (!UsernameError.IsVisible && !EmailError.IsVisible && !PhoneError.IsVisible && !LastnameError.IsVisible && !FirstnameError.IsVisible)
            {
                vm.ProfileCommand.Execute(null);
            }
        }
    }
}