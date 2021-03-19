using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourseApp.WebAPI.Services.IServices
{
    public interface IBaseService<T, TSearch>
    {
        List<T> Get(TSearch search);
        T GetById(int id);
    }
}
