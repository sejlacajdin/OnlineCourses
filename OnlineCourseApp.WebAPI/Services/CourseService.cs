﻿using AutoMapper;
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
            var query = _context.Users.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.CourseName))
                query = query.Where(x => x.FirstName.StartsWith(request.CourseName));

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

    }
}
