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
{
    [Authorize]
    [Route("api/courses")]
    [ApiController]
    public class CourseController : BaseCRUDController<Model.Courses, CoursesSearchRequest, CoursesInsertRequest, CoursesInsertRequest>
    {
        public CourseController(IBaseCRUDService<Model.Courses, CoursesSearchRequest, CoursesInsertRequest, CoursesInsertRequest> service) : base(service)
        {
        }
        //[HttpGet]
        //public ActionResult<List<Courses>> Get([FromQuery] CoursesSearchRequest request)
        //{
        //    return _courseService.Get(request);
        //}

        //[HttpGet("{id}")]
        //public ActionResult<Courses> GetById(int id)
        //{
        //    return _courseService.GetById(id);
        //}

        //[HttpDelete("{id}")]
        //public ActionResult<Courses> Delete(int id)
        //{
        //    return _courseService.Delete(id);
        //}

        //[HttpPost]
        //public Model.Courses Insert(CoursesInsertRequest request)
        //{
        //    return _courseService.Insert(request);
        //}

        //[HttpPut("{id}")]
        //public Model.Courses Update(int id, CoursesInsertRequest request)
        //{
        //    return _courseService.Update(id, request);
        //}
    }
}
