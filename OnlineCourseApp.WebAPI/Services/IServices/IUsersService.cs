using OnlineCourseApp.Model;
using OnlineCourseApp.Model.Requests.Users;
using System;
using System.Collections.Generic;

namespace OnlineCourseApp.WebAPI.Services.IServices
{
    public interface IUsersService
    {
        List<Users> Get(UsersSearchRequest request);
        Users GetById(int id);
        Users Insert(UsersInsertRequest request);
        Users Update(int id, UsersInsertRequest request);
        Users Autenticiraj(string username, string pass);
    }
}
