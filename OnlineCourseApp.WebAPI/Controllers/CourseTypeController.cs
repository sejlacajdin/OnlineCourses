using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineCourseApp.Model;
using OnlineCourseApp.Model.Requests.Courses;
using OnlineCourseApp.WebAPI.Services;
using OnlineCourseApp.WebAPI.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourseApp.WebAPI.Controllers
{
    [Route("api/course-type")]
    public class CourseTypeController : BaseController<CourseTypes, object>
    {
        public CourseTypeController(IBaseService<CourseTypes, object> service) :base(service)
        {
        }
    }
}
