using AutoMapper;
using OnlineCourseApp.Model;
using OnlineCourseApp.WebAPI.Database;
using OnlineCourseApp.WebAPI.Exceptions;
using OnlineCourseApp.WebAPI.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourseApp.WebAPI.Services
{
    public class CourseSectionService : ICourseSectionService
    {
        private readonly _160065Context _context;
        private readonly IMapper _mapper;

        public CourseSectionService(_160065Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<CourseSections> Get()
        {
            List<CourseSection> list = _context.CourseSections.ToList();

            return _mapper.Map<List<CourseSections>>(list);
        }
        public CourseSections GetById(int id)
        {
            var item = _context.CourseSections.Find(id);
            if (item == null)
                throw new UserException("Section does not exist!");

            return _mapper.Map<CourseSections>(item);
        }
    }
}
