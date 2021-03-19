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
    public class BaseCRUDService<TModel, TSearch, TInsert, TUpdate, TDatabase> : BaseService<TModel, TSearch, TDatabase>, IBaseCRUDService<TModel, TSearch, TInsert, TUpdate> where TDatabase : class
    {
        public BaseCRUDService(_160065Context context, IMapper mapper): base(context, mapper) { }
        public virtual TModel Insert(TInsert request)
        {
            var entity = _mapper.Map<TDatabase>(request);
            _context.Set<TDatabase>().Add(entity);
            _context.SaveChanges();

            return _mapper.Map<TModel>(entity);
        }

        public virtual TModel Update(int id, TUpdate request)
        {
            var entity = _context.Set<TDatabase>().Find(id);
            _context.Set<TDatabase>().Attach(entity);
            _context.Set<TDatabase>().Update(entity);

            _mapper.Map(request, entity);
            _context.SaveChanges();

            return _mapper.Map<TModel>(entity);

        }
        public TModel Delete(int id)
        {
            var entity = _context.Set<TDatabase>().Find(id);
            if (entity == null)
                throw new UserException("Does not exist!");

            _context.Set<TDatabase>().Remove(entity);
            _context.SaveChanges();

            return _mapper.Map<TModel>(entity);
        }
    }
}
