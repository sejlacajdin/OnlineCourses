using OnlineCourseApp.Model;
using OnlineCourseApp.Model.Requests.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace OnlineCourseApp.Mobile.ViewModels
{
    public class ProfileViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("users");

        public ProfileViewModel()
        {
            InitCommand = new Command(async () => await Init());
            ProfileCommand = new Command(OnSaveClicked);
        }

       Users _user = null;
        public Users User
        {
            get { return _user; }
            set
            {
                SetProperty(ref _user, value);
            }
        }


        public ICommand ProfileCommand { get; set; }
        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            User = await _service.GetById<Users>(APIService.UserId);
        }
            private async void OnSaveClicked(object obj)
        {
            var request = new UsersUpdateRequest()
            {
                FirstName = User.LastName,
                LastName = User.LastName,
                Username = User.Username,
                Email = User.Email,
                Phone = User.Phone,
            };

            await _service.Update<UsersUpdateRequest>(APIService.UserId,request);
            await Application.Current.MainPage.DisplayAlert("User profile", "Succesfully updated!", "OK");

        }
    }
}
