using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OnlineCourseApp.Model;
using OnlineCourseApp.Model.Requests.Exams;
using OnlineCourseApp.WebAPI.Database;
using OnlineCourseApp.WebAPI.Exceptions;
using OnlineCourseApp.WebAPI.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourseApp.WebAPI.Services
{
    public class ExamService : BaseCRUDService<Model.Exams, ExamsSearchRequest, ExamsInsertRequest, ExamsInsertRequest,Exam>
    {
        public ExamService(_160065Context context, IMapper mapper) : base(context, mapper)
        {

        }
        public override Exams Insert(ExamsInsertRequest request)
        {
            var entity = new Exam
            {
                Title = request.Title,
                Instructions = request.Instructions,
                TimeLimit = TimeSpan.Parse(request.TimeLimit),
                IsActive = request.IsActive,
                CourseId = request.CourseId,
                ExamOwnerId = request.ExamOwnerId
               };
            _context.Set<Exam>().Add(entity);
            _context.SaveChanges();

            return new Exams
            {
                Title = entity.Title,
                Instructions = entity.Instructions,
                TimeLimit = entity.TimeLimit.ToString(),
                IsActive = entity.IsActive,
                CourseId = entity.CourseId,
                ExamOwnerId = entity.ExamOwnerId
            };
        }

        public override List<Exams> Get(ExamsSearchRequest request)
        {
            var query = _context.Set<Exam>().AsQueryable();

            if (request?.ExamOwnerId != null)
                query = query.Where(x => x.ExamOwnerId == request.ExamOwnerId);

            if (!string.IsNullOrWhiteSpace(request?.Title))
                query = query.Include(q => q.Course).Where(x => x.Title.StartsWith(request.Title) || x.Course.CourseName.StartsWith(request.Title));

            var list = query.ToList();

            return _mapper.Map<List<Exams>>(list);
        }

    }
}
