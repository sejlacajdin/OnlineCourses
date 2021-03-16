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
    [Route("api/courses")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        [HttpGet]
        public ActionResult<List<Courses>> Get([FromQuery] CoursesSearchRequest request)
        {
            return _courseService.Get(request);
        }

        [HttpGet("{id}")]
        public ActionResult<Courses> GetById(int id)
        {
            return _courseService.GetById(id);
        }

        [HttpDelete("{id}")]
        public ActionResult<Courses> Delete(int id)
        {
            return _courseService.Delete(id);
        }

        [HttpPost]
        public Model.Courses Insert(CoursesInsertRequest request)
        {
            return _courseService.Insert(request);
        }
    }
}
