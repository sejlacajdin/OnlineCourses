using OnlineCourseApp.Mobile.Views;
using OnlineCourseApp.Model.Requests.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace OnlineCourseApp.Mobile.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("users/login");
        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }
        public ICommand LoginCommand { get; set; }
        private async void OnLoginClicked(object obj)
        {
            IsBusy = true;
            try
            {
                APIService.Username = Username;
                APIService.Password = Password;

                var user = await _service.Get<Model.Users>(new UserLoginRequest { Username = Username, Password = Password });

                if(user != null)
                {
                bool isStudent = false;

                foreach (var item in user.UserRoles)
                {
                    if (item.Role.Name == "Student")
                        isStudent = true;
                };

                if (isStudent)
                {
                    APIService.UserId = user.UserId;
                    Application.Current.MainPage = new AppShell();
                }
                else
                {
                    IsBusy = false;
                    await Application.Current.MainPage.DisplayAlert("Permission", "You need to have student account.", "OK");

                }
                }
                else
                {
                    IsBusy = false;
                    await Application.Current.MainPage.DisplayAlert("Authentication", "Wrong username or password. Try again.", "OK");
                }


            }
            catch (Exception ex)
            {
                IsBusy = false;
                await Application.Current.MainPage.DisplayAlert("Authentication", "Wrong username or password. Try again.", "OK");
            }
        }
    }
}
