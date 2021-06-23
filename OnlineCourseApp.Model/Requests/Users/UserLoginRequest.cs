using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseApp.Model.Requests.Users
{
    public class UserLoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
