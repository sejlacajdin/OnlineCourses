using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineCourseApp.Model;
using OnlineCourseApp.Model.Requests.CourseParticipants;
using OnlineCourseApp.Model.Requests.Courses;
using OnlineCourseApp.WebAPI.Services;
using OnlineCourseApp.WebAPI.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourseApp.WebAPI.Controllers
{   [Authorize]
    [Route("api/course-participants")]
    [ApiController]
    public class CourseParticipantController : BaseCRUDController<Model.CourseParticipants, CourseParticipantsSearchRequest, CourseParticipantsInsertRequest, CourseParticipantsInsertRequest>
    {
        public CourseParticipantController(IBaseCRUDService<Model.CourseParticipants, CourseParticipantsSearchRequest, CourseParticipantsInsertRequest, CourseParticipantsInsertRequest> service) : base(service)
        {
        }

    }
}
