using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OnlineCourseApp.Model;
using OnlineCourseApp.Model.Requests.ExamAnsweredQuestions;
using OnlineCourseApp.WebAPI.Database;
using OnlineCourseApp.WebAPI.Services.IServices;
using System;
using System.Linq;

namespace OnlineCourseApp.WebAPI.Services
{
    public class ExamAnsweredQuestionsService : IExamAnsweredQuestionService
    {
        private readonly _160065Context _context = null;
        private IMapper _mapper = null;
        public ExamAnsweredQuestionsService(_160065Context context, IMapper mapper) 
        {
            _context = context;
            _mapper = mapper;
        }

        public double GetResult(ExamAnsweredQuestionsSearchRequest request)
        {
            var query = _context.Set<ExamAnsweredQuestion>().AsQueryable();

            if (query.ToList().Count == 0)
                return -1;

            if(request?.QuestionId != 0 && request?.ChoiceId != 0)
            {
                query = query.Where(x => x.QuestionId == request.QuestionId && x.ChoiceId == request.ChoiceId);
                if (query.ToList().Count > 0)
                    return 1;
                else return -1;
            }


            if (request?.StudentId != 0 && request?.ExamId != 0)
            {
                query = query.Include(x => x.Question).Where(x =>x.StudentId == request.StudentId && x.Question.ExamId == request.ExamId);
           
            var list = query.Include(x => x.Choice).ToList().GroupBy(x => x.QuestionId).Select(s => new
            {
                Question = s.Key,
                Result = s.Any(x => x.MarkScored == 0 || x.Choice.IsCorrect == false) ? 0 : s.Sum(x => x.MarkScored)
            }).ToList();

            double examScore = 0;
             foreach (var item in list)
                examScore += query.Include(x => x.Question).Where(x => x.QuestionId == item.Question).Select(x => x.Question.Points).FirstOrDefault();

            return Math.Round(list.Sum(x => x.Result)*100 / examScore,2);

            }
            else
            return -1;
        
        }

        public ExamAnsweredQuestions Insert(ExamAnsweredQuestionsInsertRequest request)
        {
            var entity = _mapper.Map<ExamAnsweredQuestion>(request);
            _context.Set<ExamAnsweredQuestion>().Add(entity);
            _context.SaveChanges();

            return _mapper.Map<ExamAnsweredQuestions>(entity);
        }
    }
}
