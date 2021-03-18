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
    public class CourseTypeService : ICourseTypeService
    {
        private readonly _160065Context _context;
        private readonly IMapper _mapper;

        public CourseTypeService(_160065Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<CourseTypes> Get()
        {
            List<CourseType> list = _context.CourseTypes.ToList();

            return _mapper.Map<List<CourseTypes>>(list);
        }

        public CourseTypes GetById(int id)
        {
           var item = _context.CourseTypes.Find(id);
           if (item == null)
               throw new UserException("Section does not exist!");

           return _mapper.Map<CourseTypes>(item);    
        }
    }
}
