using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineCourseApp.Model;
using OnlineCourseApp.WebAPI.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourseApp.WebAPI.Controllers
{
    [Route("api/course-section")]
    public class CourseSectionController : BaseController<CourseSections, object>
    {
        public CourseSectionController(IBaseService<CourseSections, object> service) : base(service)
        {

        }
    }
}
