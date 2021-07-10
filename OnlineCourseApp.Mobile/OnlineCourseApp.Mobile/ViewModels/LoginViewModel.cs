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

                APIService.UserId = user.UserId;


                //await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
                Application.Current.MainPage = new AppShell();
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Authentication", "Wrong username or password. Try again.", "OK");
            }
        }
    }
}
