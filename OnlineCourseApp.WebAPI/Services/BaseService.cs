using AutoMapper;
using OnlineCourseApp.WebAPI.Database;
using OnlineCourseApp.WebAPI.Exceptions;
using OnlineCourseApp.WebAPI.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourseApp.WebAPI.Services
{
    public class BaseService<TModel, TSearch, TDatabase> : IBaseService<TModel, TSearch> where TDatabase : class
    {
        protected readonly _160065Context _context;
        protected readonly IMapper _mapper;
        public BaseService(_160065Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public virtual List<TModel> Get(TSearch search)
        {
            var list = _context.Set<TDatabase>().ToList();

            return _mapper.Map<List<TModel>>(list);
        }

        public virtual TModel GetById(int id)
        {
            var entity = _context.Set<TDatabase>().Find(id);
            if (entity == null)
                throw new UserException("Does not exist!");

            return _mapper.Map<TModel>(entity);
        }
    }
}
