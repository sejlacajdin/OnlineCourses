using Microsoft.AspNetCore.Authorization;
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
{   [Authorize]
    [Route("api/courses")]
    [ApiController]
    public class CourseController : BaseCRUDController<Model.Courses, CoursesSearchRequest, CoursesInsertRequest, CoursesInsertRequest>
    {
        public CourseController(IBaseCRUDService<Model.Courses, CoursesSearchRequest, CoursesInsertRequest, CoursesInsertRequest> service) : base(service)
        {
        }
    }
}
