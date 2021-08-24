using Microsoft.AspNetCore.Http;
using OnlineCourseApp.Model;
using OnlineCourseApp.Model.Requests.Documents;
using OnlineCourseApp.Model.Requests.ExamAnsweredQuestions;
using OnlineCourseApp.WebAPI.Database;


namespace OnlineCourseApp.WebAPI.Services.IServices
{
    public interface IExamAnsweredQuestionService
    {
        ExamAnsweredQuestions Insert(ExamAnsweredQuestionsInsertRequest request);
        double GetResult(ExamAnsweredQuestionsSearchRequest request);
    }
}
