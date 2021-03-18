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
    public class CourseService : ICourseService
    {
        private readonly _160065Context _context;
        private readonly IMapper _mapper;
        public CourseService(_160065Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Courses> Get(CoursesSearchRequest request)
        {
            var query = _context.Courses.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.CourseName))
                query = query.Where(x => x.CourseName.StartsWith(request.CourseName));

            var list = query.ToList();

            return _mapper.Map<List<Courses>>(list);
        }

        public Courses GetById(int id)
        {
            var course = _context.Courses.Find(id);
            if(course == null)
                throw new UserException("Course does not exist!");

            return _mapper.Map<Courses>(course);
        }

        public Courses Delete(int id)
        {
            var course = _context.Courses.Find(id);
            if (course == null)
                throw new UserException("Course does not exist!");

            _context.Courses.Remove(course);
            _context.SaveChanges();

            return _mapper.Map<Courses>(course);
        }
        public Courses Insert(CoursesInsertRequest request)
        {
            var entity = _mapper.Map<Database.Course>(request);

            _context.Courses.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Courses>(entity);
        }

        public Courses Update(int id, CoursesInsertRequest request)
        {
            var entity = _context.Courses.Find(id);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Courses>(entity);
        }
    }
}
