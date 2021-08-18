using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OnlineCourseApp.Model;
using OnlineCourseApp.Model.Requests.Questions;
using OnlineCourseApp.WebAPI.Database;
using OnlineCourseApp.WebAPI.Exceptions;
using OnlineCourseApp.WebAPI.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourseApp.WebAPI.Services
{
    public class QuestionService : BaseCRUDService<Model.Questions, QuestionsSearchRequest, QuestionsInsertRequest, QuestionsInsertRequest, Question>
    {
        public QuestionService(_160065Context context, IMapper mapper) : base(context, mapper)
        {

        }
        public override List<Questions> Get(QuestionsSearchRequest request)
        {
            var query = _context.Set<Question>().AsQueryable();

            if (request?.ExamId != 0)
                query = query.Where(x => x.ExamId == request.ExamId);

            if (!string.IsNullOrWhiteSpace(request?.Question))
                query = query.Include(q => q.QuestionCategory).Include(q => q.QuestionType).Where(x => x.QuestionCategory.CategoryName.StartsWith(request.Question) || x.QuestionType.TypeName.StartsWith(request.Question));

            if (request?.IsActive == true)
                query = query.Where(x => x.IsActive);

            var list = query.ToList();

            return _mapper.Map<List<Questions>>(list);
        }

        public override Questions Delete(int id)
        {
            var entity = _context.Set<Question>().Find(id);
            if (entity == null)
                throw new UserException("Question does not exist!");

            _context.Set<Question>().Remove(entity);

            var query = _context.Set<Question>().AsEnumerable().SkipWhile(x => x.QuestionNumber < entity.QuestionNumber);
            foreach (var item in query)
                item.QuestionNumber -= 1;

            _context.SaveChanges();

            return _mapper.Map<Questions>(entity);
        }

    }
}
