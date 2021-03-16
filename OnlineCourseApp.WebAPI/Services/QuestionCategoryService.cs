using AutoMapper;
using OnlineCourseApp.Model;
using OnlineCourseApp.WebAPI.Database;
using OnlineCourseApp.WebAPI.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourseApp.WebAPI.Services
{
    public class QuestionCategoryService : IQuestionCategoryService
    {
        private readonly _160065Context _context;
        private readonly IMapper _mapper;

        public QuestionCategoryService(_160065Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<QuestionCategories> Get()
        {
            List<QuestionCategory> list = _context.QuestionCategories.ToList();

            return _mapper.Map<List<QuestionCategories>>(list);
        }
    }
}
