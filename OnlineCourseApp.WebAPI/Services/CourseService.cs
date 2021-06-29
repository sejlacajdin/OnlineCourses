using AutoMapper;
using OnlineCourseApp.Model;
using OnlineCourseApp.Model.Requests.Courses;
using OnlineCourseApp.WebAPI.Database;
using OnlineCourseApp.WebAPI.Exceptions;
using OnlineCourseApp.WebAPI.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourseApp.WebAPI.Services
{
    public class CourseService : BaseCRUDService<Model.Courses, CoursesSearchRequest, CoursesInsertRequest, CoursesInsertRequest,Course>
    {
        public CourseService(_160065Context context, IMapper mapper) : base(context, mapper)
        {

        }
       public override List<Courses> Get(CoursesSearchRequest request)
        {
            var query = _context.Set<Course>().AsQueryable();

            if (request?.ProfessorId != null)
                query = query.Where(x => x.ProfessorId == request.ProfessorId);

            if (!string.IsNullOrWhiteSpace(request?.CourseName))
                query = query.Where(x => x.CourseName.StartsWith(request.CourseName));

            var list = query.ToList();

            return _mapper.Map<List<Courses>>(list);
        }
    
    }
}
