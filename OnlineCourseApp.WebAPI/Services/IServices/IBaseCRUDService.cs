using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourseApp.WebAPI.Services.IServices
{
    public interface IBaseCRUDService<T, TSearch, TInsert, TUpdate> : IBaseService<T, TSearch>
    {
        T Insert(TInsert request);
        T Update(int id, TUpdate request);
        T Delete(int id);
    }
}
