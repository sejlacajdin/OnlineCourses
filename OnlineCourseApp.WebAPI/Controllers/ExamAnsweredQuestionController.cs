using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineCourseApp.Model;
using OnlineCourseApp.Model.Requests.ExamAnsweredQuestions;
using OnlineCourseApp.WebAPI.Services.IServices;

namespace OnlineCourseApp.WebAPI.Controllers
{
    [Authorize]
    [Route("api/exam-answers")]
    [ApiController]
    public class ExamAnsweredQuestionController : ControllerBase
    {
        private readonly IExamAnsweredQuestionService _examAnsweredQuestionService;
        public ExamAnsweredQuestionController(IExamAnsweredQuestionService examAnsweredQuestionService) 
        {
            _examAnsweredQuestionService = examAnsweredQuestionService;
        }

        [HttpGet]
        public double Get([FromQuery] ExamAnsweredQuestionsSearchRequest request)
        {
            return _examAnsweredQuestionService.GetResult(request);
        }

        [HttpPost]
        public ExamAnsweredQuestions Insert(ExamAnsweredQuestionsInsertRequest request)
        {
            return _examAnsweredQuestionService.Insert(request);
        }
    }
}
