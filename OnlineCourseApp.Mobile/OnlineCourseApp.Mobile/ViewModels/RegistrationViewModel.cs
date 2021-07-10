using OnlineCourseApp.Mobile.Views;
using OnlineCourseApp.Model.Requests.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace OnlineCourseApp.Mobile.ViewModels
{
    public class RegistrationViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("users/login");
        private readonly APIService _serviceUsers = new APIService("users");
        public RegistrationViewModel()
        {
            RegistrationCommand = new Command(async () => await OnRegisterClicked());
        }

        string _firstname = string.Empty;
        public string Firstname
        {
            get { return _firstname; }
            set { SetProperty(ref _firstname, value); }
        }

        string _lastname = string.Empty;
        public string Lastname
        {
            get { return _lastname; }
            set { SetProperty(ref _lastname, value); }
        }

        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        string _email = string.Empty;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        string _phone = string.Empty;
        public string Phone
        {
            get { return _phone; }
            set { SetProperty(ref _phone, value); }
        }

        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        string _passwordConfirmation = string.Empty;
        public string PasswordConfirmation
        {
            get { return _passwordConfirmation; }
            set { SetProperty(ref _passwordConfirmation, value); }
        }
        public ICommand RegistrationCommand { get; set; }
        public async Task OnRegisterClicked()
        {
            IsBusy = true;

          
                var request = new UsersInsertRequest()
                {
                    FirstName = Firstname,
                    LastName = Lastname,
                    Username = Username,
                    Email = Email,
                    Phone = Phone,
                    Password = Password,
                    PasswordConfirmation = PasswordConfirmation,
                    Role = "Student",
                    Status = true
                };

                await _serviceUsers.Register<Model.Users>(request);
                await Application.Current.MainPage.DisplayAlert("Online courses", "Succesfully registered!", "OK");

                Application.Current.MainPage = new LoginPage(); 

        }
    }
}
