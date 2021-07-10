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
    public partial class RegistrationPage : ContentPage
    {
        RegistrationViewModel vm = null;
        public RegistrationPage()
        {
            InitializeComponent();
            this.BindingContext = vm = new RegistrationViewModel();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(this.Firstname.Text, @"^[a-zA-Z]+$") && this.Firstname.Text.Length < 3)
            {
                FirstnameError.Text = "** Only alphabets are allowed and minimum 3 characters **";
                FirstnameError.IsVisible = true;
            }
            else
            {
                FirstnameError.Text = " ";
                FirstnameError.IsVisible = false;
            }

            if (!Regex.IsMatch(this.Lastname.Text, @"^[a-zA-Z]+$") && this.Lastname.Text.Length < 3)
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

            if (string.IsNullOrWhiteSpace(this.Password.Text) || !Regex.Match(this.Password.Text, "^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])|(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^a-zA-Z0-9])|(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])|(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{8,}$").Success)
            {
                PasswordError.Text = "** Passwords must contain at 3 of 4 of the following: upper case (A-Z), lower case (a-z), number (0-9) and special character (e.g. !@#$%^&*) **";
                PasswordError.IsVisible = true;
            }
            else
            {
                PasswordError.Text = "";
                PasswordError.IsVisible = false;
            }

            if (this.Password.Text != this.PasswordConfirmation.Text)
            {
                PasswordConfirmationError.Text = "** Passwords don't match. **";
                PasswordConfirmationError.IsVisible = true;
            }
            else
            {
                PasswordConfirmationError.Text = "";
                PasswordConfirmationError.IsVisible = false;
            }

            if (!PasswordError.IsVisible && !PasswordConfirmationError.IsVisible && !UsernameError.IsVisible
                    && !EmailError.IsVisible && !PhoneError.IsVisible && !LastnameError.IsVisible && !FirstnameError.IsVisible)
            {
                vm.RegistrationCommand.Execute(null);
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Application.Current.MainPage = new LoginPage();
        }
    }
}