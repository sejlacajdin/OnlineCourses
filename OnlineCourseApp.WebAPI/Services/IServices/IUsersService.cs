using OnlineCourseApp.Model;
using OnlineCourseApp.Model.Requests.Users;
using System;
using System.Collections.Generic;

namespace OnlineCourseApp.WebAPI.Services.IServices
{
    public interface IUsersService
    {
        List<Users> Get(UsersSearchRequest request);
        Users Insert(UsersInsertRequest request);
    }
}
