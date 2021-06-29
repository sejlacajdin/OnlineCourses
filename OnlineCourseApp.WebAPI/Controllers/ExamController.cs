using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineCourseApp.Model;
using OnlineCourseApp.Model.Requests.Exams;
using OnlineCourseApp.WebAPI.Services;
using OnlineCourseApp.WebAPI.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourseApp.WebAPI.Controllers
{   [Authorize]
    [Route("api/exams")]
    [ApiController]
    public class ExamController : BaseCRUDController<Model.Exams, ExamsSearchRequest, ExamsInsertRequest, ExamsInsertRequest>
    {
        public ExamController(IBaseCRUDService<Model.Exams, ExamsSearchRequest, ExamsInsertRequest, ExamsInsertRequest> service) : base(service)
        {
        }

    }
}
