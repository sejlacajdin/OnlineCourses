﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseApp.Model.Requests.Users
{
    public class UsersSearchRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}
