using OnlineCourseApp.Model;
using OnlineCourseApp.Model.Requests.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourseApp.WebAPI.Services.IServices
{
    public interface ICourseService
    {
        List<Courses> Get(CoursesSearchRequest request);
        Courses GetById(int id);
        Courses Delete(int id);
        Courses Insert(CoursesInsertRequest request);
    }
}
