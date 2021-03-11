using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineCourseApp.Model;
using OnlineCourseApp.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourseApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Course>> Get()
        {
            var list = new List<Course>() { 
                new Course
                {
                    CourseID= 1,
                    Name= "test"
                }
            };
            return list;
        }

        [HttpGet("{id}")]
        public ActionResult<Course> GetById(int id)
        {
            var item = new Course()
            {
                CourseID = 1,
                Name = "test"
            };

            return item;
        }
    }
}
