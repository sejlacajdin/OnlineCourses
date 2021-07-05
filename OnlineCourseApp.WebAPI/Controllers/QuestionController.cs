using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineCourseApp.Model.Requests.Questions;
using OnlineCourseApp.WebAPI.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourseApp.WebAPI.Controllers
{
    [Authorize]
    [Route("api/questions")]
    [ApiController]
    public class QuestionController : BaseCRUDController<Model.Questions, QuestionsSearchRequest, QuestionsInsertRequest, QuestionsInsertRequest>
    {
        public QuestionController(IBaseCRUDService<Model.Questions, QuestionsSearchRequest, QuestionsInsertRequest, QuestionsInsertRequest> service) : base(service)
        {
        }
    }
}